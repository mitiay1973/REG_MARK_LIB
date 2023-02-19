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
            Console.WriteLine(class1.GetNextMarkAfter("В003ХА52"));
            Console.ReadKey();
        }
    }
}
