using System;
using System.Collections;
using System.Collections.Generic;

namespace ArrayLibrary
{
    public class ArrayList : IArrayList
    {
        private const double _arrayCoefficient = 1.33;
        private const int _defaultSizeArray = 5;
        private int[] _array;
        private int _currentCount;

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
        public void AddFront(int value) => AddByIndex(0, value);

        public void AddBack(int value) => AddByIndex(_currentCount, value);

        public void AddBack(IArrayList arrayList)
        {
            throw new NotImplementedException();
        }

        public void AddByIndex(int index, int value)
        {
            UpdateSize();

            for (int i = _currentCount; i > index; i--)
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
            int maxIndex = MaxI();
            int maxValue = _array[maxIndex];

            return maxValue;
        }

        public int MaxI()
        {
            int maxIndex = 0;
            int maxValue = _array[0];

            if (_currentCount == 1)
            {
                return maxIndex;
            }
            else
            {
                for (int i = 0; i < _currentCount - 1; i++)
                {
                    if (maxValue < _array[i + 1])
                    {
                        maxIndex = i + 1;
                        maxValue = _array[i + 1];
                    }
                }
            }

            return maxIndex;
        }

        public int Min()
        {
            int minIndex = MinI();
            int minValue = _array[minIndex];

            return minValue;
        }

        public int MinI()
        {
            int minIndex = 0;
            int minValue = _array[0];

            if (_currentCount == 1)
            {
                return minIndex;
            }
            else
            {
                for (int i = 0; i < _currentCount - 1; i++)
                {
                    if (minValue > _array[i + 1])
                    {
                        minIndex = i + 1;
                        minValue = _array[i + 1];
                    }
                }
            }

            return minIndex;
        }

        public int RemoveAll(int value)
        {
            throw new NotImplementedException();
        }

        public int[] RemoveBack(int count) => RemoveByIndex(_currentCount, count);

        public int RemoveByIndex(int index)
        {
            for (int i = index; i < _currentCount - 1; i++)
            {
                _array[i] = _array[i + 1];
            }

            _currentCount--;
            return index;
        }

        public int[] RemoveByIndex(int index, int count)
        {
            int[] removedArray = new int[count];
            int overSize = index + count;

            if (overSize < _currentCount)
            {
                for (int i = index, j=0; j < count; i++, j++)
                {
                    removedArray[j] = _array[i];
                    _array[i] = _array[j + overSize];
                }
            }

            return removedArray;
        }

        public int RemoveFirstValue(int value)
        {
            throw new NotImplementedException();
        }

        public int RemoveFromBack() => RemoveByIndex(_currentCount);

        public int RemoveFromFront() => RemoveByIndex(0);

        public int[] RemoveFront(int count)
        {
            throw new NotImplementedException();
        }

        public void Reverse()
        {
            Array.Reverse(_array);
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
