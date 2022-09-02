//using System;
//namespace aug30th
//{
//    internal class Program
//    {
//            //static void bubbleSort(int[] arr)
//            //{
//            //    int n = arr.Length;
//            //    for (int i = 0; i < n - 1; i++)
//            //        for (int j = 0; j < n - i - 1; j++)
//            //            if (arr[j] > arr[j + 1])
//            //            {

//            //                int temp = arr[j];
//            //                arr[j] = arr[j + 1];
//            //                arr[j + 1] = temp;
//            //            }
//            //}


//            //static void printArray(int[] arr)
//            //{
//            //    int n = arr.Length;
//            //    for (int i = 0; i < n; ++i)
//            //        Console.Write(arr[i] + " ");
//            //    Console.WriteLine();
//            //}


//            //public static void Main()
//            //{
//            //    int[] arr = { 64, 34, 25, 12, 22, 11, 90 };
//            //    bubbleSort(arr);
//            //    Console.WriteLine("Sorted array");
//            //    printArray(arr);
//            //}




//        }
//    }

//=======================================================================================================

using System;
public class Example
{
    static void Main(string[] args)
    {
        /*int[] arr = new int[10] { 56, 1, 99, 67, 89, 23, 44, 12, 78, 34 };
        int n = 10;
        Console.WriteLine("Selection sort");
        Console.Write("Initial array is: ");
        for (int i = 0; i < n; i++)
        {
            Console.Write(arr[i] + " ");
        }
        int temp, smallest;
        for (int i = 0; i < n - 1; i++)
        {
            smallest = i;
            for (int j = i + 1; j < n; j++)
            {
                if (arr[j] < arr[smallest])
                {
                    smallest = j;
                }
            }
            temp = arr[smallest];
            arr[smallest] = arr[i];
            arr[i] = temp;
        }
        Console.WriteLine();
        Console.Write("Sorted array is: ");
        for (int i = 0; i < n; i++)
        {
            Console.Write(arr[i] + " ");
        }*/
        // insertion sort

        int[] arr = new int[10] { 23, 9, 85, 12, 99, 34, 60, 15, 100, 1 };
        int n = 10, i, j, val, flag;
        Console.WriteLine("Insertion Sort");
        Console.Write("Initial array is: ");
        for (i = 0; i < n; i++)
        {
            Console.Write(arr[i] + " ");
        }
        for (i = 1; i < n; i++)
        {
            val = arr[i];
            flag = 0;
            for (j = i - 1; j >= 0 && flag != 1;)
            {
                if (val < arr[j])
                {
                    arr[j + 1] = arr[j];
                    j--;
                    arr[j + 1] = val;
                }
                else flag = 1;
            }
        }
        Console.Write("\nSorted Array is: ");
        for (i = 0; i < n; i++)
        {
            Console.Write(arr[i] + " ");
        }
    }
}


