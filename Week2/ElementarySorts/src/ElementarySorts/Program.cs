using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementarySorts
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }




    public class Temp : IComparable<Temp>
    {
        private double deg;
        public Temp(double deg)
        {
            this.deg = deg;
        }

        public int CompareTo(Temp that)
        {
            double EPS = 0.1;
            if (this.deg < that.deg - EPS)
                return -1;
            if (this.deg > that.deg + EPS)
                return 1;
            return 0;

        }
    }
}
