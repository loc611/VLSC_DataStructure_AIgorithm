using System.Data;

namespace DSA_Session05_Sortings;

class Program
{
    static void Main(string[] args)
    {
        // nhap mang tu nguoi dung 
        int[] arr = inputArray();
        //// tao ban sao cua mang de su dung cho thuan toan khac
        int [] arrCopy = (int[])arr.Clone();
        Console.WriteLine("mang ban dau ");
        PrintArray(arr);
        BubbleSort(arr);
        Console.WriteLine("mang sau khi sap xep (Bubble Sort):");
        PrintArray(arr);
        InsertionSort(arrCopy);
        Console.WriteLine("mang sau khi sap xep (insertion Sort):");
        PrintArry(arrCopy);
    }
    //ham de nhap mang tu nguoi dung 
    private static int[] InputArray()
    {
        Console.WriteLine("nhap so luong phan tu :");
        int n;
        while (!int.TryParse(Console.ReadLine(),out n))
        {
            Console.WriteLine("nhap so nguyen hop le");
        }
        int [] arr = new int[n];
        Console.WriteLine("nhap cac phan tu :");
        for (int i=0;i< n; i++)
        {
            while(!int.TryParse(Console.ReadLine(),out arr[i]))
            {
                Console.WriteLine("nhap 1 so nguyen ko hop le :");

            }
        }
        return arr;
    }
    //ham in ra mang 
    private static void PrintArray(int[] arr)
    {
        foreach ( int item in arr)
        {
            Console.Write(item +" ");
        }
          Console.WriteLine();
    }
    //3.1 bubble sort (sap xep noi bot)
    // nguyen ly : so sanh tung cap phan tu lien ket ke va hoan doi neu chung
    // khong theo thu tu dung
    //qua trinh nay lap lai cho den khi khong con hoan doi nao can thiet
    //cach hoat dong : bat dau tu phan tu dau tien 
    //so sanh no voi phan tu tiep theo va hoan doi neu can
    // do phuc tap:0(n^2) trong truong hop xau nhat
    //o(n) trong truong hop tot nhat (khi mang da sap xep )
    static void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        int swapCount = 0 ;
        for (int i = 0 ; i < n-1;i++)
        {
            // duyet qua tat ca phan tu , tru phan tu cuoi cung
            for (int j = 0; j < n - i - 1; j++)
            { // so sanh pt hien tai voi pt tiep theo
                if (arr[j] > arr[j + 1])
                {
                    //neu phan tu hien tai lon hon 
                    int temp = arr[j];
                    arr[j]=arr[j+1];
                    arr[j+1]=temp;
                    swapCount++;
                }
            }
        }
        Console.WriteLine($"bubble sort ton {swapCount} lan hoan doi ");
    }
    //3.2 insertion sort( sap xep chen)
    // nguyen ly lay tung phan tu va chen vao dung vi tri trong phan tu da sap xep
    // ( giong nhu xep bai tay)
    // cach hoat dong : bat dau tu phan tu thu 2
    //so sanh no voi phan tu truoc do va chen no vao dung vi tri trong phan da sap xep
    // do phuc tap : 0(n^2) trong truong hop xau nhat
    //0(n)trong truong hop tot nhat ( khi mang da sap xep )
    // swapcount = 0; // bien toan cuc de dem so lan hoan doi 
    static void InsertionSort(int [] arr)
    {
        int swapCoun=0;
        int n=arr.Length;
        for(int i = 1; i< n ; i ++)
        {
            int key = arr[i];// phan tu can chen
            int j=i-1;//chi sp cua pha tu truoc do 
            //di chuyen cac phan tu lon hon key sang phai
            while (j>=0&&arr[j]>key)// so sanh key voi phan tu truoc do
            //neu phan tu truoc do lon hon key , di chuyen no sang phai 
            {
                arr[j+1]=arr[j];//di chuyen phan tu sang phai 
                j--;// di chuyen chi so sang trai
                swapCoun++;
            }
            arr[j+1]=key;
        }
        Console.WriteLine($"insertion sort ton {swapCount} lan hoan doi ");
    }

}
