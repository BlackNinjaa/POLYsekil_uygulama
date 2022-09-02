using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POLYsekil_uygulama
{
   public class Ucgen : sekil
    {
        
        public int taban_uzunluk { get; set; }
        public int yukseklik { get; set; }

        public Ucgen( string isim, int taban, int Yukseklik) :base(isim)
        {
            this.taban_uzunluk = taban;
            this.yukseklik = Yukseklik;
        }

        public override void SekilHesapla()
        {
            base.SekilHesapla();
            Console.WriteLine(getIsim()+ "nin alanı: "+((taban_uzunluk*yukseklik)/2));
        }
        public override void SekilBilgi()
        {
            base.SekilBilgi();
            Console.WriteLine("Şekil: "+getIsim());
            Console.WriteLine(getIsim()+"nin taban uzunluğu: "+this.taban_uzunluk);
            Console.WriteLine(getIsim()+"nin yüksekliği: "+this.yukseklik);
        }
    }
}
