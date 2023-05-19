using Microsoft.AspNetCore.Mvc;
using EExp_M_V_C.Models;


namespace EExp_M_V_C.Controllers
{
    public class LoginController : Controller
    {
        private readonly EmployeeExplorerDBContext context;
        Random random = new Random();
        public LoginController(EmployeeExplorerDBContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        /*public IActionResult Login(LoginDummy loginCredentials)
        {
            Login session = new Login()
            {
                SessionId = $"SID{random.Next(1, 9)}{random.Next(1, 9)}{random.Next(1, 9)}{random.Next(1, 9)}",
                LoginEmployeeId = loginCredentials.LoginEmployeeId,
                Password= loginCredentials.Password,
            };
            return Ok();
        }*/

    }
}
