using System.Collections.Generic;

namespace Miscellaneous_ConsoleApp
{
    public partial class MiscellaneousPrograms
    {
        //Count Duplicate Array
        public Dictionary<int, int> Count_Duplicate_Array(int[] arr, DictionaryIntOperation @delegate)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (@delegate(dic, arr[i]))
                {
                    dic[arr[i]] += 1;
                }
                else
                {
                    dic[arr[i]] = 1;
                }
            }
            return dic;
        }
    }
}