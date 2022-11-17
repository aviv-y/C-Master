using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvivOOPTest
{
    class Calc
    {
        public virtual int Calc2num(int n1, int n2)
        {
            return n1 + n2;
        }
    }

    class NewCalc:Calc
    {
        public override int Calc2num(int n1, int n2)
        {
            return n1-n2;
        }
    }
    internal class Ans4
    {
        NewCalc calc=new NewCalc();
        public void Run()
        {
            calc.Calc2num(5, 2);
        }
    }
}
