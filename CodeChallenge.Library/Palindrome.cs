using System.Runtime.InteropServices;

namespace CodeChallenge.Library
{
    public class Palindrome
    {
        public static bool GetValue(string input)
        {
            char[] cr=input.ToCharArray();
            string ouput = string.Empty;
            for(int i=cr.Length;i>0;i--)
            {
                ouput += cr[i-1].ToString();
            }
            if (input == ouput) return true;
                return false;
        }
    }
}