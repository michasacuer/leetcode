//You're given strings J representing the types of stones that are jewels, and S representing the stones you have.
//Each character in S is a type of stone you have.  You want to know how many of the stones you have are also jewels.

//The letters in J are guaranteed distinct, and all characters in J and S are letters.
//Letters are case sensitive, so "a" is considered a different type of stone from "A".

//Example 1:
//Input: J = "aA", S = "aAAbbbb"
//Output: 3

//Example 2:
//Input: J = "z", S = "ZZ"
//Output: 0

using System.Collections.Generic;

namespace Easy
{
    public class Solution_771
    {
        public int NumJewelsInStones(string J, string S)
        {
            int i = 0;
            var hashSet = new HashSet<char>(J);

            for(int j = 0; j < S.Length; j++)
            {
                if (hashSet.Contains(S[j]))
                {
                    i++;
                }
            }

            return i;
        }
    }
}
