using System;


namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {

            int cases = Convert.ToInt32(Console.ReadLine());
            int countf = 0, countm = 0;
            for (; cases > 0; cases--)
            {
                string[] linha = Console.ReadLine().Split(' ');

                string nome = (linha[0]);
                string sexo = (linha[1]);

                if (linha[1] == "F")
                {
                    countf++;
                }
                else
                    countm++;


            }

            Console.WriteLine("{0} carrinhos", countm);
            Console.WriteLine("{0} bonecas", countf);
        }
    }
}

