using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public interface QuackBehaviour
    {
        void Quack();
    }

    public class Quack : QuackBehaviour
    {
        void QuackBehaviour.Quack()
        {
            Console.WriteLine("I can Quack");
        }
    }

    public class Squeak : QuackBehaviour
    {
        void QuackBehaviour.Quack()
        {
            Console.WriteLine("Squeak");
        }
    }

    public class MuteQuack : QuackBehaviour
    {
        void QuackBehaviour.Quack()
        {
            Console.WriteLine("Silence");
        }
    }
}
