using System;
using LibraryClasses;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryClasses.Classes;
using LibraryClasses.Interfaces;

namespace PatternBook
{
    class Program
    {
        static void Main(string[] args)
        {
            MallardDuck MD = new MallardDuck();
            DecoyDuck DD = new DecoyDuck();
            RedHeadDuck RD = new RedHeadDuck();
            RubberDuck RubbD = new RubberDuck();

            IQuackBehavior Dquack = new DQuack();
            IQuackBehavior MuteQuack = new MuteQuack();
            IQuackBehavior Squeak = new Squeak();

            IFlyBehavior FlyWithWings = new FlyWithWings();
            IFlyBehavior NoFly = new NoFly();

            MD.flyBehavior = FlyWithWings;
            MD.quackBehavior = Dquack;

            DD.flyBehavior = NoFly;
            DD.quackBehavior = MuteQuack;

            RD.flyBehavior = FlyWithWings;
            RD.quackBehavior = Dquack;

            RubbD.flyBehavior = NoFly;
            RubbD.quackBehavior = Squeak;

            Duck[] ducks = new Duck[] { MD, DD, RD, RubbD };
            foreach (Duck duck in ducks)
            {
                Console.WriteLine(duck.display());
                Console.WriteLine(duck.swim());
                Console.WriteLine(duck.perfomFly());
                Console.WriteLine(duck.perfomQuack());
            }
            Console.ReadKey();
        }
    }
}
