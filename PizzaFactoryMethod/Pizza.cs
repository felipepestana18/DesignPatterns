using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PizzaFactoryMethod
{
    public abstract class Pizza
    {
        public string Nome { get; set; }
        public int Preco { get; set; }
        public string massa { get; set; }
        public ArrayList ingredientes = new ArrayList();

        public void PrepararPizza()
        {
            Console.WriteLine($"---- Preprando a Pizza {Nome} com a masssa {massa} ----");
            foreach (var ingrediente in ingredientes)
            {
                Console.WriteLine($"Adicionando o Ingrediente {ingrediente}");
            }
        }

        public void FinalizadoPizza()
        {
            Console.WriteLine($"A Pizza {Nome} está pronta");
        }

    }
}
