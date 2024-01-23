using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaFactoryMethod
{
    public class PizzaSimpleFactory
    {

        public static PizzaFactoryMethodd CriarPizzaria(string local)
        {
            PizzaFactoryMethodd pizzaria;

            switch (local)
            {
                case "SP":
                    pizzaria = new PizzaFactorySP();
                    break;
                case "RJ":
                    pizzaria = new PizzaFactoryRJ();
                    break;
                default:
                    pizzaria = null;
                    break;

            }
            return pizzaria;
        }
    }
}
