using System;
using System.Collections.Generic;

namespace Assigment_1_Question_2
{
    class Program
    {
        static void Main(string[] args)

        {
        
            Console.WriteLine(" Q2 : Enter the string to check for pangram:");
            string sentence = Console.ReadLine().ToLower();
            string alphabets = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            alphabets = alphabets.ToLower();

            bool flag = CheckIfPangram(sentence);
            if (flag)
            {
                Console.WriteLine("Yes, the given string is a pangram");
            }
            else
            {
                Console.WriteLine("No, the given string is not a pangram");
            }
            Console.WriteLine(flag);
        }



        public static bool CheckIfPangram(string sentence)
        {



            try
            {
                
                char[] char_sentence = sentence.ToCharArray();
                char[] charaar2 = new char[] { };
                int i;
                List<char> char_list = new List<char>();

                for (i = 0; i < char_sentence.Length; i++)
                {

                    bool isDuplicate = false;

                    for (int j = 0; j < i; j++)
                    {
                        if (char_sentence[i] == char_sentence[j])
                        {
                            isDuplicate = true;
                            break;
                        }
                    }
                    if (!isDuplicate)
                    {
                        char x = char_sentence[i];
                        char_list.Add(x);
                      //  Console.WriteLine("unique characters in the array " +  i  +  char_sentence[i]);
                        
                    }

                }


                if (char_list.Count == 26)
                {
                    
                    return true;


                }
                else
                    return false;


            }

            catch (Exception)
            {

                throw;
            }

        }

    }

    
}

        

            
            
            
            
            



        

                