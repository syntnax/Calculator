using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class program {
    static void
          Main(string[] args)
    {
        Console.Title = " My C# Calculator";
        Console.ForegroundColor = ConsoleColor.Green;
        int num1;
        int num2;
        int result; 
        string operations;
        Console.WriteLine("Enter the first number");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the Second number");
        num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the operations (+,-,*,/)");
        operations = Console.ReadLine();

        switch (operations)
        {
            case ("+"):
                result = num1 + num2;
                Console.WriteLine("The answer is " + result);
                break;
        }
        switch (operations)
        {
            case ("-"):
                result = num1 - num2;
                Console.WriteLine("The answer is " + result);
                break;
        }
        switch (operations)
        {
            case ("*"):
                result = num1 * num2;
                Console.WriteLine("The answer is " + result);
                break;
        }
        switch (operations)
        {
            case ("/"):
                result = num1 / num2;
                Console.WriteLine("The answer is " + result);
                break;
        }
        Console.ReadKey();
    }
    
}