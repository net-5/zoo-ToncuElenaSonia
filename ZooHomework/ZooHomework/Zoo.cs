using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public class Zoo
    {
        private string zooName;
        private List<Animal> listAnimals = new List<Animal>();
        
        public string ZooName { get { return zooName; } set { zooName = value; } }
        public List<Animal> ListAnimals { get { return listAnimals; } set { listAnimals = value; } }   
        public Zoo(string zooName)
        {
            ZooName = zooName;
        }
        public void AddAnimal(Animal animal)
        {      
            ListAnimals.Add(animal);  
            animal.StateOfAnimal = StateOfAnimal.InZoo;
            Console.WriteLine($"The {animal.NameAnimal} was added to the zoo {ZooName} with the state:{animal.StateOfAnimal}!");
        }
        public void Transfer(Animal animal, Zoo zooDestination)
        {
            Console.WriteLine($"Transfer operation between zoo:\n");
            ListAnimals.Remove(animal);
            zooDestination.ListAnimals.Add(animal);
            animal.StateOfAnimal = StateOfAnimal.Transferred;
            Console.WriteLine($"Animal:{animal.NameAnimal}\nState:{animal.StateOfAnimal}\nFrom:{ZooName}\nTo:{zooDestination.ZooName}\n");
        }

        public void FeedAnimal()
        {
            Console.WriteLine($"\nAt {ZooName} zoo, the animals are daily fed with their favorite food like this:");
            foreach (var item in ListAnimals)
            {
                item.Eat();
            }       
        }
        public void InfoZoo()
        {
            int n = 1;        
            Console.WriteLine($"\nInformation about {ZooName} zoo:");
            Console.WriteLine($"\nNumber of animals :{ListAnimals.Count}");
            Console.WriteLine("List of animals:");
            foreach (var item in ListAnimals)
            {
                item.StateOfAnimal = StateOfAnimal.InZoo;
                Console.WriteLine(n + "." + item.NameAnimal + "->" + "Favourite food: " + item.TypeOfFood + "-> State: " + item.StateOfAnimal);
                n++;
            }
            Console.WriteLine("--------------------------------------------------------------------------------");
        }    
    }
}
