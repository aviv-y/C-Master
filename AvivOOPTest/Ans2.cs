using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvivOOPTest
{
    public interface ICar
    {
        void Stop(ref float speed);
    }

    public class PrivateCar:ICar
    {
        public void Stop(ref float s)
        {
            s = 0;
        }
    }

    public class Mazda
    {
        public void AttributeCar(ICar c)
        {
            float speed = 120;
            c.Stop(ref speed);
        }
    }
    internal class Ans2
    {
        ICar c;
        public void Run()
        {
            Mazda mazda = new Mazda();  
            mazda.AttributeCar(c);
        }
    }
}
