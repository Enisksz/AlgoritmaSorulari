using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kullanıcıdan pozitif sayılar alır ve çift olanları bastırır.
            /*Console.WriteLine("Pozitif bir sayı giriniz: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] dizi = new int[n];
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}. sayiyi giriniz",i+1);
                dizi[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i = 0; i < n; i++)
            {
                if(dizi[i]%2==0)
                {
                    Console.Write(" " + dizi[i]);
                }
            }
            Console.ReadLine();*/


            //2.Durumun kodları
            /*
            Console.WriteLine("Pozitif iki sayi giriniz: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());    

            int[] sayilar = new int[n];
            for(int i=0;i<n;i++)
            {
                Console.WriteLine("{0}. sayiyi giriniz", i + 1);
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i = 0; i < n; i++)
            {
                if(sayilar[i]%m == 0 || sayilar[i]==m)
                {
                    Console.Write(sayilar[i]);
                }
            }
            Console.ReadLine();
            */

            //Kelimeleri sondan sıralama
            /*
            Console.WriteLine("Pozitif bir sayi giriniz: ");
            int n = Convert.ToInt32(Console.ReadLine());
            string[] kelime = new string[n];

            for(int i = 0; i < kelime.Length; i++)
            {
                Console.WriteLine("{0}. kelimeyi giriniz",i+1);
                kelime[i] = Console.ReadLine();

            }
            Array.Reverse(kelime);
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(kelime[i]);
            }
            Console.ReadLine();
            */

            Console.WriteLine("Bir cümle giriniz: ");
            string cumle = Console.ReadLine();

            int bosluk=0;
            int sayac = 0;
            
            

            for (int i = 0; i < cumle.Length; i++)
            {
                if (cumle[i]==32)
                {
                    bosluk++;
                }
                else
                {
                    sayac++;    
                }
            }
            int kelimeSayisi = bosluk + 1;

            Console.WriteLine("Bu cümle "+sayac+" harf");
            Console.WriteLine("Bu cümle "+kelimeSayisi+" kelime");
            
            Console.ReadLine();
        }
    }
}
