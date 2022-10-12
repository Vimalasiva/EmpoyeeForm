using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeForm.Core.Model
{
    public class EmployeeModel
    {
        public int ID { get; set; }
        
        public string Name { get; set; }
        public int age { get; set; }
        
        public string gender { get; set; }
        public string qualification { get; set; }
        public string JobRole { get; set; }
        public int experience { get; set; }
        public string address { get; set; }
        public long PhoneNo { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string Re_Password { get; set; }
    }
}
