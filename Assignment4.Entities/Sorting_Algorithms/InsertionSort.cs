﻿using Assignment4.Entities.ToolMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4.Entities.Sorting_Algorithms
{
    public class InsertionSort
    {
        public static void ExecuteInsertionSort(List<TShirt> shirts, Check.test test)
        {
            int n = shirts.Count;
            for (int i = 1; i < n; ++i)
            {
                TShirt key = shirts[i];
                int j = i - 1;

                while (j >= 0 && test((int)shirts[j].fabric, (int)key.fabric))
                {
                    shirts[j + 1] = shirts[j];
                    j = j - 1;
                }
                shirts[j + 1] = key;
            }
        }
    }
}