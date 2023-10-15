using System;
using System.Collections.Generic;
using System.Linq;

namespace Miscellaneous_ConsoleApp
{
    //Delegates.
    public delegate bool TwoIntOperation(int i, int j);

    public delegate bool ThreeIntOperation(int i, int j, int k);

    public delegate bool TwoCharOperation(char a, char b);

    public delegate bool DictionaryCointains(Dictionary<int, int> dic, int i);

    public class Program
    {
        private static void Main(string[] args)
        {
            //Delegates declaration and initialization.
            Action<string> headerPrint = str => Console.WriteLine($"\n--------------------{str}------------\n");
            Action<dynamic> resultPrint = dy => Console.WriteLine($"{dy}");
            Action<KeyValuePair<int, int>> keyValuePairPrint = kv => Console.WriteLine($"{kv.Key} repeats {kv.Value} times");
            Action<Tuple<int, int>> TuplePrint = tu => Console.WriteLine($"Highest - {tu.Item1} \nSecond highest {tu.Item2} ");
            TwoIntOperation twoIntOperation_Delegate;
            DictionaryCointains dictionaryCointains_Delegate;
            ThreeIntOperation ThreeIntOperation_Delegate;
            TwoCharOperation twoCharOperation_Delegate;

            //Data initialization
            int[] arr = { 1, 3, 5, 4, 4, 5, 3, 9, 2, 8, 4 };
            int[] arr2 = { 1, 3, 5, 4, 4, 5, 3, 9, 2, 8, 4 };
            MiscellaneousPrograms miscellaneousPrograms = new MiscellaneousPrograms();

            #region Remove Duplicate.

            headerPrint("Remove_Duplicate_2_Loops");
            Func<int, int, bool> Remove_Duplicate_2_Loops_Func = (i, j) => i == j;
            twoIntOperation_Delegate = new TwoIntOperation(Remove_Duplicate_2_Loops_Func);
            List<int> result_Remove_Duplicate_2_Loops = miscellaneousPrograms.Remove_Duplicate_2_Loops(arr, twoIntOperation_Delegate);
            result_Remove_Duplicate_2_Loops.ForEach(x => resultPrint(x));

            headerPrint("Remove_Duplicate_1_Loops");
            HashSet<int> result_Remove_Duplicate_1_Loops = miscellaneousPrograms.Remove_Duplicate_1_Loops(arr);
            result_Remove_Duplicate_1_Loops.ToList().ForEach(x => resultPrint(x));

            headerPrint("Remove_Duplicate_Recursion_0_Loops");
            Func<int, int, bool> Remove_Duplicate_Recursion_0_Loops_Func = (i, j) => i > j;
            twoIntOperation_Delegate = new TwoIntOperation(Remove_Duplicate_Recursion_0_Loops_Func);
            HashSet<int> result_Remove_Duplicate_Recursion_0_Loops = new HashSet<int>();
            miscellaneousPrograms.Remove_Duplicate_Recursion_0_Loops(arr, twoIntOperation_Delegate, result_Remove_Duplicate_Recursion_0_Loops);
            result_Remove_Duplicate_Recursion_0_Loops.ToList().ForEach(x => resultPrint(x));

            #endregion Remove Duplicate.

            #region Sort Array.

            headerPrint("Sort_2_Loops");
            Func<int, int, bool> Sort_2_Loops_Func = (i, j) => i > j;
            twoIntOperation_Delegate = new TwoIntOperation(Sort_2_Loops_Func);
            miscellaneousPrograms.Sort_2_Loops(arr2, twoIntOperation_Delegate);
            arr2.ToList().ForEach(x => resultPrint(x));

            headerPrint("Sort_1_Loops");
            SortedSet<int> result_Sort_1_Loops = miscellaneousPrograms.Sort_1_Loops(arr);
            result_Sort_1_Loops.ToList().ForEach(x => resultPrint(x));

            headerPrint("Sort_Recursion_0_Loops");
            Func<int, int, bool> Sort_Recursion_0_Loops_Func = (i, j) => i > j;
            twoIntOperation_Delegate = new TwoIntOperation(Sort_Recursion_0_Loops_Func);
            SortedSet<int> result_Sort_Recursion_0_Loops = new SortedSet<int>();
            miscellaneousPrograms.Sort_Recursion_0_Loops(arr, twoIntOperation_Delegate, result_Sort_Recursion_0_Loops);
            result_Sort_Recursion_0_Loops.ToList().ForEach(x => resultPrint(x));

            #endregion Sort Array.

            headerPrint("Count_Duplicate_Array");
            Func<Dictionary<int, int>, int, bool> Count_Duplicate_Array_Func = (dic, i) => dic.ContainsKey(i);
            dictionaryCointains_Delegate = new DictionaryCointains(Count_Duplicate_Array_Func);
            Dictionary<int, int> Count_Duplicate_Array_result = miscellaneousPrograms.Count_Duplicate_Array(arr, dictionaryCointains_Delegate);
            foreach (KeyValuePair<int, int> kv in Count_Duplicate_Array_result)
            {
                keyValuePairPrint(kv);
            }

            #region Prime.

            headerPrint("Prime");
            Func<int, int, int, bool> Prime_Func = (i, j, k) => i % j == k;
            ThreeIntOperation_Delegate = new ThreeIntOperation(Prime_Func);
            resultPrint($"{miscellaneousPrograms.Prime(17, ThreeIntOperation_Delegate)} - Pass \n");
            resultPrint($"{miscellaneousPrograms.Prime(18, ThreeIntOperation_Delegate)} - Fail");

            #endregion Prime.

            headerPrint("Fibnocci");
            List<int> result_Fibnocci = miscellaneousPrograms.Fibnocci(10);
            result_Fibnocci.ForEach(x => resultPrint(x));

            headerPrint("Factorial");
            resultPrint($"{miscellaneousPrograms.Factorial(5)}");

            #region Palindrome.

            headerPrint("String_Palindrome");
            Func<char, char, bool> String_Palindrome_Func = (a, b) => a != b;
            twoCharOperation_Delegate = new TwoCharOperation(String_Palindrome_Func);
            resultPrint($"{miscellaneousPrograms.String_Palindrome("racecar", twoCharOperation_Delegate)} - Pass \n");
            resultPrint($"{miscellaneousPrograms.String_Palindrome("dummyfail", twoCharOperation_Delegate)} - Fail");

            headerPrint("Number_Palindrome");
            Predicate<int> Number_Palindrome_Predicate = i => i != 0;
            Func<int, int, bool> Number_Palindrome_Func = (i, j) => i == j;
            twoIntOperation_Delegate = new TwoIntOperation(Sort_Recursion_0_Loops_Func);

            resultPrint($"{miscellaneousPrograms.Number_Palindrome(11211, Number_Palindrome_Predicate, twoIntOperation_Delegate)} - Pass \n");
            resultPrint($"{miscellaneousPrograms.Number_Palindrome(12345, Number_Palindrome_Predicate, twoIntOperation_Delegate)} - Fail \n");

            #endregion Palindrome.

            headerPrint("Add_Three_Adjecent_Get_Max");
            Func<int, int, bool> Add_Three_Adjecent_Get_Max_Func = (i, j) => i > j;
            twoIntOperation_Delegate = new TwoIntOperation(Add_Three_Adjecent_Get_Max_Func);
            resultPrint($"{miscellaneousPrograms.Add_Three_Adjecent_Get_Max(arr, twoIntOperation_Delegate)}");

            #region Get Second Highest Number Array.

            Func<int, int, bool> greater_Add_Three_Adjecent_Get_Max_Func = (i, j) => i > j;
            twoIntOperation_Delegate = new TwoIntOperation(greater_Add_Three_Adjecent_Get_Max_Func);
            Func<int, int, bool> lesser_Add_Three_Adjecent_Get_Max_Func = (i, j) => i < j;
            TwoIntOperation twoIntOperation_Delegate_2 = new TwoIntOperation(lesser_Add_Three_Adjecent_Get_Max_Func);

            headerPrint("Get_Second_Highest_Number_Array_WithLoop");
            resultPrint($"{miscellaneousPrograms.Get_Second_Highest_Number_Array_WithLoop(arr, twoIntOperation_Delegate, twoIntOperation_Delegate_2)}");

            headerPrint("Get_Second_Highest_Number_Array_No_Loop");
            Tuple<int, int> tuple_Get_Second_Highest_Number_Array_WithLoop = Tuple.Create(0, 0);
            miscellaneousPrograms.Get_Second_Highest_Number_Array_No_Loop(arr, twoIntOperation_Delegate, twoIntOperation_Delegate_2, ref tuple_Get_Second_Highest_Number_Array_WithLoop);
            TuplePrint(tuple_Get_Second_Highest_Number_Array_WithLoop);

            #endregion Get Second Highest Number Array.

            #region ODD EVEN.

            headerPrint("Even");
            resultPrint($"{10 % 2 == 0}");
            headerPrint("Odd");
            resultPrint($"{11 % 2 != 0}");

            #endregion ODD EVEN.

            //The output console will close when any keyboard key is pressed.
            Console.ReadKey();
        }
    }
}