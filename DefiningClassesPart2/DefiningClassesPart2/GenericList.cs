using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPart2
{
    public class GenericList<T>
    {
        private T[] elements;
        private int count = 0;

        public int Count
        {
            get { return count; }
            set { count = value; }
        }

        public GenericList(int capacity)
        {
            elements = new T[capacity];
        }

        #region Methods

        public void Add(T element)
        {
            if (count >= elements.Length)
            {
                throw new IndexOutOfRangeException(String.Format(
                    "The list capacity of {0} was exceeded.", elements.Length));
            }
            this.elements[count] = element;
            count++;
        }

        public void RemoveAt(int index)
        {
            if (index >= this.count || index < 0)
            {
                throw new IndexOutOfRangeException(String.Format(
                   "The index {0} is out of range! The index should be in the range [0...{1}]", index, this.count - 1));
            }

            var tempElements = new List<T>();
            for (int ind = 0; ind < count; ind++)
            {
                if (ind == index)
                    continue;
                tempElements.Add(this.elements[ind]);
            }
            this.count--;
            this.elements = tempElements.ToArray();
        }

        public void InsertElementAt(T element, int index)
        {
            if (index >= this.count || index < 0)
            {
                throw new IndexOutOfRangeException(String.Format(
                   "The index {0} is out of range! The index should be in the range [0...{1}]", index, this.count - 1));
            }
            this.count++;
            var tempElements = this.elements.ToList<T>();
            tempElements.Insert(index, element);
            this.elements = tempElements.ToArray();
        }

        public void ClearList()
        {
            this.elements = new T[this.count];
        }

        public T GetElementByValue(T val)
        {
            foreach (T element in this.elements)
            {
                if (element.Equals(val))
                    return element;
            }
            return default(T);
        }

        public T this[int index]
        {
            get
            {
                if (index >= count)
                {
                    throw new IndexOutOfRangeException(String.Format(
                        "Invalid index: {0}.", index));
                }
                T result = elements[index];
                return result;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (T element in this.elements)
            {
                sb.Append(String.Format("{0}\t", element));
            }
            return sb.ToString();
        }

        #endregion
    }
}
