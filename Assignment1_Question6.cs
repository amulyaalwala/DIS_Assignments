using System;
using System.Text;

namespace Assignment1_Q6
{
    class Program
    {
        static void Main(string[] args)
        {

            //Quesiton 6:
            Console.WriteLine("Q6: Enter the sentence to convert:");
            string user_input = Console.ReadLine().ToLower();
            string goatLatin = ToGoatLatin(user_input);
            Console.WriteLine("Goat Latin for the Given Sentence is {0}", goatLatin);

        }

        private static string ToGoatLatin(string sentence)
        {
            try
            {
                int i,j;
            
                var word = sentence.Split(" "); // splitiing the input string interms of spaces


                string final_string = ""; // initializing/declaring the finalresult variable
                
             
                int count = 0;
                for (i = 0; i < word.Length; i++) // iterating through each word of the sentence
                {
                    string end_string = "ma";
                    
                    var split_word = word[i].ToCharArray();// converting each word of the sentence to a character array
                    

                   

                    // checking the vowel condition for the first element of the character string for each word

                    if (split_word[0] == 'a' || split_word[0] == 'e' || split_word[0] == 'i' || split_word[0] == 'o' || split_word[0] == 'u')
                    {

                        final_string = final_string + word[i] + end_string; // adding 'ma' to the end of each word

                    }

                    // if the first element is a consonenet 
                   
                    else

                    {

                        string x = word[i] + split_word[0] + end_string; // adding 'ma'  and the first element of the respective word at the end, for each word respectively

                        final_string = ' ' + final_string + x.TrimStart(split_word[0]);  // trimming/deleting the first element in each word

                    }

                    int n = count++;// incrementing the counter each time the loop is executed
                   

                    for (j = 0; j < n+1; j++)
                    {
                       
                        final_string = final_string + "a"; // appending the a value incrementally for all the words using for loop
                        
                    }
                    final_string = final_string + " ";// addding space between each word
                    

                }

                return final_string;


            }
            
            catch (Exception)
            {

                throw;
            }


        }


    }
}

    