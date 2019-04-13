using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example3
{
    class Program
    {
        static void Main(string[] args)
        {
            int qty,cost,totalco;
            float finalc;
            Console.Write("enter the quantity");
            qty = int.Parse(Console.ReadLine());
            Console.Write("enter the cost");
            cost = int.Parse(Console.ReadLine());
            totalco = cost * qty;
            if (qty>100)
            {
                finalc = totalco - (0.1f * totalco);
            }
            else
            {
                finalc = totalco;
            }
            Console.Write("final amt is "+finalc+"FOR "+qty );


        }
    }
}
