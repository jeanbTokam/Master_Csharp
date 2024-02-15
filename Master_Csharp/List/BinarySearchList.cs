using System;
using System.Collections.Generic;

namespace Master_Csharp.List
{
    public class BinarySearchList
    {
        public static void main()
        {
            List<int> list = new List<int> { 1, 2, 4, 5, 7, 8, 9 }; // Ensure the list is sorted

            int key = 7;

            int index = list.BinarySearch(key);

            Action<int> action = item => { Console.WriteLine($"My item is {item}"); };
            list.ForEach(action);

            if (index >= 0)
            {
                Console.WriteLine($"Element {key} found at index {index}");
            }
            else
            {
                Console.WriteLine($"The Element {key} is not found");
            }
        }
    }
}
