using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu1
{
    class PancakeIterator : Iterator
    {
        ArrayList items;
        int position;

        public PancakeIterator(ArrayList items)
        {
            this.items = items;
        }
        public bool HasNext()
        {
            if (position < items.Count)
                return true;
            else
                return false;
        }

        public object Next()
        {
            object item = items[position];
            position++;
            return item;
        }
    }
}
