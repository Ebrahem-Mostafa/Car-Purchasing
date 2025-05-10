using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using CarSystem.Data;
using CarSystem.Models;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace CarSystem.Areas.Customer.Controllers
{
    [Area("Customer")]
    [Authorize(Roles ="Admin")]
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

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(AppUser user)
        {
            if (ModelState.IsValid)
            {
                
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
        
        public async Task<IActionResult> Delete(string id)
        {
            if(id== null)   
                return NotFound();
            var user=_applicationDbContext.AppUsers.FirstOrDefault(c=>c.Id==id);
            if(user == null) 
                return NotFound();
            return View(user);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(AppUser appUser)
        {
            var userinfo = _applicationDbContext.AppUsers.FirstOrDefault(x => x.Id == appUser.Id);
            if (userinfo == null)
                return NotFound();
            userinfo.LockoutEnd = DateTime.Now.AddYears(100);
            int rowaffected = _applicationDbContext.SaveChanges();
            if (rowaffected > 0)
            {
               

                return RedirectToAction("Index");
            }
            return View(userinfo);
        }


    }
}
