using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            ////5 != 5 * 4 * 3 * 2 * 1; 1-ci elemani=1

            //Console.WriteLine("Xahis olunur bir reqem girin:");
            //int sayi=Convert.ToInt32(Console.ReadLine());
            //int faktoryel = 1;

            //for (int i = 1; i <= sayi; i++)
            //{
            //    faktoryel = faktoryel * i;
            //}

            //1-100 arasi sade ededleri gosterin
            bool bolunur=false;

            for (int i = 2; i < 100; i++)
            {
                for (   int j = 2; j < i; j++)
                {
                    if (i%j==0)
                    {
                        bolunur = true;
                    }
                }
                if (bolunur==false)
                {
                    Console.WriteLine("{0} ededi sade ededdir",i);
                }
            }

        }
    }
}
