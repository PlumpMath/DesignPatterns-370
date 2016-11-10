using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuIterator
{
    class NullIterator : IEnumerator
    {
        //这是一个空的迭代器，为了保持组合的透明性而添加进去的
        //这样遍历的时候就不用区分叶子节点跟分支节点

        public object Current
        {
            get { return null; }
        }

        public bool MoveNext()
        {
            return false;
        }

        public void Reset()
        {
            throw new InvalidOperationException();
        }
    }
}
