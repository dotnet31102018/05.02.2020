using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDP
{
    class Program
    {
        static void Main(string[] args)
        {
            IPizza basePizza = new BasePizza();
            IPizza tomato = new TomatoTopping(basePizza);
            IPizza pine = new PineaappleTopping(tomato);
            //Console.WriteLine(pine.GetDetails());
            //Console.WriteLine(pine.GetPrice());

            IPizza pineTomatoBase = new PineaappleTopping(new TomatoTopping(new BasePizza()));
            Console.WriteLine(pineTomatoBase.GetDetails());
            Console.WriteLine(pineTomatoBase.GetPrice());

        }
    }
}
