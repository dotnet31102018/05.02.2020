using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDP
{
    public class HalfPrizePizza : ToppingDecoratorBase
    {
        public HalfPrizePizza(IPizza pizza) : base(pizza)
        {
        }

        public override string GetDetails()
        {
            return pizza.GetDetails() + " Look! half price!";
        }

        public override double GetPrice()
        {
            return this.pizza.GetPrice() / 2.0;
        }
    }
}