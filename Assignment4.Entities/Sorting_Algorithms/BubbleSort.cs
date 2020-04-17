using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4.Entities.Sorting_Algorithms
{
    class BubbleSort
    {
        public void ExecuteBubbleSort(List<TShirt> shirts ,Check check)
        {
            TShirt temporary;
            for (int p = 0; p <= shirts.Count - 2; p++)
            {
                for (int i = 0; i <= shirts.Count - 2; i++)
                {
                    if (shirts[i].color > shirts[i + 1].color)
                    {
                        temporary = shirts[i + 1];
                        shirts[i + 1] = shirts[i];
                        shirts[i] = temporary;
                    }
                }
            }
        }


       public delegate bool Check();
    }


}

