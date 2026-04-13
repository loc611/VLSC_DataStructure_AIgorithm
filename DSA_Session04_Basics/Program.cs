using System;
using System.Diagnostics;
 class Program {
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.Write("nhap ho va ten: ");
        String name = Console.ReadLine();
        Console.Write("nhap MSSV: ");
        String mssv = Console.ReadLine();
        Console.Write($"chao mung sinh vien {name} co MSSV {mssv} den voi lop DSA");
        //bai 2
        Console.WriteLine("\nnhap so nguyen a: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("nhap so nguyen b: ");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine($"tong cua {a} va {b} la: {a+b}");
        Console.WriteLine($"hieu cua {a} va {b} la: {a-b}");
        Console.WriteLine($"tich cua {a} va {b} la: {a*b}");
        if (b != 0)        {
            Console.WriteLine($"thuong cua {a} va {b} la: {(float)a/b}");
        }
        else
        {
            Console.WriteLine("khong the chia cho 0");
        }
        //bai 3
        int x=5,y=10;
        Console.WriteLine($"gia tri cua x truoc khi swap: {x}");
        Console.WriteLine($"gia tri cua y truoc khi swap: {y}");
        //swap
        int temp = x;
        x = y;
        y = temp;
        Console.WriteLine($"gia tri cua x sau khi swap: {x}");
        Console.WriteLine($"gia tri cua y sau khi swap: {y}");
    }

}
