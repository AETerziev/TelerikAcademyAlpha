using System;
using System.Collections.Generic;

namespace Defining_Classes___Part_2
{
    public class GenericList<T>
        where T : IComparable<T>, IEnumerable<T>
    {
        private List<T> elements;   
        private List<T> tempElements;

        public GenericList(int capacity = 5)
        {
            this.elements = new List<T>(capacity);
        } 

        public void AddElement(T element)
        {
            if (this.elements.Count == 6)
            {
                tempElements.AddRange(elements);
                elements = new List<T>(elements.Count * 2);

            }
            this.elements.Add(element);
        } 

        public T AccessElement(int index)
        {
            if (index < 0 || index > 6)
            {
                throw new ArgumentOutOfRangeException("The index mustb e between 0 abd 6");
            }
            return this.elements[index];
        }

        public void RemoveElement(int index)
        {
            if (index < 0 || index > 6)
            {
                throw new ArgumentOutOfRangeException("The index mustb e between 0 abd 6");
            }
            this.elements.RemoveAt(index);
        }

        public void InsertElement(int index, T item)
        {
            if (index < 0 || index > 6)
            {
                throw new ArgumentOutOfRangeException("The index mustb e between 0 abd 6");
            }
            if (item == null)
            {
                throw new ArgumentNullException("You must put an instance of the item");
            }
            this.elements.Insert(index, item);
        }

        public void ClearElements()
        {

            this.elements.Clear();
        }

        public T FindElementByValue(T value)
        {
            return this.elements.Find(x => x.CompareTo(value) == 0);
        } 

        public override string ToString()
        {
            return String.Join(" ", elements.ToArray());
        }

        public T Min()
        {
            T minValue = default(T); 
            foreach (var item in elements)
            {
                if (item.CompareTo(minValue) < 0)
                {
                    minValue = item;
                    break;
                }
            }
            return minValue;
        }

        public T Max()
        {
            T maxValue = default(T);
            foreach (var item in elements)
            {
                if (item.CompareTo(maxValue)>1)
                {
                    maxValue = item;
                }
            }
            return maxValue;
        }


    }
}

