
using System;
using System.Collections;
namespace _7thsep
{
class Program
        {
        //1.calculate the length of the string
        //static void Main(string[] args)
        //{

        //    string str = "Amit";

        //    Console.WriteLine("String: " + str);
        //    Console.WriteLine("String Length: " + str.Length);
        //    Console.ReadKey();
        //}

        //6.Concatenate 2 strings using Delegates
        //static void Main()
        // {
        //    string str1 = "";
        //    string str2 = "";
        //    string str3 = "";

        //    Console.Write("Enter string1: ");
        //    str1 = Console.ReadLine();

        //    Console.Write("Enter string2: ");
        //    str2 = Console.ReadLine();

        //    str3 = String.Concat(str1, str2);
        //    Console.WriteLine("Concatenated string is: {0}", str3);
        // }

        //5) Create a employee class, having joiningYear as property
        public class Employee
        {
            public int id;
            public string name;
            public int dept_id;
            public int add_id;
            public int joining_date;
        }

        
      
            static void Main(string[] args)
            {

                // Enter data for Employee list
         List<Employee> employees = new List<Employee>()
         {
        new Employee{ id = 234, name = "sravan kumar",
                      dept_id = 1},
        new Employee{ id = 244, name = "Monika",
                      dept_id = 2},
        new Employee{ id = 734, name = "harsha",
                      dept_id = 1},
        new Employee{ id = 533, name = "komal",
                      dept_id = 4},
         };

                
   
              
            
}

    