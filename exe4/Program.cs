using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe4
{
    class Program
    {
        static void Main(string[] args)
        {
            int marks;
            Console.Write("enter the avg marks\t");
            marks = int.Parse(Console.ReadLine());

            if(marks>=60)
            {
                Console.Write("A grade\t");
            }

           else if (marks >=50 && marks <=59)
            {
                Console.Write("b grade\t");
            }

           else if (marks >= 40 && marks<=49)
            {
                Console.Write("c grade\t");
            }

          else
            {
                Console.Write("fail\t");
            }
        }
    }
}
