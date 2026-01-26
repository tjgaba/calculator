// See https://aka.ms/new-console-template for more info
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;  


namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Welcome to the Calculator App!");
            Console.WriteLine("Please enter a first number:");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a second number:");
            int number2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter an operation (+, -, *, /):");
            string operation = Console.ReadLine();*/
            /*
            if (operation == "+")
            {
                Console.WriteLine($"The sum of {number1} and {number2} is: {number1 + number2}");
            }
            else if (operation == "-")
            {
                Console.WriteLine($"The difference of {number1} and {number2} is: {number1 - number2}");
            }
            else if (operation == "*")
            {
                Console.WriteLine($"The product of {number1} and {number2} is: {number1 * number2}");
            }
            else if (operation == "/")
            {
                Console.WriteLine($"The quotient of {number1} and {number2} is: {number1 / number2}");
            }
            else
            {
                Console.WriteLine("Invalid operation.");
            }*/

            Console.WriteLine("Please enter a first number:");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a second number:");
            int number2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter an operation (+, -, *, /):");
            string operation = Console.ReadLine();


            //int request = new CalculationRequest(number1, number2, Calculator.OperationType.Add);
            
            Calculator calculator = new Calculator("SimpleCalculator");
            CalculationRequest request = new CalculationRequest(number1, number2, Calculator.OperationType.Add);
            int result = calculator.Calculate(request.A, request.B, request.Operation);



         switch (operation)
            {
                case "+":
                    Console.WriteLine(Calculator.Calculate(number1, number2, Calculator.OperationType.Add));
                    break;
                case "-":
                    Console.WriteLine(Calculator.Calculate(number1, number2, Calculator.OperationType.Subtract));
                    break;
                case "*":
                    Console.WriteLine(Calculator.Calculate(number1, number2, Calculator.OperationType.Multiply));
                    break;
                case "/":
                    try
                    {
                        Console.WriteLine(Calculator.Calculate(number1, number2, Calculator.OperationType.Divide));
                    }
                    catch (DivideByZeroException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operation.");
                    break;
            }
           /* switch (operation)
            {
                case "+":
                    Console.WriteLine(Calculator.Add(number1, number2));
                    break;
                case "-":
                    Console.WriteLine(Calculator.Subtract(number1, number2));
                    break;
                case "*":
                    Console.WriteLine(Calculator.Multiply(number1, number2));
                    break;
                case "/":
                    try
                    {
                        Console.WriteLine(Calculator.Divide(number1, number2));
                    }
                    catch (DivideByZeroException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operation.");
                    break;
            }*/

            

        }
    }
}
