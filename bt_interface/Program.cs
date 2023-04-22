using System.Text;

namespace bt_interface
{
    internal class Program
    {
        static void Work(Ihinh h)
        {
            h.hienthi(); //hiển Hình nào đó
            Console.WriteLine("Chu vi: " + h.chuvi());
            Console.WriteLine("Diện tích: " + h.dientich());
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //tạo đối tượng hình chữ nhật
            Hinhchunhat hcn = new Hinhchunhat(20, 10);
            //tạo đối tượng hình tròn
            Hinhtron tron = new Hinhtron(10);
            //gọi hàm work với đối tượng thực là hình chữ nhật
            Work(hcn);
            //gọi hàm work với đối tượng thực là hình tròn
            Work(tron);
        }
    }
}