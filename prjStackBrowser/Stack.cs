using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjStackBrowser
{
    class Stack<T>
    {
        private T[] items;
        private int top;

        public Stack(int size)
        {
            items = new T[size];
            top = 0;
        }

        public void Push(T item)
        {
            if (top == 0)
            {
                throw new Exception("Stack Overflow");
            }
            items[top++] = item;
            top++;
        }
        public T Pop()
            {
                if (top == 0)
                {
                    throw new Exception("Stack Overfllow");
                }
                return items[top - 1];
            }

        public bool IsEmpty()
        {
            return top == 0;
        }

        public int Count
        {
            get { return top; }

        }

        public T[] ToArray()
        {
            T[] result = new T[top];
            for (int i = 0; i < top; i++)
            {
                result[i] = items[i];
            }
            return result;
        }
           
    }
}
