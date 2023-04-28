using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giua_ki_4
{
    public abstract class Product
    {
        public string id;
        public string name;

        public double price;
        public Product()
        {

        }
        public Product(string id , string name, double price)
        {
            this.id = id;
            this.name = name;
            this.price = price;
        }
        public string ID {get{return name; } set { name = value;} }
        public string Name { get { return name;} set {  name = value;} }
        public double Price { get { return price; } set { price = value;} }

        public abstract double computeTax();



    }
}
