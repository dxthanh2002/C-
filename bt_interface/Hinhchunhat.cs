using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bt_interface
{
    internal class Hinhchunhat : Ihinh
    {
        public double dai;
        public double rong;
        public Hinhchunhat()
        {
            dai = 0;
            rong = 0;
        }
        public Hinhchunhat(double d,double r)
        {
            dai = d;
            rong = r;
            
        }

        public double chuvi()
        {
            return (dai + rong) * 2;
        }

        public double dientich()
        {
            return dai * rong;
        }

        public void hienthi()
        {
            Console.WriteLine("Hình chữ nhật, dài: " + dai + ", rộng: " + rong);
        }
    }
}
