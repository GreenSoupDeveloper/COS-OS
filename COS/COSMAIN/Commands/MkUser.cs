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
	public class MkUser : Command
	{
		public MkUser()
		{
			Description = "Create user.";
			Name = nameof(MkUser);
		}

		//int screenX = 800;
		//int screenY = 640;
	

		public override string Invoke(string[] Args)
		{
			Console.WriteLine("how do you want to be called the new user");

			var inputuser = Console.ReadLine();
			
			if (inputuser == "")
			 {
				 inputuser = "NewUser";
			 }
			try
			{
				var file_stream = File.Create(@"0:\" + @"COSYS\" + inputuser + ".usr");

			}
			catch (Exception e)
			{
				Console.WriteLine("COS Cant create this user, sorry");
				Console.WriteLine(e.ToString());
			}
			Console.WriteLine("the user <" + inputuser + "> is now created");

			return "";
		}
	}
}