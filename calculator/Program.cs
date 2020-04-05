using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //3 строки для чтения данных из консоли
            string firstValue, secondValue, MyOperator;
            char repeat;
            // 2 числа для операндов
            char MyOp;
            string action;
            double op1 = 0, op2 = 0, sum;
            bool result = false;
            while (!result)
            {
                //получаем первый операнд
                Console.WriteLine("Введите первое число");
                while (!result)
                {
                    firstValue = Console.ReadLine();
                    result = double.TryParse(firstValue, out op1);
                    if (!result)
                    {
                        Console.WriteLine("Введите верное число!");
                    }
                }
                result = false;
                //получаем второй операнд
                while (!result)
                {
                    Console.WriteLine("Введите второе число");
                    secondValue = Console.ReadLine();
                    result = double.TryParse(secondValue, out op2);
                    if (!result)
                    {
                        Console.WriteLine("Введите верное число!");
                    }
                }
                result = false;
                //получаем оператор 
                while (!result)
                {
                    Console.WriteLine("Введите действие: ");
                    MyOperator = Console.ReadLine();
                    result = char.TryParse(MyOperator, out MyOp);
                    if (!result)
                    {
                        Console.WriteLine("Введите +, -, / или *");
                    }
                    else
                    {
                        if (MyOp == '+')
                        {
                            action = $"складываем {op1} и {op2}";
                            sum = op1 + op2;
                            Console.WriteLine($"{action} Получаем {sum}");
                        }
                        else if (MyOp == '-')
                        {
                            action = $"вычитаем {op2} из {op1}";
                            sum = op1 - op2;
                            Console.WriteLine($"{action} Получаем {sum}");
                        }
                        else if (MyOp == '*')
                        {
                            action = $"умножаем {op1} на {op2}";
                            sum = op1 * op2;
                            Console.WriteLine($"{action} Получаем {sum}");
                        }
                        else if (MyOp == '/')
                        {
                            if (op2 != 0)
                            {
                                action = $"делим {op1} на {op2}";
                                sum = op1 / op2;
                                Console.WriteLine($"{action} Получаем {sum}");
                            }
                            else
                            {
                                action = "на ноль делить нельзя!";
                                sum = 0;
                                Console.WriteLine($"{action}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Введите +, -, / или *");
                            result = false;

                        }
                    }
                }

                //запрашиваем повтор
                Console.WriteLine("повторить? Y/N");
                repeat = (char)Console.Read();
                //char.TryParse
                if (repeat == 'y' || repeat == 'Y')
                { result = false; }
                else result = true;
            }



        }
    }
}
