using System;
using System.Collections.Generic;
using System.Text;

namespace practice_csharp_feature
{
    public class GenericStack<T> 
    {
        T [] stack;
        int top;

        public GenericStack()
        {
            stack = new T [85];
           
            top = -1;
        }

        public GenericStack(T size)
        {
            //stack = new T [(int)(object)size];
            
            stack = new T[Convert.ToInt32(size)];
            
            top = -1;
        }

        public void Push(T item)
        {
            stack[++top] = item;
        }

        public T Pop()
        {
            var value = stack[top];
            top -= 1;
            return value;
        }
    }
}
