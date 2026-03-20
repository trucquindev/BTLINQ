using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Chọn bài tập (1-20) hoặc 0 để thoát:");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 0)
                break;

            switch (choice)
            {
                case 1:
                    Bai1();
                    break;
                case 2:
                    Bai2();
                    break;
                case 3:
                    Bai3();
                    break;
                case 4:
                    Bai4();
                    break;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng chọn lại.");
                    break;
            }
        }
    }

    static void PrintProfile()
    {
        Console.WriteLine("Nguyen Truc Quynh - 22115053122335");
    }

    static void Bai1()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
        var evenNumber = numbers.Where(n => n % 2 == 0);
        PrintProfile();
        Console.WriteLine("Số chẵn: " + string.Join(", ", evenNumber));
    }

    static void Bai2()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
        var greaterThanFive = numbers.Where(n => n > 5);
        PrintProfile();
        Console.WriteLine("Số lớn hơn 5: " + string.Join(", ", greaterThanFive));
    }

    static void Bai3()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
        var sortedNumbers = numbers.OrderBy(n => n);
        PrintProfile();
        Console.WriteLine("Số theo thứ tự tăng dần: " + string.Join(", ", sortedNumbers));
    }

    static void Bai4()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
        var sortedNumbers = numbers.OrderByDescending(n => n);
        PrintProfile();
        Console.WriteLine("Số theo thứ tự giảm dần: " + string.Join(", ", sortedNumbers));
    }
}
