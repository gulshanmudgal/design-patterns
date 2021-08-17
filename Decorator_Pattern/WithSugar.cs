using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern
{
    public class WithSugar : CondimentDecorator
    {
        Beverage beverage;

        public WithSugar(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override double GetCost()
        {
            return beverage.GetCost() + 0.25;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", With Sugar";
        }
    }
}
