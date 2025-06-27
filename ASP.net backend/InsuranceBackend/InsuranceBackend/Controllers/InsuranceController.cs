using Microsoft.AspNetCore.Mvc;

namespace InsuranceBackend.Controllers
{
    public class InsuranceController : Controller
    {
        // This will respond to: /Insurance/Welcome
        public IActionResult Welcome()
        {
            return Content("Welcome to the Insurance Backend! 🚀");
        }

        // This will respond to: /Insurance/GetTime
        public IActionResult GetTime()
        {
            return Content("Current server time is: " + DateTime.Now.ToString());
        }
    }
}
