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
            // Ask for first number
            Console.WriteLine("Please enter a first number:");
            int number1 = int.Parse(Console.ReadLine());

            // Ask for second number
            Console.WriteLine("Please enter a second number:");
            int number2 = int.Parse(Console.ReadLine());

            // Ask for operation
            Console.WriteLine("Please enter an operation (+, -, *, /):");
            string operationInput = Console.ReadLine();

            // Convert string input to enum
            Calculator.OperationType operationType;
            
            switch (operationInput)
            {
                case "+":
                    operationType = Calculator.OperationType.Add;
                    break;
                case "-":
                    operationType = Calculator.OperationType.Subtract;
                    break;
                case "*":
                    operationType = Calculator.OperationType.Multiply;
                    break;
                case "/":
                    operationType = Calculator.OperationType.Divide;
                    break;
                default:
                    Console.WriteLine("Invalid operation.");
                    return; // stop program if invalid
            }

            // Create calculator instance
            Calculator calculator = new Calculator("SimpleCalculator");

            // Create request object (data holder)
            CalculationRequest request =
                new CalculationRequest(number1, number2, operationType);

            // Perform calculation
            int result = calculator.Calculate(
                request.A,
                request.B,
                request.Operation
            );

            // Output result
            Console.WriteLine($"Result: {result}");
        }
    }
}
