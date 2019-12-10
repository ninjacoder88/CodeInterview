using System.Collections.Generic;
using System.Linq;
using CodeInterview.SortingAlgorithms.Interfaces;

namespace CodeInterview.SortingAlgorithms.Algorithms
{
    public class InsertionSort : ISortingAlgorithm
    {
        public IEnumerable<int> Sort(IEnumerable<int> enumerable)
        {
            var list = enumerable.ToList();//ToList() adds enumeration, but is easier to work with
  
            int holePosition = -1;
            int valueToInsert = -1;

            for(int i = 1; i < list.Count; i++)//n-1
            {
                valueToInsert = list[i];
                holePosition = i;

                while(holePosition > 0 && list[holePosition - 1] > valueToInsert)//
                {
                    list[holePosition] = list[holePosition - 1];
                    holePosition = holePosition - 1;
                }

                list[holePosition] = valueToInsert;
            }

            return list;
        }
    }
}