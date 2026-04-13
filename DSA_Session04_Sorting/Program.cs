using System;

class Program
{
    static void Main()
    {
        // author: Dang Quang Tuan
        // Mssv: 2500113447
        // Mục tiêu: học cách sử dụng các thuật toán sắp xếp cơ bản: Bubble Sort, Selection Sort, Insertion Sort

        // thiết lập mã hóa đầu ra để hỗ trợ tiếng Việt 
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        // Bài 1: Nhập số lượng phần tử và các phần tử của mảng
        Console.Write("nhap so luong phan tu: ");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];

        Console.WriteLine("nhap cac phan tu:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"arr[{i}] = ");
            arr[i] = int.Parse(Console.ReadLine());
        }

        // Tạo 2 bản sao của mảng để thử 2 thuật toán sắp xếp khác nhau
        int[] arrBubble = (int[])arr.Clone();
        int[] arrInsertion = (int[])arr.Clone();

        // --- Sắp xếp nổi bọt: Bubble Sort ---
        // Yêu cầu: sắp xếp mảng theo thứ tự tăng dần bằng thuật toán nổi bọt
        // Quá trình: lặp qua từng phần tử, so sánh và đổi chỗ nếu cần
        BubbleSort(arrBubble);
        Console.WriteLine("Mang sau khi sap xep bang Bubble Sort:");
        PrintArray(arrBubble);

        // --- Sắp xếp chèn: Insertion Sort ---
        // Yêu cầu: sắp xếp mảng theo thứ tự tăng dần bằng thuật toán chèn
        // Quá trình: lấy phần tử thứ i, chèn vào vị trí thích hợp trong phần đã sắp xếp
        InsertionSort(arrInsertion);
        Console.WriteLine("Mang sau khi sap xep bang Insertion Sort:");
        PrintArray(arrInsertion);
    }

    // Hàm sắp xếp nổi bọt (Bubble Sort)
    static void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        // lặp qua từng phần tử của mảng
        for (int i = 0; i < n - 1; i++)
        {
            // lặp qua các phần tử còn lại sau phần tử hiện tại
            for (int j = 0; j < n - i - 1; j++)
            {
                // nếu phần tử hiện tại lớn hơn phần tử kế tiếp, đổi chỗ hai phần tử
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }

    // Hàm sắp xếp chèn (Insertion Sort)
    static void InsertionSort(int[] arr)
    {
        int n = arr.Length;
        // lặp từ phần tử thứ 2 đến cuối mảng
        for (int i = 1; i < n; i++)
        {
            int key = arr[i]; // lưu giá trị phần tử hiện tại
            int j = i - 1;    // biến j duyệt ngược phần đã sắp xếp

            // di chuyển các phần tử lớn hơn key sang phải
            while (j >= 0 && arr[j] > key)
            {
                arr[j + 1] = arr[j];
                j--;
            }

            // chèn key vào vị trí thích hợp
            arr[j + 1] = key;
        }
    }

    // Hàm in mảng
    static void PrintArray(int[] arr)
    {
        foreach (int item in arr)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}