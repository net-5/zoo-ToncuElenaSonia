using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public class Lion : Animal
    {
        public Lion(string nameOfAnimal, TypeOfFood typeOfFood) : base(nameOfAnimal, typeOfFood)
        {
            
        }
        public void Eat(int quantity)
        {
            Console.WriteLine($"The {NameAnimal} likes to eat {quantity} kilo per day of its {TypeOfFood} favourite food");
        }

    }
}
