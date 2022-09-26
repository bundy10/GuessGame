using System;
namespace guessGame
{
    public class Event
    {
        // min and max number
        // chances
        // state of game
        // difficulty
        public static int min, max, chances;
        public static string? level;
        public static bool running = true;


        public static void easy()
        {
            min = 1;
            max = 10;
            chances = 5;
            level = "easy";
        }

        public static void moderate()
        {
            min = 1;
            max = 50;
            chances = 10;
            level = "moderate";
        }

        public static void hard()
        {
            min = 1;
            max = 100;
            chances = 15 ;
            level = "hard";
        }

        public static void extreme()
        {
            min = 1;
            max = 200;
            chances = 20;
            level = "extreme";
        }


        // Methods
        // game difficulties involving min and max number and chances to guess
        // boolean to end or start game loop
        // game modes

        public static void gameMode(int guess, int secret)
        {
            var difference = secret - guess;

            if (difference == 0)
            {
                Dialog.Win();
                running = false;
            }
            else
            {
                gameIfs(difference);
            }

        }


        public static void gameIfs(int difference)
        {
            chances--;
            Dialog.chancesLeft(chances);

            if (chances == 0)
            {
                Dialog.Lost();
                running = false;
            }
            else if (difference > 0)
            {
                Dialog.Higher();
            }
            else if (difference < 0)
            {
                Dialog.Lower();
            }
        }
    }
}

