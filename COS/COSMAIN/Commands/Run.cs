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
namespace COS.COSMAIN.Commands
{
	public class Run : Command
	{
		public Run()
		{
			Description = $"Command to link for getting help with {nameof(COS)}";
			Name = nameof(Run);
		}


		public override string Invoke(string[] Args)
		{
			try
			{
				string Response;
				Console.WriteLine("what file do you want to open?");
				var openfile = Console.ReadLine();
				Console.WriteLine("what type of file do you want to open? (for example: 'program', 'text', 'none')");
				var openexfile = Console.ReadLine();

				if (openexfile == "")
				{
					Console.WriteLine("COS cant open <" + openfile + "> wihout a type of file");
				}
				if (openexfile == "text")
				{
					Console.Clear();
					Console.WriteLine(File.ReadAllText(@"0:\" + Kernel.nowDirectory + Kernel.nowChildDirectory + Kernel.nowChildChildDirectory + openfile));
				}
				if (openexfile == "program")
				{
					Console.Clear();
					Console.WriteLine("this format is for now unsupported, but soon is going to be the executable format of COS");
				}
				if (openexfile == "pl")
				{
					Console.Clear();
					Console.WriteLine("soon");
				}
				if (openexfile == "none")
				{
					Console.Clear();
					Console.WriteLine("this file doesnt have a format but it can be opened as a text, do you want to open this file? (Y) (N)");
					var request = Console.ReadLine();

					if (request == "y" || request == "Y")
					{
						Console.WriteLine(File.ReadAllText(@"0:\" + Kernel.nowDirectory + Kernel.nowChildDirectory + openfile));
					}

					if (request == "n" || request == "N")
					{
						return "";
					}
				}
				if (openexfile == "program" && openfile == "COSPAD.program")
				{
					Console.Clear();
					string cospad = "COSPad";
					string repsonse = Shell.Invoke(cospad.Split(' '));//ads a space after >
					Console.WriteLine(repsonse); // writes the responce to the users command
				}
				if (openexfile == "program" && openfile == "PERFECTLETTER.program")
				{
					Console.Clear();
					string pl = "PerfectLetter";
					string repsonse = Shell.Invoke(pl.Split(' '));//ads a space after >
					Console.WriteLine(repsonse); // writes the responce to the users command
				}




			}
			catch (Exception e)
			{
				Console.WriteLine("COS cant open this file");
				Console.WriteLine("Error: " + e.ToString());

			}



			return "";





		}
	}
}
