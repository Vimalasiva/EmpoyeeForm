using EmployeeForm.Core.Model;
using EmployeeForm.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeForm.Core.IRepository
{
    public  interface IEmployeeRepository
    {
        public void Createform(EmployeeModel employeeModel);
        public void Editform( EmployeeModel employeeModel);
        List<EmployeeModel> listform();
        public void deleteid(int id);
        public EmployeeModel Save(int id);
    }
}
