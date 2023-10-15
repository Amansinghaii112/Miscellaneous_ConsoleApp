using System.Collections.Generic;

namespace Miscellaneous_ConsoleApp
{
    public partial class MiscellaneousPrograms
    {
        //Sort Using 1 Loops.
        public SortedSet<int> Sort_1_Loops(int[] arr)
        {
            SortedSet<int> result = new SortedSet<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                result.Add(arr[i]);
            }
            return result;
        }
    }
}