using Assignment.Models.DataClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment.Models
{
    
    public class Service:IService
    {
        MyRepository repository = new MyRepository();

        public int AverageOfCarsBetween(int yearStart,int yearEnd)
        {
           return repository.GetAverageBetween(yearStart,yearEnd);
        }

        public string ColourOfMostSols(int yearStart, int yearEnd)
        {
            return repository.GetCommonColourSoldBetween(yearStart, yearEnd);
        }

        public IDictionary<string,int> MostManufacturedSoldCarsBetwen(int yearStart, int yearEnd)
        {
            return repository.ManufacturedSoldCarsBetwen(yearStart, yearEnd);
        }

        public List<string> SumOfAllCarsBetween(int yearStart, int yearEnd)
        {
            return repository.GetSoldCarsBetween(yearStart, yearEnd);
        }
    }
}