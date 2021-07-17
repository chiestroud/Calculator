using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Would you like to multiply or square?");
            var answer = Console.ReadLine();
            Console.WriteLine("Input number as 1,2,3");
            var line = Console.ReadLine();
            switch (answer.ToLower())
            {
                case "multiply":
                    var numbers = line.Split(',');
                    Console.WriteLine(int.Parse(numbers[0]) * int.Parse(numbers[1]) * int.Parse(numbers[2]));
                    break;
                case "square":
                    var squareNum = line.Split(',');
                    Console.WriteLine(int.Parse(squareNum[0]) * int.Parse(squareNum[0]) + "," + int.Parse(squareNum[1]) * int.Parse(squareNum[1]) + "," + int.Parse(squareNum[2]) * int.Parse(squareNum[2]));
                    break;
                default:
                    Console.WriteLine("Invalid");
                    break;
            }
           

        }
    }
}
