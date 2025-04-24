using System;
using Sys = Cosmos.System;
using Cosmos.System.FileSystem.VFS;
using Cosmos.System.FileSystem;
using System.Collections.Generic;
using System.Text;


using System.IO;
using COS.COSMAIN.Graphics;
using COS.COSMAIN.Hardware;
using COS.COSMAIN;
using COSKERNEL;
using COS;
namespace COS.COSMAIN.Programs
{
	public class PerfectLetter : Command
	{
		public PerfectLetter()
		{
			Description = $"Command to link for getting help with {nameof(COS)}";
			Name = nameof(PerfectLetter);
		}

		public override string Invoke(string[] Args)
		{
			Console.BackgroundColor = ConsoleColor.Green;
			Console.ForegroundColor = ConsoleColor.Black;
			Console.WriteLine("soon");
			
			Console.BackgroundColor = ConsoleColor.Black;
			Console.ForegroundColor = ConsoleColor.White;


			return "";





		}
	}
}