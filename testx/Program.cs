using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POLYtest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ŞEKİL UYGULAMASINA HOŞ GELDİNİZ");
            Console.WriteLine("=========================================");

            while (true)
            {

                Console.WriteLine("LÜTFEN YAPMAK İSTEDİĞİNİZ İŞLEMİ SEÇİNİZ:");
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("1- Dikdörtgen İşlemleri.");
                Console.WriteLine("2- Kare İşlemleri.");
                Console.WriteLine("3- Üçgen İşlemleri.");
                Console.WriteLine("4- Çıkış İşlemleri.");
                char secim =  Convert.ToChar(Console.ReadLine());
                switch (secim)
                {
                    case '1':// dikdörtgen işlemleri
                        while (true)
                        {

                            Console.WriteLine("DİKDÖRTGEN İŞLEMLERİNE HOŞ GELDİNİZ!");
                            Console.WriteLine("LÜTFEN YAPMAK İSTEDİĞİNİZ DİKDÖRTGEN İŞLEMİNİ SEÇİNİZ:");
                            Console.WriteLine("                                                      ");
                            Console.WriteLine("a| Dikdörtgenin alanını hesapla.");
                            Console.WriteLine("b| Dikdörtgenin bilgilerini göster.");
                            Console.WriteLine("c| Dikdörtgen işlemlerinden çıkış yap.");
                            while (true)
                            {
                                char dikdörtgenSecim = Convert.ToChar(Console.ReadLine());
                                switch (dikdörtgenSecim)
                                {
                                    case 'c':
                                        Console.WriteLine("Dikdörtgen İşlemlerinden Çıkış yapılıyor...");
                                        break;

                                    case 'a':
                                        Console.Write("Lütfen Dikdörtgenin kısa kenarını giriniz :  ");
                                        int kisaKenar = Convert.ToInt32(Console.ReadLine());
                                        Console.Write("Lütfen Dikdörtgenin uzun kenarını giriniz :  ");
                                        int uzunKenar = Convert.ToInt32(Console.ReadLine());

                                        DİKDÖRTGEN dikdörtgen = new DİKDÖRTGEN("Dikdörtgen", kisaKenar, uzunKenar);
                                        dikdörtgen.SEKİL_HESAPLA();
                                        break;

                                    case 'b':
                                        Console.Write("Lütfen Dikdörtgenin kısa kenarını giriniz :  ");
                                        int _kisaKenar = Convert.ToInt32(Console.ReadLine());
                                        Console.Write("Lütfen Dikdörtgenin uzun kenarını giriniz :  ");
                                        int _uzunKenar = Convert.ToInt32(Console.ReadLine());

                                        DİKDÖRTGEN Dikdörtgen = new DİKDÖRTGEN("Dikdörtgen", _kisaKenar, _uzunKenar);
                                        Dikdörtgen.SEKİL_BİLGİ();
                                        break;
                                   

                                    default:
                                        Console.WriteLine("HATALI İŞLEM YAPTINIZ LÜTFEN TEKRAR DENEYİNİZ!");
                                        break;
                                }

                            }
                        }


                    case '2': // kare işlemleri
                        Console.WriteLine("KARE İŞLEMLERİNE HOŞ GELDİNİZ!");
                        Console.WriteLine("LÜTFEN YAPMAK İSTEDİĞİNİZ DİKDÖRTGEN İŞLEMİNİ SEÇİNİZ:");
                        Console.WriteLine("                                                      ");
                        Console.WriteLine("a| Karenin alanını hesapla.");
                        Console.WriteLine("b| Karenin bilgilerini göster.");
                        Console.WriteLine("c| Kare işlemlerinden çıkış yap.");
                        char kareSecim = Convert.ToChar(Console.ReadLine());
                        switch (kareSecim)
                        {
                            case 'a':
                                Console.Write("Lütfen Karenin kenar uzunluğunu giriniz :  ");
                                int kenar = Convert.ToInt32(Console.ReadLine());
                                KARE kare = new KARE("Kare", kenar);
                                kare.SEKİL_HESAPLA();

                                break;
                            case 'b':
                                Console.Write("Lütfen Karenin kenar uzunluğunu giriniz :  ");
                                int _kenar = Convert.ToInt32(Console.ReadLine());
                                KARE Kare = new KARE("Kare", _kenar);
                                Kare.SEKİL_BİLGİ();
                                break;
                            case 'c':
                                Console.WriteLine("Kare İşlemlerinden Çıkış yapılıyor...");
                                break;

                            default:
                                Console.WriteLine("HATALI İŞLEM YAPTINIZ LÜTFEN TEKRAR DENEYİNİZ!");
                                break;

                        }
                        break;

                    case '3':  // üçgen işlemleri
                        Console.WriteLine("ÜÇGEN İŞLEMLERİNE HOŞ GELDİNİZ!");
                        Console.WriteLine("LÜTFEN YAPMAK İSTEDİĞİNİZ ÜÇGEN İŞLEMİNİ SEÇİNİZ:");
                        Console.WriteLine("                                                      ");
                        Console.WriteLine("a| Üçgenin alanını hesapla.");
                        Console.WriteLine("b| Üçgenin bilgilerini göster.");
                        Console.WriteLine("c| Üçgenin işlemlerinden çıkış yap.");
                        char ucgenSecim = Convert.ToChar(Console.ReadLine());
                        switch (ucgenSecim)
                        {
                            case 'a':
                                Console.Write("Lütfen üçgenin taban uzunluğunu giriniz :  ");
                                int taban = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Lütfen üçgenin yüksekliğini giriniz :  ");
                                int yukseklik = Convert.ToInt32(Console.ReadLine());
                                UCGEN ucgen = new UCGEN("Kare", taban, yukseklik);
                                ucgen.SEKİL_HESAPLA();
                                break;

                            case 'b':
                                Console.Write("Lütfen üçgenin taban uzunluğunu giriniz :  ");
                                int _taban = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Lütfen üçgenin yüksekliğini giriniz :  ");
                                int _yukseklik = Convert.ToInt32(Console.ReadLine());

                                UCGEN Ucgen = new UCGEN("Üçgen", _taban, _yukseklik);
                                Ucgen.SEKİL_HESAPLA();
                                break;
                            case 'c':
                                Console.WriteLine("Üçgen İşlemlerinden Çıkış yapılıyor...");
                                break;

                            default:
                                Console.WriteLine("HATALI İŞLEM YAPTINIZ LÜTFEN TEKRAR DENEYİNİZ!");
                                break;
                        }
                        break;

                    case '4': // çıkış işlemleri
                        Console.WriteLine("İŞLEMLERDEN ÇIKIŞINIZ YAPILIYOR...");
                        break;

                    default:
                        Console.WriteLine("HATALI İŞLEM YAPTINIZ LÜTFEN TEKRAR DENEYİNİZ!");
                        Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                        break;




                }


            }
        }
    }
}
