namespace Valid_Palindrome.Test
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("A man, a plan, a canal: Panama", true)]
        [InlineData("race a car", false)]
        [InlineData(" ", true)]
        [InlineData(".,", true)]
        [InlineData("0P", false)]
        [InlineData("ab2a",false)]
        public void Test1(string s, bool expected)
        {
            Solution sol = new Solution();
            bool res = sol.IsPalindrome(s.ToString());
            Assert.Equal(expected, res);
        }

        [Theory]
        [InlineData("A man, a plan, a canal: Panama", true)]
        [InlineData("race a car", false)]
        [InlineData(" ", true)]
        [InlineData(".,", true)]
        [InlineData("0P", false)]
        [InlineData("ab2a", false)]
        public void Test2(string s, bool expected)
        {
            Solution sol = new Solution();
            bool res = sol.IsPalindrome2(s.ToString());
            Assert.Equal(expected, res);
        }

        [Theory]
        [InlineData("A man, a plan, a canal: Panama", true)]
        [InlineData("race a car", false)]
        [InlineData(" ", true)]
        [InlineData(".,", true)]
        [InlineData("0P", false)]
        [InlineData("ab2a", false)]
        public void Test3(string s, bool expected)
        {
            Solution sol = new Solution();
            bool res = sol.IsPalindrome3(s.ToString());
            Assert.Equal(expected, res);
        }

        [Theory]
        [InlineData("A man, a plan, a canal: Panama", true)]
        [InlineData("race a car", false)]
        [InlineData(" ", true)]
        [InlineData(".,", true)]
        [InlineData("0P", false)]
        [InlineData("ab2a", false)]
        public void Test4(string s, bool expected)
        {
            Solution sol = new Solution();
            bool res = sol.IsPalindrome4(s.ToString());
            Assert.Equal(expected, res);
        }
    }


}