using System;
using System.Collections;

namespace Koleksiyonlar_Soru_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList sayilar = new ArrayList();
            ArrayList asalSayilar = new ArrayList();
            ArrayList asalOlmayanSayilar = new ArrayList();
            int asalAdet = asalSayilar.Count, asalOlmayanAdet = asalOlmayanSayilar.Count;
            uint asalToplam = 0, asalOlmayanToplam = 0;
            uint asalOrtalama = 0, asalOlmayanOrtalama = 0;

            for(int i=0; i<20; i++){
                System.Console.Write($"{i+1}. sayı : ");
                sayilar.Add(Convert.ToUInt32(Console.ReadLine()));
            }

            for(int i=0; i<20; i++){
                if((uint)sayilar[i] % 2 == 0 && (uint)sayilar[i] != 2){
                    if((uint)sayilar[i] == 1){
                        asalOlmayanSayilar.Add(1);
                    }
                    asalOlmayanSayilar.Add(i);
                }
                else{
                    asalSayilar.Add(i);
                }
            }

            foreach (var item in asalSayilar)
            {
                asalSayilar.Reverse();
                System.Console.WriteLine(item);
            }
            foreach (var item in asalOlmayanSayilar)
            {
                asalOlmayanSayilar.Reverse();
                System.Console.WriteLine(item);
            }

            for(int i=0; i<asalAdet; i++){
                asalToplam += (uint)asalSayilar[i];
            }
            asalOrtalama = Convert.ToUInt32(asalToplam / asalAdet);

            for(int i=0; i<asalOlmayanAdet; i++){
                asalOlmayanToplam += (uint)asalOlmayanSayilar[i];
            }
            asalOlmayanOrtalama = Convert.ToUInt32(asalOlmayanToplam / asalOlmayanAdet);

            System.Console.WriteLine($"ASAL OLMAYAN DİZİNİN ELEMAN SAYISI : {asalOlmayanAdet}");
            System.Console.WriteLine($"ASAL OLMAYAN DİZİNİN ORTALAMASI : {asalOlmayanOrtalama}");
        }
    }
}
