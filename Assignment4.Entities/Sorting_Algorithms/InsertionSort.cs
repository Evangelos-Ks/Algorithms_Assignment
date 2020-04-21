using Assignment4.Entities.ToolMethods;
using System.Collections.Generic;

namespace Assignment4.Entities.Sorting_Algorithms
{
    public class InsertionSort
    {
        public static void ExecuteInsertionSort(List<TShirt> shirts, Check.comparison comparison)
        {
            int n = shirts.Count;
            for (int i = 1; i < n; ++i)
            {
                TShirt key = shirts[i];
                int j = i - 1;

                while (j >= 0 && comparison(shirts[j], key))
                {
                    shirts[j + 1] = shirts[j];
                    j = j - 1;
                }
                shirts[j + 1] = key;
            }
        }
    }
}
