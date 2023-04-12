/*Viết chương trình Giải phương trình bậc 2 tổ chức dạng hàm
Hàm Nhapso(): nhập số thực(sử dụng tham chiếu) out
Hàm GiaiPTB2(): Đầu vào là 3 hệ số A, B, C; Hàm trả về một số nguyên thể hiện số nghiệm của phương trình(0 – vô nghiệm, 1 – nghiệm kép, 2 – 2 nghiệm phân biệt) và trả về các nghiệm x1, x2 nếu có.
Hàm Main() gọi các hàm Nhapso và hàm GiaiPTB2() và hiển thị kết quả.
Gợi ý: Hàm GiaiPTB2() có 5 tham số:
A, B, C: là các tham số kiểu tham trị
X1, X2 là các tham số kiểu tham chiếu để truyền nghiệm ra bên ngoài nơi gọi hàm
Hàm return số nguyên int thể hiện số nghiệm */
using C_buoi2;

Student[] students = new Student[100];
int count = 0;
while (true)
{
    Console.WriteLine("1. Add student");
    Console.WriteLine("2. Display all students");
    Console.WriteLine("3. Sort students by mark");
    Console.WriteLine("4. Search student by name");
    Console.WriteLine("5. Exit");

    Console.Write("Enter your choice: ");
    int choice = int.Parse(Console.ReadLine());

    switch (choice)
    {
        case 1:
            Console.Write("Enter roll no: ");
            int rollNo = int.Parse(Console.ReadLine());

            Console.Write("Enter name: ");
            string name = Console.ReadLine();

            Console.Write("Enter mark: ");
            double mark = double.Parse(Console.ReadLine());

            Student student = new Student
            {
                RollNo = rollNo,
                Name = name,
                Mark = mark
            };

            students[count] = student;
            count++;

            Console.WriteLine("Student added successfully.");
            break;

        case 2:
            Console.WriteLine("Roll No\tName\tMark");

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("{0}\t{1}\t{2}", students[i].RollNo, students[i].Name, students[i].Mark);
            }

            break;

        case 3:
            for (int i = 0; i < count - 1; i++)
            {
                for (int j = i + 1; j < count; j++)
                {
                    if (students[i].Mark < students[j].Mark)
                    {
                        Student temp = students[i];
                        students[i] = students[j];
                        students[j] = temp;
                    }
                }
            }

            Console.WriteLine("Students sorted by mark.");
            break;

        case 4:
            Console.Write("Enter name to search: ");
            string searchName = Console.ReadLine();

            bool found = false;

            for (int i = 0; i < count; i++)
            {
                if (students[i].Name.ToLower() == searchName.ToLower())
                {
                    Console.WriteLine("Roll No\tName\tMark");
                    Console.WriteLine("{0}\t{1}\t{2}", students[i].RollNo, students[i].Name, students[i].Mark);
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine("Student not found.");
            }

            break;

        case 5:
            Console.WriteLine("Exiting...");
            Environment.Exit(0);
            break;

        default:
            Console.WriteLine("Invalid choice.");
            break;
    }

    Console.WriteLine();
}
