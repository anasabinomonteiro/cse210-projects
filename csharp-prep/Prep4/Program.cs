using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep4 World!");
        List<int> numbers = new List<int>();

        int userNumber = -1;
        while (userNumber != 0)
        {
            Console.Write(" Please, enter a number (enter 0 to quit): ");
            
            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);

            // Only add if the number is not 0
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        //Compute the sum
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"the sum is: {sum}.");        
      
        // Compute the average

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}.");

        // Find max

        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number> max)
            {
                //if the number is greather than max, max is found
                max = number;
            }
        }

        Console.WriteLine($"The max is {max}.");
    }       
}
