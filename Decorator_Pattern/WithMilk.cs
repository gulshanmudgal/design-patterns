using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern
{
    public class WithMilk : CondimentDecorator
    {
        Beverage beverage;

        public WithMilk(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override double GetCost()
        {
            return beverage.GetCost() + 0.5;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", With Milk";
        }
    }
}
