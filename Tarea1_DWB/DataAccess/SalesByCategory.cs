﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Tarea1_DWB.DataAccess
{
    public partial class SalesByCategory
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string ProductName { get; set; }
        public decimal? ProductSales { get; set; }
    }
}
