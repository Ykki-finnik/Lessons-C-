using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator_case
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstValue = 0, secondValue = 0, ExpressionResult = 0;
            string s;
            char action;
            bool result = false;
            while (!result)
            {
                Console.WriteLine("Введите первое число");
                firstValue = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите второе число");
                secondValue = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите действие + - * /");
                result = char.TryParse(Console.ReadLine(), out action);
                if (result)
                {
                    switch (action)
                    {
                        case '+':
                            ExpressionResult = firstValue + secondValue;
                            break;
                        case '-':
                            ExpressionResult = firstValue - secondValue;
                            break;
                        case '*':
                            ExpressionResult = firstValue * secondValue;
                            break;
                        case '/':
                            if (secondValue != 0)
                            {
                                ExpressionResult = firstValue / secondValue;
                            }
                            else
                            {
                                Console.WriteLine("Divide by zero ");
                                ExpressionResult = 0;
                            }
                            break;

                    }

                    Console.WriteLine($"результат выражения {firstValue} {action} {secondValue} : {ExpressionResult}");
                }
                else
                {

                }

            }
        }
    }
}
