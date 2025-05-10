using System.Security.Claims;
using CarSystem.Data;
using CarSystem.Models;
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

        public AdvertisementController(ApplicationDbContext db, SignInManager<IdentityUser> signInManager, UserManager<IdentityUser> userManager)
        {
            _db = db;
           
            _signInManager = signInManager;
            _userManager = userManager;




        }

        public IActionResult Index()
        {
            var advertisements = _db.Advertisements.Where(c=>c.ReserverId==null).ToList();
            if (advertisements == null)

                return View();

            return View(advertisements);
        }
        
        [HttpPost]
        public IActionResult Index(decimal? price, string? carName,int? manufacturingYear,int? buldingNumber,string? street,string? area, string? city,string? governorate)
        {
            var advertisements = _db.Advertisements.Where(z => z.Price ==price  && z.CarName == carName && z.ManufacturingYear == manufacturingYear
                                                          && z.BuldingNumber == buldingNumber && z.Street == street && z.Area == area && z.City == city && z.Governorate == governorate).ToList();
            if (price == null || carName == null || manufacturingYear == null || buldingNumber == null || street == null || area == null || city == null || governorate == null)
                advertisements = _db.Advertisements.ToList();

            return View(/*advertisements*/);
        }
        
        //Create with Get Verb
        
        public IActionResult Create()
        {

            return View();
        }
        //Create with Post Verb
        [HttpPost]
        public async Task<IActionResult> Create(AdvertisementtViewModel advertisement)
        {
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
                        string userId = user.Id;
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


            if (id == null)
                return NotFound();

            var advertisement = _db.Advertisements.FirstOrDefault(x => x.Id == id);

            if (advertisement == null)
            { return NotFound(); }



            return View(advertisement);
        }
        
        public async Task<IActionResult> ReserveAsync(string? reserverId, int? id)
        {
            if (id == 0 || reserverId == null)
                return NotFound();
            var advertisement = _db.Advertisements.FirstOrDefault(x => x.Id == id);
            if (advertisement == null)
                return NotFound();
            advertisement.ReserverId = reserverId;
            _db.Update(advertisement);
            await _db.SaveChangesAsync();




            return View("Details", advertisement);
        }
        public async Task<IActionResult> GetReservations()
        {
           // if (_signInManager.IsSignedIn(User))
            {
                // Get the current user
                var user = await _userManager.GetUserAsync(User);
                var ads = _db.Advertisements.Where(c => c.ReserverId == user.Id).ToList();

                return View("Index", ads);
            }
        }

        public async Task<IActionResult> Delete(string? userId, int? id)
        {
            if (id == null || userId == null)
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
                .FirstOrDefaultAsync(c => c.CreatorId == user.Id && c.Id == id);

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
