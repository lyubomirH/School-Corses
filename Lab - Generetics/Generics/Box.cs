using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Box<T>
    {
        private T[] internalArray;

        public Box() 
        {
             this.internalArray = new T[4];
        }

        public int Count { get; private set; }

        public void Add(T element)
        {
            if(this.internalArray.Length == this.Count)
            {
                T[] newArray = new T[this.internalArray.Length * 2];
                for(int i = 0; i < this.Count; i++)
                {
                    newArray[i] = this.internalArray[i];
                }
                this.internalArray = newArray;
            }
            this.internalArray[this.Count]
        }

        public T Remove()
        {
            T element = this.internalArray[this.Count - 1];
            this.Count--;
            return ...
        }
    }
}
