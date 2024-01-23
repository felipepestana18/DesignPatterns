using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaFactoryMethod
{
    internal class PizzaFactoryRJ : PizzaFactoryMethodd
    {
        protected override Pizza CriarPizza(string tipo)
        {
            Pizza pizza;

            switch (tipo.ToUpper())
            {
                case "M":
                    pizza = new PizzaMussarelaRJ();
                    break;
                case "C":
                    pizza = new PizzaCalabresaRJ();
                    break;
                default:
                    pizza = null;
                    break;
            }
            return pizza;
        }
    }
}
