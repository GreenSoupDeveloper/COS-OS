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



using Cosmos.Core;


namespace COS.COSMAIN.Commands
{
	public class MkFile : Command
	{
		public MkFile()
		{
			Description = "Make a File.";
			Name = nameof(MkFile);
		}

		public override string Invoke(string[] Args)
        {
            Console.WriteLine("what name do you want for the file?");
            var inputfile = Console.ReadLine();
           

           /* if (inputfile == "")
            {
                inputfile = "New File.null";
            }*/
            try
            {
                var file_stream = File.Create(@"0:\" + Kernel.nowDirectory + Kernel.nowChildDirectory + Kernel.nowChildChildDirectory + inputfile);
                Console.WriteLine("the file <" + inputfile + "> is now created");

            }
            catch (Exception e)
            {
                Console.WriteLine("COS Cant create files with no name!!!");
                Console.WriteLine("Error:" + e.ToString());
            }
            return "";
		}
	}
}