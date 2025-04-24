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

//using GreenCOS.COSSHELL.Sounds.StartUp.placeholdr;
//using GreenCOS.COSSHELL.Sounds.ShutDown.placholder;





using Cosmos.System.Graphics;
using Cosmos.System.Graphics.Fonts;


using Cosmos.HAL;
using Cosmos.Core.Memory;

using Cosmos.HAL.Drivers.PCI.Audio;

using Cosmos.System.ExtendedASCII;
using System.Drawing;



using System.Threading.Tasks;
using IL2CPU.API.Attribs;





namespace COS.COSMAIN.Commands
{
	public class Dir : Command
	{
		public Dir()
		{
			Description = $"Command to link for getting help with {nameof(COS)}";
			Name = nameof(Dir);
		}

		public override string Invoke(string[] Args)
		{



			

			try
            {
			
				Console.WriteLine("");
				var directory_list = Directory.GetFiles(@"0:\"+Directory.GetCurrentDirectory() +@"\");
				var dir_list = Directory.GetDirectories(@"0:\" + Directory.GetCurrentDirectory() + @"\");
				//var creationtime = File.GetCreationTime(@"0:\" + Kernel.nowDirectory + Kernel.nowChildDirectory);
				

				foreach (var file in dir_list)
				{
					Console.WriteLine(file);
				
				}

				foreach (var file in directory_list)
				{
					Console.WriteLine(file);
				}
				Console.WriteLine("");
			}
            catch (Exception e)
            {

				Console.WriteLine("COS had a error showing the directory files. :(");
				Console.WriteLine(e.ToString());
				Console.WriteLine("if this problem persists, report it on the GitHub page of COS");
			}
			return "";

			
				

				
		}
	}
}