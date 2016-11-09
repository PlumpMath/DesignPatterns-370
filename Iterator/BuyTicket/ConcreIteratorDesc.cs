using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyTicket
{
    class ConcreIteratorDesc : Iterator
    {
        private ConcreteAggregate aggregate;
        private int current = 0;

        public ConcreIteratorDesc(ConcreteAggregate aggregate)
        {
            this.aggregate = aggregate;
            current = aggregate.Count - 1;
        }
        public override object First()
        {
            return aggregate[aggregate.Count - 1];
        }

        public override object Next()
        {
            object ret = null;
            current--;
            if (current >=0)
            {
                ret = aggregate[current];
            }
            return ret;
        }

        public override bool IsDone()
        {
            return current < 0 ? true : false;
        }

        public override object CurrentItem()
        {
            return aggregate[current];
        }
    }
}
