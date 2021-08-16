## 1- Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.

## 2- Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.

## 3- Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.

## 4- Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.

# KODLAR

using System;

namespace Odev1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1
            try{
                System.Console.Write("Lütfen bir sayi giriniz : ");
                uint sayi = Convert.ToUInt32(Console.ReadLine());
            }
            catch(Exception ex){
                System.Console.WriteLine(ex.Message);
                System.Console.WriteLine("ERROR : Lütfen POZİTİF bir TAMSAYI girin...");
            }
            
            try
            {
                System.Console.Write("Kaç adet sayi gireceksiniz : ");
                uint adet = Convert.ToUInt32(Console.ReadLine());
                uint[] dizi = new uint[adet];

                for(int i=0; i<dizi.Length; i++){
                    System.Console.Write(i+1 + ". sayi : ");
                    dizi[i] = Convert.ToUInt32(Console.ReadLine());
                }
                for(int i=0; i<dizi.Length; i++){
                    if(dizi[i] % 2 == 0){
                        System.Console.WriteLine(dizi[i]);
                    }
                }
            }
            catch (System.Exception ex)
            {
                System.Console.WriteLine(ex.Message);
                System.Console.WriteLine("ERROR : Lütfen POZİTİF bir TAMSAYI girin...");
            }


            // 2
            try
            {
                System.Console.WriteLine("Lütfen iki adet sayi girin : ");
                uint[] dizi = new uint[2];
                System.Console.Write("1. sayi : ");
                dizi[0] = Convert.ToUInt32(Console.ReadLine());     // N
                System.Console.Write("2. sayi : ");
                dizi[1] = Convert.ToUInt32(Console.ReadLine());     // M

                System.Console.Write("Kaç adet sayı gireceksiniz : ");
                uint adet = Convert.ToUInt32(Console.ReadLine());
                uint[] dizi2 = new uint[adet];
                for(int i=0; i<dizi2.Length; i++){
                    System.Console.Write(i+1 + ". sayi : ");
                    dizi2[i] = Convert.ToUInt32(Console.ReadLine());
                }
                for(int i=0; i<dizi2.Length; i++){
                    if(dizi2[i] == dizi[1] || dizi2[i] % dizi[1] == 0){
                        System.Console.WriteLine(dizi2[i]);
                    }
                }
            }
            catch (System.Exception ex)
            {
                System.Console.WriteLine(ex.Message);
                System.Console.WriteLine("ERROR : Lütfen POZİTİF bir TAMSAYI girin...");
            }



            // 3
            try
            {
                System.Console.Write("Kaç adet kelime girmek istiyorsunuz : ");
                uint n = Convert.ToUInt32(Console.ReadLine());   
                string[] arr = new string[n];

                for(int i=0; i<n; i++){
                    System.Console.Write(i+1 + ". kelime = ");
                    arr[i] = Convert.ToString(Console.ReadLine());
                } 
                Array.Sort(arr);
                for(int i=0; i<n; i++){
                    System.Console.WriteLine(arr[i]);
                }
            }
            catch (System.Exception ex)
            {
                System.Console.WriteLine(ex.Message);
                System.Console.WriteLine("ERROR : Lütfen POZİTİF bir TAMSAYI girin...");
            }
            


            // 4
            System.Console.WriteLine("Bir cümle yazın : ");
            string cumle = Convert.ToString(Console.Read());
            for(int i=0; i<cumle.Length; i++){

            }

            string metin = "merhaba dunya !";
            string[] cumleler = metin.Split(" ");
            int kelimeAdeti = 0;
            for(int i=0; i<cumleler.Length; i++){
                if(i<cumleler.Length){
                    kelimeAdeti = i+1;
                }
            }
            System.Console.WriteLine("Kelime adeti : " + kelimeAdeti);
            string trim = metin.Replace(" ", "");
            System.Console.WriteLine("Harf adeti : " + trim.Length);
        }
    }
}
