using System;

namespace A1_Q4
{
    class Program
    {
        public static void Main(string[] args)
        {

            //Question 4

           // int[] arr1 = { 3, 1, 4, 1, 5 };
            int[] arr1 = { 5, 1, 4, 1, 5 };


            int pivot = PivotIndex(arr1);

            if (pivot > 0)
            {

                Console.WriteLine("The Pivot index for the given array is :" + PivotIndex(arr1));

            }
            else if (pivot < 0)
            {
                Console.WriteLine("There is no pivot index for this array, hence displaying " + PivotIndex(arr1));
            }
        }

        public static int PivotIndex(int[] arr1)
        {
            int i, j; // declaring and initializing variables to store sum of elements to the right and left
            int sum_left, sum_right;
            int count = arr1.Length;
            //sum_left = 0;
            //sum_right = 0;


            for (i = 0; i < arr1.Length; i++)// checking for indexes, until the equiliobrium index is found
            {

                sum_left = 0;
                sum_right = 0;
                for (j = 0; j < i; j++) // iterating through the array length and adding the sum of the elements to the left of the index


                {
                    sum_left = sum_left + arr1[j]; // finding the sum of elements to the left

                }
                for (j = i + 1; j < count; j++) 
                {
                    sum_right = sum_right + arr1[j]; // finding the sum of elements to the right

                }

                if (sum_right == sum_left)// checking for the index that creates an equal left sum and right sum
                {
                    return i;

                }
                
            }


            return -1;

        }

       
    }
}
