namespace Miscellaneous_ConsoleApp
{
    public partial class MiscellaneousPrograms
    {
        //Sort Using 2 Loops.
        public void Sort_2_Loops(int[] arr, TwoIntOperation @delegate)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (@delegate(arr[i], arr[j]))
                    {
                        arr[i] = arr[i] + arr[j];
                        arr[j] = arr[i] - arr[j];
                        arr[i] = arr[i] - arr[j];
                    }
                }
            }
        }
    }
}