using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_13
{
    internal class MultiBuilding:Building
    {
        int n;

        int N
        {
            get
            {
                return n;
            }
            set
            {
                if (value < 0)
                    Console.WriteLine("Введено неверное значение этажности");
                else
                    n = value;
            }
        }
        public MultiBuilding(string adress, double l, double c, double h, int n)
            :base(adress, l, c, h)
        {
            this.N = n;
        }
        public string Print()
        {
            string result= base.Print();
            result += $" {n}";
            return result;
        }
    }
}
