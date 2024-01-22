using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaSimpleFactory
{
    public class PizzaMussarela : Pizza
    {

        public PizzaMussarela()
        {
            Nome = "Mussarela";
        }
        public override void Assar(int tempo)
        {
            Console.WriteLine($"Assando a pizza {Nome} em {tempo}");
        }

        public override void Embalar()
        {
            Console.WriteLine($"Embalando a Pizza {Nome}");
        }

        public override void Preparar()
        {
            Console.WriteLine($"Preparando a Pizza {Nome}");
        }
    }
}
