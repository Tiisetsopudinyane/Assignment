using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment.Models
{
    public class SalesHistory
    {
        public SalesHistory()
        {
            this.year = 0;
            this.vehiclesSold = 0;
        }
        public SalesHistory(int year,int vehicleSold)
        {
            this.year = year;
            this.vehiclesSold = vehicleSold;
        }
        public dynamic year { get; set; }
        public dynamic vehiclesSold { get; set; }
    }
}