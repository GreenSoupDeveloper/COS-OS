using System;
using Sys = Cosmos.System;
using Cosmos.System.FileSystem.VFS;
using Cosmos.System.FileSystem;
using System.Collections.Generic;
using System.Text;


using System.IO;
//using COS.COSMAIN.Graphics;
using COS.COSMAIN.Hardware;
using COS.COSMAIN;
using COS.COSMAIN.Resources;
using COSKERNEL;

//using GreenCOS.COSSHELL.Sounds.StartUp.placeholdr;
//using GreenCOS.COSSHELL.Sounds.ShutDown.placholder;





using Cosmos.System.Graphics;
using Cosmos.System.Graphics.Fonts;
using System.Drawing;
using Cosmos.HAL;
using Cosmos.Core.Memory;

using Cosmos.HAL.Drivers.PCI.Audio;

using Cosmos.System.ExtendedASCII;

//using COS.COSMAIN.Graphics;



using System.Threading.Tasks;
using IL2CPU.API.Attribs;


using COS;
namespace COS.COSMAIN.Tests
{
	public class GraphicTest : Command
	{

		public static int wallx = 0;
		public static int wally = 0;

		public static Canvas canvas;

		public GraphicTest()
		{
			Description = $"Command to link for getting help with {nameof(COS)}";
			Name = nameof(GraphicTest);
		}

		public override string Invoke(string[] Args)
		{

			canvas = new SVGAIICanvas(new Mode(800, 600, ColorDepth.ColorDepth32));



			Sys.MouseManager.ScreenWidth = 800;
			Sys.MouseManager.ScreenHeight = 600;

			Sys.MouseManager.X = (uint)((int)canvas.Mode.Columns / 2);
			Sys.MouseManager.Y = (uint)((int)canvas.Mode.Rows / 2);

			Pen bluepen = new Pen(Color.White);
			Pen brownpen = new Pen(Color.Black);
			Pen blackpen = new Pen(Color.Black);
			Pen taskbarpen = new Pen(Color.Green);
			Pen taskbar2pen = new Pen(Color.DarkGreen);
			Pen bg = new Pen(Color.Aqua);
			Pen taskba13123rpen = new Pen(Color.Blue);
			


			//wallpaper
			canvas.DrawFilledRectangle(bg, 0, 0, 800, 600);

			//canvas.DrawImage(Assets.GTestWall, (int)wallx, (int)wally);

			canvas.DrawFilledRectangle(taskbar2pen, 350, 561, 800, 8);
			canvas.DrawFilledRectangle(taskbarpen, 350, 566, 800, 300);
			








			//windows

			canvas.DrawFilledRectangle(taskbarpen, 50, 50, 500, 300);
			canvas.DrawFilledRectangle(taskba13123rpen, 120, 120, 500, 300);
		
			//canvas.DrawFilledRectangle(taskbar2pen, 48, 40, 5, 300);
			//canvas.DrawFilledRectangle(taskbar2pen, 40, 48, 500, 5);



			//taskbar



			//  taskbar.OpenTaskBar(vgo);



			//canvas.DrawImageAlpha(Assets.Cursor, (int)Cosmos.System.MouseManager.X, (int)Cosmos.System.MouseManager.Y);

			canvas.Display();
			canvas.Clear(Color.Green);
			return "";





		}
	}
}