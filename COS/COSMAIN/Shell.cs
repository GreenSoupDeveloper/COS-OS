using System.Collections.Generic;
using System;
using COS.COSMAIN.Graphics;
using COS.COSMAIN.Hardware;
using COS;
using COSKERNEL;

namespace COS.COSMAIN
{
	public static class Shell
	{
		#region Methods

		public static ReturnCode TryInvoke(string Name, string[] Args, out string Return)
		{
			if (Commands.Count == 0)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Return = "Command not found!";
				Console.ForegroundColor = ConsoleColor.White;
				return ReturnCode.CommandNotFound;

			}

			for (int I = 0; I < Commands.Count; I++)
			{
				// Use .ToLower to normalize strings.
				if (Commands[I].Name.ToLower() == Name.ToLower())
				{
					Return = Commands[I].Invoke(Args);
					return ReturnCode.Success;
				}
			}

			Return = $"Command '{Name}' not found!";

			return ReturnCode.CommandNotFound;

		}
		public static string Invoke(string Name, string[] Args)
		{
			TryInvoke(Name, Args, out string S);
			return S;
		}
		public static string Invoke(string[] Args)
		{
			string[] NewArgs = new string[Args.Length - 1];
			for (int I = 0; I < NewArgs.Length; I++)
			{
				NewArgs[I] = Args[I + 1];
			}

			TryInvoke(Args[0], NewArgs, out string Return);
			return Return;
		}
		public static void Initialize()
		{
			// Create all command objects.
			_ = new Commands.Clear();
			_ = new Commands.Credits();
			_ = new Commands.MkFile();
			_ = new Commands.MkDir();
			_ = new Commands.DelDir();

			_ = new Commands.DirList();
			_ = new Commands.GlList();
			_ = new Commands.FileList();
			//_ = new Commands.File();
			_ = new Commands.Help();
			_ = new Commands.About();
			_ = new Commands.Reboot();
			_ = new Commands.Shutdown();
			_ = new Commands.Time();
			_ = new Commands.Dir();
			_ = new Commands.Mod();
			_ = new Commands.Run();
			//_ = new Commands.();
			_ = new Commands.CD();
		
			_ = new Commands.Del();
			_ = new Commands.CCD();
			_ = new Commands.CTD();
			_ = new Commands.ClearDirs();
			_ = new Commands.Programs();
			_ = new Commands.RunHelp();
			_ = new Commands.Help2();
			_ = new Commands.Settings();


			//programs
			_ = new Programs.COSPad();
          


            // debugging
            if (Kernel.DevMode == "true")
            {
				_ = new Programs.PerfectLetter();
				_ = new Programs.GreenSoupCodeStudio();
				_ = new Commands.GraphHelp();
				_ = new Tests.GraphicTest();
				_ = new Commands.System();
				_ = new Commands.MkUser();
				_ = new Commands.Ren();
			}
			
			_ = new Dev.DevMode();




		}

		#endregion

		#region Fields

		internal static List<Command> Commands { get; set; } = new();

		#endregion
	}
}