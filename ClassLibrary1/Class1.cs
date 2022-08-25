using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        public static void print()
        {
            string s1, s2;
            Console.WriteLine("enter 1st string");
            s1=Console.ReadLine();
            Console.WriteLine("enter 2nd string");
            s2= Console.ReadLine();
            if (s1.Equals(s2))
            {
                Console.WriteLine("str is equal");
            }
            else
            {
                Console.WriteLine("str is not equal");
            }
            Console.ReadLine();

        }
        


    }
}
