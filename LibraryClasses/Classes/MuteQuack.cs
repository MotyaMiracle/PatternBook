using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryClasses.Interfaces;

namespace LibraryClasses.Classes
{
    public class MuteQuack : IQuackBehavior
    {
        public string quack()
        {
            return "";
        }
    }
}
