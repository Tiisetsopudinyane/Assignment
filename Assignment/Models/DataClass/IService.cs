using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Models.DataClass
{
    interface IService
    {
        List<string> SumOfAllCarsBetween(int yearStart, int yearEnd);
        int AverageOfCarsBetween(int yearStart,int yearEnd);
        IDictionary<string,int> MostManufacturedSoldCarsBetwen(int yearStart, int yearEnd);
        string ColourOfMostSols(int yearStart, int yearEnd);
    }
}
