using System;
using InterviewQuestions.RemoveDuplicateItems;

namespace InterviewQuestions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Question 1 - Remove Duplicate Items
            //int[] arr = { 1, 1, 2, 2, 43, 5 };
            //int[] solution = CSharpApproach<int>.RemoveItemsUsingFirstApproach(arr);

            //string[] arr = {"11", "1", "a", "b", "b", "c", "1"};
            //string[] solution =  CSharpApproach<string>.RemoveItemsUsingFirstApproach(arr);
            
            int[] arr = { 1, 1, 1, 2, 2, 5, 43, 5 };
            int[] solution = CSharpApproach<int>.RemoveItemsUsingSecondApproach(arr);
        }
    }
}