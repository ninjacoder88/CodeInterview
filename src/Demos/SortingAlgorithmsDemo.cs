using System.Collections.Generic;
using CodeInterview.SortingAlgorithms.Algorithms;
using CodeInterview.SortingAlgorithms.Interfaces;

namespace CodeInterview.Demos
{
    public class SortingAlgorithmsDemo
    {
        public void Demo()
        {
            List<ISortingAlgorithm> sortingAlgorithms = new List<ISortingAlgorithm>();
            sortingAlgorithms.Add(new BubbleSort());
            sortingAlgorithms.Add(new BucketSort());
            sortingAlgorithms.Add(new HeapSort());
            sortingAlgorithms.Add(new InsertionSort());
            sortingAlgorithms.Add(new MergeSort());
            sortingAlgorithms.Add(new QuickSort());
            sortingAlgorithms.Add(new SelectionSort());
            sortingAlgorithms.Add(new ShellSort());

            List<List<int>> dataSets = new List<List<int>>();
            dataSets.Add(new List<int>{1,2,3,4,5,6,7,8,9});
            dataSets.Add(new List<int>{5,4,3,6,7,2,9,1,8});
            dataSets.Add(new List<int>{9,8,7,6,5,4,3,2,1});

            foreach(var algorithm in sortingAlgorithms)
            {
                foreach(var dataset in dataSets)
                {
                    algorithm.Sort(dataset);
                }
            }
        }
    }
}