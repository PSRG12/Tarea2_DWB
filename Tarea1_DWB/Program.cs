using System;
using Tarea1_DWB.DataAccess;
using System.Linq;
using Tarea1_DWB.BackEnd;
    
namespace Tarea1_DWB
{
    class Program : BaseSC
    {
        static void Main(string[] args)
        {
            employeeSelect();
            productSelect();
        }

        private static void employeeSelect()
        {
            var employeeSelect = new EmployeesSC().GetEmployees().Select(s => new
            {
                //Proyección Lambda
                EmployeeId = s.EmployeeId,
                EmployeeFirstName = s.FirstName,
                EmployeeAdress = s.Address,
                EmployeeHomePhone = s.HomePhone,
                EmployeeNotes = s.Notes

            }).ToList();         
        }
   
        public static void productSelect()
        {
            var productSelect = new ProductsSC().GetProducts().Select(s => new
            {
                ProductId = s.ProductId,
                ProducName = s.ProductName,
                ProductUnits = s.UnitsInStock
            }).ToList();
        }
    }
}
