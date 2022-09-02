using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POLYsekil_uygulama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ŞEKİL UYGULAMASINA HOŞ GELDİNİZ !");
            Console.WriteLine("----------------------------------");
            while (true)
            {
                Console.WriteLine("Lütfen bir işlem seçiniz :");
                Console.WriteLine("                           ");
                Console.WriteLine("1- Dikdörtgen İşlemleri.");
                Console.WriteLine("2- Üçgen İşlemleri.");
                Console.WriteLine("3- Kare İşlemleri.");
                Console.WriteLine("q- q'ya Basarak Çıkınız.");

                string secim = Console.ReadLine();

                if (secim == "q")
                {
                    break;
                }
                else if (secim == "1")
                {
                    Console.WriteLine("a- Dikdörgen Alan Hesapla.");
                    Console.WriteLine("b- Dikdörgen Bilgileri Göster.");
                    Console.WriteLine("c- Dikdörgen Çıkış Yap.");

                    while (true)
                    {
                        string secimDikdörtgen = Console.ReadLine();

                        if (secimDikdörtgen == "c")
                        {
                            Console.WriteLine("DİKDÖRTGEN İŞLEMLERİNDEN ÇIKIŞ YAPILIYOR...");
                            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++");
                            break;
                        }
                        else if (secimDikdörtgen == "a")
                        {
                            Console.Write("Lütfen Dikdörtgenin Kısa Kenarını Giriniz: ");
                            int KisaKenar = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Lütfen Dikdörtgenin Uzun Kenarını Giriniz: ");
                            int UzunKenar = Convert.ToInt32(Console.ReadLine());

                            Dikdortgen dikdortgen = new Dikdortgen("Dikdörtgen", KisaKenar,UzunKenar );
                            dikdortgen.SekilHesapla();
                        }
                        else if (secimDikdörtgen == "b")
                        {
                            Console.Write("Lütfen Dikdörtgenin Kısa Kenarını Giriniz: ");
                            int KisaKenar = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Lütfen Dikdörtgenin Uzun Kenarını Giriniz: ");
                            int UzunKenar = Convert.ToInt32(Console.ReadLine());

                            Dikdortgen dikdortgen = new Dikdortgen("Dikdörtgen", KisaKenar, UzunKenar);
                            dikdortgen.SekilBilgi();
                        }
                        else
                        {
                            Console.WriteLine("LÜTFEN GEÇERLİ BİR DEĞER GİRİNİZ !");
                            break;
                        }
                    }
                }


                else if (secim == "2")
                {
                    Console.WriteLine("a- Üçgenin Alanını Hesapla.");
                    Console.WriteLine("b- Üçgenin Bilgilerini Göster.");
                    Console.WriteLine("c- Üçgen İşlemlerinden Çıkış Yap.");

                    while (true)
                    {
                        string UcgenSecim = Console.ReadLine();

                        if (UcgenSecim == "c")
                        {
                            Console.WriteLine("ÜÇGEN İŞLEMLERİNDEN ÇIKIŞ YAPILIYOR...");
                            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++");
                            break;
                        }
                        else if (UcgenSecim == "a")
                        {
                            Console.Write("Lütfen üçgenin taban uzunluğunu giriniz: ");
                            int taban = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Lütfen üçgenin yüksekliğini giriniz: ");
                            int yukseklik= Convert.ToInt32(Console.ReadLine());

                            Ucgen ucgen = new Ucgen("Üçgen",taban,yukseklik);
                            ucgen.SekilHesapla();
                        }
                        else if (UcgenSecim == "b")
                        {
                            Console.Write("Lütfen üçgenin taban uzunluğunu giriniz: ");
                            int taban = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Lütfen üçgenin yüksekliğini giriniz: ");
                            int yukseklik = Convert.ToInt32(Console.ReadLine());

                            Ucgen ucgen = new Ucgen("Üçge", taban, yukseklik);
                            ucgen.SekilBilgi();
                        }
                        else
                        {
                            Console.WriteLine("LÜTFEN GEÇERLİ BİR DEĞER GİRİNİZ !");
                            break;
                        }
                    }

                }



                else if (secim == "3")

                {
                    Console.WriteLine("a- Karenin Alanını Hesapla.");
                    Console.WriteLine("b- Karenin Bilgilerini Göster.");
                    Console.WriteLine("c- Kare İşlemlerinden Çıkış Yap.");
                    while (true)
                    {
                        string kareSecim = Console.ReadLine();

                        if (kareSecim == "c")
                        {
                            Console.WriteLine("KARE İŞLEMLERİNDEN ÇIKIŞ YAPILIYOR...");
                            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++");
                            break;
                        }
                        else if (kareSecim == "a")
                        {
                            Console.Write("Lütfen Kenar Uzunluğunu Giriniz: ");
                            int kenar = Convert.ToInt32(Console.ReadLine());

                            Kare kare = new Kare("Kare", kenar);
                            kare.SekilHesapla();
                        }
                        else if (kareSecim=="b")
                        {
                            Console.Write("Lütfenin Karenin Kenar Uzunluğunu Giriniz: ");
                            int kenar = Convert.ToInt32(Console.ReadLine());
                            Kare kare = new Kare("Kare", kenar);
                            kare.SekilBilgi();
                        }
                        else
                        {
                            Console.WriteLine("LÜTFEN GEÇERLİ BİR DEĞER GİRİNİZ !");
                            break;
                        }
                    }


                }
                else
                {
                    Console.WriteLine("LÜTFEN GEÇERLİ BİR DEĞER GİRİNİZ !");
                }

            }
        }


    }
}

