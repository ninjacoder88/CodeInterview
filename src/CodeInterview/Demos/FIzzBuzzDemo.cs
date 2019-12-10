using System;

namespace CodeInterview
{
    public class FizzBuzzDemo
    {
        public void DoIt(int start, int end, int fizz, int buzz)
        {
            for(int i = start; i <= end; i++)
            {
                bool fizzBuzz = false;
                if(i%fizz == 0)
                {
                    Console.Write("Fizz");
                    fizzBuzz = true;
                }

                if(i%buzz == 0)
                {
                    Console.Write("Buzz");
                    fizzBuzz = true;
                }

                if(!fizzBuzz)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
    }
}