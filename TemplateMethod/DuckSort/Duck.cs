using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckSort
{
    class Duck : IComparable<Duck>
    {
        string name;
        int weight;

        public Duck(string name, int weight)
        {
            this.name = name;
            this.weight = weight;
        }

        public override string ToString()
        {
            return name + " weight " + weight;
        }
        public int CompareTo(Duck other)
        {
            if (this.weight < other.weight)
                return -1;
            else if (this.weight > other.weight)
                return 1;
            else
                return 0;
        }
    }
}
