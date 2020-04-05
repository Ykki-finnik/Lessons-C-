using System;

namespace ConsoleApp1
{
    class Program
    {

        //валюты по отношению к рублю
        private const double D = 77.7;
        private const double Y = 20.5;
        private const double tenge = 10;




        static void Main(string[] args)
        {
            string[] LiberalValues = { "Dollar", "Юань", "tenge" };
            int Currency;
            double rub = 0, val = 0, cur = 0;
            string s1, s2;
            bool result = false;
            Console.WriteLine("Задание третье - конвертер валют");

            Console.WriteLine("Введите сумму в рублях, которую хотите конвертировать");
            while (!result)
            {

                s1 = Console.ReadLine();
                result = double.TryParse(s1, out rub);
                if (!result)
                {
                    Console.WriteLine("еще попытка: ");
                }
                Console.WriteLine("Принято к конвертации рублей: " + rub);
            }
            result = false;
            Console.WriteLine("выберите валюту: \r\n 1) - доллар \r\n 2) Юань \r\n 3) Тугрик \r\n ");
            while (!result)
            {
                s2 = Console.ReadLine();
                result = int.TryParse(s2, out Currency);
                if ((result) && (Currency <= 3 && Currency >= 1))
                {
                    switch (Currency)
                    {
                        case 1:
                            cur = D;
                            break;
                        case 2:
                            cur = Y;
                            break;
                        case 3:
                            cur = tenge;
                            break;
                        default:
                            Console.WriteLine("введите значение от 1 до 3");
                            result = false;
                            break;
                    }


                    Console.WriteLine($"конвертируем в {LiberalValues[Currency - 1]} по курсу {cur}");
                    val = rub / cur;

                }
                else
                {
                    Console.WriteLine("введите число от 1 до 3");
                    result = false;
                }
            }
            Console.WriteLine("Итог: " + val.ToString());
        }
    }
}
