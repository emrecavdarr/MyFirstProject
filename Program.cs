using System;
using System.Globalization;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Döngüler: break - continue

            // string name = "Sadık Turan";

            // for (int i = 0; i < name.Length; i++)
            // {
            //     if (name[i] == 'd')
            //         continue;
            //     Console.WriteLine(name[i]);
            // }

            // Console.WriteLine("döngü dışı");

            // int x = 0;
            // while (x<5)
            // {
            //     x++;
            //     if (x==2)
            //         continue;
            //     Console.WriteLine(x);               
            // }

            // Console.WriteLine("döngü dışı");


            // 1-100 arasındaki tek sayıların toplamı

            int x = 1;
            int toplam = 0;
            while (x<100)
            {
                x++;
                if (x%2==0)
                    continue;
                toplam += x;
            }
            Console.WriteLine("toplam: "+ toplam);

        }
    }
}
