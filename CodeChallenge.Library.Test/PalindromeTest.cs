namespace CodeChallenge.Library.Test
{
    public class PalindromeTest
    {
        [Fact]
        public void When_madam()
        {
            bool result = Palindrome.GetValue("madam");
            Assert.True(result);
            
        }
    }
}