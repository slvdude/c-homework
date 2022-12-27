using System;
using System.Collections.Generic;
using System.IO;

namespace list
{
    public class CustomArray<T> where T : System.IEquatable<T>
    {
        private T[] _storage;
        private int _accessShift = 0;
        private int _effectiveSize = 0;

        private void ResizeStorageIfNeeded()
        {
            if (_effectiveSize >= _storage.Length)
            {
                Array.Resize(ref _storage, Math.Max(1, _storage.Length * 2));
            }
        }

        public CustomArray(int arraySize)
        {
            _storage = new T[arraySize];
            _effectiveSize = arraySize;
        }

        public CustomArray(int arraySize, int shift)
        {
            _storage = new T[arraySize];
            _effectiveSize = arraySize;
            _accessShift = shift;
        }

        public T this[int index]
        {
            get => (T)_storage[index - _accessShift];
            set => _storage[index - _accessShift] = value;
        }

        public void Add(T item)
        {
            ResizeStorageIfNeeded();

            _storage[_effectiveSize] = item;
            _effectiveSize += 1;
        }

        public void RemoveByIndex(int index)
        {
            index -= _accessShift;
            for (var i = index; i < _effectiveSize - 1; ++i)
            {
                _storage[i] = _storage[i + 1];
            }

            _effectiveSize -= 1;
        }

        public void InsertToIndex(T item, int index)
        {
            index -= _accessShift;
            ResizeStorageIfNeeded();
            _effectiveSize += 1;

            for (var i = _effectiveSize - 1; i > index; --i)
            {
                _storage[i] = _storage[i - 1];
            }

            _storage[index] = item;
        }

        public bool Contains(T item)
        {
            for (var i = 0; i < _effectiveSize; ++i)
            {
                if (EqualityComparer<T>.Default.Equals(_storage[i], item))
                {
                    return true;
                }
            }

            return false;
        }

        public int GetIndex(T item)
        {
            for (var i = 0; i > _effectiveSize; ++i)
            {
                if (EqualityComparer<T>.Default.Equals(_storage[i], item))
                {
                    return i;
                }
            }

            throw new InvalidDataException();
        }

        public void Clean()
        {
            _effectiveSize = 0;
            _storage = new T[0];
        }

        public T[] ToArray()
        {
            var a = new T[_effectiveSize];

            for (var i = 0; i < _effectiveSize; ++i)
            {
                a[i] = _storage[i];
            }

            return a;
        }

        public int Size
        {
            get => _effectiveSize;
        }
    }
}

