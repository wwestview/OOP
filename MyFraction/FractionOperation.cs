using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    partial class MyFrac
    {
       public static double DoubleValue(MyFrac f)
        {
            return (double)f.nom/f.denom;
        }
    }
