using Assignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment.Controllers
{
    public class ValuesController : ApiController
    {

        Service service = new Service();

        /// <summary>
        /// Get Average of all sold cars
        /// •	The average number of vehicles sold across all manufacturers and models between 2011 -2020?
        /// </summary>
        /// <param name="yearStart"></param>
        /// <param name="yearEnd"></param>
        /// <returns>30720</returns>
        // GET api/values/GetAverage?yearStart=2011&yearEnd=2020
        [Route("api/values/GetAverage")]
        public int GetAverageOfAllCars(int yearStart,int yearEnd)
        {
            return service.AverageOfCarsBetween(yearStart,yearEnd);
        }
        /// <summary>
        /// Get sum of all sold cars and models
        /// •	How many of each model were sold throughout between 2011 -2020?
        /// </summary>
        /// <param name="yearStart"></param>
        /// <param name="yearEnd"></param>
        /// <returns>1 Series 55323,<string>2 Series 11251,3 Series 20302,A Class 26149,B Class 31000,Golf 40300</returns>
        //GET api/values/Getsum?yearStart=2011&yearEnd=2020
        [Route("api/values/Getsum")]
        public List<string> Getsum(int yearStart,int yearEnd)
        {
            return service.SumOfAllCarsBetween(yearStart, yearEnd);
        }
        /// <summary>
        /// Get all sum of sold cars and manufature
        /// •	Which manufacturer sold the most amount between 2011 -2020?
        /// </summary>
        /// <param name="yearStart"></param>
        /// <param name="yearEnd"></param>
        /// <returns>BMW 86876,MERCEDES 57149,VM 40300</returns>
        //Get api/values/GetManufactureOfMostCarsSold?yearStart=2011&yearEnd=2020
        [Route("api/values/GetManufactureOfMostCarsSold")]
        public IDictionary<string,int> GetManufactureOfMostCarsSold(int yearStart, int yearEnd)
        {
            return service.MostManufacturedSoldCarsBetwen(yearStart, yearEnd);
        }

        /// <summary>
        /// Get colour of most sold cars
        /// •	What is the most common colour of vehicles sold between 2011 -2020?
        /// </summary>
        /// <param name="yearStart"></param>
        /// <param name="yearEnd"></param>
        /// <returns>white</returns>
        //GET api/values/GetColourOfMostSold?yearStart=2011&yearEnd=2020
        [Route("api/values/GetColourOfMostSold")]
        public string GetColourOfMostSold(int yearStart, int yearEnd)
        {
            return service.ColourOfMostSols(yearStart, yearEnd);
        }

    }
}
