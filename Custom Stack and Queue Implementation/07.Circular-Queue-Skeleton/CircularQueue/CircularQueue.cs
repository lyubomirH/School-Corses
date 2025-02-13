using System;

public class CircularQueue
{
    private const int InitialCapacity = 16;
    private int[] elements;
    private int startIndex;
    private int endIndex;

    public int Count { get; private set; }

    public CircularQueue(int capacity = InitialCapacity)
    {
        if (capacity <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(capacity), "Capacity must be positive.");
        }

        this.elements = new int[capacity];
        this.startIndex = 0;
        this.endIndex = 0;
        this.Count = 0;
    }

    public void Enqueue(int element)
    {
        if (this.Count == this.elements.Length)
        {
            Grow();
        }

        this.elements[this.endIndex] = element;
        this.endIndex = (this.endIndex + 1) % this.elements.Length;
        this.Count++;
    }

    public int Dequeue()
    {
        if (this.Count == 0)
        {
            throw new InvalidOperationException("Queue is empty.");
        }

        int result = this.elements[this.startIndex];
        this.startIndex = (this.startIndex + 1) % this.elements.Length;
        this.Count--;

        return result;
    }

    public int[] ToArray()
    {
        int[] result = new int[this.Count];
        for (int i = 0; i < this.Count; i++)
        {
            result[i] = this.elements[(this.startIndex + i) % this.elements.Length];
        }
        return result;
    }

    private void Grow()
    {
        int newCapacity = this.elements.Length * 2;
        int[] newElements = new int[newCapacity];

        for (int i = 0; i < this.Count; i++)
        {
            newElements[i] = this.elements[(this.startIndex + i) % this.elements.Length];
        }

        this.elements = newElements;
        this.startIndex = 0;
        this.endIndex = this.Count;
    }
}


class Example
{
    static void Main()
    {
        CircularQueue queue = new CircularQueue();

        queue.Enqueue(10);
        queue.Enqueue(20);
        queue.Enqueue(30);

        Console.WriteLine(string.Join(", ", queue.ToArray())); // Output: 10, 20, 30

        Console.WriteLine(queue.Dequeue()); // Output: 10
        Console.WriteLine(queue.Dequeue()); // Output: 20

        queue.Enqueue(40);
        queue.Enqueue(50);

        Console.WriteLine(string.Join(", ", queue.ToArray())); // Output: 30, 40, 50
    }
}
