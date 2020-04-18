using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment4.Entities.ToolMethods;

namespace Assignment4.Entities.Sorting_Algorithms
{
    public class BubbleSort
    {
        public static void ExecuteBubbleSort(List<TShirt> shirts, Check.test test)
        {
            
            TShirt temporary;
            for (int p = 0; p <= shirts.Count - 2; p++)
            {
                for (int i = 0; i <= shirts.Count - 2; i++)
                {
                    if (test((int)shirts[i].size , (int)shirts[i + 1].size))
                    { 
                        temporary = shirts[i + 1];
                        shirts[i + 1] = shirts[i];
                        shirts[i] = temporary;
                    }
                }
            }
        }

    }


}

