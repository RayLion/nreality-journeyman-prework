using System;

namespace DataStructures
{
    public class CustomList<T>
    {
        private T[] _itemsArray = new T[0];
        private int _sizeOfArray = 0;
        private int _currentSize = 0;

        public void AddItem(T item)
        {
            if (ArrayShouldBeResized)
                ResizeArray();

            _itemsArray[_currentSize] = item;
            _currentSize++;
            _sizeOfArray++;
        }

        public void RemoveItem(T item)
        {
            CheckIfListIsEmpty();
            var newArray = RemoveItemFromArray(item);
            _itemsArray = newArray;
            _currentSize--;
            _sizeOfArray--;
        }

        public int Count
        {
            get { return _sizeOfArray; }
        }

        public void Clear()
        {
            _currentSize = 0;
            _sizeOfArray = 0;
        }

        public T First
        {
            get { return _itemsArray[0]; }
        }

        public void RemoveFirst()
        {
            RemoveItem(First);
        }

        private T[] RemoveItemFromArray(T item)
        {
            var newArray = new T[_sizeOfArray];
            var targetIndex = 0;
            var removeIndex = Array.IndexOf(_itemsArray, item);

            for (int index = 0; index < _sizeOfArray; index++)
            {
                if (index != removeIndex)
                {
                    newArray[targetIndex] = _itemsArray[index];
                    targetIndex++;
                }
            }

            return newArray;
        }

        private void CheckIfListIsEmpty()
        {
            if (_sizeOfArray == 0)
                throw new InvalidOperationException("The list is empty");
        }

        private void ResizeArray()
        {
            int newLength = DoubleSizeOfArray();
            var newArray = CopyDataToNewArray(newLength);
            _itemsArray = newArray;
        }

        private int DoubleSizeOfArray()
        {
            return (_sizeOfArray == 0) ? 4 : _sizeOfArray * 2;
        }

        private bool ArrayShouldBeResized
        {
            get { return _itemsArray.Length == _sizeOfArray; }
        }

        private T[] CopyDataToNewArray(int newLenth)
        {
            var newArray = new T[newLenth];

            for (int index = 0; index < _itemsArray.Length; index++)
            {
                newArray[index] = _itemsArray[index];
            }

            return newArray;
        }
    }
}