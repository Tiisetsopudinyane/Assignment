using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
namespace Assignment.Models
{
    public class SoldCarsList
    {
        public SoldCarsList()
        {
            this.salesHistory = new List<SalesHistory>();
            soldCars = jsonData.GetJason();
            
        }
        int SumOfcarsales,count=1;
        dynamic soldCars;
        
        JsonData jsonData = new JsonData();


        public int id { get; set; } 
        public string model { get; set; }
        public string colour { get; set; }
        public string manufacturer { get; set; }
        public List<SalesHistory> salesHistory { get; set; }


       
        public List<string> GetModelAndSumOfSoldCarsBetween(int yearStart, int yearEnd)
        {
            List<string> MySalesHistoryOutput = new List<string>();
            List<string> FinalOutputOfSalesHistory = new List<string>();
            string newCurrentModel = "";
            foreach (var soldCar in soldCars)
            {  
                this.id = soldCar.id;
                this.model = soldCar.model;
                this.colour = soldCar.colour;
                this.manufacturer = soldCar.manufacturer;
                

                foreach (var saleHistory in soldCar.salesHistory)
                {
                    SalesHistory objSaleHistory = new SalesHistory((int)saleHistory.year, (int)saleHistory.vehiclesSold);
                    this.salesHistory.Add(objSaleHistory);
                }
                int itemValue = 0;
                for (int i = 0; i < this.salesHistory.Count; i++)
                {
                    
                    var CurrentYear = this.salesHistory.ElementAt(i).year;
                    if ((int)CurrentYear >= yearStart)
                    {
                        itemValue += this.salesHistory.ElementAt(i).vehiclesSold;
                        yearStart = this.salesHistory.ElementAt(i).year;
                        if ((int)this.salesHistory.ElementAt(i).year <= yearEnd)
                            SumOfcarsales = itemValue;
                        
                    }
                    else if (yearStart == yearEnd)
                    {
                        SumOfcarsales = itemValue;
                       
                    }

                      
                    
                }
                newCurrentModel = this.model;
                MySalesHistoryOutput.Add(newCurrentModel + "  " + SumOfcarsales);
            }
            
            return MySalesHistoryOutput;
         
        }
        public IDictionary<string,int> GetMostManufactureSoldBetween(int yearStart, int yearEnd)
        {
            List<string> MySalesHistoryOutput = new List<string>();
            int counter = 0;
            List<string> FinalOutputOfSalesHistory = new List<string>();
            Dictionary<string, int> ManufactureAndMostSoldCars = new Dictionary<string, int>();
            string newCurrentManufacture = "";
            foreach (var soldCar in soldCars)
            {
                this.id = soldCar.id;
                this.model = soldCar.model;
                this.colour = soldCar.colour;
                this.manufacturer = soldCar.manufacturer;


                foreach (var saleHistory in soldCar.salesHistory)
                {
                    SalesHistory objSaleHistory = new SalesHistory((int)saleHistory.year, (int)saleHistory.vehiclesSold);
                    this.salesHistory.Add(objSaleHistory);
                }
                int itemValue = 0;
                for (int i = 0; i < this.salesHistory.Count; i++)
                {

                    var CurrentYear = this.salesHistory.ElementAt(i).year;
                    if ((int)CurrentYear >= yearStart)
                    {
                        itemValue += this.salesHistory.ElementAt(i).vehiclesSold;
                        yearStart = this.salesHistory.ElementAt(i).year;
                        if ((int)this.salesHistory.ElementAt(i).year <= yearEnd)
                            SumOfcarsales = itemValue;
                    }
                    else if (yearStart == yearEnd)
                    {
                        SumOfcarsales = itemValue;
                    }
                    counter++;
                }
                newCurrentManufacture = this.manufacturer;
                if (!ManufactureAndMostSoldCars.ContainsKey(newCurrentManufacture))
                {
                    ManufactureAndMostSoldCars.Add(newCurrentManufacture, SumOfcarsales);
                }
                else
                {
                    ManufactureAndMostSoldCars[newCurrentManufacture] = ManufactureAndMostSoldCars[newCurrentManufacture]+SumOfcarsales;
                }
            }

            return ManufactureAndMostSoldCars;
        }
        public string GetClourOfMostSold(int yearStart, int yearEnd)
        {
            List<string> MySalesHistoryOutput = new List<string>();
            int counter = 0;
            List<string> FinalOutputOfSalesHistory = new List<string>();
            Dictionary<string, int> ManufactureAndMostSoldCars = new Dictionary<string, int>();
            string newCurrentManufacture = "";
            foreach (var soldCar in soldCars)
            {
                this.id = soldCar.id;
                this.model = soldCar.model;
                this.colour = soldCar.colour;
                this.manufacturer = soldCar.manufacturer;


                foreach (var saleHistory in soldCar.salesHistory)
                {
                    SalesHistory objSaleHistory = new SalesHistory((int)saleHistory.year, (int)saleHistory.vehiclesSold);
                    this.salesHistory.Add(objSaleHistory);
                }
                int itemValue = 0;
                for (int i = 0; i < this.salesHistory.Count; i++)
                {

                    var CurrentYear = this.salesHistory.ElementAt(i).year;
                    if ((int)CurrentYear >= yearStart)
                    {
                        itemValue += this.salesHistory.ElementAt(i).vehiclesSold;
                        yearStart = this.salesHistory.ElementAt(i).year;
                        if ((int)this.salesHistory.ElementAt(i).year <= yearEnd)
                            SumOfcarsales = itemValue;
                    }
                    else if (yearStart == yearEnd)
                    {
                        SumOfcarsales = itemValue;
                    }
                    counter++;
                }
                newCurrentManufacture = this.colour;
                if (!ManufactureAndMostSoldCars.ContainsKey(newCurrentManufacture))
                {
                    ManufactureAndMostSoldCars.Add(newCurrentManufacture, SumOfcarsales);
                }
                else
                {
                    ManufactureAndMostSoldCars[newCurrentManufacture] = ManufactureAndMostSoldCars[newCurrentManufacture] + SumOfcarsales;
                }
            }
            Dictionary<string, int> newMaxColourKeyAndValue = new Dictionary<string, int>();
            var ColourOfMaxkey = "";
                int max;
             foreach(var item in ManufactureAndMostSoldCars)
             {
                   max = ManufactureAndMostSoldCars.Values.Max();
                if (ManufactureAndMostSoldCars[item.Key] == max)
                {
                    ColourOfMaxkey = item.Key;
                }
             }
                 
            return ColourOfMaxkey;
        }
        
        public int GetAverageOfAllCarsSoldBetween(int yearStart,int yearEnd)
        { int returnAverage = 0;
            List<int> MySalesHistoryOutput = new List<int>();
            List<int> FinalOutputOfSalesHistory = new List<int>();
            foreach (var soldCar in soldCars)
            {
                this.id = soldCar.id;
                this.model = soldCar.model;
                this.colour = soldCar.colour;
                this.manufacturer = soldCar.manufacturer;


                foreach (var saleHistory in soldCar.salesHistory)
                {
                    SalesHistory objSaleHistory = new SalesHistory((int)saleHistory.year, (int)saleHistory.vehiclesSold);
                    this.salesHistory.Add(objSaleHistory);
                }
                int itemValue = 0;
                for (int i = 0; i < this.salesHistory.Count; i++)
                {

                    var CurrentYear = this.salesHistory.ElementAt(i).year;
                    if ((int)CurrentYear >= yearStart)
                    {
                        itemValue += this.salesHistory.ElementAt(i).vehiclesSold;
                        yearStart = this.salesHistory.ElementAt(i).year;
                        if ((int)this.salesHistory.ElementAt(i).year <= yearEnd)
                            SumOfcarsales = itemValue;

                    }
                    else if (yearStart == yearEnd)
                    {
                        SumOfcarsales = itemValue;

                    }
                }
                MySalesHistoryOutput.Add(SumOfcarsales);
                
            }
            foreach (var items in MySalesHistoryOutput)
            {
                
                returnAverage += items;
            }
            //return datatype shouble double in this case but int is prefered
            int finalValue = (returnAverage / MySalesHistoryOutput.Count());
            return finalValue;
        }

    }


}