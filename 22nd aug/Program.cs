﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _22nd_aug
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

                //q1
                /*  int i;
                  int[] arr = new int[10];
                  Console.WriteLine("Input 10 elements in the array :\n");
                  for (i = 0; i < 10; i++)
                  {
                      Console.WriteLine("element - {0} : ", i);
                      arr[i] = Convert.ToInt32(Console.ReadLine());
                  }

                  Console.WriteLine("\nElements in array are: ");
                  for (i = 0; i < 10; i++)
                  {
                      Console.WriteLine("{0}  ", arr[i]);
                  }
                  Console.WriteLine("\n");
                  Console.ReadLine(); */

                //q2
                /* int i, n;
                 int[] a = new int[100];
                 Console.WriteLine("Input the number of elements to store in the array :");
                 n = Convert.ToInt32(Console.ReadLine());
                 Console.WriteLine("Input {0} array elements:\n", n);
                 for (i = 0; i < n; i++)
                 {
                     Console.WriteLine("element - {0} : ", i);
                     a[i] = Convert.ToInt32(Console.ReadLine());
                 }
                 Console.WriteLine("\n Values into the array are : \n");
                 for (i = 0; i < n; i++)
                 {
                     Console.WriteLine("{0}  ", a[i]);
                 }
                 Console.WriteLine("\n\n Array in Reverse order are :\n");
                 for (i = n - 1; i >= 0; i--)
                 {
                     Console.WriteLine("{0} ", a[i]);
                 }
                 Console.WriteLine("\n\n");
                 Console.ReadLine(); */


                //q3
                /* int[] a = new int[100];
                 int i, n, sum = 0;
                 Console.WriteLine("Enter the number of elements to be stored in the array :");
                 n = Convert.ToInt32(Console.ReadLine());
                 Console.WriteLine("Enter {0} elements in the array :\n", n);
                 for (i = 0; i < n; i++)
                 {
                     Console.WriteLine("element - {0} : ", i);
                     a[i] = Convert.ToInt32(Console.ReadLine());
                 }

                 for (i = 0; i < n; i++)
                 {
                     sum += a[i];
                 }

                 Console.WriteLine("Sum: {0}\n\n", sum);
                 Console.ReadLine(); */


                //q4

                /*  ArrayList arr = new ArrayList { 5 };
                  arr.Add(90);
                  arr.Add(65);
                  arr.Add(76);
                  arr.Add(63);
                  arr.Add(54);
                  Console.WriteLine("Count {0}",arr.Count);
                  arr.Remove(76);
                  Console.WriteLine("Remove {0}",arr.Count);
                  Console.ReadLine(); */

                //q5
                /*int[][] classroom = new int[4][];
                  classroom[0] = new int[] { 11, 12, 13, 14 };
                  classroom[1] = new int[] { 101, 323 };
                  classroom[2] = new int[] { 89, 23, 897 };
                  classroom[3] = new int[] { 0, 45, 78, 53, 99 };


                  for (int n = 0; n < classroom.Length; n++)
                  {


                      System.Console.Write("student({0}): ", n);

                      for (int k = 0; k < classroom[n].Length; k++)
                      {


                          System.Console.Write("{0} ", classroom[n][k]);
                      }
                      System.Console.WriteLine();
                  }
                Console.ReadLine(); */


                //q6
                /* Stack a = new Stack();
                 a.Push(1);
                 a.Push(2);
                 a.Push(3);
                 Console.WriteLine("Before pop:");
                 foreach (Object obj in a)
                 {
                     Console.WriteLine(obj);
                 }

                 Console.WriteLine("Before pop count is " + a.Count);
                 a.Pop();
                 Console.WriteLine("After pop:");
                 foreach (Object obj in a)
                 {
                     Console.WriteLine(obj);
                 }

                 Console.WriteLine("Peek  " + a.Peek());
                 Console.WriteLine("after pop count is " + a.Count);
                 Console.ReadLine(); */


                //q7
                /* Queue<int> s = new Queue<int>();
                 s.Enqueue(1);
                 s.Enqueue(11);
                 s.Enqueue(111);
                 s.Enqueue(1111);
                 s.Enqueue(11111);
                 foreach (var element in s)
                 {
                     Console.WriteLine(element);

                 }
                 Console.WriteLine("Total count :" + s.Count);
                 s.Dequeue();
                 Console.WriteLine("Count after performing Dequeue :" + s.Count);
                 Console.WriteLine("Top most element is: " + s.Peek());
                 Console.ReadLine(); */

                //q8
                /* Hashtable h = new Hashtable();
                 h.Add(1, "Hey");
                 h.Add(2, "Hearty");
                 h.Add(3, "Welcome!!");

                 Console.WriteLine("Before delete:");

                 foreach (DictionaryEntry element in h)
                 {
                     Console.WriteLine("{0} and {1} ", element.Key, element.Value);
                 }
                 h.Remove(1);
                 Console.WriteLine("After perform delete:");
                 foreach (DictionaryEntry element in h)
                 {
                     Console.WriteLine("{0} and {1} ", element.Key, element.Value);
                 }
                 Console.ReadLine(); */

                //q9
                /*float a = new float[] { 0.1f, 8.8f, 9.6f, 5.4f, 6.9f, 7.3f };
               Array.Sort(a);
               Console.WriteLine("Ascending Order: ");
               foreach (float value in a)
               {
                   Console.Write(value + " ");
               }
               Console.WriteLine("\n");
               Array.Reverse(a);
               Console.WriteLine("Dscending order : ");  /*float
               foreach (float value in a)
               {
                   Console.Write(value + " ");
               }
               Console.ReadLine(); */



                //q10
                /*SortedList<int, string> dct = new SortedList<int, string>();
                  dct.Add(1, "appnet");
                  dct.Add(2, "ab.net");
                  dct.Add(3, "pc.net");
                  dct.Add(4, "vb.net");
                  foreach (KeyValuePair<int, string> kvp in dct)
                  {
                      Console.WriteLine(kvp.Key + " " + kvp.Value);
                  }
                  dct.Remove(2);
                  Console.WriteLine("after removing");
                  foreach (KeyValuePair<int, string> kvp in dct)
                  {
                      Console.WriteLine(kvp.Key + " " + kvp.Value);
                  }
                  Console.ReadLine(); */

                //q11





                //q12
                /* int[] arr = new int[3] {89,67,56};
                int i, maximum, minimum, n;
                n = 3;
                maximum = arr[0];
                minimum = arr[0];
                for (i = 1; i < n; i++)
                {
                    if (arr[i] > maximum)
                    {
                        maximum = arr[i];
                    }
                    if (arr[i] < minimum)
                    {
                        minimum = arr[i];
                    }
                }
                Console.WriteLine("Maximum element is {0}\n", maximum);
                Console.WriteLine("Minimum element is {0}\n\n", minimum);
                Console.ReadLine(); */

                //q13
                /*nt[] arr = new int[] { 1, 3, 5, 200, 22, 2244, 213, 111 };
                 int res = 100;
                 Console.WriteLine("Given Integer {0}: ", res);
                 Console.WriteLine("Numbers larger than {0} = ", res);
                 for (int i = 0; i < arr.Length; i++)
                 {
                     if (arr[i] > res)
                     {
                         Console.WriteLine(arr[i]);
                         Console.ReadLine();
                     } 
                   } */
            }

        }
    }

    
