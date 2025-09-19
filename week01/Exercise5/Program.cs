using System;

class Program
{
    static void Main(string[] args)
    {
        // This show up the body of your program
        wellcome();
        string UserName = AskName();// variable "string UserName" para ocuparla en bloque
        int UserNumber = favnumber();// varia para ocuparla como parametro despues
        int squerdnumber = SquerdNumber(UserNumber);
        //  Esta es la    |  Esta es la |(Esta es la variable anteriormente declarada
        // nueva variable |  funcion    |aqui la ocuparemos como parametro para que 
        //                |             |la funcion "SquerdNumber" la garrarre y la 
        //                |             |supla por su parametro "number"
        DisplayNameAndSquerdNumber(UserName, squerdnumber);
        // "(UserName, UserNumber)" son varibales que antes definomos para ahora 
        // usarlas como paramtros para la funcion que tambien cuenta con parametros.


        // welcome
        static void wellcome()
        {
            Console.WriteLine("Welcome to the program!");
        }
        // ask for a name
        static string AskName()
        {
            Console.Write("Please enter your name: ");
            string username = Console.ReadLine();

            return username;
        }
        // ask favorite number
        static int favnumber()
        {
            Console.Write("Please enter your favorite number: ");
            // Long form
            // string Number = Console.ReadLine();
            // int IntNumber = int.Parse(Number);

            // shortter 
            int IntNumber = int.Parse(Console.ReadLine());

            return IntNumber;
        }

        // squerd number
        static int SquerdNumber(int number) //parametro "number" ayuda en el cuerpo de
        // la funcion a hacer las operaciones
        {
            int squerd = number * number;
            return squerd;
        }

        static void DisplayNameAndSquerdNumber(string name, int square)
        {
            Console.WriteLine($"{name}, the square of your number is {square}");
        }

    }
}