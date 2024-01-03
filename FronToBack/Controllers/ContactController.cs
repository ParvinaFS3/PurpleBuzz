using FronToBack.DAL;
using FronToBack.Models;
using FronToBack.ViewModels.Contact;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FronToBack.Controllers
{
    public class ContactController : Controller
    {
        private readonly AppDbContext _appDbContext;
        public ContactController(AppDbContext appDbContext)
        {

            _appDbContext = appDbContext;


        }
        public async Task<IActionResult> Index()
        {

            var contactIntro = await _appDbContext.ContactIntro.FirstOrDefaultAsync();
            var contactInfo = await _appDbContext.ContactInfo.FirstOrDefaultAsync();
            List<ContactHeader> contactHeaders = await _appDbContext.ContactHeaders.ToListAsync();
            ContactIndexViewModel model = new ContactIndexViewModel
            {
                ContactHeaders = contactHeaders,
                ContactInfo = contactInfo,
                ContactIntro = contactIntro,
            };


            return View(model);
        }
    }
}
