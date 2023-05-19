using Design_Pattern_10_5_23.Models;
using Design_Pattern_10_5_23.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Design_Pattern_10_5_23.Controllers
{
    public class RoleController : Controller
    {
        private readonly IRepositoryDI repoDI;
        public RoleController(IRepositoryDI repoDI)
        {
            this.repoDI = repoDI;
        }
        public IActionResult RoleView()
        {
            return View();
        }
        [HttpPost]
        public string AddRole(Roles role)
        {
            
            return repoDI.InsertRoles(role);
        }
    }
}
