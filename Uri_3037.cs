using System;

namespace _3037
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, d, joao=0, maria=0, cases;

            cases = Convert.ToInt32(Console.ReadLine());

            for(; cases > 0; cases--)
            {
                string[] linha = Console.ReadLine().Split(' ');
                x = Int32.Parse(linha[0]);
                d = Int32.Parse(linha[1]);

                joao = (x * d) + joao;

                string[] linha1 = Console.ReadLine().Split(' ');
                x = Int32.Parse(linha1[0]);
                d = Int32.Parse(linha1[1]);

                joao = (x * d) + joao;

                string[] linha2 = Console.ReadLine().Split(' ');
                x = Int32.Parse(linha2[0]);
                d = Int32.Parse(linha2[1]);

                joao = (x * d) + joao;

                string[] linha3 = Console.ReadLine().Split(' ');
                x = Int32.Parse(linha3[0]);
                d = Int32.Parse(linha3[1]);

                maria = (x * d) + maria;

                string[] linha4 = Console.ReadLine().Split(' ');
                x = Int32.Parse(linha4[0]);
                d = Int32.Parse(linha4[1]);

                maria = (x * d) + maria;

                string[] linha5 = Console.ReadLine().Split(' ');
                x = Int32.Parse(linha5[0]);
                d = Int32.Parse(linha5[1]);

                maria = (x * d) + maria;


                if(maria > joao)
                    Console.WriteLine("MARIA");

                else
                    Console.WriteLine("JOAO");

                joao = 0;
                maria = 0;
            }
        }
    }
}
