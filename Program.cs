using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje
{
    class Program
    {
        static void Main(string[] args)
        {
            muhasabe muhasabe = new muhasabe("ahmet demir",3);
            satış satış = new satış(1000, "mehmet çelik");
            Console.ReadLine();
        }
    }
}
