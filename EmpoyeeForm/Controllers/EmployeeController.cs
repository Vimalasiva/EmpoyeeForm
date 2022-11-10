using EmployeeForm.Core.IService;
using EmployeeForm.Core.Model;
using EmployeeForm.Services;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace EmpoyeeForm.Controllers
{
    public class EmployeeController : Controller
    {

        
        #region Declaration

     
        private readonly IEmployeeService employeeService;

       public EmployeeController(IEmployeeService employeeService)
        {
            this.employeeService = employeeService;
        }
        #endregion


        #region Create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(EmployeeModel employeeModel)
        {
            employeeService.Createform(employeeModel);
            return RedirectToAction("list");
            

        }
        #endregion


        #region List
        public IActionResult list()
        {
            var list = employeeService.listform();
            return View(list);
        }
        #endregion


        #region Edit
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var edit = employeeService.Save(id);
            return View("Create",edit);
        }
        //[HttpPost]
        //public IActionResult Edit( EmployeeModel employeeModel)
        //{
        //    employeeService.Editform(employeeModel);
        //    return RedirectToAction("Create");
        //}
        #endregion


        #region Delete
        public IActionResult Delete(int id)
        {
           employeeService.deleteid(id);
           return RedirectToAction("list");
        }
        #endregion

    }
}
