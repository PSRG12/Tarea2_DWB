using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tarea1_DWB.DataAccess;

namespace Tarea1_DWB.BackEnd
{
    class EmployeesSC : BaseSC
    {
        //Funcione que nos ayudan a obtener los empleados
        public IQueryable<Employee> GetEmployees()
        {
            return dbcontext.Employees.AsQueryable();
        }    
    }
}
