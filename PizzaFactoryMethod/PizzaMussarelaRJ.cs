using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaFactoryMethod
{
    public class PizzaMussarelaRJ : Pizza
    {
        public PizzaMussarelaRJ()
        {
            Nome = "Mussarela RJ";
            Preco = 10;
            massa = "Batata";
            ingredientes.Add("Tomate");
            ingredientes.Add("Azeitona");
            ingredientes.Add("Finagrete");
        }

    }
}
