using System;

namespace ObjectOrientation
{
    public class animal
    {
        public void eat()
        {
            Console.WriteLine("Animals are eating");
        }
        public virtual void analyze()
        {
            Console.WriteLine("Analyzing the animal.....");
        }
    }
    public class dog : animal { 
    public void bark()
        {
            Console.WriteLine("Dog is barking");
        }
        public override void analyze()
        {
            Console.WriteLine("Animal is dog");
        }

    
    
    }
    internal class Program
    {
        public int marks { get; set; }
        public string course { get; set; }
        public string name { get; set; }
        public Program(int Marks , String Course , String Name) {
            marks = Marks;
            course = Course;
            name = Name;
        }

        public void Registered()
        {
            
            Console.WriteLine("Student Record is Inserted");
        }
        static void Main(string[] args)
        {
            Program student = new Program(34,".NET" ,"Sirji");
           student.marks = 24;
            student.course = "Mathematics";
            student.name = "kokate Rohit";
            student.Registered();
            Console.WriteLine($"Name: {student.name} Course: {student.course} Marks: {student.marks}");
            dog d = new dog();
            d.analyze();
            Console.ReadLine();

            

        }
    }
}
