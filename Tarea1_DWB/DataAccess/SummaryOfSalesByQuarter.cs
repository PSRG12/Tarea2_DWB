﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Tarea1_DWB.DataAccess
{
    public partial class SummaryOfSalesByQuarter
    {
        public DateTime? ShippedDate { get; set; }
        public int OrderId { get; set; }
        public decimal? Subtotal { get; set; }
    }
}
