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
	public class MkDir : Command
	{
		public MkDir()
		{
			Description = "Make a Folder.";
			Name = nameof(MkDir);
		}

		public override string Invoke(string[] Args)
        {
            Console.WriteLine("what name do you want for the folder?");
            var inputfolder = Console.ReadLine();
            

            if (inputfolder == "")
            {
                inputfolder = "New Folder";
            }
            try
            {
                string folderPath = @"0:\" + Kernel.nowDirectory + Kernel.nowChildDirectory + inputfolder;

                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                    Console.WriteLine(folderPath);
                }
                Console.WriteLine("the folder <" + inputfolder + "> is now created");
                //var file_stream = File.Create(@"0:\" + inputfolder + ".f");
            }
            catch (Exception e)
            {
                Console.WriteLine("COS Cant create folders with no name!!!");
                Console.WriteLine(e.ToString());
            }

            return "";
		}
	}
}