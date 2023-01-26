using System;
class Program
{
    static void Main()
    {
        int numIntegers;
        int totalGames = 0;
        char repeat;
        do
        {
            numIntegers = 0;
            while (numIntegers <= 0)
            {
                Console.WriteLine("Enter the Number of Integers");
                string input = Console.ReadLine();
                if (!int.TryParse(input, out numIntegers) || numIntegers <= 0)
                {
                    Console.WriteLine("Enter a Number greater than Zero");
                }
            }
            int[] integers = new int[numIntegers];
            for (int i = 0; i < numIntegers; i++)
            {
                Console.WriteLine("Enter a number {0}:", i + 1);
                while (!int.TryParse(Console.ReadLine(), out integers[i]))
                {
                    Console.WriteLine("Enete a valid Number");
                }
            }
            int max = int.MinValue;
            int min = int.MaxValue;
            int sum = 0;
            int sum1 = 0;
            int oddcount = 0;
            for (int i = 0; i < numIntegers; i++)
            {
                if (integers[i] > max)
                {
                    max = integers[i];
                }
                if (integers[i] < min)
                {
                    min = integers[i];
                }
                //if (integers[i] % 2 != 0)
                //{
                //    sum += integers[i];
                //    oddcount++;
                //}
                sum1 = sum1 + integers[i];
            }
            double average = (double)sum1 / numIntegers;

            Console.WriteLine("Maximum value: {0}", max);
            Console.WriteLine("Minimum value: {0}", min);
            Console.WriteLine("Sum of Numbers Entered: {0}", sum1);
            Console.WriteLine("Average value of odd Integers: {0}", average);

            totalGames++;
            Console.WriteLine("Do You Want to play again? Y/N");
            repeat = Console.ReadKey().KeyChar;
            Console.WriteLine();
        }
        while (repeat == 'Y' || repeat == 'y');

        Console.WriteLine("Total numbers of times Played: {0}", totalGames);
    }
}