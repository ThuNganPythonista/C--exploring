using System;

class Car
{
    public  int speed = 0;  // Đây là một biến thông thường
}

class Program
{
    static void Main(string[] args)
    {
        Car car1 = new Car();
        car1.speed = 50; // vì speed không phải static nên gán nó = 50 được. Bây giờ ví dụ gán nó là static 
        Console.WriteLine(car1);
        
        Car car2 = new Car();
        Console.WriteLine(car2.speed); // In ra 0 vì car2 là một đối tượng khác
    }
}

