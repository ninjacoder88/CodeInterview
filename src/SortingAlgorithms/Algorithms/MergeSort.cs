using System.Collections.Generic;
using System.Linq;
using CodeInterview.SortingAlgorithms.Interfaces;

namespace CodeInterview.SortingAlgorithms.Algorithms
{
    public class MergeSort : ISortingAlgorithm
    {
        public IEnumerable<int> Sort(IEnumerable<int> enumerable)
        {
            var list = enumerable.ToList();//ToList() adds enumeration, but is easier to work with

            if(list.Count == 1)
            {
                return list;
            }

            var half = list.Count / 2;

            var l1 = list.Take(half);
            var l2 = list.Skip(half);

            l1 = Sort(l1);
            l2 = Sort(l2);

            var result = Merge(l1, l2);

            return result;
        }

        private List<int> Merge(IEnumerable<int> l1, IEnumerable<int> l2)
        {
            var a = l1.ToList();//ToList() adds enumeration, but is easier to work with
            var b = l2.ToList();//ToList() adds enumeration, but is easier to work with
            var c = new List<int>();
            
            while(a.Count > 0 && b.Count > 0)
            {
                if(a[0] < b[0])
                {
                    c.Add(a[0]);
                    a.RemoveAt(0);
                }
                else
                {
                    c.Add(b[0]);
                    b.RemoveAt(0);
                }
            }

            while(a.Count > 0)
            {
                c.Add(a[0]);
                a.RemoveAt(0);
            }

            while(b.Count > 0)
            {
                c.Add(b[0]);
                b.RemoveAt(0);
            }
            
            return c;
        }
    }
}