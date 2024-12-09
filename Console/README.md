**test1: Nhập xuất cơ bản**:

- Write :

```C#
static void Main(string[] args)
{
    Console.Write("K team \n"); // Sử dụng ký tự đặc biệt để xuống dòng
    Console.WriteLine(5); // Sử dụng lệnh in ra màn hình có xuống dòng
    Console.Write(6.5f); // In ra giá trị nhưng không xuống dòng
    Console.Write(Environment.NewLine); // sử dụng lệnh xuống dòng
    Console.Write(true);

    Console.ReadLine();
}
```

- Read : Đọc 1 ký tự từ bàn phím và trả về kiểu số nguyên

```C#

static void Main(string[] args)
{
     Console.WriteLine(Console.ReadLine()); // đọc dữ liệu từ bàn phím cho đến khi gặp ký tự xuống dòng thì dừng. Sau đó in giá trị đã nhập ra màn hình.

     Console.WriteLine(Console.Read()); // đọc 1 ký tự từ bàn phím bằng lệnh Console.Read() sau đó in ra ký tự vừa đọc được.
     Console.ReadKey(); // lệnh này dùng với mục đích dừng màn hình để xem kết quả.
}

```

- ReadKey:

ReadKey là một phương thức trong lớp Console của C# dùng để đọc một phím mà người dùng nhấn từ bàn phím. Khi gọi Console.ReadKey(), chương trình sẽ tạm dừng và chờ người dùng nhấn một phím bất kỳ, sau đó nó sẽ tiếp tục chạy.

Chi tiết về ReadKey:
Phương thức này trả về một đối tượng ConsoleKeyInfo, chứa thông tin về phím mà người dùng đã nhấn (chẳng hạn như ký tự của phím và trạng thái các phím bổ trợ như Shift, Ctrl, Alt).
Ký tự phím sẽ được hiển thị trên console nếu bạn không chỉ định tham số true

```C#
Console.ReadKey(); // Đọc một phím, hiển thị ký tự trên console
Console.ReadKey(true); // Đọc một phím, nhưng không hiển thị ký tự
```

**Tổng kết:**

```C#
static void Main(string[] args)
{
     Console.WriteLine("         K team"); // In chữ "K team" sau đó xuống dòng.
     Console.Write(" Moi ban nhap ten cua minh: "); // In không xuống dòng.
     Console.WriteLine("Ten cua ban la: " + Console.ReadLine()); // Quy tắc chung trong thực hiện lệnh là lệnh bên trong thực hiện trước rồi đến lệnh bên ngoài chứa nó. Do đó chạy đến đây chương trình sẽ thực hiện lệnh Console.ReadLine() sau đó thực hiện cộng chuỗi và cuối cùng in chuỗi ra màn hình.
     Console.Write(" Moi ban nhap ngay sinh: ");
     Console.WriteLine(" Ngay sinh cua ban la: " + Console.ReadLine()); // Tương tự như trên
     Console.Write(" Moi ban nhap que quan: ");
     Console.WriteLine(" Que quan: " + Console.ReadLine()); // Tương tự như trên.

     Console.ReadKey();
}

```

s
