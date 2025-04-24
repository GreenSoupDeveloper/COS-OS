using System;

namespace COS.COSMAIN.Commands
{
	public class GraphHelp : Command
	{
		public GraphHelp()
		{
			Description = $"Command to link for getting help with {nameof(COS)}";
			Name = nameof(GraphHelp);
		}

		public override string Invoke(string[] Args)
		{
			string Response;
			Console.WriteLine("");
			Console.WriteLine("List of Commands");
			Console.WriteLine("");

			Console.WriteLine("about - about the system");
			Console.WriteLine("clear - clear the screen");
			Console.WriteLine("system - view the device information");
			Console.WriteLine("mkfile - make a file");
			Console.WriteLine("mkfolder - make a folder");
			Console.WriteLine("del - delete a file");
			Console.WriteLine("dirlist - view the list of directories");
			Console.WriteLine("gllist - view the list of ALL the files and directories of the system");
			Console.WriteLine("filelist - view the list of files");
			Console.WriteLine("programs - view the list of programs");
			Console.WriteLine("runhelp - view all the types of file who you can run with the 'Run' command");
			Console.WriteLine("");
			Console.WriteLine("Type 'Help2' to view the next page of commands");
			Console.WriteLine("");

			//TODO: make the help command but in graphic, like the msdos help, its going to be easy, I THINK


			


			return "";

			
				

				
		}
	}
}