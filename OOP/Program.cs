using System;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pig myPig = new Pig(); // Create a Pig object
            myPig.sleep();  // Call the regular method
            myPig.animalSound("sound");  // Call the abstract method
            Dog dog = new Dog();
            dog.animalSound("string");
        }
    }

    // Abstract class
    abstract class Animal
    {
        // Abstract method (does not have a body) a contract
        public abstract void animalSound(string str);
        // Regular method
        public void sleep()
        {
            Console.WriteLine("Zzzzz...");
        }
    }

    // Derived class (inherit from Animal)
    class Pig : Animal
    {
        //Method overriding
        public override void animalSound(string str)
        {
            // The body of animalSound() is provided here
            Console.WriteLine("The pig says: wee wee");
        }


        public void Grunt(string grunt)
        {
            Console.WriteLine($"The pig is {grunt}");
        }
        //Method Overloading
        public string Grunt(string grunt, int times)
        {
            Console.WriteLine($"The pig {grunt} {times} times");
            return "";
        }
    }
    class Dog : Animal
    {
        //Method overriding
        public override void animalSound(string str)
        {
            Console.WriteLine("Bark...");
        }
    }
}
