using System.Collections.Generic;
using System.Linq;

namespace CodeInterview.SortingAlgorithms.Algorithms
{
    public class BubbleSort
    {
        public IEnumerable<int> Sort(IEnumerable<int> enumerable)
        {
            var list = enumerable.ToList();//ToList() adds enumeration, but is easier to work with

            int n = list.Count;

            for(int i = 0; i < n - 1; i++)//n-1
            {
                bool swapped = false;
                for(int j = 0; j < n - 1; j++)//n-1
                {
                    if(list[j] > list[j + 1])
                    {
                        Swap(list, j, j+1);
                        swapped = true;
                    }
                }

                if(!swapped)
                {
                    break;
                }
            }

            return list;
        }

        private void Swap(List<int> list, int a, int b)
        {
            int temp = list[a];
            list[a] = list[b];
            list[b] = temp;
        }
    }
}