using Microsoft.AspNetCore.Mvc;

namespace EmployeeExplorer_M_V_C.Controllers
{
    public class EngineerController : Controller
    {
        public IActionResult EngineerIndex()
        {
            return View();
        }
    }
}
