using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvivOOPTest
{
    interface IArea
    {
        double area(); 
    }
    class Circle:IArea
    {
        public double area()
        {
            double radius= Convert.ToDouble( Console.ReadLine());
            return radius *3.14;
        }
    }
    class Square : IArea
    {
        public double area()
        {
            double h = Convert.ToDouble(Console.ReadLine());
            double w = Convert.ToDouble(Console.ReadLine());
            return h*w;
        }
    }

    class Factory
    {
        Square square = new Square();
        Circle circle = new Circle();
        public void GoTo()
        {
            Console.WriteLine("Area of what shape you want to calculate?: ");
            string ansU= Console.ReadLine();
            if(ansU=="square")
                square.area();
            if (ansU == "circle")
                circle.area();
            else
                Console.WriteLine("sorry, i don't have this shape!");
                
        }
        
    }
    internal class Ans6
    {
        Factory factory = new Factory();
        public void Run()
        {
            factory.GoTo();
        }
    }
}
