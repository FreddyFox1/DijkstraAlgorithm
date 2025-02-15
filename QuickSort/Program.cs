﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace QuickSort
{
    /// <summary>
    /// Quicksort is a type of divide and conquer algorithm for sorting an array, 
    /// based on a partitioning routine; the details of this partitioning can vary 
    /// somewhat, so that quicksort is really a family of closely related algorithms.
    /// O(n*log n)
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            var arr = new[] { 10, 5, 2, 3 };
            Console.WriteLine("Array: " + string.Join(" ", arr));
            Console.WriteLine("Sorted array: " + string.Join(" ", QuickSort(arr)));
        }

        private static IEnumerable<int> QuickSort(IEnumerable<int> list)
        {
            if (list.Count() <= 1)
            {
                return list;
            }

            var pivot = list.First();
            var less = list.Skip(1).Where(i => i <= pivot);
            var greater = list.Skip(1).Where(i => i > pivot);
            
            return QuickSort(less).Union(new List<int> { pivot }).Union(QuickSort(greater));
        }
    }
}
