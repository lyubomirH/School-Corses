using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementLinkedList
{
    public class LinkedList
    {
        private class Node
        {
            public object Element { get; set; }
            public Node Next { get; set; }

            public Node(object element, Node prevNode = null)
            {
                this.Element = element;
                if (prevNode != null)
                {
                    prevNode.Next = this;
                }
            }
        }

        private Node head;
        private Node tail;
        private int count;

        public LinkedList()
        {
            this.head = null;
            this.tail = null;
            this.count = 0;
        }

        public void Add(object item)
        {
            if (this.head == null)
            {
                this.head = new Node(item);
                this.tail = this.head;
            }
            else
            {
                this.tail = new Node(item, this.tail);
            }
            this.count++;
        }

        public object Remove(int index)
        {
            if (index < 0 || index >= this.count)
            {
                throw new ArgumentOutOfRangeException("Invalid index: " + index);
            }

            Node currentNode = this.head;
            Node previousNode = null;

            for (int i = 0; i < index; i++)
            {
                previousNode = currentNode;
                currentNode = currentNode.Next;
            }

            if (currentNode == this.head)
            {
                this.head = this.head.Next;
            }
            else
            {
                previousNode.Next = currentNode.Next;
            }

            if (currentNode == this.tail)
            {
                this.tail = previousNode;
            }

            this.count--;
            return currentNode.Element;
        }

        public int Remove(object item)
        {
            Node currentNode = this.head;
            Node previousNode = null;

            for (int i = 0; i < this.count; i++)
            {
                if (currentNode.Element.Equals(item))
                {
                    if (currentNode == this.head)
                    {
                        this.head = this.head.Next;
                    }
                    else
                    {
                        previousNode.Next = currentNode.Next;
                    }

                    if (currentNode == this.tail)
                    {
                        this.tail = previousNode;
                    }

                    this.count--;
                    return i;
                }

                previousNode = currentNode;
                currentNode = currentNode.Next;
            }

            return -1;
        }

        public int IndexOf(object item)
        {
            Node currentNode = this.head;
            for (int i = 0; i < this.count; i++)
            {
                if (currentNode.Element.Equals(item))
                {
                    return i;
                }
                currentNode = currentNode.Next;
            }
            return -1;
        }

        public bool Contains(object item)
        {
            return this.IndexOf(item) != -1;
        }

        public object this[int index]
        {
            get
            {
                if (index < 0 || index >= this.count)
                {
                    throw new ArgumentOutOfRangeException("Invalid index: " + index);
                }

                Node currentNode = this.head;
                for (int i = 0; i < index; i++)
                {
                    currentNode = currentNode.Next;
                }

                return currentNode.Element;
            }
        }

        public int Count
        {
            get { return this.count; }
        }
    }
}
