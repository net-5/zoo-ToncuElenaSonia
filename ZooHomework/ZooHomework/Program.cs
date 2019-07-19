using System;

namespace Zoo
{
    class Program
    {
        //Model a ZOO keeping in mind that:
        //•	A zoo has a name and a list of animals
        //•	At a zoo they can bring new animals and transfer animals to new zoos
        //•	At a zoo the animals are daily fed with their favorite food, and each animal eats what it loves to eat.
        //•	Each animal knows to eat by itself, and not all animals of the same type prefer the same type of food. 
        //Eg; a horse prefers carrots, and another horse prefers apples

        static void Main(string[] args)
        {
            Zoo newZoo = new Zoo("Sibiu");
            Zoo newZoo1 = new Zoo("Chisinau");
            Bear newBear = new Bear("bear1", TypeOfFood.Honey);
            Bear newBear1 = new Bear("bear2", TypeOfFood.Meat);
            Giraffe newGiraffe = new Giraffe("giraffe", TypeOfFood.Leaf);
            Lion newLion = new Lion("lion",TypeOfFood.Meat);          
            Monkey newMonkey = new Monkey("chimpanzee",TypeOfFood.Banana);
            Monkey newMonkey1 = new Monkey("chimpanzee1", TypeOfFood.Nuts);
            Monkey newMonkey2 = new Monkey("chimpanzee2", TypeOfFood.Carrot);
            Wolf newWolf = new Wolf("wolf", TypeOfFood.Meat);
            Wolf newWolf1 = new Wolf("wolf1", TypeOfFood.Meat);
            Wolf newWolf2 = new Wolf("wolf2", TypeOfFood.Meat);

            //List of animals from zoo Sibiu
            newZoo.AddAnimal(newLion);
            newZoo.AddAnimal(newBear);
            newZoo.AddAnimal(newBear1);
            newZoo.AddAnimal(newMonkey);
            newZoo.AddAnimal(newMonkey1);
            newZoo.AddAnimal(newGiraffe);
            newZoo.AddAnimal(newMonkey2);
            Console.WriteLine("--------------------------------------------------------------------------------");
            newZoo1.AddAnimal(newWolf);
            newZoo1.AddAnimal(newWolf1);
            newZoo1.AddAnimal(newWolf2);
            Console.WriteLine("--------------------------------------------------------------------------------");
            newZoo.InfoZoo();
            //List of animals from zoo Chisinau
            newZoo1.InfoZoo();
            //transfer from Sibiu zoo
            newZoo.Transfer(newLion, newZoo1);
            newZoo.Transfer(newBear, newZoo1);
            newZoo.Transfer(newMonkey, newZoo1);
            Console.WriteLine("--------------------------------------------------------------------------------");
            newZoo.InfoZoo();
            //transfer from Chisinau zoo
            newZoo1.Transfer(newWolf, newZoo);
            newZoo1.InfoZoo();
            //daily fed animals
            newZoo.FeedAnimal();
            Console.WriteLine("--------------------------------------------------------------------------------");
            //each animal eats what it loves to eat.
            Console.WriteLine("\nEach animal eats what it loves, as follows:");
            newBear.Eat();
            newBear1.Eat();
            newGiraffe.Eat();
            newLion.Eat(12);
            newMonkey.Eat(TypeOfFood.Cookies, 5);
            newMonkey2.Eat(TypeOfFood.Cookies, 2);
            newWolf.Eat(TypeOfFood.Bones);
            Console.WriteLine("--------------------------------------------------------------------------------");
            //not all animals of the same type prefer the same type of food
            Console.WriteLine("\nNot all animals of the same type prefer the same type of food:");
            newBear.Eat();
            newBear1.Eat();
            newMonkey.Eat();
            newMonkey1.Eat();
            newMonkey2.Eat();






        }
    }
}
