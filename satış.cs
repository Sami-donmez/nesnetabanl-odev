using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje
{
    class satış:personel
    {
        
        public double satıs;
        public string ad;
        public satış(double satıs,string ad)
        {
            this.satıs = satıs;
            this.ad = ad;
            string maas2= Convert.ToString(maashesapla());
            ekranayaz(maas2);
        }

        public override double maashesapla() {
            asgarimaas = 1500;
            double maas = base.maashesapla()+(satıs*0.1);
            return maas;
        }
        public void ekranayaz(string maasaylık)
        {
            Console.Write("Ad: "+ad+" Maaş: "+maasaylık);
        }
    }
}
