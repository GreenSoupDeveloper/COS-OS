using System;

namespace COS.COSMAIN.Commands
{
	public class Time : Command
	{
		public Time()
		{
			Description = "Gets the current time of the system.";
			Name = nameof(Time);
		}

		public override string Invoke(string[] Args)
		{
			return DateTime.Now.ToString();
		}
	}
}