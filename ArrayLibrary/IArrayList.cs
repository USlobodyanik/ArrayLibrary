using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayLibrary
{
    public interface IArrayList : IEnumerable<int>
    {
        void AddFront(int value);
        void AddBack(int value);
        void AddByIndex(int index, int value);
        int RemoveFromFront();
        int RemoveFromBack();
        int RemoveByIndex(int index);
        int[] RemoveFront(int count);
        int[] RemoveBack(int count);
        int[] RemoveByIndex(int index, int count);
        int Length { get; }
        int this[int index] { get; set; }
        int IndexOf(int value);
        void Reverse();
        int Min();
        int Max();
        int MinI();
        int MaxI();
        void Sort(bool ascending = true);
        int RemoveFirstValue(int value);
        /// <summary>
        /// Remove all elements by value
        /// </summary>
        /// <param name="value">Value to remove</param>
        /// <returns>Countets removed</returns>
        int RemoveAll(int value);
        void AddFront(IArrayList arrayList);
        void AddBack(IArrayList arrayList);
        void AddByIndex(int index, IArrayList arrayList);
        int[] ToArray();
    }
}
