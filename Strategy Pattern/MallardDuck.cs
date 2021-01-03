using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            flyBehavior = new FlyWithWings();
            quackBehaviour = new Quack();
        }
        public override void Display()
        {
            Console.WriteLine("I am a real mallard duck");
        }
    }
}
