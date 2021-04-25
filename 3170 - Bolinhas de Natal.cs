using System;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            int galhos;
            long bolinhas, quantfalta;

            bolinhas = Convert.ToInt32(Console.ReadLine());
            galhos = Convert.ToInt32(Console.ReadLine());

            quantfalta = galhos / 2;

            if(quantfalta <= bolinhas)
                Console.WriteLine("Amelia tem todas bolinhas!");
            else
                Console.WriteLine("Faltam {0} bolinha(s)", quantfalta - bolinhas);
                 
        }
    }
}
