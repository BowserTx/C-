using System;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {

            int a, media;

            a = Convert.ToInt32(Console.ReadLine());
            media = Convert.ToInt32(Console.ReadLine());


            a = (media * 2) - a;

            Console.WriteLine("{0}", a);

        }
    }
}
