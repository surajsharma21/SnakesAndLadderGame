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
			int currPosition = INITIAL_POSITION;
			int moves = 0;
			Console.WriteLine("Welcome to Snake Ladder Game!!!");
			Console.WriteLine("Player is at the starting position");
			while (currPosition != WINNING_POSITION)
			{
				Random random = new Random();
				int diceValue = random.Next(1, 7);
				Console.WriteLine("Player rolled : " + diceValue);
				int actionTaken = random.Next(0, 3);
				if (actionTaken == NO_PLAY)
				{
					Console.WriteLine("No action taken");
				}
				else if (actionTaken == LADDER)
				{
					currPosition += diceValue;
					if (currPosition > WINNING_POSITION)
					{
						currPosition -= diceValue;
					}
				}
				else
				{
					currPosition -= diceValue;
					if (currPosition < INITIAL_POSITION)
					{
						currPosition = INITIAL_POSITION;
					}
				}
				moves++;
				Console.WriteLine("Player is at position : " + currPosition);
			}
			Console.WriteLine("Player reaches exact winning position in : " + moves + " moves");
		}
	}
}
