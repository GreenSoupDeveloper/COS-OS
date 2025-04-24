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
namespace COS.COSMAIN.Programs
{
	public class COSPad : Command
	{
		public string texttyped;
		public string textopenedtyped;
		public bool fileopened;
		public string openxsfile;
		public string backopenfile;
		public string title = "COSPad";
		public COSPad()
		{
			Description = $"Command to link for getting help with {nameof(COS)}";
			Name = nameof(COSPad);
		}

		public override string Invoke(string[] Args)
		{
			Console.Clear();
			Console.BackgroundColor = ConsoleColor.Black;
			TextGraphics.DrawLineH(0, 0, CLI.Width, ' ', Color.Black, Kernel.TitleBarColor); // draw background
			TextGraphics.DrawString(CLI.Width - Kernel.OS_NAME.Length, 0, Kernel.OS_NAME, Kernel.TitleColor, Kernel.TitleBarColor); // draw title

			// TextGraphics.DrawString(CLI.Width - TitleBarTime.Length, 0, TitleBarTime, DateTimeColor, TitleBarColor); // draw title

			Console.BackgroundColor = ConsoleColor.Green;
			Console.WriteLine(title);
			Console.BackgroundColor = ConsoleColor.Black;

			Console.BackgroundColor = ConsoleColor.Green;
			Console.ForegroundColor = ConsoleColor.Black;
			Console.WriteLine("");
			Console.WriteLine("");
			Console.WriteLine("+-------------------------+");
			Console.WriteLine("|                         |");
			Console.WriteLine("|       COSPad v1.0       |");
			Console.WriteLine("|      Normal Edition     |");
			Console.WriteLine("|                         |");
			Console.WriteLine("+-------------------------+");
			Console.BackgroundColor = ConsoleColor.Black;
			Console.ForegroundColor = ConsoleColor.White;

			Console.WriteLine("");
			Console.WriteLine("GreenSoupDev 2022-2022");
			Console.WriteLine("");
			Console.WriteLine("do you want to open a text file (Y) (N)");
			var openfile = Console.ReadLine();
			if (openfile == "N" || openfile == "n")
			{
				fileopened = false;
			}
			if (openfile == "Y" || openfile == "y")
			{
				Console.WriteLine("what file do you want to open? (only on the <" + @"0:\TextFiles> directory)");
				openxsfile = Console.ReadLine();

				Console.WriteLine("");
				fileopened = true;

			}
			if (fileopened == false)
			{
				Console.WriteLine("Type something: ");

				Console.WriteLine("");

				string text;
				texttyped = Console.ReadLine();

				Console.WriteLine("");
			}
			if (fileopened == true)
			{
				Console.Write(File.ReadAllText(@"0:\" + @"TextFiles\" + openxsfile));
				backopenfile = File.ReadAllText(@"0:\" + @"TextFiles\" + openxsfile);
				textopenedtyped = Console.ReadLine();
			}




			try
			{
				Console.WriteLine("You want to save the file? (Y) (N)");
				var response = Console.ReadLine();

				if (response == "y" || response == "Y")
				{
					if (fileopened == true)
					{
						File.WriteAllText(@"0:\TextFiles\" + openxsfile, backopenfile + textopenedtyped);
						Console.WriteLine("do you want to close COSPad? (Y)");
						var responseclose = Console.ReadLine();
						if (responseclose == "y" || responseclose == "Y")
						{
							Console.Clear();



							Console.BackgroundColor = ConsoleColor.Black;
							TextGraphics.DrawLineH(0, 0, CLI.Width, ' ', Color.Black, Kernel.TitleBarColor); // draw background
							TextGraphics.DrawString(CLI.Width - Kernel.OS_NAME.Length, 0, Kernel.OS_NAME, Kernel.TitleColor, Kernel.TitleBarColor); // draw title

							// TextGraphics.DrawString(CLI.Width - TitleBarTime.Length, 0, TitleBarTime, DateTimeColor, TitleBarColor); // draw title

							Console.BackgroundColor = ConsoleColor.Green;
							Console.WriteLine(DateTime.Now.ToString());
							Console.BackgroundColor = ConsoleColor.Black;
							return string.Empty;
						}
					}
					if (fileopened == false)
					{
						Console.WriteLine("what name do you want for the text file?");
						var inputfile = Console.ReadLine();
						var inputexfile = inputfile + ".txt";
						Directory.CreateDirectory(@"0:\TextFiles\");
						File.Create(@"0:\TextFiles\" + inputexfile);
						File.WriteAllText(@"0:\TextFiles\" + inputexfile, texttyped);
						Console.WriteLine("the file <" + inputfile + "> is now created in the directory <" + @"0:\TextFiles>");
						Console.WriteLine("do you want to close COSPad? (Y)");
						var responseclose = Console.ReadLine();
						if (responseclose == "y" || responseclose == "Y")
						{
							Console.Clear();



							Console.BackgroundColor = ConsoleColor.Black;
							TextGraphics.DrawLineH(0, 0, CLI.Width, ' ', Color.Black, Kernel.TitleBarColor); // draw background
							TextGraphics.DrawString(CLI.Width - Kernel.OS_NAME.Length, 0, Kernel.OS_NAME, Kernel.TitleColor, Kernel.TitleBarColor); // draw title

							// TextGraphics.DrawString(CLI.Width - TitleBarTime.Length, 0, TitleBarTime, DateTimeColor, TitleBarColor); // draw title

							Console.BackgroundColor = ConsoleColor.Green;
							Console.WriteLine(DateTime.Now.ToString());
							Console.BackgroundColor = ConsoleColor.Black;
							return string.Empty;
						}
					}




				}
				if (response == "n" || response == "N")
				{

					Console.Clear();



					Console.BackgroundColor = ConsoleColor.Black;
					TextGraphics.DrawLineH(0, 0, CLI.Width, ' ', Color.Black, Kernel.TitleBarColor); // draw background
					TextGraphics.DrawString(CLI.Width - Kernel.OS_NAME.Length, 0, Kernel.OS_NAME, Kernel.TitleColor, Kernel.TitleBarColor); // draw title

					// TextGraphics.DrawString(CLI.Width - TitleBarTime.Length, 0, TitleBarTime, DateTimeColor, TitleBarColor); // draw title

					Console.BackgroundColor = ConsoleColor.Green;
					Console.WriteLine(DateTime.Now.ToString());
					Console.BackgroundColor = ConsoleColor.Black;
					return string.Empty;
				}


			}
			catch (Exception e)
			{
				Console.WriteLine(e.ToString());
			}



			return "";





		}
	}
}