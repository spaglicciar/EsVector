using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsVector
{
    class CustomArray
    {
        private int[] arr = new int[100];

        public int this[int index]
        {
            get
            {
                return (index < 0 || index >= 100) ? 0 : arr[index];
            }
            set
            {
                if (index >= 0 && index < 100)
                {
                    arr[index] = value;
                }
            }
        }
    }
}
