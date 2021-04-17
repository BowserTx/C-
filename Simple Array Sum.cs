


/*using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Simple_Array_Sum
{
    class Program
    {
        /*
      * Complete the simpleArraySum function below.
      
        static int simpleArraySum(int[] ar)
        {
            int sum = 0;
            for (int i = 0; i < ar.Length; i++)
            {
                sum += ar[i];
            }

            return sum;
        }

        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int arCount = Convert.ToInt32(Console.ReadLine());

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
            ;
            int result = simpleArraySum(ar);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}*/


using System;

namespace Simple_Array_Sum
{

    class Program
    {

        static void Main(string[] args)
        {
            int tam = 0;
            

            tam = Convert.ToInt32(Console.ReadLine());
            int sum = 0;


            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));

            for (int i = 0; i < tam; i++)
            {




                sum = sum + a[i];

            }

            Console.WriteLine(sum);

        }
    }

}
    
