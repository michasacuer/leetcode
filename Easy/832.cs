﻿//Given a binary matrix A, we want to flip the image horizontally, then invert it, and return the resulting image.
//To flip an image horizontally means that each row of the image is reversed.For example, flipping[1, 1, 0] horizontally results in [0, 1, 1].
//To invert an image means that each 0 is replaced by 1, and each 1 is replaced by 0. For example, inverting[0, 1, 1] results in [1, 0, 0].

//Example 1:
//Input: [[1,1,0],[1,0,1],[0,0,0]]
//Output: [[1,0,0],[0,1,0],[1,1,1]]
//Explanation: First reverse each row: [[0,1,1],[1,0,1],[0,0,0]].
//Then, invert the image: [[1,0,0],[0,1,0],[1,1,1]]

//Example 2:
//Input: [[1,1,0,0],[1,0,0,1],[0,1,1,1],[1,0,1,0]]
//Output: [[1,1,0,0],[0,1,1,0],[0,0,0,1],[1,0,1,0]]
//Explanation: First reverse each row: [[0,0,1,1],[1,0,0,1],[1,1,1,0],[0,1,0,1]].
//Then invert the image: [[1,1,0,0],[0,1,1,0],[0,0,0,1],[1,0,1,0]]

namespace Easy
{
    public class Solution_832
    {
        public int[][] FlipAndInvertImage(int[][] A)
        {
            var result = new int[A[0].Length][];

            for (int i = 0; i < A[0].Length; i++)
            {
                result[i] = new int[A[0].Length];
                int k = 0;

                for (int j = A[0].Length - 1; j >= 0; j--)
                {
                    result[i][k++] = 1 - A[i][j];
                }
            }

            return result;
        }
    }
}
