using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace InterviewQuestions.RemoveDuplicateItems
{
    /// Remove Duplicates from Array - Given an array, remove the duplicates in-place such that each element appear only once and return the new array.
    /// The array can be numeric or alphanumeric
    /// 
    /// Constraints:
    /// Do not allocate extra space for another array, you must do this by modifying the input array in-place with O(1) extra memory.
    /// Things to remember: HashSet<T> is a datastructure in C# that contains unique ordered elements.
    /// There are multiple solutions for this:
    /// 1. Naive Approach: We can use HashSet<T> to store distinct values and iterate over the array. This is the easy solution but not the optimal.
    /// 2. Optimized Approach: Iterate the array and remove the duplicate ones from the same array by comparing n and n+1 elements.
    static class CSharpApproach<T>
    {
        /// We can iterate the incoming array and store the unique elements in HashSet<T>. 
        /// Afterwards, we can convert the HashSet<T> into array and return the result.
        public static T[] RemoveItemsUsingFirstApproach(T[] arr)
        {
            int length = arr.Length;
            if (length <= 1)
                return arr;

            HashSet<T> set = new HashSet<T>();

            int i = 0;
            while (i < length)
            {
                if (!set.Contains(arr[i]))
                {
                    set.Add(arr[i]);
                }

                i++;
            }

            return set.ToArray<T>();
        }

        public static int[] RemoveItemsUsingSecondApproach(int[] arr)
        {
            int length = arr.Length;
            int counter = 1;
            int[] newArr;

            for (int i = 0; i < length - 1; i++)
            {
                if (arr[i] != arr[i + 1])
                {
                    arr[counter] = arr[i + 1];

                    counter++;
                }
            }

            newArr = new int[counter - 1];
            for (int i = 0; i < newArr.Length; i++)
            {
                newArr[i] = arr[i];
            }

            return newArr;
        }
    }
}