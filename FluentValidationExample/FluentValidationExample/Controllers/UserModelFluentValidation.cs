using FluentValidation.AspNetCore;
using FluentValidationExample.Models;
using FluentValidationExample.Validators;
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
        public IActionResult Index(UserModelFV model)
        {
            var validator = new UserModelValidator();

            var results = validator.Validate(model);
            results.AddToModelState(ModelState, null);
            return View(model);
        }
    }
}