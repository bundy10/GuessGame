﻿using System;
using System.Reflection.Emit;

namespace guessGame
{
    public class Dialog
    {

        public static void StartMessage()
        {
            Console.WriteLine("Number Guessing Game");
        }

        public static void Win()
        {
            Console.WriteLine("you have won!");
        }

        public static void Higher()
        {
            Console.WriteLine("the secret number is higher!");
        }

        public static void Lower()
        {
            Console.WriteLine("the secret number is lower!");
        }

        public static void chancesLeft(int chances)
        {
            Console.WriteLine("you have {0} chances left", chances);
        }

        public static void Lost()
        {
            Console.WriteLine("you have lost");
        }

        public static void Menu()
        {
            Console.Clear();
            Console.WriteLine("____Welcome to Number Guessing Game____\n\nEnter Input\n");
            Console.WriteLine("1: Start Game");
            Console.WriteLine("2: Change level");
            Console.WriteLine("3: Exit");
        }

        public static void EnterGuess()
        {
            Console.WriteLine("enter your guess ");
        }

        public static void LevelSelect()
        {
            Console.Clear();
            Console.WriteLine("____Select Your Level____\n");
            Console.WriteLine("1: Easy\n2: Moderate \n3: Hard\n4: Extreme \n");
            Console.WriteLine($"Current Level: {Program.level}");
        }

        public static void Goodbye()
        {
            Console.WriteLine("thanks for playing");
        }
    }
}
