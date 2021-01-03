using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public interface FlyBehavior
    {
        void Fly();
    }

    public class FlyWithWings : FlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Flying With Wings");
        }
    }

    public class FlyNoWay : FlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Not Flying");
        }
    }
}