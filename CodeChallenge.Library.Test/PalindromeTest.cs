namespace CodeChallenge.Library.Test
{
    public class PalindromeTest
    {
        [Fact]
        public void Test1()
        {
            bool result = Palindrome.GetValue("madam");
            Assert.True(result);
            
        }
    }
}