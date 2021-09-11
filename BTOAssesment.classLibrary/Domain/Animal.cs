using System;
using System.Collections.Generic;
using System.Text;

namespace BTOAssesment.classLibrary.Domain
{
    public  class Animal
    {
        public string animalName { get; protected set; }
        public string animalSound { get; protected set; }


        public Animal(string name,string sound)
        {
            animalName = name;
            animalSound = sound;
        }

       
    }
}
