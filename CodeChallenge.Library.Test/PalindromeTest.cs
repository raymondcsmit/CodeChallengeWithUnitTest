namespace CodeChallenge.Library.Test
{
    public class PalindromeTest
    {
        [Theory]
        [InlineData("madam",true)]//true
        [InlineData("step on no pets",true)]//true
        [InlineData("book",false)]//false
        [InlineData("bookddd", false)]//false
        public void WhenCase(string input,bool expected)
        {
            bool Actual= Palindrome.GetValue(input);
            Assert.Equal(expected, Actual);
            
        }
    }
}