using System;
using Sys = Cosmos.System;
using Cosmos.System.FileSystem.VFS;
using Cosmos.System.FileSystem;
using System.Collections.Generic;
using System.Text;

using System.IO;
using COS.COSMAIN.Graphics;
using COS.COSMAIN.Hardware;

using Cosmos.System.Audio;
using Cosmos.System.Audio.IO;
using Cosmos.HAL.Drivers.PCI.Audio;
using Cosmos.HAL.Audio;

using COS.COSMAIN;
using COS.Drivers;

using Cosmos.System.Graphics;
using Cosmos.System.Graphics.Fonts;
using Cosmos.HAL;
using Cosmos.Core.Memory;
using COS.COSMAIN.Resources;
using static Cosmos.Core.INTs;
using Cosmos.System.Network.IPv4.UDP.DHCP;

using Cosmos.Core;


using System.IO;

using COSKERNEL;
using COS;



namespace COS.COSMAIN.Commands
{
	public class System : Command
	{
		public System()
		{
			Description = "Gets information about the system.";
			Name = nameof(System);
		}
		

	//	int screenX = 800;
	//	int screenY = 640;
		public string user = Kernel.user;
		public string hostName = "COS";
		public string version = "v 2.50";
	

		public override string Invoke(string[] Args)
		{
			string Response = "";

			uint maxmem = Cosmos.Core.CPU.GetAmountOfRAM();
			ulong availableMem = Cosmos.Core.GCImplementation.GetAvailableRAM();
			ulong usedmem = availableMem - maxmem;
			Console.WriteLine("");
			Console.ForegroundColor = ConsoleColor.Blue;
			Console.WriteLine("  /C/#");
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("C/O/S");
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("/S/");
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("");
			Console.WriteLine("Memory Used:" + ((usedmem / 1024) / 1024) + "/" + maxmem);
			Console.WriteLine("");
			Console.WriteLine("Memory Avalaible:" + availableMem);
			//Console.WriteLine("Screen Size: " + "x: " + screenX + " y: " + screenY);
			Console.WriteLine("");
			Console.WriteLine("Hard Disk Info");
			Console.WriteLine("");
			var fs_type = VFSManager.GetFileSystemType(@"0:\");
			Console.WriteLine("File System Type: " + fs_type);
			var available_space = VFSManager.GetAvailableFreeSpace(@"0:\");
			Console.WriteLine("Available Free Space: " + available_space);
			var fs_label = VFSManager.GetFileSystemLabel(@"0:\");
			Console.WriteLine("File System Label: " + fs_label);
			var fs_disks = VFSManager.GetDisks();
			Console.WriteLine("Disks: " + fs_disks);
			//var fs_stream = VFSManager.GetFileStream(@"0:\");
			//Console.WriteLine("File System Stream: " + fs_stream);
			Console.WriteLine("");
			Console.WriteLine("");


			/*case "user":
				Response += user;
				break;

			case "mem":
				{
					Response += "Memory Used: " + ((usedmem / 1024) / 1024) + "/" + maxmem;//must fix this lol
					//Response += "\nMemory Available: " + availableMem;
					break;
				}

			case "screen":
				Response += "Screensize (Columns and Rows): " + screenX + " x " + screenY;
				break;*/



			return Response;
		}
	}
}