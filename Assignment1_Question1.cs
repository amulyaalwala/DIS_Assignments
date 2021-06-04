using System;

namespace Assignment_1_Question_1
{
    class Program
    {


        static void Main(string[] args)
        {



            Console.WriteLine("Enter the combination of moves: ");



            String input_moves = Console.ReadLine().ToUpper();// converting the user input to upper case


            bool position = JudgeCircle(input_moves);

            if (position == true)
            {
                Console.WriteLine("The Robot return’s to initial Position (0,0)");
            }
            else
            {
                Console.WriteLine("The Robot doesn’t return to the Initial Postion (0,0)");
            }

            Console.WriteLine(position);

        }
        public static bool JudgeCircle(string i_moves)
        {



            int x = 0; //initializing  and declaring the variables to represent the position of the robot
            int y = 0;
            int i;


            char[] moves = i_moves.ToCharArray();// converting the user input string to character array

            for (i = 0; i < moves.Length; i++)// iterating through the length of the element
            {

                char move = moves[i]; // assigning each element of the character array to move iteratively

                if (move == 'R') // incrementing the x variable representing the right move
                {
                    x = x + 1;
                }

                else if (move == 'L') // decrementing the x variable representing the right move
                {
                    x = x - 1;
                }

                else if (move == 'U') // incrementing the y variable representing the upward move
                {
                    y = y++;

                }

                else if (move == 'D') // decrementing the x variable representing the downward move
                {
                    y = y--;

                }

            }



            if (x == 0 && y == 0)// checking if the combination of moves lead to 0 values, representing return to original position
            {

                return true;    //returning true/ false depending on the input moves meeting the condition
                //Console.WriteLine("true");

            }
            else
                return false;
            // Console.WriteLine(" false");
        }


    }

}



