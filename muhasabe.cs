using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje
{
    class muhasabe:personel
    {
        public int mesaigun;
        public string ad;
        public muhasabe(string ad,int mesaigun)
        {
            this.ad = ad;
            this.mesaigun = mesaigun;
            string maas2 = Convert.ToString(maashesapla());
            ekranayaz(maas2);
        }
        
        public override double maashesapla()
        {
            asgarimaas = 1300;
            double sabit = base.maashesapla() / 22;
            double maas = base.maashesapla() + (sabit * mesaigun);
            return maas;
        }
        public void ekranayaz(string maasaylık)
        {
            Console.Write("Ad: " + ad + " Maaş: " + maasaylık);
        }
    }
}
