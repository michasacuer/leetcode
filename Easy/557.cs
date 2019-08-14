//Given a string, you need to reverse the order of characters in each word within a sentence while still preserving whitespace and initial word order.

//Example 1:
//Input: "Let's take LeetCode contest"
//Output: "s'teL ekat edoCteeL tsetnoc"

using System.Text;

namespace Easy
{
    public class Solution_557
    {
        public string ReverseWords(string s)
        {
            var split = s.Split(' ');
            var sb = new StringBuilder();

            for (int j = 0; j < split.Length; j++)
            {

                for (int i = split[j].Length - 1; i >= 0; i--)
                {
                    sb.Append(split[j][i]);
                }

                sb.Append(' ');
            }

            return sb.ToString(0, s.Length);
        }
    }
}
