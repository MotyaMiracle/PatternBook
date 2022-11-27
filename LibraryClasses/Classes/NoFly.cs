using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryClasses.Interfaces;

namespace LibraryClasses.Classes
{
    public class NoFly : IFlyBehavior
    {
        public string fly()
        {
            return "";
        }
    }
}
