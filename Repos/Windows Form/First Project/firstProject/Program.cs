using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter your name: ");
        string name = Console.ReadLine();
        Console.WriteLine("Hey Mr. " + name + " Welcome to the league of Legends! \n");

        Console.WriteLine("Enter your age: ");
        // Read the age as a string and then parse it to an integer
        string ageBakri = Console.ReadLine();

        Console.WriteLine("So you are " + ageBakri + " Nice Job buddy");
       
    }
}
