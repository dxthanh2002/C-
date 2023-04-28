using System.Text;

namespace ngay7
{
    namespace Baitap_Dem_So_lan_xuat_hien
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                Console.OutputEncoding = Encoding.UTF8;
                List<string> strings = new List<string>();
                Dictionary<string, int> words = new Dictionary<string, int>();
                //nhập các chuỗi, nhập rỗng để kết thúc
                while (true)
                {
                    Console.WriteLine("Nhập chuỗi (ENTER để kết thúc):");
                    string str = Console.ReadLine();
                    if (str == "")
                        break;
                    else
                        strings.Add(str);
                }
                Console.WriteLine("Các chuỗi đã nhập:");
                foreach (string str in strings)
                {
                    Console.WriteLine(str);
                }
                //duyệt các chuỗi và đến số lần xuất hiện
                int count = 0;
                foreach (string str in strings)//duyệt từng chuỗi
                {
                    //tách chuỗi thành các chuỗi phân biệt bởi dấu cách
                    string[] arr = str.Split(' ');
                    foreach (string word in arr)//duyệt từ từ tách từ chuỗi
                    {
                        count++;//đếm số từ tách được
                        if (words.ContainsKey(word))//nếu từ tách được đã có trong từ điển
                        {
                            int n = words[word]; //lấy giá trị số lần xuất hiện cũ
                            n++; //tăng 1 đơn vị
                            words[word] = n;
                        }
                        else //nếu từ tách được chưa có trong từ điển
                            words.Add(word, 1);//thêm vào từ điển với số lần là 1
                    }
                }
                //hiển thị kết quả
                Console.WriteLine("Số lần xuất hiện của mỗi từ là:");
                foreach (string word in words.Keys)//duyệt các key của từ điển
                {
                    Console.WriteLine(word + " : " + words[word]);
                }

                Console.WriteLine("Tổng số từ: " + count);
                Console.ReadKey();
            }
        }
    }
}