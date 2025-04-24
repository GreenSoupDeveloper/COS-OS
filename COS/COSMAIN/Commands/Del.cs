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
	public class Del : Command
	{
		public Del()
		{
			Description = $"Command to link for getting help with {nameof(COS)}";
			Name = nameof(Del);
		}

		public override string Invoke(string[] Args)
		{
			string Response;
			Console.WriteLine("what file do you want to delete?");
			var delfile = Console.ReadLine();
			




			try
			{
				File.Delete(@"0:\" + Kernel.nowDirectory + Kernel.nowChildDirectory + Kernel.nowChildChildDirectory + delfile);
				Console.WriteLine("File <" + delfile + "> deleted :(");

			}
			catch (Exception e)
			{
				Console.WriteLine("COS cant delete this file!!");
				Console.WriteLine("Error: " + e.ToString());
			}



			return "";

			
				

				
		}
	}
}