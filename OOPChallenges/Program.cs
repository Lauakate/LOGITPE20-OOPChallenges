using System;

namespace OOPChallenges
{
    class Program
    {
        class Dog
        {
            string name;
            double happiness;
            int spots;

            public Dog(string _name, int _spots)
            {
                name = _name;
                happiness = 0;
                spots = _spots;
                Console.WriteLine($"The dog {name} has been created");
            }

            public void Bark()
            {
                Console.WriteLine($"{name} barks!");

                happiness += 0.2;
            }

            public void Wiggle()
            {
                Console.WriteLine($"{name} wiggles its tail!");
            }

            public double Happiness
            {
                get { return happiness; }
               
            }

            public void Rename(string newName)
            {
                name = newName; 
            }

            public void ShowDogData()
            {
                Console.WriteLine($"Name: {name}; Spots: {spots}; Happiness: {happiness}");
            }
        }
        static void Main(string[] args)
        {
            Dog newDog = new Dog("KogMaw", 10);
            Console.WriteLine($"The level of happiness: {newDog.Happiness}");

            while(newDog.Happiness != 1)
            {
                newDog.Bark();
            }

            Console.WriteLine($"The level of happiness: {newDog.Happiness}");

            newDog.Wiggle();

            Console.WriteLine("Name the dog: ");
            string newDogName = Console.ReadLine();
            newDog.Rename(newDogName);

            newDog.ShowDogData();

           




        }
    }
}
