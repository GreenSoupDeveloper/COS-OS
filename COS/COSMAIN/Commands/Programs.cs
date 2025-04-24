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
	public class Programs : Command
	{
		public Programs()
		{
			Description = $"Command to link for getting help with {nameof(COS)}";
			Name = nameof(Programs);
		}

		public override string Invoke(string[] Args)
		{
			string Response;
			Console.WriteLine("");
			var directory_list = Directory.GetFiles(@"0:\Programs\");


			foreach (var file in directory_list)
			{
				Console.WriteLine(file);
			}

			Console.WriteLine("");


			return "";

			
				

				
		}
	}
}