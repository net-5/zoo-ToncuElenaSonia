using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public enum TypeOfFood { Meat, Leaf, Apple, Honey, Banana, Carrot, Nuts }
    public enum StateOfAnimal { InZoo, ProposedToTransfer}
    public abstract class Animal
    {
        private string nameAnimal;
        private TypeOfFood typeOfFood;
        private StateOfAnimal stateOFAnimal;
        public string NameAnimal
        {
            get { return nameAnimal; }
            set { nameAnimal = value; }
        }
        public TypeOfFood TypeOfFood
        {
            get
            {
                return typeOfFood;
            }
            set
            {
                typeOfFood = value;
            }
        }
        public StateOfAnimal StateOfAnimal { get; set; }
        public Animal(string nameOfAnimal, TypeOfFood typeOfFood)
        {
            NameAnimal = nameOfAnimal;
            TypeOfFood = typeOfFood;         
        }
        public virtual void Eat()
        {
            Console.WriteLine($"The {NameAnimal} loves to eat its {TypeOfFood} favourite food.");
        }

    }
}
