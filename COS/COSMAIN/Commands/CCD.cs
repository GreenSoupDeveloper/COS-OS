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
	public class CCD : Command
	{
		public CCD()
		{
			Description = $"Command to link for getting help with {nameof(COS)}";
			Name = nameof(CCD);
		}

		public override string Invoke(string[] Args)
		{
			
			Console.WriteLine("to what child directory do you want to change?");
			var inputcdir = Console.ReadLine();

			if (inputcdir == "")
			{
				Console.WriteLine("COS cant change to a directory with no name!!");
			}
			if (inputcdir != "")
			{
				Kernel.nowChildChildDirectory = "";
			   Kernel.nowChildDirectory = inputcdir + @"\";
				Console.WriteLine("changed to " + Kernel.nowDirectory + Kernel.nowChildDirectory + Kernel.nowChildChildDirectory + " directory");
				//Kernel.nowDirectory = Kernel.nowDirectory + Kernel.nowChildDirectory;
			}



			return "";





		}
	}
}