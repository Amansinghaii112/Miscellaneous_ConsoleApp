using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;

namespace Miscellaneous_ConsoleApp
{

    public delegate bool checkIntsEquals(int i, int j);

    public class Program
    {
        static void Main(string[] args)
        {
            //Delegates
            Action<string> headerPrint = str => Console.WriteLine($"--------------------{str}------------ \n");
            Action<dynamic> resultPrint = dy => Console.WriteLine($"{dy}");
            Action<KeyValuePair<int, int>> keyValuePairPrint = kv => Console.WriteLine($"{kv.Key} repeats {kv.Value} times \n");
            checkIntsEquals checkIntsEquals_Delegate;

            //data initialization
            int[] arr = { 1, 3, 5, 4, 4, 5, 3, 9, 2, 8 };
            int[] arr2 = { 1, 3, 5, 4, 4, 5, 3, 9, 2, 8 };
            Miscellaneous miscellaneous = new Miscellaneous();

            Func<int, int, bool> Remove_Duplicate_2_Loops_Func = (i, j) => i == j;
            checkIntsEquals_Delegate = new checkIntsEquals(Remove_Duplicate_2_Loops_Func);
            headerPrint("Remove_Duplicate_2_Loops");
            List<int> result_Remove_Duplicate_2_Loops = miscellaneous.Remove_Duplicate_2_Loops(arr, checkIntsEquals_Delegate);
            result_Remove_Duplicate_2_Loops.ForEach(x => resultPrint(x));

            Console.ReadKey();
        }
    }

    public class Miscellaneous
    {
        //Remove Duplicate Using 2 Loops.
        public List<int> Remove_Duplicate_2_Loops(int[] arr, checkIntsEquals @delegate)
        {
            List<int> result = new List<int>();
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
                    result.Add(arr[i]);
                }
            }
            return result;
        }
    }
}



