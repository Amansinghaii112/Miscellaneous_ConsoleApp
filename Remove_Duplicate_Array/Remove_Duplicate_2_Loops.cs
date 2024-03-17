using System.Collections.Generic;

namespace Miscellaneous_ConsoleApp
{
    public partial class MiscellaneousPrograms
    {
        //Remove Duplicate Using 2 Loops.
        public IEnumerable<int> Remove_Duplicate_2_Loops(int[] arr, TwoIntOperation @delegate)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                bool flag = true;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (@delegate(arr[i], arr[j]))
                    {
                        flag = false;
                    }
                }
                if (flag)
                {
                    yield return arr[i];
                }
            }
        }
    }
}