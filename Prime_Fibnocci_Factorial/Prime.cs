namespace Miscellaneous_ConsoleApp
{
    public partial class MiscellaneousPrograms
    {
        //Prime
        public bool Prime(int num, ThreeIntOperation @delegate)
        {
            for (int i = 2; i < num; i++)
            {
                if (@delegate(num, i, 0))
                {
                    return false;
                }
            }
            return true;
        }
    }
}