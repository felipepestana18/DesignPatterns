using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaFactoryMethod
{
    public class PizzaCalabresaSP : Pizza
    {

        public PizzaCalabresaSP()
        {
            Nome = "Calabresa de SP";
            Preco = 20;
            massa = "trigo";
            ingredientes.Add("Cebola");
            ingredientes.Add("Queijo");
        }
    }
}
