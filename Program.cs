using System;

class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Score { get; set; }
}


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
                case 5:
                    Bai5();
                    break;
                case 6:
                    Bai6();
                    break;
                case 7:
                    Bai7();
                    break;
                case 8:
                    Bai8();
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

    static void Bai5()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
        var squaredNumbers = numbers.Select(n => n * n);
        PrintProfile();
        Console.WriteLine("Bình phương của các số: " + string.Join(", ", squaredNumbers));
    }

    static void Bai6()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
        var evenNumber = numbers.Where(n => n % 2 == 0).Count();
        PrintProfile();
        Console.WriteLine("Số lượng số chẵn: " + evenNumber);
    }

    static void Bai7()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
        var numberThanTen = numbers.Where(n => n > 10);
        PrintProfile();
        if (numberThanTen.Any())
        {
            Console.WriteLine("Số lớn hơn 10: " + string.Join(", ", numberThanTen));
        }
        else
        {
            Console.WriteLine("Không có số nào lớn hơn 10.");
        }
    }

    static void Bai8()
    {
        var students = new List<Student>()
    {
        new Student { Id = 1, Name = "An", Score = 8 },
        new Student { Id = 2, Name = "Binh", Score = 6 },
        new Student { Id = 3, Name = "Chi", Score = 9 },
        new Student { Id = 4, Name = "Dung", Score = 7 }
    };

        var goodStudents = students.Where(s => s.Score >= 8);
        PrintProfile();
        Console.WriteLine("Sinh viên giỏi:");
        foreach (var student in goodStudents)
        {
            Console.WriteLine($"{student.Name} - Điểm: {student.Score}");
        }
    }


}