using System;
using LibraryClasses.Interfaces;

namespace LibraryClasses
{
    abstract public class Duck
    {
        public IFlyBehavior flyBehavior { get; set; }
        public IQuackBehavior quackBehavior { get; set; }

        public string perfomFly()
        {
            return flyBehavior.fly();
        }
        public string perfomQuack()
        {
            return quackBehavior.quack();
        }
        
        public string swim()
        {
            return "Буль буль буль";
        }
        abstract public string display();
    }
}
