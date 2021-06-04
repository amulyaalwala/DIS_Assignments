using System;
using System.Collections.Generic;

namespace A1_Q3
{
    class Program
    {

        public static void Main(string[] args)
        {

            int[] arr = { 1, 2, 3, 1, 1, 3 };
            int gp = NumIdenticalPairs(arr);

            Console.WriteLine("Q3:");
            Console.WriteLine("The number of IdenticalPairs in the array are :" +
          gp);


        }

        public static int NumIdenticalPairs(int[] arr)
        {


            int i, j;
            int l = arr.Length;
            int count_pairs= 0;
            for (i = 0; i < l; i++) // iterating through the length of the array
            {
                for (j = i + 1; j < l; j++)
                {


                    if (arr[i] == arr[j]) // finding the element of the array with same value and different array index
                    {

                        count_pairs++; //increasing the count once the elements with same value are found

                    }


                }

            }

            return count_pairs; 

        }



     

        
    }
}





//String input = Console.ReadLine();
//String[] seperators = input.Split(' ');


//List<int> nums = new List<int>();
//int x;
//foreach (string s in seperators)
//{
//    if (Int32.TryParse(s, out x))
//    {
//        nums.Add(x);
//    }

//}
//for (int i = 0; i < )
//    Console.WriteLine("display the integer array" + nums);


//int[] val = new int[8];
//for (int i = 0; i < val.Length; i++)
//{

//    val[i] = int.Parse(Console.ReadLine());
//    Console.WriteLine("display the inetegers in the array: " + val[i]);
//}

