using System;
using System.Globalization;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            raio = 2 * 3.14 * raio;

            Console.WriteLine("" + raio.ToString("F2", CultureInfo.InvariantCulture));
                
            

        }
    }
}

