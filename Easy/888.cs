//Alice and Bob have candy bars of different sizes: A[i] is the size of the i-th bar of candy that 
//Alice has, and B[j] is the size of the j-th bar of candy that Bob has.
//Since they are friends, they would like to exchange one candy bar each so that after the exchange, 
//they both have the same total amount of candy.  (The total amount of candy a person has is the sum of the sizes of candy bars they have.)
//Return an integer array ans where ans[0] is the size of the candy bar that Alice must exchange, and ans[1] 
//is the size of the candy bar that Bob must exchange.
//If there are multiple answers, you may return any one of them.  It is guaranteed an answer exists.

//Example 1:
//Input: A = [1, 1], B = [2, 2]
//Output: [1,2]

//Example 2:
//Input: A = [1, 2], B = [2, 3]
//Output: [1,2]

//Example 3:
//Input: A = [2], B = [1, 3]
//Output: [2,3]

//Example 4:
//Input: A = [1, 2, 5], B = [2, 4]
//Output: [5,4]

using System;
using System.Collections.Generic;

namespace Easy
{
    public class Solution_888
    {
        public int[] FairCandySwap(int[] A, int[] B)
        {
            int aSum = 0;
            int bSum = 0;

            var setB = new HashSet<int>(B);

            for (int i = 0; i < A.Length; i ++)
            {
                aSum += A[i];
            }

            for (int i = 0; i <B.Length; i++)
            {
                bSum += B[i];
            }

            int delta = (bSum - aSum) / 2;

            for (int i = 0; i < A.Length; i++)
            {
                if (setB.Contains(A[i] + delta))
                {
                    return new int[2] { A[i], A[i] + delta };
                }
            }

            throw new Exception();
        }
    }
}
