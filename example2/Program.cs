using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exampleBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            double d = 10.13;
            float x = 10.45f;
            Console.WriteLine("enter double type data");
            d = double.Parse(Console.ReadLine());
            Console.WriteLine("enter float type data");
            x = float.Parse(Console.ReadLine());

            Console.WriteLine("d:{0:00.00}\tx:{1}", d, x);//{0:00.00}//

        }
    }
}
