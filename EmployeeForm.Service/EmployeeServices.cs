using EmployeeForm.Core.IRepository;
using EmployeeForm.Core.IService;
using EmployeeForm.Core.Model;
using EmployeeForm.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeForm.Services
{
    public class EmployeeServices:IEmployeeService
    {
        IEmployeeRepository _employeeRepository;
        public EmployeeServices(IEmployeeRepository employeeRepository)
        {
            _employeeRepository=employeeRepository;
        }
        #region Createform
        public void Createform(EmployeeModel employeeModel)
        {
            _employeeRepository.Createform(employeeModel);
        }
        #endregion

        #region Editform
        public void  Editform(EmployeeModel employeeModel)
        {
            _employeeRepository.Editform(employeeModel);
        }
        #endregion

        #region Listform

       
        public List<EmployeeModel> listform()
        {
             return _employeeRepository.listform();
        }
        #endregion

        public void deleteid(int id)
        {
            _employeeRepository.deleteid(id);
        }

        public EmployeeModel Save(int id)
        {
            return _employeeRepository.Save(id);
        }

    }
}
