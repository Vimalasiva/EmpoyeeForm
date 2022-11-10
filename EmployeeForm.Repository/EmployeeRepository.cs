using EmployeeForm.Core.IRepository;
using EmployeeForm.Core.Model;
using EmployeeForm.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeForm.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        #region Adding new details
        public void Createform(EmployeeModel employeeModel)
        {
            if (employeeModel != null)
            {
                using (Registration_FormContext entity = new Registration_FormContext())
                {
                    if (employeeModel.ID == 0)
                    {
                        EmployeeDetail employeeDetail = new EmployeeDetail();
                        employeeDetail.Employee_Name = employeeModel.Name;
                        employeeDetail.Age = employeeModel.age;
                        employeeDetail.Gender = employeeModel.gender;
                        employeeDetail.Qualification = employeeModel.qualification;
                        employeeDetail.Job_Role = employeeModel.JobRole;
                        employeeDetail.Experience = employeeModel.experience;
                        employeeDetail.Address = employeeModel.address;
                        employeeDetail.Phone_No = employeeModel.PhoneNo;
                        employeeDetail.Email = employeeModel.email;
                        employeeDetail.Password = employeeModel.password;
                        employeeDetail.Conform_Password = employeeModel.Re_Password;
                        entity.Add(employeeDetail);
                        entity.SaveChanges();

                    }

                    else
                    {
                        var check = entity.EmployeeDetail.Where(m => m.Employee_ID == employeeModel.ID).SingleOrDefault();
                        check.Employee_Name = employeeModel.Name;
                        check.Age = employeeModel.age;
                        check.Gender = employeeModel.gender;
                        check.Qualification = employeeModel.qualification;
                        check.Job_Role = employeeModel.JobRole;
                        check.Experience = employeeModel.experience;
                        check.Address = employeeModel.address;
                        check.Phone_No = employeeModel.PhoneNo;
                        check.Email = employeeModel.email;
                        check.Password = employeeModel.password;
                        check.Conform_Password = employeeModel.Re_Password;

                        entity.SaveChanges();
                    }
                }
            }
        }
            #endregion

            #region Assigning values in Edit page
            public EmployeeModel Save(int id)
            {
                using (Registration_FormContext entity = new Registration_FormContext())
                {
                    EmployeeModel employeeModel = new EmployeeModel();
                    var save = entity.EmployeeDetail.Where(m => m.Employee_ID == id).SingleOrDefault();

                    employeeModel.ID = save.Employee_ID;
                    employeeModel.Name = save.Employee_Name;
                    employeeModel.age = save.Age;
                    employeeModel.gender = save.Gender;
                    employeeModel.qualification = save.Qualification;
                    employeeModel.JobRole = save.Job_Role;
                    employeeModel.experience = save.Experience;
                    employeeModel.address = save.Address;
                    employeeModel.PhoneNo = save.Phone_No;
                    employeeModel.email = save.Email;
                    employeeModel.password = save.Password;
                    employeeModel.Re_Password = save.Conform_Password;
                    entity.SaveChanges();


                    return employeeModel;
                }


            }
            #endregion

            //#region Editing Details

            //public void Editform(EmployeeModel employeeModel)
            //{

            //    using (Registration_FormContext entity = new Registration_FormContext())
            //    {

            //        var check = entity.EmployeeDetail.Where(m => m.Employee_ID == employeeModel.ID).SingleOrDefault();
            //        if (check != null)
            //        {
            //            check.Employee_Name = employeeModel.Name;
            //            check.Age = employeeModel.age;
            //            check.Gender = employeeModel.gender;
            //            check.Qualification = employeeModel.qualification;
            //            check.Job_Role = employeeModel.JobRole;
            //            check.Experience = employeeModel.experience;
            //            check.Address = employeeModel.address;
            //            check.Phone_No = employeeModel.PhoneNo;
            //            check.Email = employeeModel.email;
            //            check.Password = employeeModel.password;
            //            check.Conform_Password = employeeModel.Re_Password;

            //            entity.SaveChanges();
            //        }

            //    }

            //}
            //#endregion

            #region Listing the Details

            public List<EmployeeModel> listform()
            {
                List<EmployeeModel> employeeList = new List<EmployeeModel>();
                using (Registration_FormContext entity = new Registration_FormContext())
                {
                    var List = entity.EmployeeDetail.Where(x => x.Is_Deleted == false).ToList();
                    if (List != null)
                    {

                        foreach (var item in List)
                        {
                            EmployeeModel employeeModel = new EmployeeModel();
                            employeeModel.ID = item.Employee_ID;
                            employeeModel.Name = item.Employee_Name;
                            employeeModel.age = item.Age;
                            employeeModel.gender = item.Gender;
                            employeeModel.qualification = item.Qualification;
                            employeeModel.JobRole = item.Job_Role;
                            employeeModel.experience = item.Experience;
                            employeeModel.address = item.Address;
                            employeeModel.PhoneNo = item.Phone_No;
                            employeeModel.email = item.Email;
                            employeeModel.password = item.Password;
                            employeeModel.Re_Password = item.Conform_Password;
                            employeeList.Add(employeeModel);
                        }

                    }
                    return employeeList;
                }


            }
            #endregion

            #region Deleting detail
            public void deleteid(int id)
            {
                using (Registration_FormContext entity = new Registration_FormContext())
                {
                    var delete = entity.EmployeeDetail.Where(m => m.Employee_ID == id).SingleOrDefault();
                    if (delete != null)
                    {
                        delete.Is_Deleted = true;
                        entity.SaveChanges();
                    }
                }
            }
            #endregion
        }
    }
