using BTOAssesment.classLibrary.Domain;
using BTOAssesment.classLibrary.Features.RecitePoem;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solutions.Question1
{
    public class Solution1
    {



        /// <summary>
        ///Data Driven Approach
        ///    Here, the idea is to have a concrete database(Dictionary) with the seeded data to passed to the recitePoem method.
        ///    The implementation of the recitePoem method used here is controlled by the seeded data.
        ///Polymophism Approach
        ///  Here, the idea is to seperate concerns.In the class library,an object structure has been implemented such that a
        ///  base class "Animal" exists,one which encapsulates what it means to be an animal at the very base level.i.e properties like name and sound.
        ///  Inorder to demonstrate polymorphism(runtime), inheriting classes representing different types of animals have been created, e.g Dog, Cat e.t.c.
        ///  The seperation of concerns here is that what it means to be an animal(1st concern) is different from the what it means to recite a poem(2nd concern)
        ///  and thus,this is why everything that concerns reciting a poem is encapsulated in a poem class.
        ///  The way polymorphism works in this implementation is that <see cref="Poem.recitePoem(Animal)"/> under the hood does not know which exact animal to use at
        ///  compile time, rather at runtime inheriting classes passed into the method(the polymorphic nature of animal class) allow the method to display the correct poem per animal.
        /// </summary>
        public static void Run()
        {


            Console.WriteLine("::::::::::::::::::::::::" +
               "Using a data-driven approach" +
               "::::::::::::::::::::::::::::::::::::::::::::::");

            Dictionary<string, string> animalsDB = new Dictionary<string, string>();
            animalsDB.Add("Cow", "moo");
            animalsDB.Add("Dog", "bark");
            animalsDB.Add("Cat", "mew");
            animalsDB.Add("Pig", "oink");
            animalsDB.Add("Duck", "quack");


            foreach (var val in animalsDB)
            {
                Console.WriteLine(Poem.recitePoem(val.Key, val.Value));
            }




            Console.WriteLine("::::::::::::::::::::::::" +
                "Using Polymorphism" +
                "::::::::::::::::::::::::::::::::::::::::::::::");
            Animal dog = new Dog("Dog", "bark");
            Console.WriteLine(Poem.recitePoem(dog));
            Animal cat = new Cat("Cat", "mew");
            Console.WriteLine(Poem.recitePoem(cat));
            Animal cow = new Cow("Cow", "moo");
            Console.WriteLine(Poem.recitePoem(cow));
            Animal pig = new Dog("Pig", "oink");
            Console.WriteLine(Poem.recitePoem(pig));
            Animal duck = new Duck("Duck", "quack");
            Console.WriteLine(Poem.recitePoem(duck));
        }


    }
}
