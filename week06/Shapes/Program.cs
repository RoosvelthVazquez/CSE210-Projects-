using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new  List<Shape>();

        Square cuadrado = new Square(5, "blue");
        shapes.Add(cuadrado);

        Rectangle rectangulo = new Rectangle(8, 5, "black");
        shapes.Add(rectangulo);

        Circle circulo = new Circle(5.7, "yellow");
        shapes.Add(circulo);

        foreach (Shape i in shapes)
        {
            string color = i.GetColor();

            double area = i.GetArea();

            Console.WriteLine($"The {color} has an area of a {area:f2}");
        }
    }
}