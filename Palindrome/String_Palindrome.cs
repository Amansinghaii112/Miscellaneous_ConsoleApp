namespace Miscellaneous_ConsoleApp
{
    public partial class MiscellaneousPrograms
    {
        //StringPalindrome
        public bool String_Palindrome(string str, TwoCharOperation @delegate)
        {
            for (int i = 0; i < str.Length / 2; i++)
            {
                if (@delegate(str[i], str[str.Length - 1 - i]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}