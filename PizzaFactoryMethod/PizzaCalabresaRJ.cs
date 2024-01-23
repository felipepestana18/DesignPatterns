using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaFactoryMethod
{
    public class PizzaCalabresaRJ : Pizza
    {

        public PizzaCalabresaRJ()
        {
            Nome = "Calabresa do RJ";
            Preco = 20;
            massa = "trigo";
            ingredientes.Add("Cebola");
            ingredientes.Add("Queijo");
        }
    }
}
