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
                    var mul = 1;
                    for (var i = 0; i < numbers.Length; i++)
                    {
                        mul *= int.Parse(numbers[i]);
                    }
                    Console.WriteLine(mul);
                    break;
                case "square":
                    var squareNum = line.Split(',');
                    var squ = "";
                    for (var i = 0; i < squareNum.Length; i++)
                    {
                        squ += int.Parse(squareNum[i]) * int.Parse(squareNum[i]);
                        squ += ',';
                    }
                    Console.WriteLine(squ.TrimEnd(','));
                    break;
                default:
                    Console.WriteLine("Invalid");
                    break;
            }

            Console.WriteLine("Please indicate me how you would like to use this calculator");
            var indication = Console.ReadLine();
            Console.WriteLine(indication);
        


        }
    }
}
