using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POLYsekil_uygulama
{
    public class sekil  // base class
    {
        public string isim { get; set; }

        public sekil(string isim)
        {
            this.isim = isim;
        }

        public string getIsim()
        {
            return this.isim;
        }

        public void setIsim(string isim)
        {
            this.isim = isim;
        }

        public virtual void SekilHesapla()
        {
            Console.WriteLine("Şeklin Alanı Hesaplanıyor...");
        }
        public virtual void SekilBilgi()
        {
            Console.WriteLine("=============================");
            Console.WriteLine(getIsim() + "nin Bilgileri : ");
            Console.WriteLine("=============================");
        }
    }
}
