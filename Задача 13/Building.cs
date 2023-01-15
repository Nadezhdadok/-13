using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_13
{
    internal class Building
    {
        string adress;
        double l;
        double c;
        double h;

        public Building(string adress, double l, double c, double h)
        {
            this.adress = adress;
            this.l = l;
            this.c = c;
            this.h = h;
        }
        public string Print ()
        {
            return $"{adress} {l} {c} {h}";
        }
    }
}
