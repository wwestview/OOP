using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFraction
{
     class MainFrac
    {
        static void Main()
        {
            MyFrac f1 =  new(12, 4);
            MyFrac f2 = new(4, 8);
            Console.WriteLine(MyFrac.DoubleValue(f1));
            Console.WriteLine(f1 + f2);
            Console.WriteLine(f1 - f2);
            Console.WriteLine(f1 * f2);
            Console.WriteLine(f1 / f2);
            Console.WriteLine(MyFrac.ToStringWithIntPart(f1));
        }
          
    }
}
