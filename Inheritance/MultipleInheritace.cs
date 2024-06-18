using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{



    public interface IFlyable
    {
        void Fly();
    }

    public interface ISwimmable
    {
        void Swim();
    }


    public class Duck : IFlyable, ISwimmable
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

            // Using interface references
            IFlyable flyable = duck;
            ISwimmable swimmable = duck;

            flyable.Fly();
            swimmable.Swim();
        }
    }

}

    