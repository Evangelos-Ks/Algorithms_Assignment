using Assignment4.Entities.ToolMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4.Entities.Sorting_Algorithms
{
    public class BucketSort
    {
        public static void ExecuteBucketSort(List<TShirt> shirts, Check.comparison comparisonFirst, Check.comparison comparisonSecond, Check.comparison comparisonThird)
        {
            //    TShirt minValue = shirts[0];
            //    TShirt maxValue = shirts[0];

            //    for (int i = 1; i < shirts.Count; i++)
            //    {
            //        if (shirts[i].fabric > maxValue.fabric)
            //            maxValue = shirts[i];
            //        if (shirts[i].fabric < minValue.fabric)
            //            minValue = shirts[i];
            //    }

            //    List<TShirt>[] bucket = new List<TShirt>[maxValue.fabric - minValue.fabric + 1];

            //    for (int i = 0; i < bucket.Length; i++)
            //    {
            //        bucket[i] = new List<TShirt>();
            //    }

            //    for (int i = 0; i < shirts.Count; i++)
            //    {
            //        bucket[shirts[i].fabric - minValue.fabric].Add(shirts[i]);
            //    }


            //    int k = 0;
            //    for (int i = 0; i < bucket.Length; i++)
            //    {
            //        if (bucket[i].Count > 0)
            //        {
            //            for (int j = 0; j < bucket[i].Count; j++)
            //            {
            //                shirts[k] = bucket[i][j];
            //                k++;
            //            }
            //        }
            //    }
            //}

            List<TShirt> result = new List<TShirt>();

            //Determine how many buckets you want to create, in this case, the 10 buckets will each contain a range of 10
            //1-10, 11-20, 21-30, etc. since the passed array is between 1 and 99
            int numOfBuckets = 10;

            //Create buckets
            List<List<TShirt>> buckets = new List<List<TShirt>>();
            for (int i = 0; i < numOfBuckets; i++)
                buckets.Add(new List<TShirt>());

            //Iterate through the passed array and add each integer to the appropriate bucket
            for (int i = 0; i < shirts.Count; i++)
            {
                int buckitChoice = ((int)shirts[i].fabric / numOfBuckets);
                buckets[buckitChoice].Add(shirts[i]);
            }

            //Sort each bucket and add it to the result List
            //Each sublist is sorted using Bubblesort, but you could substitute any sorting algo you would like
            for (int i = 0; i < numOfBuckets; i++)
            {
                //BubbleSort.ExecuteBubbleSort(buckets[i], comparisonThird);
                //BubbleSort.ExecuteBubbleSort(buckets[i], comparisonSecond);
                //BubbleSort.ExecuteBubbleSort(buckets[i], comparisonFirst);

                InsertionSort.ExecuteInsertionSort(buckets[i], comparisonThird);
                InsertionSort.ExecuteInsertionSort(buckets[i], comparisonSecond);
                InsertionSort.ExecuteInsertionSort(buckets[i], comparisonFirst);

                result.AddRange(buckets[i]);

            }

            shirts.Clear();
            shirts.AddRange(result);

        }
    }
}
