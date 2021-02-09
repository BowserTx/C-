using System;

namespace _1038
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao, quantidade;
            double total=0;
            string[] linha = Console.ReadLine().Split(' ');
            opcao = int.Parse(linha[0]);
            quantidade = int.Parse(linha[1]);
            switch (opcao)
            {
                case 1:
                    total = 4.00 * quantidade;
                    break;
                case 2:
                    total = 4.50 * quantidade;
                    break;
                case 3:
                    total = 5.00 * quantidade;
                    break;
                case 4:
                    total = 2.00 * quantidade;
                    break;
                case 5:
                    total = 1.50 * quantidade;
                    break;
            }
            Console.WriteLine("Total: R$ {0:0.00}", total);

        }
    }
}
