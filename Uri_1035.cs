using System;

namespace _1035
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=0, b=0, c=0, d=0;
            string[] linha1 = Console.ReadLine().Split(' ');
            a = int.Parse(linha1[0]);
            b = int.Parse(linha1[1]);
            c = int.Parse(linha1[2]);
            d = int.Parse(linha1[3]);
            if ((b > c) && (d > a) && ((c + d) > (a + b)) && (c > 0) && (d > 0) && (a % 2 == 0))
                Console.WriteLine("Valores aceitos");
            else
                Console.WriteLine("Valores nao aceitos");
        }
    }
}
