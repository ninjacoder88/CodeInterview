using System.Collections.Generic;
using System.Linq;
using CodeInterview.DataStructures;
using CodeInterview.Demos;
using CodeInterview.SortingAlgorithms.Algorithms;
using CodeInterview.SortingAlgorithms.Interfaces;
using CodeInterview.Utility;

namespace CodeInterview
{
    public class Program
    {
        public static void Main(string[] args)
        {
            

            IWriter writer = new ConsoleWriter();

            // DataStructures.LinkedList<int> ll = new DataStructures.LinkedList<int>(writer);

            // ll.AddNode(4);
            // ll.AddNode(8);
            // ll.AddNode(2);
            // ll.Print();

            FindOverlappingSquares fos = new FindOverlappingSquares();
            writer.WriteLine(string.Join("\r\n", fos.Find().Select(x => $"{x.Item1.Id} and {x.Item2.Id}")));
        }
    }
}