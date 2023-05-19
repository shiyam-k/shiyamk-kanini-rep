using Dependency_Injection_MVC_11_5_23.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Dependency_Injection_MVC_11_5_23.Controllers
{
    public class HomeController : Controller
    {

        private readonly IRepoDI repoDI;
        public HomeController(IRepoDI repoDI)
        {
            this.repoDI = repoDI;
        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult AddProject(Projects prj)
        {
            Projects p = repoDI.AddProjects(prj);
            return View(p);
        }

        

        
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}