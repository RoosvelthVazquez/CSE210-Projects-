using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment A1 = new Assignment("Roos", "Algebra");
        Console.WriteLine(A1.GetSummary());
        Console.WriteLine();

        MathAssignment A2 = new MathAssignment("Alejandro", "Calculo", "Calculo II", "Problema 2 y 3");
        Console.WriteLine(A2.GetSummary());
        Console.WriteLine(A2.GetHomeworkList());
        Console.WriteLine();

        WritingAssignment A3 = new WritingAssignment("Johani", "Español", "Compresion Lectora");
        Console.WriteLine(A3.GetSummary());
        Console.WriteLine(A3.GetWritingInformation());
    }
}