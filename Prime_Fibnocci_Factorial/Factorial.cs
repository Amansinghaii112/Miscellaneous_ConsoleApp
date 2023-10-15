namespace Miscellaneous_ConsoleApp
{
    public partial class MiscellaneousPrograms
    {
        //Factorial
        public int Factorial(int num)
        {
            int result = 1;
            for (int i = 2; i <= num; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}