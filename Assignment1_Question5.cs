using System;

namespace Assignment1_Q5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Q5:");
            Console.WriteLine("Enter the First Word:");
            string user_input_word1 = Console.ReadLine();

            Console.WriteLine("Enter the Second Word:");
            string user_input_word2 = Console.ReadLine();

            string merged = MergeAlternately(user_input_word1, user_input_word2);

            Console.WriteLine("The Merged Sentence formed by both words is {0}" + merged);

        }

        public static string MergeAlternately(string word1, string word2)
        {

            try
            {
                int i = 0;
                int j = 0;
                string merged_string = "";

                while ( i < word1.Length || j<word2.Length)// for each element in the array, iterating through the length of the array string
                {



                    if (i < word1.Length) // for each element of the string, getting the letter respective to the index for word1 
                    {
                        merged_string = merged_string + word1[i];
                        i++;
                    }

                    if (j < word2.Length) // for each element of the string, getting the letter respective to the index for word2
                    {
                        merged_string = merged_string + word2[j];// adding the elements alternatively
                        j++;
                    }

                }

            
                return merged_string;

            }

            catch(Exception e)
            {

                Console.WriteLine(e.Message);
                throw;
            }

        }

    }
    
}
