using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public static class Search
    {

        static private int BinSearch<T>(T[] array, int left, int right, T element) where T : IComparable<T>
        {
            if (array == null)
                throw new ArgumentNullException("Array is null");
            if (array.Length == 0)
                return -1;
            if (element == null)
                throw new ArgumentNullException("Element is null");
            int middle = (left + right) / 2;
            if (array[middle].CompareTo(element) == 0)
            {
                return middle;
            }
            if (left == right)
            {
                return -1;
            }
            else
            {
                if (array[middle].CompareTo(element) == -1)
                {
                    return BinSearch(array, middle + 1, right, element);
                }
                else
                    return BinSearch(array, left, middle - 1, element);
            }
        }

        static public int BinSearch<T>(this T[] array, T elem ) where T : IComparable<T>
        {
            if (array.Length != 0)
            {
                return BinSearch(array, 0, array.Length - 1, elem);
            }
            else
                return -1;
        }

    }
}
