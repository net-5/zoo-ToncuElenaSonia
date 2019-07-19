using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public class Wolf : Animal
    {
        public Wolf(string nameOfAnimal, TypeOfFood typeOfFood) : base(nameOfAnimal, typeOfFood)
        {
        }
        public void Eat(TypeOfFood typeOfFood)
        {
            Console.WriteLine($"The {NameAnimal} likes to eat its {TypeOfFood} favourite food and somethimes it preffers to crunch some {typeOfFood}.");
        }
    }
}
