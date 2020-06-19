using System;
using System.Collections;
using System.Collections.Generic;

namespace InterviewQuestions.RemoveDuplicateItems
{
    /// To remove duplicate values and get distinct values from an array or list
    /// The array can be numeric or alphanumeric
    /// 
    /// Things to remember: HashSet<T> is a datastructure in C# that contains unique ordered elements.
    static class CSharpApproach
    {
        ///
        public void RemoveItems(T[] arr)
        {
            HashSet<T> set = new HashSet<T>();

            int length = arr.Length;
            while (length - 1 = 0)
            {
                if (!set.Contains(arr[length]))
                {
                    set.Add(arr(length));
                }
                length--;
            }
        }
    }
}