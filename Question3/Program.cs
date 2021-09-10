using Question3.Interface;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Question3
{
    class Program
    {

        public static void recitePoem()

        {

            Console.Write("Enter animal name: ");

            string animalName = Console.ReadLine();

            Console.Write("Enter animal sound: ");

            string animalSound = Console.ReadLine();

            ICanrecitePoem customAnimal = new Animal(animalName, animalSound);

            Console.WriteLine(customAnimal.recitePoem());
        }

        static void Main(string[] args)
        {

            recitePoem();

        }
    }
}
