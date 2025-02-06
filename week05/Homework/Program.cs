using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment;
        string summary;
        MathAssignment mathAssignment;
        string homework;
        WritingAssignment writingAssignment;

        assignment = new Assignment("Alma Barraza", "Fractions");
        summary = assignment.GetSumary();
        Console.WriteLine(summary);
        
        mathAssignment = new MathAssignment("Carlos Lopéz","Fractions","Section 7.3", "Problems 8-19");
        homework = mathAssignment.GetHomeworkList();
        summary = mathAssignment.GetSumary();
        Console.WriteLine($"{summary} {homework}");

        writingAssignment = new WritingAssignment("Sofia Perez", "Mexican History", "Indepence of México");
        homework = writingAssignment.GetWritingInformation();
        summary = writingAssignment.GetSumary();
        Console.WriteLine(summary);
        Console.WriteLine(homework);

        

    }
}