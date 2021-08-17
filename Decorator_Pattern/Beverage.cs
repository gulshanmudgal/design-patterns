using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern
{
    public abstract class Beverage
    {
        public string description = String.Empty;

        public string GetDescription() => description;
        public abstract double GetCost();
    }
}
