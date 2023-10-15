using System;

namespace Miscellaneous_ConsoleApp
{
    public partial class MiscellaneousPrograms
    {
        //Get Second Highest Number Array No Loop.
        public void Get_Second_Highest_Number_Array_No_Loop(int[] arr, TwoIntOperation @delegate1, TwoIntOperation @delegate2, ref Tuple<int, int> @tuple, int index = 0)
        {
            if (@delegate1(arr.Length, index))
            {
                if (@delegate1(arr[index], @tuple.Item1))
                {
                    @tuple = Tuple.Create(arr[index], @tuple.Item1);
                }
                else
                {
                    if (@delegate1(arr[index], @tuple.Item2) && @delegate2(arr[index], @tuple.Item1))
                    {
                        @tuple = Tuple.Create(@tuple.Item1, arr[index]);
                    }
                }
                Get_Second_Highest_Number_Array_No_Loop(arr, @delegate1, @delegate2, ref @tuple, (index + 1));
            }
        }
    }
}