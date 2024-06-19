using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    

   
    public class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Animal is eating.");
        }
    }

   
    public class Mammal : Animal
    {
        public void Walk()
        {
            Console.WriteLine("Mammal is walking.");
        }
    }

    // Derived class from Mammal
    public class Dog : Mammal
    {
        public void Bark()
        {
            Console.WriteLine("Dog is barking.");
        }
    }

   

    internal class MultiLevelInheritance
    {
        public static void Display()
        {
            Dog dog = new Dog();
            dog.Eat();  // Method from Animal class
            dog.Walk(); // Method from Mammal class
            dog.Bark(); // Method from Dog class
        }
    }
}
