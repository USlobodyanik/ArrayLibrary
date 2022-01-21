using ArrayLibrary;
using NUnit.Framework;

namespace ArrayTests
{
    public class ArrayListTest
    {

        [TestCase(new[] { 1, 2, 3, 4 })]
        [TestCase(new[] { 1 })]
        [TestCase(new[] { 1, 2, 3, 4, 5, 6 })]
        public void InitializeNewArray_ShouldFillArray(int[] sourceArray)
        {
            ArrayList array = new ArrayList(sourceArray);

            CollectionAssert.AreEqual((System.Collections.IEnumerable)array, sourceArray);
        }

        [TestCase(new[] { 1, 2, 3, 4 }, 0, new[] { 0, 1, 2, 3, 4 })]
        [TestCase(new[] { 1 }, 0, new[] { 0, 1 })]
        [TestCase(new int[] { }, 0, new[] { 0 })]
        public void AddValueInFront_WhenArrayFilled_ShouldAddedValueInFrontByFillArray(
            int[] sourceArray,
            int value,
            int[] expectedArray)
        {
            ArrayList array = new ArrayList(sourceArray);

            array.AddFront(value);
            CollectionAssert.AreEqual((System.Collections.IEnumerable)array, expectedArray);
        }

        [TestCase(new[] { 1, 2, 3, 4 }, 0, new[] { 1, 2, 3, 4, 0 })]
        [TestCase(new[] { 1 }, 0, new[] { 1, 0 })]
        [TestCase(new int[] { }, 0, new[] { 0 })]
        public void AddValueInBack_WhenArrayFilled_ShouldAddedValueInBackByFillArray(
            int[] sourceArray,
            int value,
            int[] expectedArray)
        {
            ArrayList array = new ArrayList(sourceArray);

            array.AddBack(value);
            CollectionAssert.AreEqual((System.Collections.IEnumerable)array, expectedArray);
        }

        [TestCase(new[] { 1, 2, 3, 4 }, 0, new[] { 1, 2, 3, 4, 0 })]
        [TestCase(new[] { 1 }, 0, new[] { 1, 0 })]
        [TestCase(new int[] { }, 0, new[] { 0 })]
        public void AddValueByIndex_WhenArrayFilled_ShouldAddedValueByIndexInFillArray(
            int[] sourceArray,
            int value,
            int index,
            int[] expectedArray)
        {
            ArrayList array = new ArrayList(sourceArray);

            array.AddByIndex(index, value);
            CollectionAssert.AreEqual((System.Collections.IEnumerable)array, expectedArray);
        }

        [TestCase(new[] { 1, 2, 3, 4 }, new[] { 2, 3, 4 })]
        [TestCase(new[] { 1 }, new int[] { })]
        [TestCase(new int[] { }, new int[] { })]
        public void RemoveFromFront_WhenArrayFilled_ShouldArrayWithRemovedFirstValue(
            int[] sourceArray,
            int[] expectedArray)
        {
            ArrayList array = new ArrayList(sourceArray);

            array.RemoveFromFront();
            CollectionAssert.AreEqual((System.Collections.IEnumerable)array, expectedArray);
        }

        [TestCase(new[] { 1, 2, 3, 4 }, new[] { 1, 2, 3 })]
        [TestCase(new[] { 1 }, new int[] { })]
        [TestCase(new int[] { }, new int[] { })]
        public void RemoveFromBack_WhenArrayFilled_ShouldArrayWithRemovedLastValue(
            int[] sourceArray,
            int[] expectedArray)
        {
            ArrayList array = new ArrayList(sourceArray);

            array.RemoveFromBack();
            CollectionAssert.AreEqual((System.Collections.IEnumerable)array, expectedArray);
        }

        [TestCase(new[] { 1, 2, 3, 4 }, 2, new[] { 1, 2, 3 })]
        [TestCase(new[] { 1 }, 0, new int[] { })]
        [TestCase(new int[] { }, 0, new int[] { })]
        public void RemoveByIndex_WhenArrayFilled_ShouldArrayWithRemovedValueByIndex(
            int[] sourceArray,
            int index,
            int[] expectedArray)
        {
            ArrayList array = new ArrayList(sourceArray);

            array.RemoveByIndex(index);
            CollectionAssert.AreEqual((System.Collections.IEnumerable)array, expectedArray);
        }

        [TestCase(new[] { 1, 2, 3, 4 }, 2, new[] { 3, 4 })]
        [TestCase(new[] { 1 }, 0, new int[] { 1 })]
        [TestCase(new int[] { }, 0, new int[] { })]
        public void RemoveFrontByCount_WhenArrayFilled_ShouldArrayWithRemovedValueByCountFromFront(
            int[] sourceArray,
            int count,
            int[] expectedArray)
        {
            ArrayList array = new ArrayList(sourceArray);

            int[] result = array.RemoveFront(count);
            CollectionAssert.AreEqual((System.Collections.IEnumerable)result, expectedArray);
        }

        [TestCase(new[] { 1, 2, 3, 4 }, 2, new[] { 1, 2 })]
        [TestCase(new[] { 1 }, 0, new int[] { 1 })]
        [TestCase(new int[] { }, 0, new int[] { })]
        public void RemoveBackByCount_WhenArrayFilled_ShouldArrayWithRemovedValueByCountFromBack(
            int[] sourceArray,
            int count,
            int[] expectedArray)
        {
            ArrayList array = new ArrayList(sourceArray);

            int[] result = array.RemoveBack(count);
            CollectionAssert.AreEqual((System.Collections.IEnumerable)result, expectedArray);
        }

        [TestCase(new[] { 1, 2, 3, 4, 5 }, 1, 2, new[] { 1, 4, 5 })]
        [TestCase(new[] { 1, 2, 3, 4, 5 }, 3, 2, new[] { 1, 2, 3 })]
        [TestCase(new[] { 1, 2, 3, 4, 5 }, 0, 2, new[] { 3, 4, 5 })]
        [TestCase(new[] { 1 }, 0, 0, new int[] { 1 })]
        [TestCase(new int[] { }, 0, 0, new int[] { })]
        public void RemoveBackByCount_WhenArrayFilled_ShouldArrayWithRemovedValueByCountFromBack(
            int[] sourceArray,
            int index,
            int count,
            int[] expectedArray)
        {
            ArrayList array = new ArrayList(sourceArray);

            int[] result = array.RemoveByIndex(index, count);
            CollectionAssert.AreEqual((System.Collections.IEnumerable)result, expectedArray);
        }
    }
}