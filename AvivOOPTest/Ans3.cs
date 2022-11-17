using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvivOOPTest
{
    internal class Ans3
    {
        public void Print(string s)
        {
            Console.WriteLine("this is your string: " + s);
        }
        public void Print(int iNum)
        {
            Console.WriteLine("this is your integer number: " + iNum);
        }
        public void Print(double dNum)
        {
            Console.WriteLine("this is your double number: " + dNum);
        }
        public void Print(int iNum, double dNum)
        {
            Console.WriteLine("this is your the product of the two numbers: " + iNum*dNum);
        }
        public void Print(int iNum, string s)
        {
            Console.WriteLine(s+ ": " + iNum );
        }

        public void Run()
        {
            Print("hello!!");
            Print(35);
            Print(1.25);
            Print(20, 12.568);
            Print(54, "this is my number");
        }
    }
}
