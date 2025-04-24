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
	public class DirList : Command
	{
		public DirList()
		{
			Description = $"Command to link for getting help with {nameof(COS)}";
			Name = nameof(DirList);
		}

		public override string Invoke(string[] Args)
		{
			string Response;
			Console.WriteLine("");

			var dir_list = Directory.GetDirectories(@"0:\");

			foreach (var file in dir_list)
			{
				Console.WriteLine(@"0:\" + file);
			}
			Console.WriteLine("");


			return "";

			
				

				
		}
	}
}