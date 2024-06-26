﻿using System.Collections.Generic;

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

        /// <summary>
        /// Get even numbers till the given argument.
        /// </summary>
        /// <param name="num"></param>
        /// <returns>IEnumerable of int.</returns>
        public IEnumerable<int> EvenList(int num)
        {
            for (int i = 0; i <= num; i += 2)
            {
                yield return i;
            }
        }
    }
}