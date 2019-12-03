using System.Collections.Generic;

namespace CodeInterview.SortingAlgorithms.Interfaces
{
    public interface ISortingAlgorithm
    {
        IEnumerable<int> Sort(IEnumerable<int> enumerable);
    }
}