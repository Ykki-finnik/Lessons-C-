using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cycle
{
    class Program
    {
        static void Main(string[] args)
        {
            //СУММА И КОЛИЧЕСТВО ЧЕТНЫХ И НЕЧЕТНЫХ ЧИСЕЛ В ДИАПАЗОНЕ
            // числа целые, возможно отрицательные
            int firstValue = 0, secondValue = 0, sumOdd=0, sumEven=0, numOdd=0, numEven=0;
                Console.WriteLine("Введите начало диапазона");
                firstValue = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите конец диапазона");
                secondValue = int.Parse(Console.ReadLine());
                if (firstValue > secondValue)
                { firstValue = firstValue + secondValue - (secondValue = firstValue); }
                ;
            for (int counter = firstValue; counter <= secondValue; counter++)
                {
                // Нечетное число
                    if (counter % 2 == 1)
                    {
                        numEven++;
                        sumEven += counter;
                    }
                    else
                    // четное число
                    {
                        numOdd++;
                        sumOdd += counter;
                    }
                
            }
            Console.WriteLine($"количество четных чисел: {numOdd}, их сумма: {sumOdd}");
            Console.WriteLine($"количество Нечетных чисел: {numEven}, их сумма: {sumEven}");
           

        }
    }
}
