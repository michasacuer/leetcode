//Given an array A of non-negative integers, half of the integers in A are odd, and half of the integers are even.
//
//Sort the array so that whenever A[i] is odd, i is odd; and whenever A[i] is even, i is even.
//
//You may return any answer array that satisfies this condition.

namespace Easy
{
    public class Solution_922
    {
        public int[] SortArrayByParityII(int[] A)
        {
            var result = new int[A.Length];

            int j = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] % 2 == 0)
                {
                    result[j] = A[i];
                    j += 2;
                }
            }

            j = 1;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] % 2 == 1)
                {
                    result[j] = A[i];
                    j += 2;
                }
            }

            return result;
        }
    }
}
