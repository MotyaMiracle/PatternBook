using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryClasses
{
    public abstract class Pizza
    {
        public Pizza(string n)
        {
            this.Name = n;
        }

        public string Name { get; protected set; }
        public abstract int GetCost();
    }
}
