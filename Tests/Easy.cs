using Easy;
using Shouldly;
using System;
using Xunit;

namespace Tests
{
    public class Easy
    {
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
        public void Solution_1108()
        {
            var solution = new Solution_1108();
            var result = solution.DefangIPaddr("1.1.1.1");

            result.ShouldBe("1[.]1[.]1[.]1");
        }
    }
}
