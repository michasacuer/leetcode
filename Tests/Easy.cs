using System.Collections.Generic;
using Shouldly;
using Xunit;
using Easy;

namespace Tests
{
    public class Easy
    {
        [Fact]
        public void Solution_1()
        {
            var solution = new Solution_1();
            var nums = new int[] { 2, 7, 11, 15 };
            var result = solution.TwoSum(nums, 9);

            var expected = new int[] { 0, 1 };

            result[0].ShouldBe(expected[0]);
            result[1].ShouldBe(expected[1]);
        }

        [Fact]
        public void Solution_7()
        {
            var solution = new Solution_7();
            var result1 = solution.Reverse(123);
            var result2 = solution.Reverse(120);
            var result3 = solution.Reverse(-123);

            result1.ShouldBe(321);
            result2.ShouldBe(21);
            result3.ShouldBe(-321);
        }

        [Fact]
        public void Solution_557()
        {
            var solution = new Solution_557();
            var result = solution.ReverseWords("Let's take LeetCode contest");

            result.ShouldBe("s'teL ekat edoCteeL tsetnoc");
        }

        [Fact]
        public void Solution_566()
        {
            var solution = new Solution_566();

            var input1 = new int[2][] { new int[2] { 1, 2 }, new int[2] { 3, 4 } };
            var result1 = solution.MatrixReshape(input1, 1, 4);
            var expected1 = new int[1][] { new int[4] { 1, 2, 3, 4 } };

            result1.ShouldBe(expected1);

            var result2 = solution.MatrixReshape(input1, 2, 4);

            result2.ShouldBe(input1);
        }

        [Fact]
        public void Solution_728()
        {
            var solution = new Solution_728();
            var result = solution.SelfDividingNumbers(1, 22);
            var expected = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 11, 12, 15, 22 };

            result = (List<int>)result;
            result.ShouldBe(expected);
        }

        [Fact]
        public void Solution_766()
        {
            var solution = new Solution_766();

            var input1 = new int[3][] { new int[4] { 1, 2, 3, 4 }, new int[4] { 5, 1, 2, 3 }, new int[4] { 9, 5, 1, 2 } };
            var result1 = solution.IsToeplitzMatrix(input1);


            var input2 = new int[2][] { new int[2] { 1, 2 }, new int[2] { 2, 2 } };
            var result2 = solution.IsToeplitzMatrix(input2);

            var input3 = new int[3][] 
            {
                new int[7] { 36, 59, 71, 15, 26, 82, 87 },
                new int[7] { 56, 36, 59, 71, 15, 26, 82 },
                new int[7] { 15, 0, 36, 59, 71, 15, 26 }
            };
            var result3 = solution.IsToeplitzMatrix(input3);

            result1.ShouldBe(true);
            result2.ShouldBe(false);
            result3.ShouldBe(false);

        }

        [Fact]
        public void Solution_771()
        {
            var solution = new Solution_771();

            var result1 = solution.NumJewelsInStones("aA", "aAAbbbb");
            var result2 = solution.NumJewelsInStones("z", "ZZ");

            result1.ShouldBe(3);
            result2.ShouldBe(0);
        }

        [Fact]
        public void Solution_821()
        {
            var solution = new Solution_821();

            var result = solution.ShortestToChar("loveleetcode", 'e');
            var expected = new int[] { 3, 2, 1, 0, 1, 0, 0, 1, 2, 2, 1, 0 };

            result.ShouldBe(expected);
        }

        [Fact]
        public void Solution_832()
        {
            var solution = new Solution_832();

            var input1 = new int[3][] { new int[3] { 1, 1, 0 }, new int[3] { 1, 0, 1 }, new int[3] { 0, 0, 0 } };
            var result1 = solution.FlipAndInvertImage(input1);
            var expected1 = new int[3][] { new int[3] { 1, 0, 0 }, new int[3] { 0, 1, 0 }, new int[3] { 1, 1, 1 } };

            result1.ShouldBe(expected1);

            var input2 = new int[4][] { new int[4] { 1, 1, 0, 0 }, new int[4] { 1, 0, 0, 1 }, new int[4] { 0, 1, 1, 1 }, new int[4] { 1, 0, 1, 0 } };
            var result2 = solution.FlipAndInvertImage(input2);
            var expected2 = new int[4][] { new int[4] { 1, 1, 0, 0 }, new int[4] { 0, 1, 1, 0 }, new int[4] { 0, 0, 0, 1 }, new int[4] { 1, 0, 1, 0 } };

            result2.ShouldBe(expected2);
        }

        [Fact]
        public void Solution_867()
        {
            var solution = new Solution_867();

            var input1 = new int[3][] { new int[3] { 1, 2, 3 }, new int[3] { 4, 5, 6 }, new int[3] { 7, 8, 9 } };
            var result1 = solution.Transpose(input1);
            var expected1 = new int[3][] { new int[3] { 1, 4, 7 }, new int[3] { 2, 5, 8 }, new int[3] { 3, 6, 9 } };

            result1.ShouldBe(expected1);

            var input2 = new int[2][] { new int[3] { 1, 2, 3 }, new int[3] { 4, 5, 6 } };
            var result2 = solution.Transpose(input2);
            var expected2 = new int [3][] { new int[2] { 1, 4 }, new int[2] { 2, 5 }, new int[2] { 3, 6 } };

            result2.ShouldBe(expected2);
        }

        [Fact]
        public void Solution_961()
        {
            var solution = new Solution_961();

            var input1 = new int[4] { 1, 2, 3, 3 };
            var result1 = solution.RepeatedNTimes(input1);

            var input2 = new int[6] { 2, 1, 2, 5, 3, 2 };
            var result2 = solution.RepeatedNTimes(input2);

            var input3 = new int[8] { 5, 1, 5, 2, 5, 3, 5, 4 };
            var result3 = solution.RepeatedNTimes(input3);

            result1.ShouldBe(3);
            result2.ShouldBe(2);
            result3.ShouldBe(5);
        }

        [Fact]
        public void Solution_977()
        {
            var solution = new Solution_977();

            var input1 = new int[5] { -4, -1, 0, 3, 10 };
            var result1 = solution.SortedSquares(input1);
            var expected1 = new int[5] { 0, 1, 9, 16, 100 };

            var input2 = new int[5] { -7, -3, 2, 3, 11 };
            var result2 = solution.SortedSquares(input2);
            var expected2 = new int[5] { 4, 9, 9, 49, 121 };

            result1.ShouldBe(expected1);
            result2.ShouldBe(expected2);
        }

        [Fact]
        public void Solution_1047()
        {
            var solution = new Solution_1047();

            var result = solution.RemoveDuplicates("abbaca");

            result.ShouldBe("ca");
        }

        [Fact]
        public void Solution_1108()
        {
            var solution = new Solution_1108();
            var result = solution.DefangIPaddr("1.1.1.1");

            result.ShouldBe("1[.]1[.]1[.]1");
        }
    }
}
