using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje
{
    class personel
    {
        public  double asgarimaas = 0;
        public virtual double maashesapla()
        {
            double maas = asgarimaas * 2;
            return maas;
        }
    }
}
