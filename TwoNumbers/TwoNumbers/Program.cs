// TwoNumbers
// Daniel Singletary

using System;

public class TwoNumbers
{
    // Main method begins TwoNumbers application
    public static void Main(string[] args)
    {
        int number1; // declares first integer
        int number2; // declares second integer
        int sum; // declares sum of number1 and number2
        int difference; // declares difference of both numbers
        int product; // declares product of both numbers
        int quotient; // declares quotient of both numbers
        int remainder; // declares remainder of both numbers

        // Ask user and read first number
        Console.Write("Enter first integer: ");
        number1 = Convert.ToInt32(Console.ReadLine());

        // Ask user and read second number
        Console.Write("Enter second integer: ");
        number2 = Convert.ToInt32(Console.ReadLine());

        // Adds blank line for spacing
        Console.WriteLine();

        // Displays two numbers entered
        Console.WriteLine("The two numbers you entered are: {0} and {1}", number1, number2);

        // Calculates and displays the sum of both numbers
        sum = number1 + number2; // adds both numbers
        Console.WriteLine("The sum of the two numbers is {0}", sum);

        // Calculates the difference of the two numbers
        difference = number1 - number2; // subtracts
        Console.WriteLine("The difference of the two numbers is {0}", difference);

        // Calculates the product of the two numbers
        product = number1 * number2; // multiplies
        Console.WriteLine("The product of the two numbers is {0}", product);

        // Calculates the quotient of the two numbers
        quotient = number1 / number2; // divides
        Console.WriteLine("The quotient of the two numbers is {0}", quotient);

        // Calculates the remainder of the two numbers
        remainder = number1 % number2; // finds remainder
        Console.WriteLine("The remainder of the two numbers is {0}", remainder);

        // Adds blank line for spacing
        Console.WriteLine();

        // Finds the larger of the two numbers
        if (number1 == number2)
            Console.WriteLine("The two numbers are equal", number1, number2);
        if (number1 > number2)
            Console.WriteLine("The larger of the two numbers is {0}", number1);
        if (number1 < number2)
            Console.WriteLine("The larger of the two numbers is {0}", number2);

        // Displays line of text to let user know to press any key to end app.
        Console.WriteLine("Please press any key to exit application.");
        Console.ReadLine();

        // Displays sum of two numbers
    } // end Main
} // end class TwoNumbers 

