using BTOAssesment.classLibrary.Features.RecitePoem;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solutions.Question2
{
    public class Solution2
    {

        public static void Run()
        {

            Dictionary<string, string> animalsDB = new Dictionary<string, string>();
            animalsDB.Add("Cow", "moo");
            animalsDB.Add("Dog", "bark");
            animalsDB.Add("Cat", "mew");
            animalsDB.Add("Pig", "oink");
            animalsDB.Add("Duck", "quack");
            animalsDB.Add("Eagle", "screech");
            animalsDB.Add("Frog", "croak");
            animalsDB.Add("Crow", "caw");
            animalsDB.Add("Goat", "bleat");
            animalsDB.Add("Hamster", "squeak");
            animalsDB.Add("Hornet", "buzz");
            animalsDB.Add("Locust", "chirp");
            animalsDB.Add("Mouse", "squeak");
            animalsDB.Add("Owl", "hoot");
            animalsDB.Add("Pigeon", "coo");


            foreach (var val in animalsDB)
            {
                Console.WriteLine(Poem.recitePoem(val.Key, val.Value));
            }

        }



            
            
    }
}
