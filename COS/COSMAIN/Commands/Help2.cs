using System;

namespace COS.COSMAIN.Commands
{
	public class Help2 : Command
	{
		public Help2()
		{
			Description = $"Command to link for getting help with {nameof(COS)}";
			Name = nameof(Help2);
		}

		public override string Invoke(string[] Args)
		{
			string Response;
			Console.WriteLine("");
			Console.WriteLine("List of Commands - Part 2");
			Console.WriteLine("");

		
			Console.WriteLine("cd - change directory");
			Console.WriteLine("ccd - change to a child directory of another directory");
			Console.WriteLine("ctd - change to a child directory of another directory of another directory"); //lol
			Console.WriteLine("mod - modify a file (only for text files)");
			Console.WriteLine("run - runs a file");
			Console.WriteLine("dir - view directory");
			//Console.WriteLine("ren - rename a file");
			//Console.WriteLine("rendir - rename a dir");
			Console.WriteLine("shutdown - shutdown the device");
			Console.WriteLine("reboot - reboots the device");
			Console.WriteLine("time - view the current time");
			Console.WriteLine("settings - the system settings");
			Console.WriteLine("deldir - delete a directory");
			Console.WriteLine("cleardirs - go back to the " + @"0:\" + " directory");

			Console.WriteLine("");

			


			return "";

			
				

				
		}
	}
}