using System;
using System.Collections;
using System.Collections.Generic;

namespace CustomList
{
    public class CustomList<T> : IEnumerable<T>
    {
        private T[] buffer;
        private int size;
        private const int minCapacity = 4;

        public CustomList()
        {
            buffer = null;
            size = 0;
        }

        public int Size => size;
        public int Capacity => buffer.Length;

        public T Last
        {
            get
            {
                return buffer[size - 1];
            }
            set
            {
                buffer[size - 1] = value;
            }
        }

        public void Reserve(int newSize)
        {
            if (newSize<size)
            {
                return;
            }

            var newBuffer = new T[newSize];
            for (int i = 0; i < size; i++)
            {
                newBuffer[i] = buffer[i];
            }
            buffer = newBuffer;
        }


        public void PushBack(T value)
        {
            if (buffer==null)
            {
                buffer = new T[minCapacity];
            }
            else if (size == buffer.Length)
            {
                Reserve(size * 2);
            }
            buffer[size] = value;
            ++size;
        }

        public void Add(T value)
        {
            PushBack(value);
        }

        public void  InsertAt(int index, T value)
        {
            if (index==size)
            {
                PushBack(value);
                return;
            }

            PushBack(Last)
        }



        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
