//Given a string S of lowercase letters, a duplicate removal consists of choosing two adjacent and equal letters, and removing them.
//We repeatedly make duplicate removals on S until we no longer can.
//Return the final string after all such duplicate removals have been made.It is guaranteed the answer is unique.

//Example 1:
//Input: "abbaca"
//Output: "ca"
//Explanation: 
//For example, in "abbaca" we could remove "bb" since the letters are adjacent and equal, and this is the only possible move.
//The result of this move is that the string is "aaca", of which only "aa" is possible, so the final string is "ca".

using System.Text;

namespace Easy
{
    public class Solution_1047
    {
        public string RemoveDuplicates(string S)
        {
            bool isDeleting = true;

            while(isDeleting)
            {
                isDeleting = false;

                for (int i = 0; i < S.Length - 1; i++)
                {
                    if (S[i] == S[i + 1])
                    {
                        S = S.Replace(S[i].ToString() + S[i].ToString(), "");
                        isDeleting = true;
                        break;
                    }
                }
            }

            return S;
        }
    }
}
