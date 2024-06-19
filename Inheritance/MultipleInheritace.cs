using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{



    public interface Flyable
    {
        void Fly();
    }

    public interface Swimmable
    {
        void Swim();
    }


    public class Duck : Flyable, Swimmable
    {
        public void Fly()
        {
            Console.WriteLine("The duck is flying.");
        }

        public void Swim()
        {
            Console.WriteLine("The duck is swimming.");
        }
    }

    internal class MultipleInheritace
    {
        public static void Print()
        {
            Duck duck = new Duck();
            duck.Fly();
            duck.Swim();

            
            Flyable flyable = duck;
            Swimmable swimmable = duck;

            flyable.Fly();
            swimmable.Swim();
        }
    }

}

    