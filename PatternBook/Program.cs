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
            Computer computer = new Computer();
            computer.Launch("Windows 10");
            Console.WriteLine(computer.OS.Name);

            // Не получится изменить ОС, так как объект уже создан
            computer.OS = OS.GetInstance("Windows 11");
            Console.WriteLine(computer.OS.Name);

            Console.ReadKey();
        }
    }
}
