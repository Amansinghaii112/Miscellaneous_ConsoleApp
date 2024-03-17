using System.Collections.Generic;

namespace Miscellaneous_ConsoleApp
{
    public partial class MiscellaneousPrograms
    {
        //Remove Duplicate Using 1 Loops.
        public IEnumerable<int> Remove_Duplicate_1_Loops(int[] arr)
        {
            HashSet<int> result = new HashSet<int>(); // HashSet to track duplicates.
            for (int i = 0; i < arr.Length; i++)
            {
                if (result.Add(arr[i]))
                {
                    yield return arr[i];
                }
            }
        }
    }
}