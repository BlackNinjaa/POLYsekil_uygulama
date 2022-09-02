using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POLYsekil_uygulama
{
    public class Dikdortgen : sekil
    {
        public int UzunKenar;
        public int KisaKenar { get; set; }

        public Dikdortgen(string isim, int kisa_kenar, int uzun_kenar) :base (isim)
        {
            this.UzunKenar = uzun_kenar;
            this.KisaKenar = kisa_kenar;
        }

        public override void SekilHesapla()
        {
            base.SekilHesapla();
            Console.WriteLine(getIsim()+"nin alanı: "+(KisaKenar*UzunKenar));
        }

        public override void SekilBilgi()
        {
            base.SekilBilgi();
            Console.WriteLine("Şekil : "+getIsim());
            Console.WriteLine(getIsim()+"nin kısa kenarı: "+this.KisaKenar);
            Console.WriteLine(getIsim()+"nin uzun Kenarı: "+this.UzunKenar);

        }
    }
}
