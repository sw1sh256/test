using System;

namespace QuickSorting
{
    class QuickSorting
    {
        public static void sorting(double[] arr, long first, long last)
        {
            double p = arr[(last - first) / 2 + first];
            double temp;
            long i = first, j = last;
            while (i <= j)
            {
                while (arr[i] < p && i <= last) ++i;
                while (arr[j] > p && j >= first) --j;
                if (i <= j)
                {
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    ++i; --j;
                }
            }
            if (j > first) sorting(arr, first, j);
            if (i < last) sorting(arr, i, last);
        }
    }
    class Test
    {
        static void Main(string[] args)
        {
            double[] arr = new double[100];
            Random rd = new Random();
            for (int i = 0; i < arr.Length; ++i)
            {
                arr[i] = rd.Next(1, 101);
            }
            System.Console.WriteLine("До сортировки:");
            foreach (double x in arr)
            {
                System.Console.Write(x + " ");
            }
            QuickSorting.sorting(arr, 0, arr.Length - 1);
            System.Console.WriteLine("После сортировки:");
            foreach (double x in arr)
            {
                System.Console.Write(x + " ");
            }
            System.Console.ReadLine();
        }
    }
}
