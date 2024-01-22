using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaSimpleFactory
{

    public sealed class PizzaSimpleFactory
    {

        public static Pizza? CriarPizza(string tipo)
        {
            Pizza pizza;
            switch (tipo.ToUpper())
            {
                case "C":
                    pizza = new PizzaCalabresa();
                    break;
                case "M":
                    pizza = new PizzaMussarela();
                    break;
                default:
                    pizza = null;
                    break;
            }
            return pizza;
        }
    }
}
