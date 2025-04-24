using System;
using Sys = Cosmos.System;
using Cosmos.System.FileSystem.VFS;
using Cosmos.System.FileSystem;
using System.Collections.Generic;
using System.Text;

using System.IO;
using COS.COSMAIN.Graphics;
using COS.COSMAIN.Hardware;

using Cosmos.System.Audio;
using Cosmos.System.Audio.IO;
using Cosmos.HAL.Drivers.PCI.Audio;
using Cosmos.HAL.Audio;

using COS.COSMAIN;
using COS.Drivers;

using Cosmos.System.Graphics;
using Cosmos.System.Graphics.Fonts;
using Cosmos.HAL;
using Cosmos.Core.Memory;
using COS.COSMAIN.Resources;
using static Cosmos.Core.INTs;
using Cosmos.System.Network.IPv4.UDP.DHCP;





namespace COSKERNEL
{
	/*man making cosmos oses is a shit, its a hell, and more with a shitty internet in a fuckin latinoamerican country with the worst president of all the world, i want to kill him.*/
	//and i want to microsoft die, man, the actual microsoft is a shit, adding unnecessary shits to win 10 and 11, i hate the fucking motherfocker windows 11, i like the old microsoft and linux
	//motherfucker malparido shitty fuck fucking stupid pendejo puto microsoft

	//not ratos

	//sex

	public class Kernel : Sys.Kernel
	{
		public static string DevMode = File.ReadAllText(@"0:\COSYS\OSDEVMD.cifl");

		public static Color TitleBarColor = Color.Green;
		public static Color DateTimeColor = Color.White;
		public static Color TitleColor = Color.White;
		public static bool TitleBarVisible = true;
		public static string user = "";
		public static string password = "";
		public static string userpass = "";
		public string hostName = "COS";

		public static string OS_NAME = "COS";
		public static string OS_USERBUYEDCOS = "user";
		public static string OS_CTADA = "CTADA 2.0";
		public static string OS_BUILD = "2211.17";
		public static string OS_VER = "2.80";
		public static string OS_CODENAME = "Sandwitch";
		public static string KERNEL_INFO = "This operating system was built using the open source COSMOS kernel.";
		public static string OS_EDITION = "Official Release"/* "Developer Release"*/;

		public string datetitle = "";
		public static string nowDirectory = "";
		public static bool StartSystem;
		public static bool StartSetup;
		public static bool IsInstallCDOnDevice;
		public static string IsCOSInstalled = File.ReadAllText(@"0:\COSYS\OSIV.cifl");
		public string userinput;
		public bool startsetupillegal = false;

		//public static string versionverification = File.ReadAllText(@"0:\" + @"COSYS\" + "versionold" + ".sovv");

		public static bool GUIMode = false;

		public static byte _deltaT;

		public static int _fps;
		public static int _frames;


		public static bool booting;
		public static int bootprogress;
		//public static ConsoleColor textcolor = ConsoleColor.White;
		//	public static string textcolorstring;
		public static ConsoleColor textcolor = ConsoleColor.White;


		public static string nowChildDirectory = nowDirectory + "";
		public static string nowChildChildDirectory = nowDirectory + nowChildDirectory + "";

		public static string arrowDir = @"0:\";

		public static string publicDir = nowDirectory + nowChildDirectory + nowChildChildDirectory;

		public string responsepartition;

		public bool allowinstall;



		protected override void BeforeRun()
		{

			Audio.InitializeAudio();
			//_ = new DHCPClient().SendDiscoverPacket();
			CosmosVFS VFS = new();
			VFSManager.RegisterVFS(VFS);


			if (Directory.Exists(@"0:\COSYS"))
			{
				StartSystem = true;
				StartSetup = false;
				IsCOSInstalled = "y";
				if (File.Exists(@"0:\COSYS\OSIV.cifl"))
				{
					File.WriteAllText(@"0:\COSYS\OSIV.cifl", IsCOSInstalled);
				}
			}
			if (!Directory.Exists(@"0:\COSYS") || startsetupillegal == true)
			{
				StartSystem = false;
				StartSetup = true;
				IsCOSInstalled = "n";
				if (File.Exists(@"0:\COSYS\OSIV.cifl"))
				{
					File.WriteAllText(@"0:\COSYS\OSIV.cifl", IsCOSInstalled);
				}
			}
			/*if (Directory.Exists(@"C:\COSYS"))
			{
				StartSystem = true;
				StartSetup = false;
			}
			if (!Directory.Exists(@"C:\COSYS"))
			{
				StartSystem = false;
				StartSetup = true;
				IsCOSInstalled = "n";
			}*/


			//Sys.FileSystem.CosmosVFS fs = new Sys.FileSystem.CosmosVFS();
			//Sys.FileSystem.VFS.VFSManager.RegisterVFS(fs);
			Console.Clear();

			if (File.Exists(@"0:\" + @"COSYS\" + "OSINSTALLNEWVER.cifl"))
			{
				
				
					StartSetup = true;
					StartSystem = false;
					File.Delete(@"0:\" + @"COSYS\" + "OSINSTALLNEWVER.cifl");
				
			}
				if (File.Exists(@"0:\" + @"COSYS\" + "OSERRORREPAIROS.cifl"))
			{
				Console.WriteLine("do you want to repair the operative system? (Y)");
				string responserep = Console.ReadLine();

				if (responserep == "y" || responserep == "Y")
				{
					StartSetup = true;
					StartSystem = false;
					File.Delete(@"0:\" + @"COSYS\" + "OSERRORREPAIROS.cifl");
				}
			}

			if (StartSystem == true)
			{



				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");

				Console.WriteLine("       ");
				Console.ForegroundColor = ConsoleColor.Blue;
				Console.WriteLine("                                       /C/#");

				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("                                     C/O/S");
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("                                     /S/");
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("");
				Console.WriteLine("");

				Console.WriteLine("");
				Console.WriteLine("                                  Loading...");
				
				Console.WriteLine("");
				

				//a false load scrin



				try
				{
					//string textcolortostring = File.ReadAllText(@"0:\" + @"COSYS\" + "textcolor" + ".cof");
					//textcolorstring = textcolorstring;	
					File.ReadAllText(@"0:\COSYS\OSVC.cifl");
					File.ReadAllText(@"0:\COSYS\OSIV.cifl");
					File.ReadAllText(@"0:\COSYS\OSVR.cifl");
					File.ReadAllText(@"0:\COSYS\OSUSRDATA.cifl");
					File.ReadAllText(@"0:\" + @"Programs\" + "COSPAD.program");
					File.ReadAllText(@"0:\" + @"Programs\" + "COSPAD.program");
					File.ReadAllText(@"0:\" + @"Programs\" + "PERFECTLETTER.program");

					/* if (textcolorstring == "green" || textcolorstring == "Green")
					 {
						 textcolor = ConsoleColor.Green;
					 }*/
					StartSystem = true;
				}
				catch (Exception e)
				{
					Console.WriteLine("cant load files, COS cannot initialize, restart the device now");
					Console.WriteLine("Error:" + e.ToString());
					Console.WriteLine("");
					File.Create(@"0:\" + @"COSYS\" + "OSERRORREPAIROS.cifl");
					StartSystem = false;

					throw;




				}
				Cosmos.HAL.Global.PIT.Wait(50000);
				Console.WriteLine("                                   Loaded!");
				Console.WriteLine("");
				



				Console.WriteLine("Initialize session, type a user to initialize session");
				var usrinput = Console.ReadLine();
				user = usrinput;

				try
				{

					File.ReadAllText(@"0:\" + @"COSYS\" + user + ".usr");
				}
				catch (Exception err)
				{
					Console.WriteLine("this user does not exist!!!, type again the user");
					Console.WriteLine(err.ToString());
					StartSystem = false;
					throw;
				}
				Console.WriteLine("Type the user's password");
				password = Console.ReadLine();
				Console.WriteLine("Initializing session...");
				try
				{

					File.ReadAllText(@"0:\" + @"COSYS\" + "userpass" + password + ".usrp");
				}
				catch (Exception er)
				{
					Console.WriteLine("this password is incorrect!!!");
					Console.WriteLine(er.ToString());
					StartSystem = false;

					throw;
				}



				OS_USERBUYEDCOS = File.ReadAllText(@"0:\" + @"COSYS\" + usrinput + ".usr");



				Console.Clear();


				StartSetup = false;
				Console.BackgroundColor = ConsoleColor.Black;
				TextGraphics.DrawLineH(0, 0, CLI.Width, ' ', Color.Black, Kernel.TitleBarColor);
				TextGraphics.DrawString(CLI.Width - Kernel.OS_NAME.Length, 0, Kernel.OS_NAME, Kernel.TitleColor, Kernel.TitleBarColor);

				// TextGraphics.DrawString(CLI.Width - TitleBarTime.Length, 0, TitleBarTime, DateTimeColor, TitleBarColor); // draw title

				Console.BackgroundColor = ConsoleColor.Green;
				Console.WriteLine(DateTime.Now.ToString());
				Console.BackgroundColor = ConsoleColor.Black;
				Console.WriteLine("Initialized COS successfully. Type 'Help' to view command list");
				Shell.Initialize();
				if (DevMode == "true")
				{
					Console.WriteLine("DevMode: " + DevMode);
				}

				//	Audio.Play(MemoryAudioStream.FromWave(Assets.StartupWave));
				Console.Beep();

				if (!File.Exists(@"0:\" + @"COSYS\" + "v280" + ".sovv"))
				{
					Console.WriteLine("Theres a new version of COS avalaible, do you want to install it? [Y] [N]");
					string resnewv = Console.ReadLine();
                    if (resnewv == "y" || resnewv == "Y")
                    {
						File.Create(@"0:\" + @"COSYS\" + "OSINSTALLNEWVER.cifl");
						Cosmos.System.Power.Reboot();
					}
				}

			}

			if (StartSetup == true)
			{
				StartSystem = false;

			}




		}
		/*protected override void OnBoot()
		{
			try
			{
				base.OnBoot();
			}
			catch (Exception ex)
			{
				CrashScreen.DisplayKernelErrorAndReboot(ex.Message);
			}
		}*/
		protected override void Run()
		{

			if (StartSystem == true)
			{
               
				///	Console.ForegroundColor = textcolor;

				Console.Write(Directory.GetCurrentDirectory() + ":> ");
				string repsonse = Shell.Invoke(Console.ReadLine().Split(' '));
				Console.WriteLine(repsonse);
			

			}
            #region the install thingy
            if (StartSetup == true)
			{
				File.WriteAllText(@"0:\COSYS\OSIV.cifl", "n");
				Console.WriteLine("Starting Setup.....");

				Console.WriteLine("");
				Console.WriteLine("Do you want to install COS in your device? [Y] [N]");
				string response = Console.ReadLine();
				if (response == "y" || response == "yes")
				{
					
					Console.WriteLine("Type the product serial key:");
					string responseserialkey = Console.ReadLine();
					if (responseserialkey == "1234-5678-9010")
					{
						allowinstall = true;
					}
					else
					{
						Console.WriteLine("this serial doesnt exist");
					}
                    if (allowinstall == true)
                    {
						Console.WriteLine("In what partition do you want to install COS? (example: C, 0)");
						responsepartition = Console.ReadLine();
						Console.WriteLine("");
						Console.WriteLine("Installing COS....");
						Console.WriteLine("");
					}

					

					if (responsepartition == "c" || responsepartition == "C")
					{
						try
						{
							string folderPathC = @"C:\";


							Directory.CreateDirectory(folderPathC + "COSYS");
							File.Create(folderPathC + @"COSYS\" + "OSVC.cifl");
							File.WriteAllText(@"C:\COSYS\OSVC.cifl", "1234-5678-9090-1423");
							File.Create(folderPathC + @"COSYS\" + "OSIV.cifl");
							File.WriteAllText(@"C:\COSYS\OSIV.cifl", IsCOSInstalled);
							File.Create(folderPathC + @"COSYS\" + "OSVR.cifl");
							File.WriteAllText(@"C:\COSYS\OSVR.cifl", "1.50");
							File.Create(folderPathC + @"COSYS\" + "OSUSRDATA.cifl");
							File.WriteAllText(@"C:\COSYS\OSUSRDATA.cifl", "none");
							Directory.CreateDirectory(@"C:\Programs\");
							File.Create(folderPathC + @"Programs\" + "COSPAD.program");
							File.Create(folderPathC + @"Programs\" + "OSDEVMD.cifl");
							File.Create(folderPathC + @"Programs\" + "PERFECTLETTER.program");
							File.Create(@"C:\" + @"COSYS\" + "textcolor" + ".cof");



							//var file_stream = File.Create(@"0:\" + inputfolder + ".f");
						}
						catch (Exception e)
						{
							Console.WriteLine(e.ToString());
						}
					}
					if (responsepartition == "0")
					{
						try
						{
							string folderPath0 = @"0:\";


							Directory.CreateDirectory(folderPath0 + "COSYS");
							Console.Write("///");
							File.Create(folderPath0 + @"COSYS\" + "OSVC.cifl");
							Console.Write(@"\\\");
							File.WriteAllText(@"0:\COSYS\OSVC.cifl", "1234-5678-9090-1423");
							Console.Write("///");
							File.Create(folderPath0 + @"COSYS\" + "OSIV.cifl");
							Console.Write(@"\\\");
							File.WriteAllText(@"0:\COSYS\OSIV.cifl", IsCOSInstalled);
							Console.Write("///");
							File.Create(folderPath0 + @"COSYS\" + "OSVR.cifl");
							Console.Write(@"\\\");
							File.WriteAllText(@"0:\COSYS\OSVR.cifl", "1.50");
							Console.Write("///");
							File.Create(folderPath0 + @"COSYS\" + "OSUSRDATA.cifl");
							Console.Write(@"\\\");
							File.WriteAllText(@"0:\COSYS\OSUSRDATA.cifl", "none");
							Console.Write("///");
							Directory.CreateDirectory(@"0:\Programs\");
							Console.Write(@"\\\");
							File.Create(folderPath0 + @"Programs\" + "COSPAD.program");
							Console.Write("///");
							File.WriteAllText(folderPath0 + @"Programs\" + "COSPAD.program", "Behind Code");
							Console.Write(@"\\\");
							File.Create(folderPath0 + @"Programs\" + "PERFECTLETTER.program");
							Console.Write("///");
							File.Create(@"0:\" + @"COSYS\" + "textcolor" + ".cof");					
                            if (File.Exists(@"0:\" + @"COSYS\" + "v250" + ".sovv"))
                            {
								File.Delete(@"0:\" + @"COSYS\" + "v250" + ".sovv");
							}
							Console.Write(@"\\\");
							File.Create(@"0:\" + @"COSYS\" + "v280" + ".sovv");
							Console.Write("///");
							Console.WriteLine("");



							//var file_stream = File.Create(@"0:\" + inputfolder + ".f");
						}
						catch (Exception e)
						{
							Console.WriteLine(e.ToString());
						}
					}


				
					Console.WriteLine("");
					Console.WriteLine("create a user, what name do you want to your new user?");
					string rescruser = Console.ReadLine();


					Console.WriteLine("create a password, how do you want to be the password?");
					string rescrpass = Console.ReadLine();


					Console.WriteLine("creating user...");
					File.Create(@"0:\" + @"COSYS\" + rescruser + ".usr");
					Console.WriteLine("creating password...");
					File.Create(@"0:\" + @"COSYS\" + "userpass" + rescrpass + ".usrp");
					Console.WriteLine("user created!!!");


					IsCOSInstalled = "y";
					File.WriteAllText(@"0:\COSYS\OSIV.cifl", IsCOSInstalled);
					Console.WriteLine("COS installed, restart your device to start using COS");
					
					StartSetup = false;
				}
			}

            #endregion

        }
    }
}