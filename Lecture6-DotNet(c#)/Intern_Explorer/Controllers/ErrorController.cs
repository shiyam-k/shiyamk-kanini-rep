using Microsoft.AspNetCore.Mvc;

namespace Intern_Explorer.Controllers
{
    public class ErrorController : Controller
    {
        public IActionResult ErrorView(string errorMessage)
        {            
            return View(errorMessage);
        }
    }
}
