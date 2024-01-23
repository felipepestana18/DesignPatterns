// 
using PizzaFactoryMethod;

Console.WriteLine("Digite ou Local da Pizzaria SP ou RJ");
string local = Console.ReadLine().ToUpper();

Console.WriteLine("Digite o tipo de pizza que gostaria (M) para mussarela, (C) para calabresa");
string tipo = Console.ReadLine().ToUpper();


PizzaFactoryMethodd pizzaria = PizzaSimpleFactory.CriarPizzaria(local);
Pizza pizza = pizzaria.MontarPizza(tipo);

pizza.PrepararPizza();
pizza.FinalizadoPizza();