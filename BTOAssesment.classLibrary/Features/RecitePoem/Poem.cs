using BTOAssesment.classLibrary.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace BTOAssesment.classLibrary.Features.RecitePoem
{
    public class Poem
    {
       public static string recitePoem(Animal animal) => 
                    "Old MacDonald had a farm, E I E I O,"
                    + $"And on his farm he had a {animal.animalName}, E I E I O."
                    + $"With a {animal.animalSound} {animal.animalSound} here and a {animal.animalSound} {animal.animalSound} there,"
                    + $"Here a {animal.animalSound}, there a {animal.animalSound}, ev'rywhere a {animal.animalSound} {animal.animalSound}."
                    + $"Old MacDonald had a farm, E I E I O.\n";

       public static string recitePoem(string animalName,string animalSound) =>
                    "Old MacDonald had a farm, E I E I O,"
                    + $"And on his farm he had a {animalName}, E I E I O."
                    + $"With a {animalSound} {animalSound} here and a {animalSound} {animalSound} there,"
                    + $"Here a {animalSound}, there a {animalSound}, ev'rywhere a {animalSound} {animalSound}."
                    + $"Old MacDonald had a farm, E I E I O.\n";
    }
}
