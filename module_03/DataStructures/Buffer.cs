using System.Collections.Generic;

namespace DataStructures
{
    public class Buffer<T> : IBuffer<T>
    {
        Queue<T> _queue = new Queue<T>();

        public bool IsEmpty => _queue.Count == 0;

        public void Write(T value)
        {
            _queue.Enqueue(value);
        }

        public T Read()
        {
            return _queue.Dequeue();
        }
    }
}
