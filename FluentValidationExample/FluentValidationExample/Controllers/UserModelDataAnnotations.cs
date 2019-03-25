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

        // Post
        [HttpPost]
        public IActionResult Post(UserModelDA model)
        {
            return View();
        }
    }
}