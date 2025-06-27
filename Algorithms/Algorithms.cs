using System;
using System.Linq;
using System.Text;

namespace DeveloperSample.Algorithms
{
    public static class Algorithms
    {
        public static int GetFactorial(int n)
        {
            if (n < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(n));
            }
            if (n <= 1)
            {
                return 1;
            }
            if (n == 2)
            {
                return 2;
            }
            else
            {
                return n * GetFactorial(n - 1);
            }
        }


        public static string FormatSeparators(params string[] items)
        {
            if (items == null || items.Length == 0)
            {
                return string.Empty;
            }
            if (items.Length == 1)
            {
                return items[0];
            }

            StringBuilder outputSB = new StringBuilder();
            for (int i = 0; i < items.Length; i++)
            {
                if (i == items.Length - 1)
                {
                    outputSB.Append(" and ");
                }
                else if (i > 0)
                {
                    outputSB.Append(", ");
                }

                outputSB.Append(items[i]);
            }

            return outputSB.ToString();
        }
    }
}