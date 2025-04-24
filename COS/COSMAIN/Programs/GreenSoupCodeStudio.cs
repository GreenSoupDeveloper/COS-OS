using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COS.COSMAIN.Programs
{ 
    public class GreenSoupCodeStudio : Command
    {
        public string codename;

        public GreenSoupCodeStudio()
        {
            Description = "The program for write code and made programs for COS!";
            Name = nameof(GreenSoupCodeStudio);
        }
        public override string Invoke(string[] Args)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("using System;");
            Console.WriteLine("using System.Collections.Generic;");
            Console.WriteLine("using System.Linq;");
            Console.WriteLine("using System.Text;");
            Console.WriteLine("using System.Threading.Tasks;");
            Console.WriteLine("");
            Console.WriteLine("namespace Code{");
            Console.WriteLine("");
            Console.WriteLine("public class "+codename+"{");
            Console.WriteLine("");
            Console.WriteLine("public override string Invoke(string[] Args)");
            Console.WriteLine("{");
            Console.WriteLine("");
            Console.WriteLine("}");
            Console.WriteLine("}");
            Console.WriteLine("}");

            return "";
        }
    }
}
