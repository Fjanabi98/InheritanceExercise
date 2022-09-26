using Microsoft.VisualBasic;
using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // Done Be sure to follow best practice when creating your classes
            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class


            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
            *Creatively display the class member values
            */

            var bird1 = new Bird();
            bird1.WingColor = "black";
            bird1.CanFly = true;
            bird1.migrate = true;
            bird1.BeakLength = 3.5;


            var lizard = new Reptile() 
            { 
                IsColdBlooded = true,
                IsAlive = true, 
                Habitat = "Swamp",
                IsScaly = true,
                CanGrowTail = true,

            };

            var animals = new Animals[] { bird1, lizard };

            foreach (var a in animals)
            {
                Console.WriteLine($"Alive:{a.IsAlive}");
                Console.WriteLine($"Age:{a.Age} years old");
                Console.WriteLine($"It has { a.LegCount}Legs");
                Console.WriteLine($"it lives by {a.LandSeaAir}");
            }


            
                    
          }

    }
}   


        
               

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *
              

            
             * Creatively display the class member values 
             */
        
