﻿using System;

namespace SnakesAndLadderGame
{
    class Program
    {
        public const int START_POINT = 0;
        public const int END_POINT = 100;
        public const int NO_PLAY = 0;
        public const int SNAKE = 1;
        public const int LADDER = 2;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to snakes and ladders game \nEnter player name");
            string player1 = Console.ReadLine();
            int playerPosition = START_POINT;
            int diceRoll = DiceRoll();
            Console.WriteLine("Dice Roll : " + diceRoll);
            playerPosition = PlayerMovement(diceRoll, playerPosition);
            Console.WriteLine("Your Position: " + playerPosition);
        }
        static int DiceRoll()
        {
            Random random = new Random();
            int diceNumber = random.Next(1, 7);
            return diceNumber;
        }
        static int PlayerMovement(int numberRolled, int playerPosition)
        {
            Random random = new Random();
            int move = random.Next(0, 3);
            switch (move)
            {
                case NO_PLAY:
                    Console.WriteLine("No Play");
                    break;
                case SNAKE:
                    Console.WriteLine("Snake");
                    playerPosition = playerPosition - numberRolled;
                    break;
                case LADDER:
                    Console.WriteLine("Ladder");
                    playerPosition = playerPosition + numberRolled;
                    break;
            }
            return playerPosition;
        }
    }
}
