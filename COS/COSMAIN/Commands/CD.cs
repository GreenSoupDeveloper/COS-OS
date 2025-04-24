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
	public class CD : Command
	{
		public CD()
		{
			Description = $"Command to link for getting help with {nameof(COS)}";
			Name = nameof(CD);
		}

		public override string Invoke(string[] Args)
		{
		
			Console.WriteLine("to what directory do you want to change?");
			var inputdir = Console.ReadLine();
			if (inputdir == "")
			{
				Console.WriteLine("COS cant change to a directory with no name!!");
			}
			if (inputdir != "")
			{
				Directory.SetCurrentDirectory(@"0:\" + inputdir + @"\");
				
			   Console.WriteLine("changed to " + inputdir + " directory");

			}



			return "";





		}
	}
}