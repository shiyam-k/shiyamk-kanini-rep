using Intern_Explorer.Auth;
using Intern_Explorer.Models;
using Intern_Explorer.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Intern_Explorer.Controllers
{
    public class InternController : Controller
    {
        private readonly IRepoIC repocontext;
        private LoginLog InternLogin;
        //private LoginCredentials InternCredentials;

        Random random = new Random();
        public InternController(IRepoIC repocontext)
        {
            this.repocontext = repocontext;
            
        }
        public ActionResult InternView(LoggedIn loggerData)
        {
            LoggedIn intern = new LoggedIn();
            intern.IsLoggedIn = loggerData.IsLoggedIn;
            intern.SessionId = loggerData.SessionId;
            intern.EmployeeId = loggerData.EmployeeId;
            intern.Message = loggerData.Message;           
            return View();
        }

        
    }
}
