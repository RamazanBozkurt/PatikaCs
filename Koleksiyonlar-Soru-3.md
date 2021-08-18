using System;

namespace Koleksiyonlar_Soru_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Soru - 3:
            // Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan
            // ve dizinin elemanlarını sıralayan programı yazınız.

            char[] sesliHarfler = {'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü'};

            try
            {
                System.Console.Write("Bir cümle girin : ");
                string cumle = Console.ReadLine();

                string[] yeniDizi = new string[cumle.Length];

                string bosluksuz = cumle.Replace(" ", "");
                string kucuk = bosluksuz.ToLower();

                for(int i=0; i<kucuk.Length; i++){
                    for(int j=0; j<sesliHarfler.Length; j++){
                        if(kucuk[i] == sesliHarfler[j]){
                        yeniDizi[i] = kucuk[i].ToString();
                        }
                    }
                }
                
                foreach (var item in yeniDizi)
                {
                    if(item == null){
                        continue;
                    }
                    System.Console.WriteLine(item);
                }
            }
            catch (System.Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }
            
        }
    }
}
