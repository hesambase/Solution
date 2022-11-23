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
            int result = 0;
            if (tokens.Length < 2)
            {
                Console.WriteLine("Playing the Only token in the bag is impossible beacuase you either have little power or too little score");
                return 0;
            }
                
          
            while (i <= j)
            {
                if (power >= tokens[i])
                {
                    power -= tokens[i++];
                    result = Math.Max(result, ++points);
                    Console.WriteLine("Play the " + i + "th token(" + tokens[i] + ") in order to face up and score becomes " + result);
                }
                else if (points > 0)
                {
                    points--;
                    power += tokens[j--];
                    Console.WriteLine("Play the " + i + "th token(" + tokens[i] + ") in order to face down and score becomes " + result);
                }
                else
                {
                    break;

                }



            }
            return result;
        }

    }


}


