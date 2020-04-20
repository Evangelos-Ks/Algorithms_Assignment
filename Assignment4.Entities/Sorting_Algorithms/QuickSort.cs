using Assignment4.Entities.ToolMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4.Entities.Sorting_Algorithms
{
    public class QuickSort
    {
        //============================================= Partition ==========================================================
        protected static int Partition(List<TShirt> shirts, int low, int high, Check.test comparison)
        {

            //This is the original way to find the pivot
            TShirt pivot = shirts[high];

            //This logic for the pivot point implemented by Koutsogiorgos Evangelos
            //int potentialPivot1 = (int)shirts[high].color;
            //int potentialPivot2 = (int)shirts[low].color;
            //int potentialPivot3 = (int)shirts[(low + high) / 2].color;

            //List<int> pontentialPivotsArr = new List<int> { potentialPivot1, potentialPivot2, potentialPivot3 };
            //pontentialPivotsArr.Sort();
            //int pivot = pontentialPivotsArr[1];
            //Until here

            // index of smaller element 
            TShirt temp;
            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                // If current element is smaller  
                // than the pivot 
                if (!comparison((int)shirts[j].color, (int)pivot.color))
                {
                    i++;

                    // swap arr[i] and arr[j] 
                    temp = shirts[i];
                    shirts[i] = shirts[j];
                    shirts[j] = temp;
                }
            }

            // swap arr[i+1] and arr[high] (or pivot) 
            TShirt temp1 = shirts[i + 1];
            shirts[i + 1] = shirts[high];
            shirts[high] = temp1;

            return i + 1;
        }

        //============================================= Quick Sort =========================================================
        public static void ExecuteQuickSort(List<TShirt> shirts, int low, int high, Check.test comparison)
        {
            if (low < high)
            {

                /* pi is partitioning index, arr[pi] is  
                now at right place */
                int pi = Partition(shirts, low, high, comparison);

                // Recursively sort elements before 
                // partition and after partition 
                ExecuteQuickSort(shirts, low, pi - 1, comparison);
                ExecuteQuickSort(shirts, pi + 1, high, comparison);
            }
        }
    }
}
