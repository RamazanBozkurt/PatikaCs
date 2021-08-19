using System;
using System.Collections.Generic;

namespace TelefonRehberi
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dictionary<string, string> baslangicNumaralar = new Dictionary<string, string>{
            //     "05438532168", "1",
            //     "05367785038", "2",
            //     "05079296307", "3", 
            //     "05424214088", "4", 
            //     "05426125655", "5"
            // };
            List<string> numaralar = new List<string>{"05438532168", "05367785038", "05079296307", "05424214088", "05426125655"};
            List<string> adlar = new List<string>{"Ramazan", "Yasemin", "Emine", "Dedem", "Yusuf"};
            List<string> soyadlar = new List<string>{"Bozkurt", "Bozkurt", "Bozkurt", "Bozkurt", "Bozkurt"};

            while(true){
                System.Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz");
                System.Console.WriteLine("****************************************");
                System.Console.WriteLine("(1) Yeni Numara Kaydetmek");
                System.Console.WriteLine("(2) Kayıtlı Numarayı Silmek");
                System.Console.WriteLine("(3) Kayıtlı Numarayı Güncellemek");
                System.Console.WriteLine("(4) Rehberi Listelemek");
                System.Console.WriteLine("(5) Rehberde Arama Yapmak");

                int secim = Convert.ToInt32(Console.ReadLine());

                if(secim == 1){
                    TelefonNumarasiKaydet(numaralar, adlar, soyadlar);
                }
                else if(secim == 2){
                    //TelefonNumarasiSil();
                    System.Console.Write("Lütfen numarasını silmek istediğini kişinin adını veya soyadını giriniz : ");
                    string deger2 = Console.ReadLine();    
                    string deger = deger2.ToLower();

                    for(int i=0; i<numaralar.Count; i++){
                        if(deger == adlar[i].ToLower() || deger == soyadlar[i].ToLower()){
                            Console.Write(deger + " isimli kişi rehberden silinmek üzere, onaylıyor musunuz? (E/H)");
                            string islem = Console.ReadLine();
                            string islem2 = islem.ToLower();
                            if(islem2 == "e"){
                                numaralar[i].Remove(i);
                                adlar[i].Remove(i);
                                soyadlar[i].Remove(i);
                                break;
                            }
                            else if(islem2 == "h"){
                                System.Console.WriteLine("İşlem iptal edildi.");
                                break;
                            }
                            break;
                        }
                        else{
                            System.Console.WriteLine("Aradınığınız kriterlere uygun kişi rehberde bulunamadı. Lütfen bir seçim yapınız.");
                            System.Console.WriteLine("Silmek sonlandırmak için (1)");
                            System.Console.WriteLine("Yeniden denemek için (2)");
                            int yeniSecim = Convert.ToInt32(Console.ReadLine());

                            if(yeniSecim == 1){
                                break;               
                            }
                            else if(yeniSecim == 2){
                                continue;
                            }
                            else{
                                System.Console.WriteLine("Lütfen geçerli bir işlem seçiniz.");
                            }

                        }
                    }
                }
                else if(secim == 3){
                    System.Console.Write("Lütfen numarasını değiştirmek istediğini kişinin adını veya soyadını giriniz : ");
                    string deger2 = Console.ReadLine();    
                    string deger = deger2.ToLower();

                    for(int i=0; i<numaralar.Count; i++){
                        if(deger == adlar[i].ToLower() || deger == soyadlar[i].ToLower()){
                            System.Console.Write("Lütfen yeni numarayı giriniz : ");
                            string yeniNumara = Console.ReadLine();    
                            numaralar[i] = yeniNumara;
                        }
                        else{
                            System.Console.WriteLine("Aradınığınız kriterlere uygun kişi rehberde bulunamadı. Lütfen bir seçim yapınız.");
                            System.Console.WriteLine("Silmek sonlandırmak için (1)");
                            System.Console.WriteLine("Yeniden denemek için (2)");
                            int yeniSecim = Convert.ToInt32(Console.ReadLine());

                            if(yeniSecim == 1){
                                break;               
                            }
                            else if(yeniSecim == 2){
                                continue;
                            }
                            else{
                                System.Console.WriteLine("Lütfen geçerli bir işlem seçiniz.");
                            }

                        }
                    }
                }
                else if(secim == 4)
                {
                    System.Console.WriteLine("Telefon Rehberi");
                    System.Console.WriteLine("*****************************");
                    for(int i=0; i<numaralar.Count; i++){
                        System.Console.WriteLine("**********************************");
                        System.Console.WriteLine("İsim : " + adlar[i]);
                        System.Console.WriteLine("Soyisim : " + soyadlar[i]);
                        System.Console.WriteLine("Telefon Numarası : " + numaralar[i]);
                        System.Console.WriteLine("**********************************");
                    }
                }
                else if(secim == 5){
                    //RehberdeArama();
                    Console.WriteLine("Arama yapmak istediğiniz tipi seçin");
                    System.Console.WriteLine("*****************************************");
                    System.Console.WriteLine("İsim veya soyisime göre arama yapmak için (1)");
                    System.Console.WriteLine("Telefon numarasına göre arama yapmak için (2)");
                    int aramaSecimi = Convert.ToInt32(Console.ReadLine());

                    if(aramaSecimi == 1){
                        System.Console.Write("İsim veya soyisim giriniz : ");
                        string deger = Console.ReadLine();
                        string deger2 = deger.ToLower();
                        for(int i=0; i<numaralar.Count; i++){
                            if(deger2 == adlar[i].ToLower() && deger2 == soyadlar[i].ToLower()){
                                for(int j=0; j<adlar.Count; j++){
                                    System.Console.WriteLine("**********************************");
                                    System.Console.WriteLine("İsim : " + adlar[i]);
                                    System.Console.WriteLine("Soyisim : " + soyadlar[i]);
                                    System.Console.WriteLine("Telefon Numarası : " + numaralar[i]);
                                    System.Console.WriteLine("**********************************");
                                    break;
                                }
                            }
                            else{
                                System.Console.WriteLine("Aradığınız kişi bulunamadı.");
                            }
                        }
                    }
                    else if(aramaSecimi == 2){
                        System.Console.Write("Telefon numarası giriniz : ");
                        string deger = Console.ReadLine();
                        for(int i=0; i<numaralar.Count; i++){
                            if(deger == numaralar[i]){
                                System.Console.WriteLine("**********************************");
                                System.Console.WriteLine("İsim : " + adlar[i]);
                                System.Console.WriteLine("Soyisim : " + soyadlar[i]);
                                System.Console.WriteLine("Telefon Numarası : " + numaralar[i]);
                                System.Console.WriteLine("**********************************");
                                break;
                            }
                            else{
                                System.Console.WriteLine("Aradığınız kişi bulunamadı.");
                            }
                        }
                        
                    }
                    else{
                        System.Console.WriteLine("Lütfen geçerli bir işlem seçiniz...");
                    }
                }
                else{
                    System.Console.WriteLine("Geçerli bir işlem tipi seçiniz...");
                }
            }
        }
        public static void TelefonNumarasiKaydet(List<string> numara, List<string> ad, List<string> soyad){
            System.Console.Write("Lütfen isim giriniz : ");
            string isim = Console.ReadLine();
            System.Console.Write("Lütfen soyisim giriniz : ");
            string soyisim = Console.ReadLine();
            System.Console.Write("Lütfen telefon numarasını giriniz : ");
            string yeniNumara = Console.ReadLine();

            numara.Add(yeniNumara);
            ad.Add(isim);
            soyad.Add(soyisim);
        }
    }
}
