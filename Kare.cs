using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POLYsekil_uygulama
{
   public class Kare : sekil
    {
        public int BirKenar { get; set; }

        public Kare(string isim, int bir_kenar) : base(isim)
        {
            this.BirKenar = bir_kenar;
        }
        public override void SekilHesapla()
        {
            base.SekilHesapla();
            Console.WriteLine(getIsim()+"nin alanı: "+(BirKenar*BirKenar));
        }
        public override void SekilBilgi()
        {
            base.SekilBilgi();
            Console.WriteLine(getIsim()+"nin bir kenar uzunluğu: "+BirKenar);
        }
    }
}
