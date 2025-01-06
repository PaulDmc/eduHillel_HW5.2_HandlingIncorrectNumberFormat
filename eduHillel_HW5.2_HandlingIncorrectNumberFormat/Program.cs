using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace Hillel_HW51_Demchenko
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            int firstNumber;
            int secondNumber;
            int resultOperation = 0;
            char operation;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Enter the first number:");
                firstNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the second number:");
                secondNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the operation:");
                operation = Convert.ToChar(Console.ReadLine());

                try
                {
                    switch (operation)
                    {
                        case '+':
                            resultOperation = firstNumber + secondNumber;
                            break;
                        case '-':
                            resultOperation = firstNumber - secondNumber;
                            break;
                        case '*':
                            resultOperation = firstNumber * secondNumber;
                            break;
                        case '/':
                            if (firstNumber == 0 || secondNumber == 0)
                            {
                                throw new DivideByZeroException();
                            }
                            resultOperation = firstNumber / secondNumber;
                            break;
                        default:
                            Console.WriteLine("Invalid operation");
                            break;
                    }
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Division by zero is not allowed");
                    Console.WriteLine("Press any key to continue or close the console");
                    Console.ReadKey();
                    continue;
                }
                Console.WriteLine($"Result: {resultOperation}");
                Console.WriteLine("Press any key to continue or close the console");
                Console.ReadKey();


            }

        }

    }
}