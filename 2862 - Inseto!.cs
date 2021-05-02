using System;

namespace main
{
    class Program
    {
        static void Main(string[] args)
        {
            int cases;

            int vegeta;


            cases = Convert.ToInt32(Console.ReadLine());

            for (; cases > 0; cases--)
            {
                vegeta = Convert.ToInt32(Console.ReadLine());

                if (vegeta > 8000)
                    Console.WriteLine("Mais de 8000!");

                else
                    Console.WriteLine("Inseto!");
            }
        }
    }
}
