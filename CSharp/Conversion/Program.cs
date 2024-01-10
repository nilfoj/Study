using System;

namespace App
{
    class Conversion
    {
        static void Main(string[] args)
        {
            int pvalor = 1;
            float svalor = 2.1f;

            //pvalor = svalor;
            //svalor = (int)pvalor;

            //string tvalor = pvalor.ToString();
            //svalor = int.Parse(tvalor);

            svalor = Convert.ToInt32(pvalor);

            Console.WriteLine(svalor);
            
        }
    }
}

