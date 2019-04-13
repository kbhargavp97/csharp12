using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example2basic
{
    class Program
    {
        static void Main(string[] args)
        {
            //let us take  two input in a single line
            int n1, n2, result;
            Console.Write("enter the number using space");
            string s = Console.ReadLine();

            //spit the string by space
            string[] inputs = s.Split();
            n1 = int.Parse(inputs[0]);
            n2 = int.Parse(inputs[1]);

            result = n1 + n2;
            Console.WriteLine("num1:{0}\t  num2={1}\t sum={2}", n1, n2, result);


        }
    }
}



