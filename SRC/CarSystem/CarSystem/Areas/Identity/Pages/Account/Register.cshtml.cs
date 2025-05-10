// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
#nullable disable

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading;
using System.Threading.Tasks;
using CarSystem.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;

namespace CarSystem.Areas.Identity.Pages.Account
{
    public class RegisterModel : PageModel
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
       
        private readonly IEmailSender _emailSender;


        public RegisterModel(UserManager<IdentityUser> userManager,SignInManager<IdentityUser> signInManager, IEmailSender emailSender)
        {
            _userManager = userManager;
            _signInManager = signInManager;
           
            _emailSender = emailSender;
        }

        [BindProperty]
        public InputModel Input { get; set; }

       
        public string ReturnUrl { get; set; }

       
        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        public class InputModel
        {
          
            [Required(ErrorMessage = "Invalid Input")]
            [EmailAddress(ErrorMessage = "Invalid Input")]
            [Display(Name = "Email")]
            public string Email { get; set; }

            [Required(ErrorMessage = "Invalid Input")]
            [StringLength(20, MinimumLength = 8, ErrorMessage = "Invalid Input")]
            [RegularExpression(@"^(?=.*[a-zA-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,20}$", ErrorMessage = "Invalid Input")]
            [DataType(DataType.Password, ErrorMessage = "Invalid Input")]
            public string Password { get; set; }

          
            [DataType(DataType.Password)]
            [Display(Name = "Confirm password")]
            [Compare("Password", ErrorMessage = "Invalid Input")]
            public string ConfirmPassword { get; set; }

            [Required(ErrorMessage = "Invalid Input")]
            [StringLength(8, ErrorMessage = "Invalid Input")]
            [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Invalid Input")]
            public string FirstName { get; set; }

            [Required(ErrorMessage = "Invalid Input")]
            [StringLength(8, ErrorMessage = "Invalid Input")]
            [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Invalid Input")]
            public string LastName { get; set; }

            [Required(ErrorMessage = "Invalid Input")]
            [StringLength(30, ErrorMessage = "Invalid Input")]
            [RegularExpression(@"^[a-zA-Z0-9\s.,]+$",ErrorMessage = "Invalid Input")]
            public string Address { get; set; }

            [Required(ErrorMessage = "Invalid Input")]
            [Range(18, 120, ErrorMessage = "Invalid Input")]
            [RegularExpression("^[0-9]+$", ErrorMessage = "Invalid Input")]
            public int Age { get; set; }

            [Required(ErrorMessage = "Invalid Input")]
            [StringLength(12, ErrorMessage = "Invalid Input")]
            [RegularExpression(@"^20[0-9]{10}$",ErrorMessage = "Invalid Input")]
            public string PhoneNumber { get; set; }

        }


        public async Task OnGetAsync(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl ??= Url.Content("~/");
         
            if (ModelState.IsValid)
            {
                var user = new AppUser 
                {
                    UserName = Input.Email, 
                    Email = Input.Email ,
                    FirstName = Input.FirstName,
                    LastName = Input.LastName,
                    Address = Input.Address,
                    Age = Input.Age,
                    PhoneNumber = Input.PhoneNumber,

                };

               
                var result = await _userManager.CreateAsync(user, Input.Password);
                if (result.Succeeded)
                {
                  

                    var userId = await _userManager.GetUserIdAsync(user);
                    var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
                    var callbackUrl = Url.Page(
                        "/Account/Login",
                        pageHandler: null,


                        values: new { area = "Identity", userId = userId, code = code, returnUrl = returnUrl },
                        protocol: Request.Scheme);

                    await _emailSender.SendEmailAsync(Input.Email, "Confirm your email",
                        $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");

                    
                        await _signInManager.SignInAsync(user, isPersistent: false);
                        return LocalRedirect(returnUrl);
                    
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }

        private IdentityUser CreateUser()
        {
            try
            {
                return Activator.CreateInstance<IdentityUser>();
            }
            catch
            {
                throw new InvalidOperationException($"Can't create an instance of '{nameof(IdentityUser)}'. " +
                    $"Ensure that '{nameof(IdentityUser)}' is not an abstract class and has a parameterless constructor, or alternatively " +
                    $"override the register page in /Areas/Identity/Pages/Account/Register.cshtml");
            }
        }

  
    }
}
