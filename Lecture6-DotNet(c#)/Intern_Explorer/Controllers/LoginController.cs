using Intern_Explorer.Models;
using Intern_Explorer.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Intern_Explorer.Controllers
{
    public class LoginController : Controller
    {
        private readonly IRepoIC repocontext;
        Random random = new Random();
        public LoginController(IRepoIC repocontext)
        {
            this.repocontext = repocontext;
        }
        public IActionResult LoginView()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult<string>> ConnectIntern(LoginModelDummy iLoginData)
        {
            return repocontext.AddUser(iLoginData);
        }
        public IActionResult ILogin(LoginModelDummy iLoginData)
        {
            LoggedIn result = repocontext.ILogin(iLoginData);            
            if(result.IsLoggedIn) {
                return RedirectToAction("InternView", "Intern", result);
            }
            else
            {
                return RedirectToAction("ErrorView", "Error",result.Message);
            }
        }
        
    }
}
