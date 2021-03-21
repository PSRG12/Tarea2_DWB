using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tarea1_DWB.DataAccess;

namespace Tarea1_DWB.BackEnd
{
    class ProductsSC : BaseSC
    {
        //Funcion que nos ayuda a obtener los Productos
        public IQueryable<Product> GetProducts()
        {
            return dbcontext.Products.AsQueryable();
        }
    }
}
