using System;

namespace AbstractAndInterfaceDemo
{
    // ===== Bước 1: Lớp trừu tượng Animal =====
    public abstract class Animal
    {
        public abstract string MakeSound();
    }

    public class Tiger : Animal
    {
        public override string MakeSound()
        {
            return "Tiger: roarrrrr!";
        }
    }

    public class Chicken : Animal, IEdible
    {
        public override string MakeSound()
        {
            return "Chicken: cluck-cluck!";
        }

        public string HowToEat()
        {
            return "could be fried";
        }
    }

    // ===== Bước 2: Interface Edible =====
    public interface IEdible
    {
        string HowToEat();
    }

    // ===== Bước 3: Lớp Fruit và các lớp con =====
    public abstract class Fruit : IEdible
    {
        public abstract string HowToEat();
    }

    public class Apple : Fruit
    {
        public override string HowToEat()
        {
            return "Apple could be slided";
        }
    }

    public class Orange : Fruit
    {
        public override string HowToEat()
        {
            return "Orange could be juiced";
        }
    }

    // ===== Chương trình kiểm thử =====
    class Program
    {
        static void Main(string[] args)
        {
            // Kiểm thử Animal
            Animal[] animals = new Animal[2];
            animals[0] = new Tiger();
            animals[1] = new Chicken();

            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal.MakeSound());

                if (animal is IEdible edibleAnimal)
                {
                    Console.WriteLine(edibleAnimal.HowToEat());
                }
            }

            Console.WriteLine(new string('-', 40));

            // Kiểm thử Fruit
            Fruit[] fruits = new Fruit[2];
            fruits[0] = new Orange();
            fruits[1] = new Apple();

            foreach (Fruit fruit in fruits)
            {
                Console.WriteLine(fruit.HowToEat());
            }

            Console.ReadLine();
        }
    }
}
