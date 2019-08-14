//Given a string S and a character C, return an array of integers representing the shortest distance from the character C in the string.

//Example 1:
//Input: S = "loveleetcode", C = 'e'
//Output: [3, 2, 1, 0, 1, 0, 0, 1, 2, 2, 1, 0]

using System;

namespace Easy
{
    public class Solution_821
    {
        public int[] ShortestToChar(string S, char C)
        {
            int[] result = new int[S.Length];

            for (int i = 0; i < S.Length; i++)
            {
                int min = int.MaxValue;

                for (int j = 0; j < S.Length; j++)
                {
                    if (S[j] == C && Math.Abs(j - i) < min)
                    {
                        min = Math.Abs(j - i);
                    }
                }

                result[i] = min;
            }

            return result;
        }
    }
}
