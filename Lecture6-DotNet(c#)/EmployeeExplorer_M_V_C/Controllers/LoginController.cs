using EmployeeExplorer_M_V_C.ModelDummy;
using EmployeeExplorer_M_V_C.Models;
using EmployeeExplorer_M_V_C.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace EmployeeExplorer_M_V_C.Controllers
{
    public class LoginController : Controller
    {
        private readonly IEmployeeRepository repocontext;
        Random random = new Random();
        public LoginController(IEmployeeRepository repocontext)
        {
            this.repocontext = repocontext;
        }

        public IActionResult EmployeeLogin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult<string> Login(LoginDummy loginCred)
        {
            var v = repocontext.Login(loginCred).ToLower();
            
            if (v.Equals("engineer")){
                
                return RedirectToAction("EngineerIndex", "Engineer");
            }
            else if (v.Equals("admin") ||  v.Equals("manager"))
            {
                return Ok($"{v} has logged in");
            }
            return Ok(v);
        }

    }
}
