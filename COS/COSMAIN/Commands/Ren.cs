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
	public class Ren : Command
	{
		public Ren()
		{
			Description = $"Command to link for getting help with {nameof(COS)}";
			Name = nameof(Ren);
		}

		public override string Invoke(string[] Args)
		{
			string Response;
			Console.WriteLine("what file do you want to modify?");
			var modfile = Console.ReadLine();

			Console.WriteLine("Modify the file how do you want!");
			var modifiedfile = Console.ReadLine();



			try
			{
				
				File.WriteAllText(@"0:\" + Kernel.nowDirectory + Kernel.nowChildDirectory + Kernel.nowChildChildDirectory + modfile, modifiedfile);
				Console.WriteLine("File <" + modfile + "> modifyed :)");
			}
			catch (Exception e)
			{
				Console.WriteLine("COS cant modify this file");
				Console.WriteLine("Error: " + e.ToString());
			}



			return "";

			
				

				
		}
	}
}