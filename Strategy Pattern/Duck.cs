using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public abstract class Duck
    {
        public FlyBehavior flyBehavior;
        public QuackBehaviour quackBehaviour;

        public Duck()
        {
        }

        public abstract void Display();

        public void PerformFly()
        {
            flyBehavior.Fly();
        }

        public void PerformQuack()
        {
            quackBehaviour.Quack();
        }

        public void Swim()
        {
            Console.WriteLine("Any Duck can Swim");
        }
    }
}
