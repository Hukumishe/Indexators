using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexators
{
    class MyArray : IEnumerable
    {
        int[] arr;

        public MyArray(int size)
        {
            arr = new int[size];
        }

        public int this[int index]
        {
            get
            {
                return arr[index];
            }

            set
            {
                arr[index] = value * value;
            }
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
