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
            [Required(ErrorMessage = "Invalid Input")]
            [RegularExpression(
        @"^(?![0-9]+@)[a-zA-Z0-9]+([._%+-]?[a-zA-Z0-9]+)*@[a-zA-Z0-9]+([.-]?[a-zA-Z0-9]+)*\.[a-zA-Z]{2,}$",
        ErrorMessage = "Invalid Input")]
            [Display(Name = "Email Address")]
            public string Email { get; set; }

            [Required(ErrorMessage = "Invalid Input")]
            [MinLength(8, ErrorMessage = "Invalid Input")]
            [RegularExpression(@"^[^\s]{0,20}$", ErrorMessage = "Invalid Input")] 
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; }

           
            [Display(Name = "Remember me?")]
            public bool RememberMe { get; set; }
        }

        public async Task<IActionResult> OnGetAsync(string returnUrl = null)
        {
            // Redirect authenticated users to home page
            if (User.Identity.IsAuthenticated)
            {
                return LocalRedirect(returnUrl ?? Url.Content("~/"));
            }

            if (!string.IsNullOrEmpty(ErrorMessage))
            {
                ModelState.AddModelError(string.Empty, ErrorMessage);
            }

            returnUrl ??= Url.Content("~/");

            await HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);

            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();

            ReturnUrl = returnUrl;

            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl ??= Url.Content("~/");
            if (User.Identity.IsAuthenticated)
            {
                return LocalRedirect(returnUrl ?? Url.Content("~/"));
            }

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
                            reasons.Add("Invalid Input");

                        if (await _userManager.IsLockedOutAsync(user))
                            reasons.Add("Invalid Input");

                       
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
                    ModelState.AddModelError(string.Empty, "Invalid Input");
                    return Page();
                }
            }

           
            return Page();
        }
    }
}
