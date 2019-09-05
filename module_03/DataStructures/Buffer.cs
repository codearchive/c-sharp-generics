using System.Collections;
using System.Collections.Generic;

namespace DataStructures
{
    public class Buffer<T> : IBuffer<T>
    {
        public Queue<T> _queue = new Queue<T>();

        public virtual bool IsEmpty => _queue.Count == 0;

        public virtual void Write(T value)
        {
            _queue.Enqueue(value);
        }

        public virtual T Read()
        {
            return _queue.Dequeue();
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in _queue)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
