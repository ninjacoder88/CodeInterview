using CodeInterview.Demos;
using CodeInterview.Common.Interfaces;
using CodeInterview.Common.Utility;

namespace CodeInterview
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ILogger logger = new ConsoleLogger();

            // DataStructures.LinkedList<int> ll = new DataStructures.LinkedList<int>(writer);

            // ll.AddNode(4);
            // ll.AddNode(8);
            // ll.AddNode(2);
            // ll.Print();

            FindOverlappingSquares fos = new FindOverlappingSquares();
            //writer.WriteLine(string.Join("\r\n", fos.Find().Select(x => $"{x.Item1.Id} and {x.Item2.Id}")));

            // FizzBuzzDemo fbd = new FizzBuzzDemo();
            // fbd.DoIt(1, 100, 3, 5);
        }
    }
}