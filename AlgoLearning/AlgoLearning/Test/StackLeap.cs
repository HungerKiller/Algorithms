using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoLearning.Test
{
    class MyStack
    {
        // keep these two fields as they​​​​​​‌​​​​​​‌​‌‌‌​‌​​​‌‌​‌‌​‌‌ are
        private Object[] elements;
        private int size = 0;

        public MyStack(int initialCapacity)
        {
            elements = new Object[initialCapacity];
        }

        public void Push(object o)
        {
            try
            {
                EnsureCapacity();
            }
            finally
            {
                //return;
            }
            elements[size++] = o;
        }

        public object Pop()
        {
            if (size == 0)
            {
                throw new InvalidOperationException();
            }
            var index = --size;
            var returnValue = elements[index];
            elements[index] = null;
            return returnValue;
        }

        private void EnsureCapacity()
        {
            if (elements.Length == size)
            {
                Object[] old = elements;
                elements = new Object[2 * size + 1];
                old.CopyTo(elements, 0);
            }
        }
    }
}
