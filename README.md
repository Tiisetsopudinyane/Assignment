# Assignment
Given the JSON data structure for and array of vehicle sales history: 
[{
        "id": 1,
        "model": "1 Series",
        "colour": "white",
        "manufacturer": "BMW",
        "salesHistory": [
            {
                "year": 2011,
                "vehiclesSold": 2991
            },
…
       ]
}] 
Where: 
•	‘id’ – Integer – represents a unique identifier of the data record (Primary Key).
•	‘model’ – String – represents the model (Polo) of the vehicle being sold from a manufacturer (VW).
•	‘colour’ – String – represents the specific colour of each the vehicle sold.
•	‘manufacturer’ – String – represents the name of the manufacturer producing the specific vehicle model.
•	‘salesHistory’ – Array of objects – represents an array of historical data outlining:
o	‘year’ – String – The year of sales.
o	‘vehiclesSold’ – Integer – The number of vehicles sold within that year.

                **THE PURPOSE OF THE ASSIGNMENT WAS TO**
                
  •	How many of each model were sold throughout between 2011 -2020? 
        OUTPUT eg.
          *Golf – 20000*
          *Polo – 30000*
          *1 Series - 10000*  

  •	Which manufacturer sold the most amount between 2011 -2020?
        OUTPUT eg.
          *VW – 20000*
          *Mercedes – 30000*
          *BMW - 10000*

  •	The average number of vehicles sold across all manufacturers and models between 2011 -2020?
        OUTPUT eg.
          *150000*
  •	What is the most common colour of vehicles sold between 2011 -2020?
        OUTPUT eg.
          *silver*
