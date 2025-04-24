using System;

namespace COS.COSMAIN.Commands
{
	public class RunHelp : Command
	{
		public RunHelp()
		{
			Description = $"Command to link for getting help with {nameof(COS)}";
			Name = nameof(RunHelp);
		}

		public override string Invoke(string[] Args)
		{
			string Response;
			Console.WriteLine("");
			Console.WriteLine("List of Run Commands");
			Console.WriteLine("");

			Console.WriteLine("program - run a program");
			Console.WriteLine("text - run a text file");
			Console.WriteLine("none - run a file wihout extention");
			Console.WriteLine("pl - run a 'PerfectLetter' file");
			Console.WriteLine("");


			Console.WriteLine("");

			


			return "";

			
				

				
		}
	}
}