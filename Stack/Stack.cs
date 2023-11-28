using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class CustomStack<T>
    {
        public List<T> Stack = new List<T>();

        public T push(T item)
        {
            Stack.Add(item);
            return item;
        }
        public T pop()
        {
            T item = Stack[Stack.Count - 1];
            Stack.RemoveAt(Stack.Count - 1);
            return item;
        }
        public int size()
        {
            return Stack.Count;
        }
    }
}
