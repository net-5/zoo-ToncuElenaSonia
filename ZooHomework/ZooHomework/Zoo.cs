using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public class Zoo
    {
        private string zooName;
        private List<Animal> listAnimals = new List<Animal>();
        private List<Animal> listTransfers = new List<Animal>();
        
        public string ZooName { get { return zooName; } set { zooName = value; } }
        public List<Animal> ListAnimals { get { return listAnimals; } set { listAnimals = value; } }   
        public List<Animal> ListTransfers { get { return listTransfers; } set { listTransfers = value; } }
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
        public void ProposedToTransfer(Animal animal)
        {
            ListAnimals.Remove(animal);
            ListTransfers.Add(animal);
            animal.StateOfAnimal = StateOfAnimal.ProposedToTransfer;
        }
        public void PerformTransfer(Animal animal,Zoo zooDestination)
        {
                zooDestination.ListAnimals.Add(animal);
                ListTransfers.Remove(animal);
                animal.StateOfAnimal = StateOfAnimal.InZoo;      
                Console.WriteLine($"The {animal.NameAnimal} was transfered from {ZooName} zoo to {zooDestination.ZooName} zoo and his state is chaged to {animal.StateOfAnimal}!");
                Console.WriteLine("--------------------------------------------------------------------------------");
        }
        public void TransferInfo()
        {
            int q = 1;
            Console.WriteLine();
            Console.WriteLine($"\nNumber of animals proposed to transfer from {ZooName}: {ListTransfers.Count} ");
            Console.WriteLine($"Animals proposed to be transferred:");
            foreach (var item in ListTransfers)
            {
                Console.WriteLine(q + "." + item.NameAnimal + "->" + "Favourite food: " + item.TypeOfFood + "-> State: " + item.StateOfAnimal);
                q++;
            }
            Console.WriteLine("--------------------------------------------------------------------------------");
        }
        public void FeedAnimal()
        {
            Console.WriteLine($"\nAt {ZooName} zoo, the animals are daily fed with their favorite food like this:");
            foreach (var item in ListAnimals)
            {
                Console.WriteLine($"The {item.NameAnimal} is daily fed with its favourite {item.TypeOfFood}.");
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
                Console.WriteLine(n + "." + item.NameAnimal + "->" + "Favourite food: " + item.TypeOfFood + "-> State: " + item.StateOfAnimal);
                n++;
            }
            Console.WriteLine("--------------------------------------------------------------------------------");
        }    
    }
}
