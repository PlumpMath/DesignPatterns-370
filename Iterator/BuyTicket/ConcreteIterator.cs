using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyTicket
{
    class ConcreteIterator : Iterator
    {
        private int current = 0;
        private ConcreteAggregate concreteAggregate;

        public ConcreteIterator(ConcreteAggregate concreteAggregate)
        {
            // TODO: Complete member initialization
            this.concreteAggregate = concreteAggregate;
        }
        public override object First()
        {
            return concreteAggregate[0];
        }

        public override object Next()
        {
            object ret = null;
            current++;
            if (current < concreteAggregate.Count)
            {
                ret = concreteAggregate[current];
            }
            return ret;
        }

        public override bool IsDone()
        {
            return current >= concreteAggregate.Count ? true : false;
        }

        public override object CurrentItem()
        {
            return concreteAggregate[current];
        }
    }
}
