using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class3
    {
        public static void splits()
        {
            string text = "a b,c.d/e";
            Console.WriteLine("splitting " + text);

            string[] result = text.Split(' ', ',', '.', '/');

            foreach (string str in result)
            {
                Console.WriteLine(str);
            }

        }
    }
}
