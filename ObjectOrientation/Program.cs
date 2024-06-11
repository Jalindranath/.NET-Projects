using System;

namespace ObjectOrientation
{
    public class animal
    {
        public virtual void voice()
        {
            Console.WriteLine("Analyzing the Voice");
        }
    }

    public class dog : animal {
        public override void voice()
        {
            Console.WriteLine("Voice is of Barking");
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
            d.voice();
            Console.ReadLine();

            

        }
    }
}
