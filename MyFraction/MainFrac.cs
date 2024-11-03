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
            MyFrac fr = new(4, 8);
            Console.WriteLine(MyFrac.ToStringWithIntPart(fr));
        }
          
    }
}
