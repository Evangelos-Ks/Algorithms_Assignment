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
        protected static int Partition(int[] arr, int low, int high)
        {

            //This is the original way to find the pivot
            //int pivot = arr[high]; 

            //This logic for the pivot point implemented by Koutsogiorgos Evangelos
            int potentialPivot1 = arr[high];
            int potentialPivot2 = arr[low];
            int potentialPivot3 = arr[(low + high) / 2];

            List<int> pontentialPivotsArr = new List<int> { potentialPivot1, potentialPivot2, potentialPivot3 };
            pontentialPivotsArr.Sort();
            int pivot = pontentialPivotsArr[1];
            //Until here

           // index of smaller element 
            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                // If current element is smaller  
                // than the pivot 
                if (arr[j] < pivot)
                {
                    i++;

                    // swap arr[i] and arr[j] 
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            // swap arr[i+1] and arr[high] (or pivot) 
            int temp1 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp1;

            return i + 1;
        }

        //============================================= Quick Sort =========================================================
        public static void ExecuteQuickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {

                /* pi is partitioning index, arr[pi] is  
                now at right place */
                int pi = Partition(arr, low, high);

                // Recursively sort elements before 
                // partition and after partition 
                ExecuteQuickSort(arr, low, pi - 1);
                ExecuteQuickSort(arr, pi + 1, high);
            }
        }
    }
}
