using System;
using Sys = Cosmos.System;
using Cosmos.System.FileSystem.VFS;
using Cosmos.System.FileSystem;
using COS.COSMAIN.Graphics;
using COS.COSMAIN.Hardware;
using COS.COSMAIN;
using COSKERNEL;
using COS;

namespace COS.COSMAIN.Commands
{
	public class Clear : Command
	{
		public Clear()
		{
			Description = "Clears the console.";
			Name = nameof(Clear);
		}

		public override string Invoke(string[] Args)
		{
			Console.Clear();

			
			
			Console.BackgroundColor = ConsoleColor.Black;
			TextGraphics.DrawLineH(0, 0, CLI.Width, ' ', Color.Black, Kernel.TitleBarColor); // draw background
			TextGraphics.DrawString(CLI.Width - Kernel.OS_NAME.Length, 0, Kernel.OS_NAME, Kernel.TitleColor, Kernel.TitleBarColor); // draw title

			// TextGraphics.DrawString(CLI.Width - TitleBarTime.Length, 0, TitleBarTime, DateTimeColor, TitleBarColor); // draw title

			Console.BackgroundColor = ConsoleColor.Green;
			Console.WriteLine(DateTime.Now.ToString());
			Console.BackgroundColor = ConsoleColor.Black;
			Console.WriteLine("Type 'Help' to view command list");
			return "";
		}
	}
}