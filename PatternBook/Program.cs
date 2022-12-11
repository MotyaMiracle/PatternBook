using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryClasses;

namespace PatternBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizza pizza1 = new ItalianPizza();
            pizza1 = new TomatoPizza(pizza1); // Итальянская пицца с томатами
            Console.WriteLine($"Название: {pizza1.Name}");
            Console.WriteLine($"Стоимость: {pizza1.GetCost()}");

            Pizza pizza2 = new ItalianPizza();
            pizza2 = new CheesePizza(pizza2); // Итальянская пицца с сыром
            Console.WriteLine($"Название: {pizza2.Name}");
            Console.WriteLine($"Стоимость: {pizza2.GetCost()}");

            Pizza pizza3 = new BulgerianPizza();
            pizza3 = new TomatoPizza(pizza3);
            pizza3 = new CheesePizza(pizza3); // Болгарская пицца с томатами и сыром
            Console.WriteLine($"Название: {pizza3.Name}");
            Console.WriteLine($"Стоимость: {pizza3.GetCost()}");

            Console.ReadKey();
        }
    }
}
