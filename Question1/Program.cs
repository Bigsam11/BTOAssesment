using Question1;
using System;
using System.Collections.Generic;

namespace Question1
{
    class Program
    {




        static void Main(string[] args)
        {


            /********
             * 
             * Modeling the animals
             * using a data-driven approach.
             * 
             * In a real world approach where the data is being provided from a storage .
             * 
             * ***************/

            Console.WriteLine("::::::::::::::::::::::::" +
               "Using a data-driven approach" +
               "::::::::::::::::::::::::::::::::::::::::::::::");

            Dictionary<string, string> animal = new Dictionary<string, string>();
            animal.Add("Cow", "moo");
            animal.Add("Dog", "bark");
            animal.Add("Cat", "mew");
            animal.Add("Pig", "oink");
            animal.Add("Duck", "quack");


            foreach (var val in animal)
            {
                Console.WriteLine(
                    "Old MacDonald had a farm, E I E I O,"
                    + "And on his farm he had a {0}, E I E I O."
                    + "With a {1} {1} here and a {1} {1} there,"
                    + "Here a {1}, there a {1}, ev'rywhere a {1} {1}."
                    + "Old MacDonald had a farm, E I E I O.\n", val.Key, val.Value);
            }




            /**
             * Another approach using polymorphism,
             * where different instances of animals
             * are created from a base class.
             * 
             * 
             * 
             * ***/


            Console.WriteLine("::::::::::::::::::::::::" +
                "Using Polymorphism" +
                ":::::::::::::::::::::::::::::::::::::::::: ::::");

            ICanrecitePoem dog = new Animal("Dog","bark");
            Console.WriteLine(dog.recitePoem());
            ICanrecitePoem cat = new Animal("Cat","mew");
            Console.WriteLine(cat.recitePoem());
            ICanrecitePoem cow = new Animal("Cow","moo");
            Console.WriteLine(cow.recitePoem());
            ICanrecitePoem pig = new Animal("Pig","oink");
            Console.WriteLine(pig.recitePoem());
            ICanrecitePoem duck = new Animal("Duck","quack");
            Console.WriteLine(duck.recitePoem());


        }
    }
}
