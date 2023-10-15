using System.Collections.Generic;

namespace Miscellaneous_ConsoleApp
{
    public partial class MiscellaneousPrograms
    {
        //Remove Duplicate Using Recursion and 0 Loops.
        public void Remove_Duplicate_Recursion_0_Loops(int[] arr, TwoIntOperation @delegate, HashSet<int> result, int index = 0)
        {
            if (@delegate(arr.Length, index))
            {
                result.Add(arr[index]);
                Remove_Duplicate_Recursion_0_Loops(arr, @delegate, result, (index + 1));
            }
        }
    }
}