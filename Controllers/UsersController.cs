using Microsoft.AspNetCore.Mvc;
using ANazhatOOP.Models;

namespace ANazhatOOP.Controllers
{
    public class UsersController : Controller
    {
        UsersContext uc = new();
        public IActionResult ANView()
        {
            return View(uc.AnazhatTables.ToList());
        }
    }
}
