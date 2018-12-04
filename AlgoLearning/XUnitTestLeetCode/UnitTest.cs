using LeetCode;
using System.Collections.Generic;
using Xunit;

namespace XUnitTestLeetCode
{
    public class UnitTest
    {
        #region Problem 1

        [Theory]
        [MemberData(nameof(Data))]
        public void TestTwoSum(int[] values, int value, int[] expected)
        {
            var actual = Solution.TwoSum(values, value);
            Assert.Equal(expected, actual);
        }

        public static IEnumerable<object[]> Data => new List<object[]>
        {
            new object[] { new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 } },
            new object[] { new int[] { -1, -2, -3, -4, -5 }, -8, new int[] { 2, 4 } },
            new object[] { new int[] { 3, 3 }, 6, new int[] { 0, 1 } }            
        };

        #endregion Problem 1

        #region Problem 3

        [Theory]
        [InlineData("abcabcbb", 3)]
        [InlineData("bbbbb", 1)]
        [InlineData("pwwkew", 3)]
        [InlineData(" ", 1)]
        [InlineData("aab", 2)]
        [InlineData("dvdf", 3)]
        public void TestLengthOfLongestSubstring(string value, int expected)
        {
            var actual = Solution.LengthOfLongestSubstring(value);
            Assert.Equal(expected, actual);
        }

        #endregion Problem 3

        #region Problem 5

        [Theory]
        [InlineData("babad", "bab")]
        [InlineData("cbbd", "bb")]
        [InlineData("abcde", "a")]
        [InlineData("ccc", "ccc")]
        [InlineData("", "")]
        [InlineData(null, "")]
        [InlineData("lphbehiapswjudnbcossedgioawodnwdruaaxhbkwrxyzaxygmnjgwysafuqbmtzwdkihbwkrjefrsgjbrycembzzlwhxneiijgzidhngbmxwkhphoctpilgooitqbpjxhwrekiqupmlcvawaiposqttsdgzcsjqrmlgyvkkipfigttahljdhtksrozehkzgshekeaxezrswvtinyouomqybqsrtegwwqhqivgnyehpzrhgzckpnnpvajqevbzeksvbezoqygjtdouecnhpjibmsgmcqcgxwzlzztdneahixxhwwuehfsiqghgeunpxgvavqbqrelnvhnnyqnjqfysfltclzeoaletjfzskzvcdwhlbmwbdkxnyqappjzwlowslwcbbmcxoiqkjaqqwvkybimebapkorhfdzntodhpbhgmsspgkbetmgkqlolsltpulgsmyapgjeswazvhxedqsypejwuzlvegtusjcsoenrcmypexkjxyduohlvkhwbrtzjnarusbouwamazzejhnetfqbidalfomecehfmzqkhndpkxinzkpxvhwargbwvaeqbzdhxzmmeeozxxtzpylohvdwoqocvutcelgdsnmubyeeeufdaoznxpvdiwnkjliqtgcmvhilndcdelpnilszzerdcuokyhcxjuedjielvngarsgxkemvhlzuprywlypxeezaxoqfges", "pnnp")]
        [InlineData("bb", "bb")]
        public void TestLongestPalindrome(string value, string expected)
        {
            var actual = Solution.LongestPalindrome(value);
            Assert.Equal(expected, actual);
        }

        #endregion Problem 5

        #region Problem 6

        [Theory]
        [InlineData("PAYPALISHIRING", 3, "PAHNAPLSIIGYIR")]
        [InlineData("PAYPALISHIRING", 4, "PINALSIGYAHRPI")]
        [InlineData("A", 1, "A")]
        public void TestConvert(string value, int num, string expected)
        {
            var actual = Solution.Convert(value, num);
            Assert.Equal(expected, actual);
        }

        #endregion Problem 6
    }
}
