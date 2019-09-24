using HumanResource.Business;
using HumanResource.DataAccess.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HumanResource.Controllers
{
    public class HomeController : Controller
    {
        #region Properties
        private readonly IEmployee _employee;
        private readonly IDepartment _department;
        #endregion
        public HomeController(IEmployee employee, IDepartment department)
        {
            _employee = employee;
            _department = department;
        }


        public IActionResult Index()
        {
            var data = new EmployeeService(_employee, _department).GetEmployees();

            return View(data);
        }

        public IActionResult Login()
        {
            return View();
        }


    }
}