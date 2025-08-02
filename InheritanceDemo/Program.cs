using System;

// Base class
class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Some generic sound");
    }
}

// Derived class Dog
class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Bark");
    }
}

// Derived class Cat
class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Meow");
    }
}

class Program
{
    static void Main()
    {
        Animal generic = new Animal();
        Dog dog = new Dog();
        Cat cat = new Cat();

        Console.Write("An animal says: ");
        generic.MakeSound(); 
      

        Console.Write("Dog says: ");
        dog.MakeSound();    

        Console.Write("Cat says: ");
        cat.MakeSound();      
    }
}
