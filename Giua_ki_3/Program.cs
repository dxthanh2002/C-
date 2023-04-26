using System.Text;

namespace Giua_ki_3
{
    internal class Program
    {
        //xây dựng phương thức tĩnh (static) hiển thị menu và nhập số chọn
        public static int Menu()
        {
            int chon;
            Console.WriteLine("Menu \n1. ADD \n2. Display");
            Console.WriteLine("3.Delete \n4.Exit");
            
            Console.WriteLine("Mời lựa chọn  (1-4):");
            chon = int.Parse(Console.ReadLine());
            return chon;
        }
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            List dssv = new List();
            
            int chon;
            do
            {
                //hiển thị menu
                chon = Menu();
                //xử lý menu
                switch (chon)
                {
                    case 1:
                        dssv.Nhap();
                        break;
                    case 2:
                        dssv.Hienthi();
                        break;
                    case 3:
                        dssv.Xoa();
                        break;
                    case 4:
                        Console.WriteLine("Kết thúc chương trình \nChào tạm biệt!");
                        break;
                    default:
                        Console.WriteLine("Bạn nhập sai lựa chọn, mới nhập lại!");
                        break;
                        

                    
                }
            } while (chon != 4);
        }
    }
}