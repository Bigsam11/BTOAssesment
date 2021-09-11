using BTOAssesment.classLibrary.Domain;
using BTOAssesment.classLibrary.Features.RecitePoem;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solutions.Question3
{
    public class Solution3
    {
        public static void Run()
        {
            Console.Write("Enter animal name: ");

            string animalName = Console.ReadLine();

            Console.Write("Enter animal sound: ");

            string animalSound = Console.ReadLine();

            Animal customAnimal = new Animal(animalName, animalSound);

            Console.WriteLine(Poem.recitePoem(customAnimal));
        }
    }
}
