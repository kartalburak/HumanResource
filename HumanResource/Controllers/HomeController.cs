using HumanResource.Business;
using HumanResource.DataAccess.Interfaces;
using HumanResource.Models;
using HumanResource.Resources;
using HumanResource.Utils;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

namespace HumanResource.Controllers
{
    [MiddlewareFilter(typeof(LocalizationPipeline))]
    public class HomeController : Controller
    {
        #region Properties
        private readonly IEmployee _employee;
        private readonly IDepartment _department;
        private readonly IEducation _education;
        private readonly IMission _mission;
        private readonly IStringLocalizer<HomeController> _localizer;
        private readonly IStringLocalizer<SharedResources> _sharedLocalizer;
        private readonly IHttpContextAccessor _httpContextAccessor;


        #endregion
        public HomeController(IEmployee employee
            , IDepartment department
            , IStringLocalizer<HomeController> localizer
            , IStringLocalizer<SharedResources> sharedLocalizer
            , IHttpContextAccessor httpContextAccessor
            , IEducation education
            , IMission mission
            )
        {
            _employee = employee;
            _department = department;
            _localizer = localizer;
            _sharedLocalizer = sharedLocalizer;
            _httpContextAccessor = httpContextAccessor;
            _education = education;
            _mission = mission;

        }


        public IActionResult Index()
        {

            ViewData["Anasayfa"] = _localizer.GetString("Anasayfa");
            var response = ViewData["Anasayfa"];

            var data = new EmployeeService(_employee, _department).GetEmployees();

            return View(data);
        }

        public IActionResult Login()

        {

            return View();
        }
        [HttpPost]
        public IActionResult Login(LoginViewModel loginViewModel)

        {
            SessionHelper.Configure(_httpContextAccessor);

            SessionLoginResult result =
               SessionHelper.Login(loginViewModel.EmployeeUsername, loginViewModel.EmployeePassword, _employee, _department, _education, _mission);

            if (ModelState.IsValid)
            {
                if (result.IsSuccess)
                {
                    HttpContext.Session.SetString("RememberMe", loginViewModel.IsChecked.ToString());
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ViewBag.Login = result.Message;
                    return View();
                }
            }
            else
            {
                return View();
            }






        }

        public IActionResult LogOut()
        {
            //SessionHelper.Configure(_httpContextAccessor);
            //HttpContext.SignOutAsync();
            if (SessionHelper.Logout())
            {
                return RedirectToAction("Login", "Home");
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

    }
}