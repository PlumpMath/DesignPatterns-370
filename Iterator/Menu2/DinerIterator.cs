using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu2
{
    class DinerIterator : IEnumerator
    {
        MenuItem[] items;
        int position = 0;

        public DinerIterator(MenuItem[] items)
        {
            this.items = items;
        }
        public object Current
        {
            get 
            {
                object item = items[position];
                position++;
                return item;
            }
        }

        public bool MoveNext()
        {
            if (position >= items.Length || items[position] == null)
                return false;
            else
                return true;
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}
