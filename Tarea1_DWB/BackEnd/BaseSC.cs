using System;
using System.Collections.Generic;
using System.Text;
using Tarea1_DWB.DataAccess;

namespace Tarea1_DWB.BackEnd
{
    class BaseSC
    {
        public static NorthwindContext dbcontext = new NorthwindContext();
    }
}
