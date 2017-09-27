using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class QueueWithList<T>
{
    private const int MIN_CAPACITY = 4;

    private T[] buffer;
    private int startIndex;
    private int size;
    private int endIndex;

    public QueueWithList()
    {
        buffer = null;
        startIndex = 0;
        size = 0;
        endIndex = 0;
    }

    public int Size => size;
    public bool Empty => size == 0;
    public T Front => buffer[startIndex];

    private int NextIndex(int index)
    {
        ++index;
        if (index == buffer.Length)
        {
            index = 0;
        }
        return index;
    }


    public void Reserve(int newSize)
    {
        if (newSize<size)
        {
            return;
        }

        var newBuffer = new T[newSize];
        for (int i = 0, j =startIndex; i < size; i++,j=NextIndex(j))
        {
            newBuffer[i] = buffer[j];
        }
        startIndex = 0;
        endIndex = size;
        buffer = newBuffer;
    }



    public void Push(T value)
    {
        if (buffer==null)
        {
            buffer = new T[MIN_CAPACITY];
        }
        else if (size==buffer.Length)
        {
            Reserve(size * 2);
        }
        buffer[endIndex] = value;
        endIndex = NextIndex(startIndex);
        ++size;
    }


    public void Pop()
    {
        buffer[startIndex] = default(T);
        startIndex = NextIndex(startIndex);
        --size;
    }

}

