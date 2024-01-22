using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaSimpleFactory
{
    public class Pizzaria
    {

        public  void SolicitarPizza()
        {
            Console.WriteLine("Digite o sabor da Pizza: M para Mussarela, C para calabresa");
            string sabor = Console.ReadLine();

            Pizza pizza =  PizzaSimpleFactory.CriarPizza(sabor);
            pizza.Preparar();
            pizza.Assar(20);
            pizza.Embalar();
            Console.WriteLine("Pizza Finalizzada");

        }
    }
}
