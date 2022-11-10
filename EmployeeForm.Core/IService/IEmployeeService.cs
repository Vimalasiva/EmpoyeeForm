using EmployeeForm.Core.Model;
using EmployeeForm.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeForm.Core.IService
{
    public  interface IEmployeeService
    {
        public void Createform(EmployeeModel employeeModel);
        public void deleteid(int id);
        List<EmployeeModel> listform();
       public  EmployeeModel Save(int id);
    }
}
