using System;
using System.Text;

// Індексатори.

class Program
{
    static void Main()
    {
        Dictionary dictionary = new Dictionary();

        Console.WriteLine(dictionary["книга"]);
        Console.WriteLine(dictionary["дім"]);
        Console.WriteLine(dictionary["ручка"]);
        Console.WriteLine(dictionary["стол"]);
        Console.WriteLine(dictionary["олівець"]);
        Console.WriteLine(dictionary["яблуко"]);
        Console.WriteLine(dictionary["сонце"]);

        Console.WriteLine(new string('-', 20));

        for (int i = 0; i < 6; i++)
        {
            Console.WriteLine(dictionary[i]);
        }
                        
        // Delay.
        Console.ReadKey();
    }
}