using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Models
{
    interface DataMethod
    {
        //return model and sum of sold cars between years
         List<string> GetSoldCarsBetween(int yearStart, int yearEnd);

        //return manufacture and sum of sold cars between years
        IDictionary<string,int> ManufacturedSoldCarsBetwen(int yearStart, int yearEnd);

        //return model and sum of sold cars between years
        int GetAverageBetween(int yearStart, int yearEnd);

        //return colour only
        string GetCommonColourSoldBetween(int yearStart, int yearEnd);
    }
}
