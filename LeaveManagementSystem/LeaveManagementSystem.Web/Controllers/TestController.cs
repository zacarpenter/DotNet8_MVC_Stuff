using LeaveManagementSystem.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace LeaveManagementSystem.Web.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            var data = new TestViewModel
            {
                Name = "test",
                DateOfBirth = new DateTime(1991, 10, 10, 23, 59, 0),
            };
            return View(data);
        }
    }
}
