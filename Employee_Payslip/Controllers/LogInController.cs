using DataModel.Models;
using DataModel.Repositories;
using Employee_Payslip.Models;
using Microsoft.AspNetCore.Mvc;

namespace Employee_Payslip.Controllers
{
    public class LogInController : Controller
    {
        private readonly IUnitOfWork _IUnitOfWork;

        public LogInController(IUnitOfWork unitOfWork)
        {
            _IUnitOfWork = unitOfWork;
        }

        public IActionResult LogIn()
        {
            return View();
        }
        [HttpPost]
        public string Log_In(User logIn)
        {
            string result = string.Empty;
            try
            {
                var User = _IUnitOfWork.IUserRepository.GetLogIn(logIn);
                if (User != null)
                {
                    result = "Success";
                }
            }
            catch(Exception ex)
            {

            }
            
            return result;
        }

        public ActionResult Logout()
        {
            Response.Redirect("LogIn/LogIn");
            return View();
        }
    }
}
