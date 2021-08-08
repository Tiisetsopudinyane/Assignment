using Assignment.Models.DataClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment.Models
{
    public class MyRepository : DataMethod
    {
        SoldCarsList soldCarList = new SoldCarsList();
        public int GetAverageBetween(int yearStart, int yearEnd)
        {
            return soldCarList.GetAverageOfAllCarsSoldBetween(yearStart,yearEnd);
        }

        public string GetCommonColourSoldBetween(int yearStart, int yearEnd)
        {
            return soldCarList.GetClourOfMostSold(yearStart, yearEnd);
        }

        public List<string> GetSoldCarsBetween(int yearStart, int yearEnd)
        {
            return soldCarList.GetModelAndSumOfSoldCarsBetween(yearStart, yearEnd);
        }

        public IDictionary<string,int> ManufacturedSoldCarsBetwen(int yearStart, int yearEnd)
        {
            return soldCarList.GetMostManufactureSoldBetween(yearStart, yearEnd);
        }
    }
}