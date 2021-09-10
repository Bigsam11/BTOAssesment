using System;
using System.Collections.Generic;
using System.Text;

namespace Question1
{
    public  class Animal:ICanrecitePoem
    {
        private string animalName;
        private string animalSound;


        public Animal(string name,string sound)
        {
            animalName = name;
            animalSound = sound;
        }

        public string recitePoem() => $" Old MacDonald had a farm, E I E I O,"
                    + $"And on his farm he had a {animalName}, E I E I O."
                    + $"With a {animalSound} {animalSound} here and a {animalSound} {animalSound} there,"
                    + $"Here a {animalSound}, there a {animalSound}, ev'rywhere a {animalSound} {animalSound}."
                    + "Old MacDonald had a farm, E I E I O.\n";

       
    }
}
