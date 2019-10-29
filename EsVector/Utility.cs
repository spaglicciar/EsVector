using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsVector
{
    static class Utility
    {
        public static void ModifyVector(ref SVector v, double d)
        {
            v.vx = d; //modificare il vx di v con d
        }
    }
}
