﻿using System;
using System.Globalization;
using ClassLibrary1;

namespace augg24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("compare string");
            Class1.print();
            

               /*   DateTime dt1 = new DateTime();
                    dt1 = Convert.ToDateTime(Console.ReadLine());
                    Console.WriteLine("enter your bday date");
                    DateTime now = DateTime.Today;
                    int age = now.Year - dt1.Year;
                    if (dt1 > now.AddYears(-age))
                        age--;

                    Console.WriteLine("age= "+age);
                    Console.WriteLine("day = " + dt1.Day);
                    Console.WriteLine("month = " +dt1.Month);
                    Console.WriteLine("year = " + dt1.Year);
                    Console.WriteLine("week = " + dt1.DayOfWeek);


                    bool isLeapYear = DateTime.IsLeapYear(dt1.Year);
                    Console.WriteLine("leap year or not "+isLeapYear);



                    Console.ReadLine();   */

                //Console.WriteLine("enter the string");
                //myapp.printstring();
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("string copy from s1 to s2 ");
                Class2.copys();
                Console.WriteLine("-----------------------------------");
                Class3.splits();
                Console.WriteLine("-----------------------------------");
                Class4.upper();
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("new file is created");
                Class5.file();
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("date properities");
                Class6.dateprop();
                Console.WriteLine("-----------------------------------");
                Class7.index();
                Console.WriteLine("-----------------------------------");
        }
        }
    }

}
    }
}