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

namespace COS.COSMAIN.Dev
{
	public class DevMode : Command
	{
		public DevMode()
		{
			Description = "dev mode.";
			Name = nameof(DevMode);
		}

		//int screenX = 800;
		//int screenY = 640;
	

		public override string Invoke(string[] Args)
		{

		
			Console.WriteLine("allow dev mode, true, false");

			var inputdev = Console.ReadLine();

            if (inputdev == "true")
            {
				File.WriteAllText(@"0:\COSYS\" + "OSDEVMD.cifl", "true");
			}
			if (inputdev == "false")
			{
				File.WriteAllText(@"0:\COSYS\" + "OSDEVMD.cifl", "false");
			}

			Console.WriteLine("restart the system now");

			return "";
		}
	}
}