using System.Diagnostics;
using System.Security.Claims;
using CarSystem.Data;
using CarSystem.Models;
using CarSystem.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace CarSystem.Areas.Customer.Controllers
{

    [Area("Customer")]
    [Authorize]

    public class AdvertisementController : Controller
    {
        private ApplicationDbContext _db;       
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public string? LoggedInUser { get; set; }
        

        public AdvertisementController(ApplicationDbContext db, SignInManager<IdentityUser> signInManager, UserManager<IdentityUser> userManager, IHttpContextAccessor httpContextAccessor)
        {
            _db = db;
           
            _signInManager = signInManager;
            _userManager = userManager;

            _httpContextAccessor = httpContextAccessor;
           

        }
       
        public async Task<IActionResult>  Index()
        {
            if (_signInManager.IsSignedIn(User))
            {
                // Get the current user
                var user = await _userManager.GetUserAsync(User);

                if (user != null)
                {
                    
                    ViewData["Email"] = user.Email;
                    var x = user.Email;

                }
            }


            var advertisements = _db.Advertisements.Where(c => c.ReserverId == null).ToList();
            
			if (advertisements == null)

				return View();

			return View(advertisements);
		}

        //search is here 
        
        [HttpPost]
        public async Task<IActionResult> Index(SearchViewModel searchViewModel)
        {
            if (_signInManager.IsSignedIn(User))
            {
                // Get the current user
                var user = await _userManager.GetUserAsync(User);

                if (user != null)
                {

                    ViewData["Email"] = user.Email;

                }
            }
            // Start with a base query that selects all advertisements
            var query = _db.Advertisements.AsQueryable();

			// Apply filters only if the property has a value (not null or empty/zero)
			if (!string.IsNullOrEmpty(searchViewModel.CarName))
			{
				query = query.Where(a => a.CarName.Contains(searchViewModel.CarName));
			}

			if (searchViewModel.Price > 0) // Since Price has [Range(100000, ...)], 0 means not provided
			{
				query = query.Where(a => a.Price == searchViewModel.Price);
			}

			if (searchViewModel.ManufacturingYear.HasValue)
			{
				query = query.Where(a => a.ManufacturingYear == searchViewModel.ManufacturingYear);
			}

			if (searchViewModel.BuldingNumber.HasValue)
			{
				query = query.Where(a => a.BuldingNumber == searchViewModel.BuldingNumber);
			}

			if (!string.IsNullOrEmpty(searchViewModel.Street))
			{
				query = query.Where(a => a.Street.Contains(searchViewModel.Street));
			}

			if (!string.IsNullOrEmpty(searchViewModel.Area))
			{
				query = query.Where(a => a.Area.Contains(searchViewModel.Area));
			}

			if (!string.IsNullOrEmpty(searchViewModel.City))
			{
				query = query.Where(a => a.City.Contains(searchViewModel.City));
			}

			if (!string.IsNullOrEmpty(searchViewModel.Governorate))
			{
				query = query.Where(a => a.Governorate.Contains(searchViewModel.Governorate));
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
        
        //Create with Get Verb
        
        public async Task<IActionResult> Create()
        {
            if (_signInManager.IsSignedIn(User))
            {
                // Get the current user
                var user = await _userManager.GetUserAsync(User);

                if (user != null)
                {

                    ViewData["Email"] = user.Email;

                }
            }

            return View();
        }
        //Create with Post Verb
        [HttpPost]
        public async Task<IActionResult> Create(AdvertisementtViewModel advertisement)
        {
            if (_signInManager.IsSignedIn(User))
            {
                // Get the current user
                var user = await _userManager.GetUserAsync(User);

                if (user != null)
                {

                    ViewData["Email"] = user.Email;

                }
            }
            Advertisement _advertisement = new Advertisement();
            _advertisement.CarName = advertisement.CarName;
            _advertisement.ManufacturingYear = advertisement.ManufacturingYear;
            _advertisement.Price = advertisement.Price;
            _advertisement.LicenceExpirationDate = advertisement.LicenceExpirationDate;
            _advertisement.PhoneNumber = advertisement.PhoneNumber;
            _advertisement.BuldingNumber = advertisement.BuldingNumber;
			_advertisement.Street = advertisement.Street;
			_advertisement.Area = advertisement.Area;
			_advertisement.City = advertisement.City;
			_advertisement.Governorate = advertisement.Governorate;

			if (ModelState.IsValid)
            {
                if (advertisement.Image != null)
                {
                    //var name = Path.Combine(_he.ContentRootPath + "/Images",Path.GetFileName(product.Image.FileName));
                    //await product.Image.CopyToAsync(new FileStream(name,FileMode.Create));
                    //products.Image = "Images/" + product.Image.FileName;



                    string fileName = Path.GetFileName(advertisement.Image.FileName);
                    string uploadfilepath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\Images", fileName);
                    var stream = new FileStream(uploadfilepath, FileMode.Create);
                    advertisement.Image.CopyToAsync(stream);
                    _advertisement.Image = "Images/" + advertisement.Image.FileName;
                }
                if (advertisement.Image == null)

                    _advertisement.Image = "no-image-found-360x260.png";


                if (_signInManager.IsSignedIn(User))
                {
                    // Get the current user
                    var user = await _userManager.GetUserAsync(User);

                    if (user != null)
                    {
                        string userId = user.Email;
                        _advertisement.CreatorId = userId;


                    }





                }
                _db.Add(_advertisement);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");

            }


			

			return View(advertisement);
        }

        //Details with GET Verb
       
        public async Task<IActionResult> DetailsAsync(int? id)
        {
            if (_signInManager.IsSignedIn(User))
            {
                // Get the current user
                var user = await _userManager.GetUserAsync(User);

                if (user != null)
                {

                    ViewData["Email"] = user.Email;
                    ViewBag.Email = user.Email;
                    var x = ViewData["Email"];
                    var y = x;

                }
            }

            if (id == null)
                return NotFound();

            var advertisement = _db.Advertisements.FirstOrDefault(x => x.Id == id);

            if (advertisement == null)
            { return NotFound(); }



            return View(advertisement);
        }
        
        public async Task<IActionResult> ReserveAsync(string? reserverId, int? id)
        {
            var user = await _userManager.GetUserAsync(User);
            if (_signInManager.IsSignedIn(User))
            {
                // Get the current user
                 user = await _userManager.GetUserAsync(User);

                if (user != null)
                {

                    ViewData["Email"] = user.Email;

                }
            }
            if (id == 0 || reserverId == null)
                return NotFound();
            var advertisement = _db.Advertisements.FirstOrDefault(x => x.Id == id);
            if (advertisement == null)
                return NotFound();
            advertisement.ReserverId = user.Email;
            _db.Update(advertisement);
            await _db.SaveChangesAsync();

            var test= _db.Advertisements.FirstOrDefault(x => x.ReserverId== user.Email);



            TempData["ReservationMessage"] = "Reserved for 72 hours.";
            return View("Details", advertisement);
        }

        [HttpGet]
        public async Task<IActionResult> CancelReserveAsync( int? id)
        {
            if (_signInManager.IsSignedIn(User))
            {
                // Get the current user
                var user = await _userManager.GetUserAsync(User);

                if (user != null)
                {

                    ViewData["Email"] = user.Email;

                }
            }
            if (id == 0 )
                return NotFound();
            var advertisement = _db.Advertisements.FirstOrDefault(x => x.Id == id);
            if (advertisement == null)
                return NotFound();
            advertisement.ReserverId = null;
            _db.Update(advertisement);
            await _db.SaveChangesAsync();


            TempData["ReservationMessage"] = "Reservation cancelled.";

            return View("Details", advertisement);
        }

        public async Task<IActionResult> GetReservations()
        {           
            
            var user = await _userManager.GetUserAsync(User);
            ViewData["Email"] = user.Email;
            

            var ads = _db.Advertisements.Where(c => c.ReserverId == user.Email.ToString()).ToList();
            

            return View("Index", ads);
            
        }

        public async Task<IActionResult>  Delete( int? id)
        {
            if (_signInManager.IsSignedIn(User))
            {
                // Get the current user
                var useremail = await _userManager.GetUserAsync(User);

                if (useremail != null)
                {

                    ViewData["Email"] = useremail.Email;

                }
            }
            if (id == null)
            {
                return NotFound();
            }

            // Get the current user
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound();
            }

            // Properly await the async call
            var ad = await _db.Advertisements
                .FirstOrDefaultAsync(c =>c.Id == id);

            if (ad == null)
            {
                return NotFound();
            }

            _db.Advertisements.Remove(ad);
            await _db.SaveChangesAsync();

            return RedirectToAction("Index"); // Typically return RedirectToAction after POST
        }
    }
}
