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

            Console.WriteLine("Please type +, -, /, *, or ^2 of your preference");
            var key = Console.ReadLine();
            Console.WriteLine("Then type your numbers you want to calculate like 1,2,3");
            var calculate = Console.ReadLine();

            switch (key)
            {
                case "+":
                    var sum = 0;
                    var numbers = calculate.Split(',');
                    for (var i = 0; i < numbers.Length; i++)
                    {
                        sum += int.Parse(numbers[i]);
                    }
                    Console.WriteLine(sum);
                    break;
                case "-":  
                    var subtractNum = calculate.Split(',');
                    int subtract = int.Parse(subtractNum[0]);
                    for (var i = 1; i < subtractNum.Length; i++)
                    {
                        subtract -= int.Parse(subtractNum[i]);
                    }
                    Console.WriteLine(subtract);
                    break;
                case "^2":
                    var square = "";
                    var squareNumber = calculate.Split(',');
                    for (var i = 0; i < squareNumber.Length; i++)
                    {
                        square += int.Parse(squareNumber[i]) * int.Parse(squareNumber[i]);
                        square += ',';
                    }
                    Console.WriteLine(square.TrimEnd(','));
                    break;
                case "/":
                    var divideNum = calculate.Split(',');
                    int divide = int.Parse(divideNum[0]);
                    for (var i = 1; i < divideNum.Length; i++)
                    {
                        divide /= int.Parse(divideNum[i]);
                    }
                    Console.WriteLine(divide);
                    break;
                case "*":
                    var multiNum = calculate.Split(',');
                    var multi = int.Parse(multiNum[0]);
                    for (var i = 1; i < multiNum.Length; i++)
                    {
                        multi *= int.Parse(multiNum[i]);
                    }
                    Console.WriteLine(multi);
                    break;
                default:
                    Console.WriteLine("invalid");
                    break;
            }
            





        }
    }
}
