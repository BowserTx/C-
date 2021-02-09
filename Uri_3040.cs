using System;

namespace _3040
{
    class Program
    {
        static void Main(string[] args)
        {
            int h, d, g, cases;

            cases = Convert.ToInt32(Console.ReadLine());

            for(; cases > 0; cases--)
            {
                string[] linha = Console.ReadLine().Split(' ');
                h = Int32.Parse(linha[0]);
                d = Int32.Parse(linha[1]);
                g = Int32.Parse(linha[2]);

                if (h >= 200 && h <= 300 && d >= 50 && g >= 150)
                    Console.WriteLine("Sim");

                else
                    Console.WriteLine("Nao");
            }
        }
    }
}
