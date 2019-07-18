using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public class Monkey:Animal
    {
        public Monkey(string nameOfAnimal, TypeOfFood typeOfFood) : base(nameOfAnimal, typeOfFood)
        {
            
        }
        public override void Eat()
        {
            Console.WriteLine($"The {NameAnimal} likes to eat its {TypeOfFood} favourite food.");
        }
        public void Eat(TypeOfFood typeOfFood, int quantity)
        {
            Console.WriteLine($"The {NameAnimal} likes to eat {quantity} kilo per day of its {TypeOfFood} favourite food and somethimes, {NameAnimal} likes to eat {typeOfFood} given by people.");
        }
    }
}
