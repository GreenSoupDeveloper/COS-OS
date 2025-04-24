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
	public class ClearDirs : Command
	{
		public ClearDirs()
		{
			Description = $"Command to link for getting help with {nameof(COS)}";
			Name = nameof(ClearDirs);
		}

		public override string Invoke(string[] Args)
		{
			Kernel.nowDirectory = "";
			Kernel.nowChildDirectory = "";
			Console.WriteLine("changed to " + Kernel.nowDirectory + " directory");



			return "";





		}
	}
}