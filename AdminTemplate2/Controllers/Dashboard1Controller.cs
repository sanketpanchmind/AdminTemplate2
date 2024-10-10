using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AdminTemplate2.Controllers
{
    public class Dashboard1Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
