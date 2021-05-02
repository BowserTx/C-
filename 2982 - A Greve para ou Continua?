using System;

namespace main
{
    class Program
    {
        static void Main(string[] args)
        {
            int dinheiro, cases, governo=0, verba=0;
            string gv;


            cases = Convert.ToInt32(Console.ReadLine());

            for(; cases>0; cases--)
            {
                string[] linha = Console.ReadLine().Split(' ');

                gv = (linha[0]);
                dinheiro = int.Parse(linha[1]);


                if (gv == "G")
                    governo = governo + dinheiro;
                else
                    verba = verba + dinheiro;
            }

            dinheiro = governo - verba;

            if (dinheiro <= 0)
                Console.WriteLine("A greve vai parar.");
            else
                Console.WriteLine("NAO VAI TER CORTE, VAI TER LUTA!");


           
        }
    }
}
