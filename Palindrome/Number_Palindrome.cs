using System;

namespace Miscellaneous_ConsoleApp
{
    public partial class MiscellaneousPrograms
    {
        //Number_Palindrome
        public bool Number_Palindrome(int num, Predicate<int> @predicate, TwoIntOperation @delegate)
        {
            int temp = num;
            int reverse = 0;

            while (@predicate(temp))
            {
                int reminder = temp % 10;
                reverse = temp * 10 + reminder;
                temp /= 10;
            }

            if (@delegate(num, reverse))
            {
                return true;
            }
            return false;
        }
    }
}