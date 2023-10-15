namespace Miscellaneous_ConsoleApp
{
    public partial class MiscellaneousPrograms
    {
        //Get Second Highest Number Array With Using Loop.
        public int Get_Second_Highest_Number_Array_WithLoop(int[] arr, TwoIntOperation @delegate1, TwoIntOperation @delegate2)
        {
            int highestNumber = 0, secondHighestNumber = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (@delegate1(arr[i], highestNumber))
                {
                    secondHighestNumber = highestNumber;
                    highestNumber = arr[i];
                }
                else
                {
                    if (@delegate1(arr[i], secondHighestNumber) && @delegate2(arr[i], highestNumber))
                    {
                        secondHighestNumber = arr[i];
                    }
                }
            }
            return secondHighestNumber;
        }
    }
}