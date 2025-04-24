using System;
using Sys = Cosmos.System;
using Cosmos.System.FileSystem.VFS;
using Cosmos.System.FileSystem;
using System.Collections.Generic;
using System.Text;
using Cosmos.Core;


using System.IO;
using COS.COSMAIN.Graphics;
using COS.COSMAIN.Hardware;
using COS.COSMAIN;
using COSKERNEL;
using COS;

namespace COS.COSMAIN.Commands
{
	public class About : Command
	{
		public About()
		{
			Description = "Gets information about the system.";
			Name = nameof(About);
		}

		//int screenX = 800;
		//int screenY = 640;


		public override string Invoke(string[] Args)
		{
			string Response = "";

			Console.WriteLine("");
			Console.ForegroundColor = ConsoleColor.Blue;
			Console.WriteLine("  /C/#");
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("C/O/S");
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("/S/");
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("");
			Console.WriteLine("COS Version " + Kernel.OS_VER + " CodeName " + Kernel.OS_CODENAME);
			Console.WriteLine("Build: " + Kernel.OS_BUILD);
			Console.WriteLine(Kernel.OS_EDITION);
			Console.WriteLine("");
			Console.WriteLine(Kernel.OS_CTADA);
			Console.WriteLine(Kernel.KERNEL_INFO);
			Console.WriteLine("COS License gaved to: " + Kernel.user);
			Console.WriteLine("");
			Console.WriteLine("GreenSoupDeveloper 2022-2022");
			Console.WriteLine("");
			/*uint maxmem = Cosmos.Core.CPU.GetAmountOfRAM();
			ulong availableMem = Cosmos.Core.GCImplementation.GetAvailableRAM();
			ulong usedmem = availableMem - maxmem;*/

			/*case "user":
				Response += user;
				break;

			case "mem":
				{
					Response += "Memory Used: " + ((usedmem / 1024) / 1024) + "/" + maxmem;//must fix this lol
					//Response += "\nMemory Available: " + availableMem;
					break;
					break;
				}

			case "screen":
				Response += "Screensize (Columns and Rows): " + screenX + " x " + screenY;
				break;*/



			return Response;
		}
	}
}