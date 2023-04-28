using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giua_ki_4
{
    internal class Phone : Product
    {
        public Phone(string id, string name, double price) : base(id, name, price) { }

        public override double computeTax()
        {
            return price * 10 / 100;
        }
    }
}
