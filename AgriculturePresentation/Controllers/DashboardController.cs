using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.Controllers
{
    public class DashboardController : Controller
    {
        private readonly IContactService _contactService;

        public DashboardController(IContactService contactService)
        {
            _contactService = contactService;
        }

        public IActionResult Index()
        {
            var values = _contactService.GetListAll();

            return View(values);
        }
    }
}
