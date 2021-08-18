using System;

namespace Koleksiyonlar_Soru_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Soru - 2: Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan, 
            // her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları 
            // ve ortalama toplamlarını console'a yazdıran programı yazınız. (Array sınıfını kullanarak yazınız.)

            int[] sayilar = new int[6];
            int[] buyukSayilar = new int[3];
            int[] kucukSayilar = new int[3];

            for(int i=0; i<sayilar.Length; i++){
                System.Console.Write((i+1) + ". sayı : ");
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
            }

            // en küçük 3 tane
            Array.Sort(sayilar);
            for(int i=0; i<3; i++){
                kucukSayilar[i] = sayilar[i];
            }
            
            // en büyük 3 tane 
            Array.Reverse(sayilar);
            for(int i=0; i<3; i++){
                buyukSayilar[i] = sayilar[i];
            }
            Array.Sort(buyukSayilar);

            // Büyük sayı ortalama
            int ortalamaBuyuk = 0, toplamBuyuk = 0;
            for(int i=0; i<buyukSayilar.Length; i++){
                toplamBuyuk += buyukSayilar[i];
            }
            ortalamaBuyuk = toplamBuyuk / buyukSayilar.Length;

            // Küçük sayı ortalama
            int ortalamaKucuk = 0, toplamKucuk = 0;
            for(int i=0; i<kucukSayilar.Length; i++){
                toplamKucuk += kucukSayilar[i];
            }
            ortalamaKucuk = toplamKucuk / kucukSayilar.Length;

            System.Console.WriteLine("Büyük sayılar toplamı : " + toplamBuyuk + " Büyük sayılar ortalaması : " + ortalamaBuyuk);
            System.Console.WriteLine("Küçük sayılar toplamı : " + toplamKucuk + " Küçük sayılar ortalaması : " + ortalamaKucuk);
        }
    }
}
