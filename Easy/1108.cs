//Given a valid(IPv4) IP address, return a defanged version of that IP address.
//A defanged IP address replaces every period "." with "[.]".

using System.Text;

namespace Easy
{
    public class Solution_1108
    {
        public string DefangIPaddr(string address)
        {
            var arr = address.Split('.');
            var sb = new StringBuilder();

            for (int i = 0; i < arr.Length - 1; i++)
            {
                sb.Append(arr[i] + "[.]");
            }

            sb.Append(arr[arr.Length - 1]);

            return sb.ToString();
        }
    }
}
