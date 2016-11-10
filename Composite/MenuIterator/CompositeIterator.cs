using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuIterator
{
    class CompositeIterator : IEnumerator
    {
        Stack stack = new Stack();

        public CompositeIterator(IEnumerator iterator)
        {
            stack.Push(iterator);
        }
        public object Current
        {
            get 
            {
                if (MoveNext())
                {
                    IEnumerator iterator = (IEnumerator)stack.Peek();
                    MenuComponent component = (MenuComponent)iterator.Current;
                    Console.WriteLine("遍历顺序：" + component.GetName());
                    if (component is Menu)
                    {
                        stack.Push(component.GetEnumerator());
                    }
                    return component;
                }
                else
                    return null;
            }
        }

        public bool MoveNext()
        {
            if (stack.Count == 0)
                return false;
            else
            {
                IEnumerator iterator = (IEnumerator)stack.Peek();
                if (!iterator.MoveNext())
                {
                    stack.Pop();
                    return MoveNext();
                }
                else
                {
                    return true;
                }
            }
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}
