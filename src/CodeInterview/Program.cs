using CodeInterview.Demos;
using CodeInterview.Common.Interfaces;
using CodeInterview.Common.Utility;
using System.Collections.Generic;
using System;

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

            //FindOverlappingSquares fos = new FindOverlappingSquares();
            //writer.WriteLine(string.Join("\r\n", fos.Find().Select(x => $"{x.Item1.Id} and {x.Item2.Id}")));

            // FizzBuzzDemo fbd = new FizzBuzzDemo();
            // fbd.DoIt(1, 100, 3, 5);

            List<Tuple<string, string, bool>> testCases = new List<Tuple<string, string, bool>>();
            testCases.Add(new Tuple<string, string, bool>("a", "a", true));
            testCases.Add(new Tuple<string, string, bool>("a", "b", false));
            testCases.Add(new Tuple<string, string, bool>("abc", "ab", false));
            testCases.Add(new Tuple<string, string, bool>("abc", "abca", false));
            testCases.Add(new Tuple<string, string, bool>("", "a", false));

            testCases.Add(new Tuple<string, string, bool>("abc", "a.b", false));
            testCases.Add(new Tuple<string, string, bool>("abc", "..c", true));
            testCases.Add(new Tuple<string, string, bool>("abc", ".", false));
            testCases.Add(new Tuple<string, string, bool>("a b", "a.b", true));

            testCases.Add(new Tuple<string, string, bool>("aa", "a*", true));
            testCases.Add(new Tuple<string, string, bool>("aab", "c*a*b", true));
            
            testCases.Add(new Tuple<string, string, bool>("aa", ".*", true));
            testCases.Add(new Tuple<string, string, bool>("aab", "a.*", true));
            testCases.Add(new Tuple<string, string, bool>("aaa", "a*.", true));

            testCases.Add(new Tuple<string, string, bool>("aaccbb", "aa.*bb", true));
            // testCases.Add(new Tuple<string, string, bool>("aaccbb", "aa.*dd", false));
            // testCases.Add(new Tuple<string, string, bool>("aacccbb", "aa.*cbb", true));
            

            RegularExpressionEvaluator ree = new RegularExpressionEvaluator();
            foreach(var tc in testCases)
            {
                var actual = ree.Evaluate(tc.Item1, tc.Item2);
                var status = tc.Item3 == actual ? "PASS" : "FAIL";
                logger.Log($"p = {tc.Item1}; s = {tc.Item2}; expected = {tc.Item3}; actual = {actual}; status = {status}");
            }
        }
    }
}