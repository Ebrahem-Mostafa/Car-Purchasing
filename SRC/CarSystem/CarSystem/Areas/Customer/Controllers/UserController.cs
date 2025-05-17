using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using CarSystem.Data;
using CarSystem.Models;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using CarSystem.Models.ViewModels;

namespace CarSystem.Areas.Customer.Controllers
{
    [Area("Customer")]
    [Authorize]

    public class UserController : Controller
    {
        

       private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly ApplicationDbContext _applicationDbContext;
        
        public UserController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager, ApplicationDbContext applicationDbContext)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _applicationDbContext = applicationDbContext;
        }

        //  Index means home page
       
        public IActionResult Index()
        {
            return View(_applicationDbContext.AppUsers.ToList());
        }

        [HttpPost]
        public async Task<IActionResult> Index(EmailViewModel emailViewModel)
        {
            // Start with a base query that selects all advertisements
            var query = _applicationDbContext.AppUsers.AsQueryable();

            // Apply filters only if the property has a value (not null or empty/zero)
            if (!string.IsNullOrEmpty(emailViewModel.Email))
            {
                query = query.Where(a => a.Email.Contains(emailViewModel.Email));
            }

            // Execute the query and return results
            var results = query.ToList();
            if (!results.Any())  // Most efficient way to check if list has items
            {
                // List contains items
                return View("SearchNotFound");
            }

            return View(results);
        }


        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(AppUser user)
        {
            
            if (ModelState.IsValid)
            {
                user.Email = user.UserName;
                var result = await _userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    TempData["save"] = "User created successfully";

                    return RedirectToAction("Index");
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(String.Empty, error.Description);
                }
            }



            return View(user);
        }
        public async Task<IActionResult> Details(string id)
        {
            var user = _applicationDbContext.AppUsers.FirstOrDefault(x => x.Id == id);
            if (user == null)
                return NotFound();
            return View(user);
        }
        
        //public async Task<IActionResult> Delete(string id)
        //{
        //    if(id== null)   
        //        return NotFound();
        //    var user=_applicationDbContext.AppUsers.FirstOrDefault(c=>c.Id==id);
        //    if(user == null) 
        //        return NotFound();
        //    return View(user);
        //}

       
        //public async Task<IActionResult> Delete(AppUser appUser)
        //{
        //    var userinfo = _applicationDbContext.AppUsers.FirstOrDefault(x => x.Id == appUser.Id);
        //    if (userinfo == null)
        //        return NotFound();
        //    userinfo.LockoutEnd = DateTime.Now.AddYears(100);
        //    int rowaffected = _applicationDbContext.SaveChanges();
        //    if (rowaffected > 0)
        //    {
               

        //        return RedirectToAction("Index");
        //    }
        //    return View(userinfo);
        //}



        [HttpPost]
        public async Task<IActionResult> DeleteUser(string Email)
        {
            if (string.IsNullOrEmpty(Email))
            {
                return NotFound();
            }

           
            var user = await _userManager.FindByEmailAsync(Email);

            if (user == null)
            {
                return NotFound();
            }
          
            var result = await _userManager.DeleteAsync(user);


            if (!result.Succeeded)
            {
                ModelState.AddModelError("Email", "Invalid input."); 
                return View();
            }

            return RedirectToAction(nameof(Index)); 
        }



    }
}
