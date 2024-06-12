using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Bird animal1 = new Bird();
            animal1.Diet = "worms";
            animal1.EatsFish = true;
            animal1.Habitat = "nest";
            animal1.Sound = "tweet";
                
;
            Reptile animal2 = new Reptile();
            animal2.HasLegs = true;
            animal2.IsCarnivore = true;
            animal2.Water = "swamp";
            animal2.HasForkedTongue = true;

            Console.WriteLine("Here are some features of a bird:");
            animal1.PrintBirdDetails();
            Console.WriteLine();
            Console.WriteLine("Here are some features of a reptile:");
            animal2.PrintReptileDetails();


        
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
        }
    }
}
