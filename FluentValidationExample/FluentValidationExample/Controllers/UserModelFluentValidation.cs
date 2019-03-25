using FluentValidationExample.Models;
using Microsoft.AspNetCore.Mvc;

namespace FluentValidationExample.Controllers
{
    public class UserModelFluentValidation : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View(new UserModelFV());
        }

        // Post
        [HttpPost]
        public IActionResult Post(UserModelFV model)
        {
            return View();
        }
    }
}