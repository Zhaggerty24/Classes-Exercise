using System;
using System.Collections.Generic;


namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var MyCar = new Car();
            MyCar.Make = "Mclaren";
            MyCar.Model = "Senna";
            MyCar.Year = 2023;

            var Honda = new Car()
            {
                Make = "Honda" ,
                Model = "HR-v" ,
                Year = 2023
            };
            
            var Mazda = new Car("Mazda", "Stinger", 2023)
            {

            };
            
            
            
            
            
            
            
            
        }
    }
}
