using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public class Giraffe:Animal
    {

        public Giraffe(string nameOfAnimal, TypeOfFood typeOfFood) : base(nameOfAnimal, typeOfFood)
        {
           
        }
        public override void Eat()
        {
            Console.WriteLine($"The {NameAnimal} prefer to consume its {TypeOfFood} favourite food what is in the tree.");
        }
    }
}
