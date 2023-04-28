﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giua_ki_4
{
    internal class Book : Product
    {
        public Book(string id, string name, double price) : base(id, name, price) { }

        public override double computeTax()
        {
            return price * 5 / 100;
        }
    }
}
