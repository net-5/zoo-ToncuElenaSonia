using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public class Bear:Animal
    {     
        public Bear(string nameOfAnimal,TypeOfFood typeOfFood) : base(nameOfAnimal,typeOfFood)
        {
           
        } 
        public override void Eat()
        {
            Console.WriteLine($"The {NameAnimal} may eat a lot of its {TypeOfFood} favourite food.");
        }
 
    }
}
