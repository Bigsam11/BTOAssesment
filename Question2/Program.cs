

using Question2;
using System;
using System.Collections.Generic;

namespace Question2
{
    class Program
    {
        static void Main(string[] args)
        {


            /**
             * 
             * 
             * Using polymorphism,I extended the solution to store 
             * another 10 animals and their corresponding  sounds 
             * in a list of type animals and iterate through with the poems respectively.
             * 
             * 
             * 
             * **/

            Console.WriteLine("::::::::::::::::::::::::" +
                "Using Polymorphism" +
                "::::::::::::::::::::::::::::::::::::::::::::::" +
                "                                              ");

            List<Animal> animal = new List<Animal>();
            animal.Add(new Animal("Cow", "moo"));
            animal.Add(new Animal("Dog", "bark"));
            animal.Add(new Animal("Cat", "mew"));
            animal.Add(new Animal("Pig", "oink"));
            animal.Add(new Animal("Duck", "quack"));
            animal.Add(new Animal("Crow", "caw"));
            animal.Add(new Animal("Eagle", "screech"));
            animal.Add(new Animal("Frog", "croak"));
            animal.Add(new Animal("Goat", "bleat"));
            animal.Add(new Animal("Hamster", "squeak"));
            animal.Add(new Animal("Hornet", "buzz"));
            animal.Add(new Animal("Locust", "chirp"));
            animal.Add(new Animal("Mouse", "squeak"));
            animal.Add(new Animal("Owl", "hoot"));
            animal.Add(new Animal("Pigeon", "coo"));


            foreach (var val in animal)
            {

                Console.WriteLine(val.recitePoem());
                   
            }
        }
    }
}
