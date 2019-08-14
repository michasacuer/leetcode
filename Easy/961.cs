//In a array A of size 2N, there are N+1 unique elements, and exactly one of these elements is repeated N times.
//Return the element repeated N times.

//Example 1:
//Input: [1,2,3,3]
//Output: 3

//Example 2:
//Input: [2,1,2,5,3,2]
//Output: 2

//Example 3:
//Input: [5,1,5,2,5,3,5,4]
//Output: 5

using System;
using System.Collections.Generic;
using System.Text;

namespace Easy
{
    public class Solution_961
    {
        public int RepeatedNTimes(int[] A)
        {
            int n = A.Length / 2;
            int compare = 0;
            int counter;

            for (int i = 0; i < A.Length; i++)
            {
                counter = 0;
                compare = A[i];

                for (int j = 0; j < A.Length; j++)
                {
                    if (A[j] == compare)
                    {
                        counter++;
                    }
                }

                if (counter == n)
                {
                    break;
                }
            }

            return compare;
        }
    }
}
