using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class funcexer3
{
    public static int Sum(int num1, int num2)
    {
        int total;
        total = num1 + num2;
        return total;
    }

    public static void Main(string[] args)
    {
        //1
        Console.Write("Enter a number: ");
        int n1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter another number: ");
        int n2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("\nThe sum of two numbers is : {0} \n", Sum(n1, n2));
        //2
        int a, b;
        int sum;

        Console.Write("Enter first number: ");
        a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        b = Convert.ToInt32(Console.ReadLine());

        sum = addition(a, b);

        Console.WriteLine("Sum is: " + sum);
        //3.

        Employee john = new Employee("E01", "John", "001","50000");
        Console.WriteLine("Emp Number: " + john.eno);
        Console.WriteLine("Emp Name: " + john.ename);
        Console.WriteLine("Emp0 Position: " + john.deptno);
        Console.WriteLine("Emp salary: " + john.sal);
        Console.Read();


    }

    private static int addition(int a, int b)
    {
        throw new NotImplementedException();
    }
}
