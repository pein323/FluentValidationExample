using FluentValidationExample.Models;
using Microsoft.AspNetCore.Mvc;

namespace FluentValidationExample.Controllers
{
    public class UserModelDataAnnotations : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View(new UserModelDA());
        }

        [HttpPost]
        public IActionResult FormValidation(UserModelDA model)
        {
            if (this.ModelState.IsValid)
            {
                ViewBag.SuccessMessage = "Great!";
            }
            return View();
        }
    }
}