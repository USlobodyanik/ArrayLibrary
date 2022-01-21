using System;
using System.Collections;
using System.Collections.Generic;

namespace ArrayLibrary
{
    public class ArrayList : IArrayList
    {
        private int[] _array;
        private int _currentCount;
        private const double _arrayCoefficient = 1.33;
        private const int _defaultSizeArray = 5;

        public int this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int Length => _currentCount;

        public ArrayList()
        {
            _array = new int[_defaultSizeArray];
            _currentCount = 0;
        }

        public ArrayList(int[] array)
        {
            int size = (int)(array.Length * _arrayCoefficient);
            _array = new int[size];
            _currentCount = array.Length;

            for (int i = 0; i < _currentCount; i++)
            {
                _array[i] = array[i];
            }
        }
        public void AddFront(int value)
        {
            AddByIndex(0, value);
        }

        public void AddBack(int value)
        {
            UpdateSize();
            _array[_currentCount++] = value;
        }

        public void AddBack(IArrayList arrayList)
        {
            var array = arrayList.ToArray();
            UpdateSize(array.Length);

            for (int i = _currentCount, j = 0; j < array.Length; i++, j++)
            {
                _array[i] = array[j];
            }

            _currentCount += array.Length;
        }

        public void AddByIndex(int index, int value)
        {
            UpdateSize(index);
            for (int i = _currentCount; i < index; i--)
            {
                _array[i] = _array[i - 1];
            }

            _array[index] = value;
            _currentCount++;
        }

        public void AddByIndex(int index, IArrayList arrayList)
        {
            throw new NotImplementedException();
        }

        public void AddFront(IArrayList arrayList)
        {
            throw new NotImplementedException();
        }

        public int IndexOf(int value)
        {
            throw new NotImplementedException();
        }

        public int Max()
        {
            throw new NotImplementedException();
        }

        public int MaxI()
        {
            throw new NotImplementedException();
        }

        public int Min()
        {
            throw new NotImplementedException();
        }

        public int MinI()
        {
            throw new NotImplementedException();
        }

        public int RemoveAll(int value)
        {
            throw new NotImplementedException();
        }

        public int[] RemoveBack(int count)
        {
            throw new NotImplementedException();
        }

        public int RemoveByIndex(int index)
        {
            throw new NotImplementedException();
        }

        public int[] RemoveByIndex(int index, int count)
        {
            throw new NotImplementedException();
        }

        public int RemoveFirstValue(int value)
        {
            throw new NotImplementedException();
        }

        public int RemoveFromBack() => RemoveByIndex(_currentCount - 1);

        public int RemoveFromFront() => RemoveByIndex(0);

        public int[] RemoveFront(int count)
        {
            throw new NotImplementedException();
        }

        public void Reverse()
        {
            throw new NotImplementedException();
        }

        public void Sort(bool ascending = true)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < _currentCount; i++)
            {
                yield return _array[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public int[] ToArray()
        {
            int[] result = new int[Length];
            for (int i = 0; i < Length; i++)
            {
                result[i] = _array[i];
            }

            return result;
        }

        private void UpdateSize(int countToAdd = 1)
        {
            if ((_currentCount + countToAdd) >= _array.Length)
            {
                int newSize = (int)((_array.Length + countToAdd) * _arrayCoefficient);
                int[] newArray = new int[newSize];
                for (int i = 0; i < _currentCount; i++)
                {
                    newArray[i] = _array[i];
                }

                _array = newArray;
            }
        }
    }
}
