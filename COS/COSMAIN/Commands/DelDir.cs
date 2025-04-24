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
	public class DelDir : Command
	{
		public DelDir()
		{
			Description = $"Command to link for getting help with {nameof(COS)}";
			Name = nameof(DelDir);
		}

		public override string Invoke(string[] Args)
		{

			Console.WriteLine("what directory do you want to delete?");
			var delfile = Console.ReadLine();
			




			try
			{
				Directory.Delete(@"0:\" + Kernel.nowDirectory + Kernel.nowChildDirectory + Kernel.nowChildChildDirectory + delfile);
				Console.WriteLine("Directory <" + delfile + "> deleted :(");


			}
			catch (Exception e)
			{
				Console.WriteLine("COS cant delete this directory!!");
				Console.WriteLine(e.ToString());
			}
			Console.WriteLine("Directory <" + delfile + "> deleted :(");



			return "";

			
				

				
		}
	}
}