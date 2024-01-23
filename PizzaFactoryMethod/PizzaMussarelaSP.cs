using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaFactoryMethod
{
    public class PizzaMussarelaSP : Pizza
    {

        public PizzaMussarelaSP()
        {
            Nome = "Mussarela SP";
            Preco = 10;
            massa = "Batata";
            ingredientes.Add("Tomate");
            ingredientes.Add("Azeitona");
            ingredientes.Add("Finagrete");

        }
    }
}
