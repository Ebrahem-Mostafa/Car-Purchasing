// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
#nullable disable

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using CarSystem.Data;

using CarSystem.Models;


namespace CarSystem.Areas.Identity.Pages.Account
{
    public class LoginModel : PageModel
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly ILogger<LoginModel> _logger;
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;
        
        public LoginModel(SignInManager<IdentityUser> signInManager, ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _signInManager = signInManager;
            
            _context = context;
            _userManager = userManager;
            
        }

        
        [BindProperty]
        public InputModel Input { get; set; }

        
        public IList<AuthenticationScheme> ExternalLogins { get; set; }

       
        public string ReturnUrl { get; set; }

       
        [TempData]
        public string ErrorMessage { get; set; }

      
        public class InputModel
        {
            
            [Required]
            [EmailAddress]
            public string Email { get; set; }


            [Required(ErrorMessage = "Invalid Input")]
            [StringLength(20, MinimumLength = 8, ErrorMessage = "Invalid Input")]
            [RegularExpression(@"^(?=.*[a-zA-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,20}$",ErrorMessage = "Invalid Input")]
            [DataType(DataType.Password)]
            public string Password { get; set; }

           
            [Display(Name = "Remember me?")]
            public bool RememberMe { get; set; }
        }

        public async Task OnGetAsync(string returnUrl = null)
        {
            if (!string.IsNullOrEmpty(ErrorMessage))
            {
                ModelState.AddModelError(string.Empty, ErrorMessage);
            }

            returnUrl ??= Url.Content("~/");

           
            await HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);

            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();

            ReturnUrl = returnUrl;
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl ??= Url.Content("~/");

            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();

            if (ModelState.IsValid)
            {
               
                var user = await _userManager.FindByEmailAsync(Input.Email);
                if (user != null)
                {
                    var canSignIn = await _signInManager.CanSignInAsync(user);
                    if (!canSignIn)
                    {
                        var reasons = new List<string>();

                        if (!user.EmailConfirmed)
                            reasons.Add("Email not confirmed");

                        if (await _userManager.IsLockedOutAsync(user))
                            reasons.Add("Account locked out");

                       
                        //Console.WriteLine($"Cannot sign in because: {string.Join(", ", reasons)}");
                    }

                    // Check canSignIn value here
                }

                var result = await _signInManager.PasswordSignInAsync(Input.Email, Input.Password, Input.RememberMe, lockoutOnFailure: false);
                if (result.Succeeded)
                {
                  
                    return LocalRedirect(returnUrl);
                }
                if (result.RequiresTwoFactor)
                {
                    return RedirectToPage("./LoginWith2fa", new { ReturnUrl = returnUrl, RememberMe = Input.RememberMe });
                }
                if (result.IsLockedOut)
                {
                    
                    return RedirectToPage("./Lockout");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                    return Page();
                }
            }

           
            return Page();
        }
    }
}
