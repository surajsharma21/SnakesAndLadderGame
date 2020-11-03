using System;

namespace SnakesAndLadderGame
{
	class Program
	{
		public const int NO_OF_PLAYERS = 1;
		public const int INITIAL_POSITION = 0;
		public const int NO_PLAY = 0;
		public const int LADDER = 1;
		public const int SNAKE = 2;
		public const int WINNING_POSITION = 100;
		static void Main(String[] args)
		{
			int player1Pos = INITIAL_POSITION;
			int player2Pos = INITIAL_POSITION;
			bool player1 = true;
			Console.WriteLine("Welcome to Snake Ladder Game!!!");
			Console.WriteLine("Both players are at the starting position");
			while (player1Pos != WINNING_POSITION && player2Pos != WINNING_POSITION)
			{
				if (player1)
				{
					Random random = new Random();
					int diceValue = random.Next(1, 7);
					Console.WriteLine("Player rolled : " + diceValue);
					int actionTaken = random.Next(0, 3);
					if (actionTaken == NO_PLAY)
					{
						player1 = false;
					}
					else if (actionTaken == LADDER)
					{
						player1Pos += diceValue;
						if (player1Pos > WINNING_POSITION)
						{
							player1Pos -= diceValue;
						}
					}
					else
					{
						player1 = false;
						player1Pos -= diceValue;
						if (player1Pos < INITIAL_POSITION)
						{
							player1Pos = INITIAL_POSITION;
						}
					}
				}
				else
				{
					Random random = new Random();
					int diceValue = random.Next(1, 7);
					Console.WriteLine("Player rolled : " + diceValue);
					int actionTaken = random.Next(0, 3);
					if (actionTaken == NO_PLAY)
					{
						player1 = true;
					}
					else if (actionTaken == LADDER)
					{
						player2Pos += diceValue;
						if (player2Pos > 100)
						{
							player2Pos -= diceValue;
						}
					}
					else
					{
						player1 = true;
						player2Pos -= diceValue;
						if (player2Pos < INITIAL_POSITION)
						{
							player2Pos = INITIAL_POSITION;
						}
					}
				}
			}
			if (player1Pos == WINNING_POSITION)
			{
				Console.WriteLine("Player 1 won the game");
			}
			else
			{
				Console.WriteLine("Player 2 won the game");
			}
		}
	}
}
