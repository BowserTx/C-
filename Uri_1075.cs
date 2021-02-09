using System;

class URI
{

    static void Main(string[] args)
    {
        int mod, i, n;

        n = Convert.ToInt32(Console.ReadLine());

        for (i = 0; i < 10000; i++)
        {
            mod = i % n;

            if (mod == 2)

                Console.WriteLine("{0}", i);
        }

    }

}