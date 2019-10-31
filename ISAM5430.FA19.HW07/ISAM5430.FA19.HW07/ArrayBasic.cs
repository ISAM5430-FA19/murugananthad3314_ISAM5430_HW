using System;
using System.Collections.Generic;
using System.Text;

namespace ISAM5430.FA19.HW07
{
    public class ArrayBasic
    {
        /// <summary>
        /// Find the first element of an array
        /// </summary>
        /// <param name="array"></param>
        /// <returns>the first element, or 0 if the array is empty or null</returns>
        public int FirstElement(int[] array)
        {
            if (array != null && array.Length > 0)
                return (array[0]);
            else return 0;

            throw new NotImplementedException();
        }

        /// <summary>
        /// Find the last element of an array
        /// </summary>
        /// <param name="array"></param>
        /// <returns>the last element, or 0 if the array is empty or null</returns>
        public int LastElement(int[] array)
        {
            if (array != null && array.Length > 0)
                return (array[array.Length - 1]);
            else return 0;
            throw new NotImplementedException();
        }

        /// <summary>
        /// Find the middle element if odd; the rounded average of the two middle elements if even
        /// </summary>
        /// <param name="array"></param>
        /// <returns>middle element or 0 if the array is empty or null</returns>
        public int MiddleElement(int[] array)
        {
            if (array != null && array.Length > 0)
            {
                if (array.Length % 2 != 0)
                    return (array[array.Length / 2]);
                else
                    return ((array[array.Length / 2] + array[array.Length / 2 + 1]) / 2);
            }
            else return 0;
            throw new NotImplementedException();
        }

        /// <summary>
        /// Given an array of ints, return true if 6 appears as either the first or last element in the array.The array will be length 1 or more.
        /// </summary>
        /// <example>firstLast6([6, 1, 2, 3]) → true</example>
        /// <example>firstLast6([1, 2, 6]) → false</example>
        /// <example>firstLast6([13, 6, 1, 2, 3]) → false</example>
        /// <param name="array"></param>
        /// <returns>true if 6</returns>
        public bool FirstLast6(int[] array)
        {
            if (array != null && array.Length > 0)
            {
                if (array[0] != 6 && array[array.Length - 1] != 6)
                    return false;
                else return true;
            }
            else return false;
            throw new NotImplementedException();
        }

        /// <summary>
        /// Given 2 arrays of ints, a and b, return true if they have the same first element or they have the same last element.Both arrays will be length 1 or more.
        /// </summary>
        /// <example>commonEnd([1, 2, 3], [7, 3]) → true</example>
        /// <example>commonEnd([1, 2, 3], [7, 3, 2]) → false</example>
        /// <example>commonEnd([1, 2, 3], [1, 3]) → true</example>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public bool CommonEnd(int[] a, int[] b)
        {
            if (a[0] == b[0] || a[a.Length - 1] == b[b.Length - 1])
                return true;
            else return false;
            throw new NotImplementedException();
        }

        /// <summary>
        /// Given 2 int arrays, a and b, each length 3, return a new array length 2 containing their middle elements.
        /// </summary>
        /// <example>middleWay([1, 2, 3], [4, 5, 6]) → [2, 5]</example>
        /// <example>middleWay([7, 7, 7], [3, 8, 0]) → [7, 8]</example>
        /// <example>middleWay([5, 2, 9], [1, 4, 5]) → [2, 4]</example>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int[] MiddleWay(int[] a, int[] b)
        {
            int[] c = new int[2];
            c[0] = a[1];
            c[1] = b[1];
            return c;
            throw new NotImplementedException();
        }

        /// <summary>
        /// Given an int array length 2, return true if it does not contain a 2 or 3.
        /// </summary>
        /// <example>no23([4, 5]) → true</example>
        /// <example>no23([4, 2]) → false</example>
        /// <example>no23([3, 5]) → false</example>
        /// <param name="array"></param>
        /// <returns></returns>
        public bool No23(int[] array)
        {
            int flag = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == 2 || array[i] == 3)
                {
                    flag = 1;
                    return false;
                }
            }
            if (flag == 0) return true;
            throw new NotImplementedException();
        }

        /// <summary>
        /// Given an int array length 3, if there is a 2 in the array immediately followed by a 3, set the 3 element to 0. Return the changed array.
        /// </summary>
        /// <example>fix23([1, 2, 3]) → [1, 2, 0]</example>
        /// <example>fix23([2, 3, 5]) → [2, 0, 5]</example>
        /// <example>fix23([1, 2, 1]) → [1, 2, 1]</example>
        /// <param name="array"></param>
        /// <returns></returns>
        public int[] Fix23(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == 2 && array[i + 1] == 3)
                {
                    array[i + 1] = 0;
                }
            }
            return array;
            throw new NotImplementedException();
        }

        /// <summary>
        /// Given an array and an index, return true if the sum of the first and the last element is equal to the element located at the position index in the array.
        /// </summary>
        /// <returns><c>true</c>, if equal was sumed, <c>false</c> otherwise.</returns>
        /// <param name="array">Array.</param>
        /// <param name="index">Index.</param>
        public bool SumEqual(int[] array, int index)
        {
            int sum = array[0] + array[array.Length - 1];
            if (sum == array[index]) return true;
            else return false;
            throw new NotImplementedException();
        }
    }
}
