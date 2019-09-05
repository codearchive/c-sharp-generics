namespace DataStructures
{
    public class CircularBuffer<T> : Buffer<T>
    {
        private int _capacity;
        public CircularBuffer()
            : this(capacity: 10)
        {
        }

        public CircularBuffer(int capacity)
        {
            _capacity = capacity;
        }

        public override void Write(T value)
        {
            base.Write(value);
            if (_queue.Count > _capacity)
            {
                _queue.Dequeue();
            }
        }

        public bool IsFull
        {
            get { return _queue.Count == _capacity; }
        }
    }
}
