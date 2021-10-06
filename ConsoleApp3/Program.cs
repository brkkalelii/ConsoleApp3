using System;

namespace ConsoleApp3
{
    class Program
    {

 
        static void Main(string[] args)
        {
            int i = 0;
            while (i < 10)
            {
                i = i + 1;
                Console.WriteLine("While Döngüsü : " + i);
            }
            //var = degeri otomatik algiliyor
            var k = 0;

            do
            {
                k++;
                Console.WriteLine("do..while döngüsü: " + k);

            } while (k < 10);


            int toplam = 0;
            for (int sayi = 1; sayi < 11; sayi++)
            {
                toplam = toplam + i;
            }


            }

        }
    }

