using EmployeeForm.Core.IRepository;
using EmployeeForm.Core.IService;
using EmployeeForm.Repository;
using EmployeeForm.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeForm.Utility
{
    public  class DIResolver
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            #region Context accesor
            services.AddTransient<IHttpContextAccessor, HttpContextAccessor>();
            #endregion

            #region Services
            services.AddScoped<IEmployeeService, EmployeeServices>();

            #endregion

            #region Repository
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            #endregion
        }
    }
}
