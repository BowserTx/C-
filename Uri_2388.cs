using System;

class URI
{

    static void Main(string[] args)
    {

        int total = 0, caso, t, v;

        caso = Convert.ToInt32(Console.ReadLine());

        for (; caso > 0; caso--)
        {
            string[] linha = Console.ReadLine().Split(' ');
            t = Int32.Parse(linha[0]);
            v = Int32.Parse(linha[1]);

            total += (t * v);
        }

        Console.WriteLine("{0}", total);
    }

}