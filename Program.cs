using System;

namespace _9994086_task2_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Start the program with Clear();
            Console.Clear();
            
            // Explain program to user
            var lineBreak = "-------------------------------------------";
            Console.WriteLine("This program asks you for a set of ten number then calculates the average.");
            Console.WriteLine($"\n{lineBreak}\n");

            // Get input from user, check for bad input and ask again if it is bad
            var input = "";
            var nums = new double[10];
            var isNumber = true;
            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine($"Please enter number {i + 1}:");
                do
                {
                    input = Console.ReadLine();
                    isNumber = double.TryParse(input, out nums[i]);
                    if (!isNumber)
                    {
                        Console.WriteLine("Invalid input. Try again:");
                    }
                } while (!isNumber);
            }

            // Calculate average
            var sum = 0.0;
            for (var i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            var average = sum / nums.Length;
            
            // Output to user
            var numberString = string.Join(", ", nums);
            Console.WriteLine($"\n{lineBreak}\n");
            Console.WriteLine($"You numbers were: {numberString}");
            Console.WriteLine($"\nThe average of these numbers is: {average}");

            //End the program with blank line and instructions
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Press <Enter> to quit the program");
            Console.ReadKey();
        }
    }
}
