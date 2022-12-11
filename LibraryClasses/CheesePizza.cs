using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace LibraryClasses
{
    public class CheesePizza : PizzaDecorator
    {
        public CheesePizza(Pizza pizza) : base(pizza.Name + ", с сыром", pizza)
        {

        }

        public override int GetCost()
        {
            return pizza.GetCost() + 5;
        }
    }
}
