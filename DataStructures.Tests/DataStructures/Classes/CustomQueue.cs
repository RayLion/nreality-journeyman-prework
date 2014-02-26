using System;

namespace DataStructures
{
    public class CustomQueue<T>
    {
        readonly CustomList<T> _items = new CustomList<T>();

        public void Enqueue(T item)
        {
            _items.AddItem(item);
        }

        public T Dequeue()
        {
            if (_items.Count == 0)
                throw new InvalidOperationException("The queue is empty.");

            var value = _items.First;
            _items.RemoveFirst();

            return value;
        }

        public T Peek()
        {
            if (_items.Count == 0)
                throw new InvalidOperationException("The queue is empty.");

            return _items.First;
        }

        public int Count
        {
            get { return _items.Count; }
        }

        public void Clear()
        {
            _items.Clear();
        }
    }
}