using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Giua_ki_3
{
    internal class List
    {
        List<product> ds = new List<product>();
        //xây dựng hàm tạo

        
        public void Nhap()
        {
            Console.WriteLine("Input new product");
            product product = new product();
            product.Nhap();
            ds.Add(product);
            
            
        }
        public void Hienthi()
        {
            if (ds.Count == 0)
            {
                Console.WriteLine("List id emty!");
            }
            else
            {
                Console.WriteLine("List of product: ");
                for (int i = 0; i < ds.Count; i++)
                {
                    ds[i].Hienthi();
                }
            }
        }
        public void Xoa()
        {
            Console.Write("Enter product ID to delete: ");
            String id = Console.ReadLine();

            for (int i = 0; i < ds.Count; i++)
            {
                if (ds[i].ProductID == id)
                {
                    ds.RemoveAt(i);
                }
            }
        }

    }
}

