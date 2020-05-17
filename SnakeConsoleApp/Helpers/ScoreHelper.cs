using System;

namespace SnakeConsoleApp.Helpers
{
	public static class ScoreHelper
	{
		public static void GetScore(int score)
		{
			Console.SetCursorPosition(2, 22);
			Console.WriteLine($"Score: {score}");
		}
	}
}
