using Intern_Explorer.Auth;
using Intern_Explorer.Models;
using Intern_Explorer.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Intern_Explorer.Controllers
{
    public class ProfileController : Controller
    {
        private readonly IRepoIC repocontext;
        private LoginLog InternLogin;
        //private LoginCredentials InternCredentials;

        Random random = new Random();
        public ProfileController(IRepoIC repocontext)
        {
            this.repocontext = repocontext;

        }
        public IActionResult ProfileView(string EmployeeId)
        {
            return View(EmployeeId);
        }
        [HttpGet]
        public IActionResult GetProfile(string InternId)
        {
            ProfileModel profile = repocontext.GetProfileDetails(InternId);
            if (profile.isProfileExists)
            {
                return View(profile);
            }
            else
            {
                return RedirectToAction("ErrorView", "Error", profile.Message);
            }
        }
    }
}
