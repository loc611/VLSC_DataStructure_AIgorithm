using System;

class Program
{
    // ham de quy tinh giai thua
    static long GiaiThua(int n)
    {
        if (n <= 1) return 1;
        return n * GiaiThua(n - 1);
    }
    static int Fibonacci(int n)
    {   // truong hop co so
        if ( n == 0) return 0;
        if ( n == 1) return 1;
        // buoc de quy : F(n) = F(n-1) + F(n-2)
        return Fibonacci(n-1) + Fibonacci(n-2);
    }
    static void Main(string[] args)
    {
        Console.Write("Nhap n: ");
        int n = int.Parse(Console.ReadLine()!);

        Console.WriteLine("{0}! = {1}", n, GiaiThua(n));
        Console.WriteLine("Fibonacci({0}) = {1}", n, Fibonacci(n));
    }
}