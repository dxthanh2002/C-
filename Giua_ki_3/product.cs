using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giua_ki_3
{
    internal class product
    {
        private string productID;
        private string productName;
        private double price;
        
        public product()
        {
            productID = "";
            productName = "";
            price = 0;
        }
        public product(string i, string n,double pr)
        {
            productID = i;
            productName = n;
            price = pr;

        }
        public string ProductID { get { return productID; } set { productID = value; } }
        public string ProductName { get {  return productName; } set { productName = value; } }
        public double Price { get { return price; } set { price = value; } }





        //xây dựng phương thực Nhap() để nhập thông tin sinh viên từ bàn phím
        public void Nhap()
        {
            Console.Write("Nhap ma ID:");
            productID = Console.ReadLine(); ;
            Console.Write("Nhap ten product");
            productName = Console.ReadLine();
            Console.Write("Nhap gia tien");
            price =int.Parse(Console.ReadLine());


        }
        public void Hienthi()
        {
            Console.WriteLine("ID: {0}, Name: {1}, price : {2}", productID, productName,price);
        }

        
    }
}
