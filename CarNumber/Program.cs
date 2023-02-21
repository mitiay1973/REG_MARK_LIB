using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using REG_MARK_LIB;

namespace CarNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            REG_MARK_LIB.Class1 class1 = new REG_MARK_LIB.Class1();
            Console.WriteLine(class1.GetNextMarkAfterInRange("В003ХА52", "А001АА52", "Х999ХХ52"));
            Console.ReadKey();
        }
    }
}
