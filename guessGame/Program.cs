using System;
namespace guessGame
{
    class Program
    {
        static int number; // declaring field variables
        static int menu;
        static int guess;
        static int duplicate;
        public static int level = 1;

        static void Main(string[] args) // main method
        {

            Dialog.StartMessage();


            Random random = new Random();

            while ( Event.running == true) // while loop to run game as long as running is equal to true
            {
                try
                {
                    Dialog.Menu();
                    menu = Convert.ToInt32(Console.ReadLine()); // take guess as start menu input
                    Console.Clear();

                    if (menu == 1) // if start, Event will initialize field values according to easy to extreme properties
                    {
                        switch (level)
                        {
                            case 1:
                                Event.easy();
                                break;
                            case 2:
                                Event.moderate();
                                break;
                            case 3:
                                Event.hard();
                                break;
                            case 4:
                                Event.extreme();
                                break;
                            default:
                                Event.easy();
                                break;
                        }
                        number = random.Next(Event.min, Event.max); // declare secret number to a random int from event min to max
                        Console.WriteLine("Level: " + level); // cheat codes
                        Console.WriteLine("Min: " + Event.min);
                        Console.WriteLine("Max: " + Event.max);
                        Console.WriteLine("Num: " + number);

                        while (guess != number && Event.chances != 0) // 
                        {                  
                            Dialog.EnterGuess();
                            guess = Convert.ToInt32(Console.ReadLine());
                            if (duplicate == guess)
                            {
                                duplicate = guess;
                                Dialog.duplicate();
                            }
                            else
                            {
                                Event.gameMode(guess, number);
                            }
                            
                        }
                    }
                    else if (menu == 2)
                    {
                        Dialog.LevelSelect();
                        level = Convert.ToInt32(Console.ReadLine());
                    }
                    else if (menu == 3)
                    {
                        Event.running = false;
                    }

                }


                catch (Exception)
                {
                    Console.Clear();
                    Console.WriteLine("\nInvalid input");
                }
            }

            Dialog.Goodbye();
        }
    }
}