using System;

struct Student_Record
{
    public string Name { get; }
    public int Age { get; }
    public string Grade { get; }

    public Student_Record(string name, int age, string grade)
    {
        Name = name;
        Age = age;
        Grade = grade;
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter the number of students: ");
        int numberOfStudents = int.Parse(Console.ReadLine()); ;
        

        Student_Record[] students = new Student_Record[numberOfStudents];

        for (int i = 0; i < numberOfStudents; i++)
        {
            Console.WriteLine($"\nEnter details for student {i + 1}:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Grade: ");
            string grade = Console.ReadLine();

            students[i] = new Student_Record(name, age, grade);
        }

        Console.WriteLine("\nStudent Details:");
        
        Console.WriteLine("Name\t\tAge\t\tGrade");
        Console.WriteLine("");

        foreach (var student in students)
        {
            Console.WriteLine($"{student.Name,-6}\t\t{student.Age,3}\t\t{student.Grade,5}\t\t");
        }

        
    }
}
