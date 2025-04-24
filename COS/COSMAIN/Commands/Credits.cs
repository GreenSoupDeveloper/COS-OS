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
	public class Credits : Command
	{
		public Credits()
		{
			Description = "Returns the credits list.";
			Name = nameof(Credits);
		}

		public override string Invoke(string[] Args)
		{
			Console.WriteLine("GreenSoupDeveloper");
			Console.WriteLine("RaphMar2021");
			Console.WriteLine("The COSMOS Team");
			return "";
		}
	}
}