using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionTest
{
    public class Solution
    {
        public int BagOfTokensScore(int[] tokens, int power)
        {
            Array.Sort(tokens);
            int i = 0;
            int j = tokens.Length - 1;
            int points = 0;
            int res = 0;
            while (i <= j)
            {
                if (power >= tokens[i])
                {
                    power -= tokens[i++];
                    res = Math.Max(res, ++points);
                }
                else if (points > 0)
                {
                    points--;
                    power += tokens[j--];
                }
                else
                {
                    break;
                }



            }
            return res;
        }

    }
    }

