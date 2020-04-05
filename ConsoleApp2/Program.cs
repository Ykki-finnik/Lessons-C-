using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a = 33;
                int b = 60;
                byte c = checked((byte)(a + b));
                Console.WriteLine(c);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
