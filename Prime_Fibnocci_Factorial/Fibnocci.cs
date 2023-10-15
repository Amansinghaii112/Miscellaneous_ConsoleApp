using System.Collections.Generic;

namespace Miscellaneous_ConsoleApp
{
    public partial class MiscellaneousPrograms
    {
        //Fibnocci
        public List<int> Fibnocci(int num)
        {
            List<int> result = new List<int>();
            int a = 0, b = 1, c = 0;

            for (int i = 0; i < num; i++)
            {
                result.Add(a);

                c = a + b; a = b; b = c;
            }

            return result;
        }
    }
}