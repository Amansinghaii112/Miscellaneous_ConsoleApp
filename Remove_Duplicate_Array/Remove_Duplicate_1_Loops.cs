using System.Collections.Generic;

namespace Miscellaneous_ConsoleApp
{
    public partial class MiscellaneousPrograms
    {
        //Remove Duplicate Using 1 Loops.
        public HashSet<int> Remove_Duplicate_1_Loops(int[] arr)
        {
            HashSet<int> result = new HashSet<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                result.Add(arr[i]);
            }
            return result;
        }
    }
}