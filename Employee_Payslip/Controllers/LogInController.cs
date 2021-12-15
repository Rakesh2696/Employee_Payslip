using Employee_Payslip.Models;
using Microsoft.AspNetCore.Mvc;

namespace Employee_Payslip.Controllers
{
    public class LogInController : Controller
    {
        public IActionResult LogIn()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LogIn(LogIn logIn)
        {
            if(logIn.UserId.ToLower()=="admin" && logIn.Password.ToLower() == "admin")
            {
                Response.Redirect("Home/Index");
            }
            else
            {

            }
            return View();
        }

        public ActionResult Logout()
        {
            Response.Redirect("LogIn/LogIn");
            return View();
        }
    }
}
