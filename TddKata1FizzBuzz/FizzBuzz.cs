using System;
namespace TddKata1FizzBuzz
{
    public class FizzBuzz
    {
        public FizzBuzz()
        {
        }

        public string Print(int limit)
        {
            string output = "";

            for (int cnt = 1; cnt <= limit; cnt++)
            {
                if (cnt != 1)
                    output += "\n";

                if (Fizzable(cnt) && Buzzable(cnt))
                    output += "FizzBuzz";
                else if (Fizzable(cnt))
                    output += "Fizz";
                else if (Buzzable(cnt))
                    output += "Buzz";
                else
                    output += cnt.ToString();
            }

            return output;
        }

        private static bool Buzzable(int cnt)
        {
            return cnt % 5 == 0;
        }

        private static bool Fizzable(int cnt)
        {
            return cnt % 3 == 0;
        }
    }
}
