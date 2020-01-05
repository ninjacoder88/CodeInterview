using System;
using System.Collections.Generic;
using System.Linq;
using CodeInterview.Common.Interfaces;

namespace CodeInterview.Demos
{
    //write a function that takes two strings as arguments, s and p and returns a boolean denoting whether s matches p, where p is a sequences of any number of the following:
    //1. a-z - which stands for itself
    //2. . - which matches any character
    //3. * - which matches 0 or more occurences of the previous
    //examples: 
    //s = "aba", p = "ab" => false
    //s = "aa", p = "a*" => true
    //s = "ab", p = ".*" => true
    //s = "ab", p = "." => false
    //s = "aab", p = "c*a*b" => true
    //s = "aaa", p = "a*." => true

    //questions:
    //s = "aba", p = "a." => 
    //s = "a", p = "a." => false?
    //s = "abc", p = "bc" => false?
    //s = "abba", p = "**"
    public class RegularExpressionEvaluator
    {
        public bool Evaluate(string s, string p)
        {
            Queue<char> sQueue = ToQueue(s);
            Queue<char> pQueue = ToQueue(p);

            while(pQueue.Any())
            {
                //do some work
                var currentPattern = pQueue.Dequeue();
                pQueue.TryPeek(out char peekPattern);

                if(peekPattern == '*')
                {
                    pQueue.Dequeue();//get rid of the *
                    //go through sQueue until currentPattern no longer matches
                    while(true)
                    {
                        //if no more chars in s, then wildcard has consumed remainder of s
                        if(!sQueue.TryPeek(out char peekString))
                        {
                            return true;
                        }
                        
                        if(peekString == currentPattern)
                        {
                            sQueue.Dequeue();
                        }
                        else
                        {
                            if(currentPattern == '.')
                            {
                                //peek again to see if anything is in pattern after .*
                                if(!pQueue.TryPeek(out char remainingString))//if not
                                {
                                    return true;
                                }
                                throw new NotImplementedException();
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                    continue;
                }

                //if nothing is left in s, then false because we are still have a currentPattern to match
                if(!sQueue.TryDequeue(out char currentString))
                {
                    return false;
                }

                if(currentPattern == '.')
                {
                    continue;
                }

                //string comparison at this point
                if(currentPattern == currentString)
                {
                    continue;
                }

                return false;
            }

            if(sQueue.Any())//not good because we are out of patterns to match
            {
                return false;
            }

            return true;
        }

        public bool Attempt2(string s, string p)
        {
            // p = aa.*cbb.*
            // a = |a|a|.|.|c|b|b
            // s = |a|a|c|c|c|b|b

            int sPosition = 0;
            int pPosition = 0;
            char[] result = new char[s.Length];

            while(sPosition < s.Length)
            {
                var currentPattern = p[pPosition];
            }
            return false;
        }

        private Queue<char> ToQueue(string str)
        {
            Queue<char> charQueue = new Queue<char>();
            for(int i = 0; i < str.Length; i++)
            {
                charQueue.Enqueue(str[i]);
            }
            return charQueue;
        }
    }
}