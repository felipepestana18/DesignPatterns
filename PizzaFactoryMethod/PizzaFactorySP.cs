using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaFactoryMethod
{
    public class PizzaFactorySP : PizzaFactoryMethodd
    {
        protected override Pizza CriarPizza(string tipo)
        {
            Pizza pizza;

            switch(tipo.ToUpper())
            {
                case "M":
                    pizza = new PizzaMussarelaSP();
                    break;
                case "C":
                    pizza = new PizzaCalabresaSP();
                    break;
                default:
                    pizza = null;
                    break;

            }
            return pizza;
        }
    }
}
