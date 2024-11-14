using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Static_Implementation_of_a_List
{
    public class CustomArrayList
    {
        private static readonly int INITIAL_CAPACITY = 4;
        private object[] arr;
        private int count;
        public int Count
        {
            get { return count; }
            private set { count = value; }
        }

        public CustomArrayList()
        {
            arr = new object[INITIAL_CAPACITY];
            count = 0;
        }
        public void Add(object item)
        {
            if (Count == arr.Length)
            {
                Resize();
            }

            arr[Count] = item;


            Count++;
        }

        public void Insert(int index, object item)
        {
            if (Count == arr.Length)
            {
                Resize();
            }
            for (int i = arr.Length - 1; i > index; i--)
            {
                arr[i] = arr[i - 1];
            }
            arr[index] = item;
            Count++;
        }

        private void Resize()
        {
            object[] copy = new object[arr.Length * 2];
            Array.Copy(arr, copy, arr.Length);
            arr = copy;
        }

        public int IndexOf(object item)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Equals(item)) 
                {
                    return i;
                }
            }
            return -1;
        }
        public void Clear()
        {
        }
        public bool Contains(object item)
        {
        }
        public object this[int index]
        {
            get
            {
                if (index < 0  index >= Count)
                {
                    throw new ArgumentOutOfRangeException("Ivalid index: " + index);

                }
                return arr[index];
            }
            set
            {
                if (index < 0  index >= Count)
                {
                    throw new ArgumentOutOfRangeException("Ivalid index: " + index);
                }
                arr[index] = value;
            }
        }
        public object Remove(int index)
        {
            if (index >= Count || index < 0)
            {
                throw new ArgumentOutOfRangeException("Invalid index: " + index);
            }

            object item = arr[index];
            Shift(index);
            Count--;

            if (Count <= arr.Length / 2)
            {
                Shrink();
            }

            return item;
        }
        private void Shift(int index)
        {
            for (int i = index; i < arr.Length - 1; i++)
            {
                arr[i] = arr[i + 1];
            }
            arr[Count - 1] = null;
        }
        private void Shrink()
        {
            object[] copy = new object[arr.Length / 2];
            Array.Copy(arr, copy, copy.Length);
            arr = copy;
        }
        public int Remove(object item)
        {
            int index = Array.IndexOf(arr, item);

            if (index == -1)
            {
                return index;
            }

            Remove(index);
            return index;
        }
    }
}
