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
        public static void ExecuteBubbleSort(List<TShirt> shirts, Check.comparison comparison)
        {
            
            TShirt temporary;
            for (int p = 0; p <= shirts.Count - 2; p++)
            {
                for (int i = 0; i <= shirts.Count - 2; i++)
                {
                    if (comparison(shirts[i] ,shirts[i + 1]))
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

