using System.Collections.Generic;

namespace Miscellaneous_ConsoleApp
{
    public partial class MiscellaneousPrograms
    {
        //Sort Using Recursion and 0 Loops.
        public void Sort_Recursion_0_Loops(int[] arr, TwoIntOperation @delegate, SortedSet<int> result, int index = 0)
        {
            if (@delegate(arr.Length, index))
            {
                result.Add(arr[index]);
                Sort_Recursion_0_Loops(arr, @delegate, result, (index + 1));
            }
        }
    }
}