using System.Collections.Generic;

namespace Miscellaneous_ConsoleApp
{
    public partial class MiscellaneousPrograms
    {
        //Add_Three_Adjecent_Get_Max.
        public int Add_Three_Adjecent_Get_Max(int[] arr, TwoIntOperation @delegate)
        {
            int result = 0;
            List<int> list = new List<int>();

            for (int i = 0; i < arr.Length - 2; i++)
            {
                int temp = 0;
                for (int j = 0; j <= 2; j++)
                {
                    temp += arr[i + j];
                }
                list.Add(temp);
            }

            for (int i = 0; i < list.Count; i++)
            {
                result = @delegate(list[i], result) ? list[i] : result;
            }
            return result;
        }
    }
}