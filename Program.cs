using System;
namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
           int num1, num2;

            int maxNum;
            Console.WriteLine("1.enter first number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second number");
            num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                maxNum = num1;
            }
            else
            {
                maxNum = num2;
            }
            Console.WriteLine("Maximum number is: " + maxNum);
            Console.WriteLine("===================================");

            //2.largest of three number

            int N1, N2, N3;
            Console.WriteLine("2.Enter three numbers: \n");

            N1 = Convert.ToInt32(Console.ReadLine());
            N2 = Convert.ToInt32(Console.ReadLine());
            N3 = Convert.ToInt32(Console.ReadLine());

            if (N1 >= N2)
            {
                if (N1 >= N3)
                    Console.WriteLine(N1 + " is the largest number");
                else
                    Console.WriteLine(N3 + " is the largest number");
            }

            else if (N2 >= N3)
                Console.WriteLine(N2 + " is the largest number");

            else
                Console.WriteLine(N3 + " is the largest number");
            Console.WriteLine("===================================");
            //3.comparing characters

            char c1, c2;

            Console.WriteLine("3.Enter the first character : ");
            c1 = Console.ReadLine()[0];

            Console.WriteLine("Enter the second character : ");
            c2 = Console.ReadLine()[0];

            if (c1 == c2)
                Console.WriteLine("Both characters are equal");
            else
                Console.WriteLine("Characters are not equal");
            Console.WriteLine("===================================");
            //4.strings equal or not

            string str1, str2;
            Console.WriteLine("4.enter first string");
            str1 = Console.ReadLine();
            Console.WriteLine("enter second string");
            str2 = Console.ReadLine();
            Console.WriteLine(str1 == str2);
            Console.WriteLine("===================================");
            //5.which is biggest
            int no1, no2;

            int biggest;
            Console.WriteLine("5.enter first number");
            no1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second number");
            no2 = Convert.ToInt32(Console.ReadLine());

            if (no1 > no2)
            {
                biggest = no1;
            }
            else
            {
                biggest = no2;
            }
            Console.WriteLine("biggest number is: " + biggest);
            Console.WriteLine("===================================");
            //6.check leap

            int year;
            Console.Write("6.Input an year : ");
            year = Convert.ToInt32(Console.ReadLine());

            if ((year % 400) == 0)
                Console.WriteLine("{0} is a leap year.\n", year);
            else if ((year % 100) == 0)
                Console.WriteLine("{0} is not a leap year.\n", year);
            else if ((year % 4) == 0)
                Console.WriteLine("{0} is a leap year.\n", year);
            else
                Console.WriteLine("{0} is not a leap year.\n", year);
            Console.WriteLine("===================================");
            //7.student marks
            double rl, phy, che, bio, total;
            double per;
            string nm, div;

            Console.Write("7.Roll Number of the student :");
            rl = Convert.ToInt32(Console.ReadLine());
            Console.Write("Name of the Student :");
            nm = Console.ReadLine();

            Console.Write("Physics : ");
            phy = Convert.ToInt32(Console.ReadLine());
            Console.Write("Chemistry : ");
            che = Convert.ToInt32(Console.ReadLine());
            Console.Write("Biology : ");
            bio = Convert.ToInt32(Console.ReadLine());

            total = phy + che + bio;
            per = total / 3;
            if (per >= 60)
                div = "First";
            else
            if (per < 60 && per >= 46)
                div = "Second";
            else
                if (per < 46 && per >= 35)
                div = "Third";
            else
                div = "Fail";

            Console.Write("\nRoll No : {0}\nName of Student : {1}\n", rl, nm);
            Console.Write("Marks in Physics : {0}\nMarks in Chemistry : {1}\nMarks in Biology : {2}\n", phy, che, bio);
            Console.Write("Total Marks = {0}\nPercentage = {1}\nDivision = {2}\n", total, per, div);
            Console.WriteLine("===================================");
            //8.pattern
            Console.WriteLine("8.pattern\n");
            for (int u = 1; u <= 5; ++u)
            {
                for (int j = 1; j <= u; ++j)
                {
                    Console.Write("*");
                }
                Console.WriteLine();

            }
            Console.WriteLine("===================================");
            //9.Write a program in C# Sharp to display the n
            //terms of odd natural number and their sum.

            int i, n, sum = 0;
            Console.Write("9.Enter number of terms : ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nThe odd numbers are :");
            for (i = 1; i <= n; i++)
            {
                Console.Write("{0} ", 2 * i - 1);
                sum += 2 * i - 1;
            }
            Console.Write("\nThe Sum of odd Natural Number upto {0} terms : {1} \n", n, sum);
            Console.WriteLine("===================================");

            //10.Write a program in C# Sharp to display the number in reverse order.
            //Go to the editor

            int N, reverse = 0, rem;
            Console.Write("10.Enter a number: ");
            n = int.Parse(Console.ReadLine());
            while (n!= 0)
            {
                rem = n % 10;
                reverse = reverse * 10 + rem;
                n /= 10;
            }
            Console.Write("Reversed Number: " + reverse);
            Console.WriteLine("\n===================================");
            //11.write all integer b/w 100-200
            int a, s = 0;
            Console.Write("\n11.Numbers between 100 and 200 : \n");
            for (a = 101; a < 200; a++)
            {
           
             Console.Write("{0}  ", a);
               s += a;
                
            }
            Console.Write("\n\nThe sum : {0} \n", s);
            Console.WriteLine("\n========================================");

            //12.

            int b,su = 0;

           Console.Write("Numbers between 100 and 200, divisible by 9 : \n");
            for (b= 101; b< 200; b++)
            {
                if (b% 9 == 0)
                {
                    Console.Write("{0}  ", b);
                    su += i;
                }
            }
            Console.Write("\n\nThe sum : {0} \n", su);
        }
    }
}