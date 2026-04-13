using System.ComponentModel;

namespace DSA_Session05_Basics;

class Program
{
    // Dang Quang Tuan _ 2500113447
    static void Main(string[] args)
    {
        // bai 1 : hoan doi 2 so khong dung bien tam (toan hoc)
        // goi y :dung phep cong va tru 
        // nguoi dung co the nhap 2 so tu ban phim va sau do thuc hien hoan doi
        Console.WriteLine("bai 1 : hoan doi 2 so ko dung bien tam");
        Console.Write("nhap so a: ");
        //nhap chuoi vao tu ban phim va luu vao bien inputA
        string inputA= Console.ReadLine();
        //su dung int.Tryparse de chuyen doi chuoi nhap vao thanh so nguyen
        // neu ko hop thi yeu cau nguoi dung lap lai
        int a ;
        while(!int.TryParse(inputA,out a))
        {
            Console.Write("so a ko hop le . vui long nhap lai: ");
            inputA = Console.ReadLine();
        }
        Console.Write("nhap so b: ");
        //doc chuoi nhap vao tu ban phim va luu vao bien inputB
        string inputB=Console.ReadLine();
        //su dung int.TryParse de chuyen doi chuoi nhap vao thanh so nguyen
        //neu khong hop le thi yeu cau nguoi dung nhap lai 
        int b;
        while(!int.TryParse(inputB,out b))
        {
            Console.Write("so a ko hop le . vui long nhap lai: ");
            inputA = Console.ReadLine();
        }
        a=a+b;//cong a va b luu ket qua vao a
        b=a-b;// lay gia tri moi nhat cua a tru di b
        // luu ket qua vao b(b gio la gia tri ban dau cua a)
        a=a-b;// lay gia tri moi nha cua a tru di b 
        // ket qua luu a( a gio la gia tri ban dau cua b)
        Console.WriteLine($"a={a},b={b}");
        Console.WriteLine("=============");
        Console.WriteLine("bai 2 : ve hinh vuong dau sao (n x n)");
        //nguoi dung co the nhap kich thuc n tu ban phim 
        // va sau do in ra hinh vuong tuong ung 
        Console.Write("nhap kich thuoc n cua hinh vuong ");
        string inputN= Console.ReadLine();
        int n ; // su dung int.TryParse de chuyen doi chuoi nhap vao thanh so nguyen
        // neu ko hop le thi yeu cau nguoi dung nhap lai
        // n >0
        while(!int.TryParse(inputN, out n) || n <= 0)
        {
            Console.Write("kich thuoc n khong hop le .vui long nhap lai");
            inputN = Console.ReadLine();
        }
        // dung 2 vong lap for de in ra hinh vuong dau sao
        for (int i = 0; i < n; i++)
        {   // duyet hang
            for (int j = 0; j < n; j++)
            {
                // duyet cot
                Console.Write("*");
            }
            Console.WriteLine(); // xuong dong sau moi hang
        }
        Console.WriteLine("============");
        console.WriteLine("bai 3 : in bang cuu chuong (2 den 9)");
        for (int i = 2; i <= 9; i++)
        {
            Console.WriteLine($"-- bang cuu chuong {i}--");
            for(int j = 1 ; j <= 10; j++)
            {
                Console.WriteLine($"{i} x {j} = {i*j}");
            }
        }

    }
}
