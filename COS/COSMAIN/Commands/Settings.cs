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
	public class Settings : Command
	{
		public static string textcolorcon;
		public Settings()
		{
			Description = "system settings";
			Name = nameof(Settings);
		}

		public override string Invoke(string[] Args)
		{
			Console.WriteLine("");
			Console.WriteLine("Settings");
			Console.WriteLine("");
			Console.WriteLine("[1].Repair COS");
			Console.WriteLine("[2].Format PC");
			Console.WriteLine("[3].User Settings");
			Console.WriteLine("");

			var inputoptions = Console.ReadLine();


			if (inputoptions == "1")
			{

				Console.WriteLine("do you want to repair the operative system? (Y) (N)");
				string responserep = Console.ReadLine();
				File.Create(@"0:\" + @"COSYS\" + "OSERRORREPAIROS.cifl");
				Cosmos.System.Power.Reboot();


			}
			if (inputoptions == "2")
			{

				Console.WriteLine("You are sure to format your pc?, this will delete ALL your files (Y) (N)");
				var inputformatpc = Console.ReadLine();
				if (inputformatpc == "y" || inputformatpc == "Y")
				{
					Console.WriteLine("Deleting Files.....");
					var directory_list = Directory.GetFiles(@"0:\");
					var dir_list = Directory.GetDirectories(@"0:\");

					foreach (var file in dir_list)
					{
						Directory.Delete(@"0:\" + file);
					}

					foreach (var file in directory_list)
					{
						File.Delete(file);
					}
					Console.WriteLine("Formatting PC.....");
					Console.WriteLine("Formatted!");
					Cosmos.System.Power.Reboot();
				}


			}
			if (inputoptions == "3")
			{
				Console.WriteLine("User Settings");
				Console.WriteLine("");
				Console.WriteLine("[1].Change username");
				Console.WriteLine("[2].Change password");
				//Console.WriteLine("[3].Delete password");
				Console.WriteLine("");
				var inputuseroptions = Console.ReadLine();

				if (inputuseroptions == "1")
				{

					Console.WriteLine("change the username, what name do you want to your user?");
					string rescruser = Console.ReadLine();


				


					Console.WriteLine("changing username...");
					File.Create(@"0:\" + @"COSYS\" + rescruser + ".usr");
					
					Console.WriteLine("username changed!!!");


				}
				if (inputuseroptions == "2")
				{
					Console.WriteLine("change the password, how do you want to be the password?");
					string rescrpass = Console.ReadLine();

					Console.WriteLine("changing password...");
					File.Create(@"0:\" + @"COSYS\" + "userpass" + rescrpass + ".usrp");
					Console.WriteLine("password changed!!!");


				}
			/*	if (inputuseroptions == "3")
				{
					Console.WriteLine("type the password");
					string resdelpass = Console.ReadLine();

					Console.WriteLine("deleting password...");
					File.Create(@"0:\" + @"COSYS\" + "userpass" + "" + ".usrp");
					Console.WriteLine("password deleted!!!");

				
				}*/


			}



			return "";





		}
	}
}