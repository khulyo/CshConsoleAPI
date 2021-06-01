using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;






namespace CshConsoleAPI
{
	public class AppCommands
	{
		public const string CMD_PROMPED = "\n>";
		public const string CMD_ECHO = "echo";
		public const string CMD_ADD = "add";
		public const string CMD_SUB = "sub";
		public const string CMD_MULT = "mult";
		public const string CMD_DIV = "div";





		/***
		* Echo demonstrates a command execution function.
		* the command prints the parameters it receives.
		*/
		public static bool CommandEcho(string[] parameters)
		{
			foreach (string param in parameters){
				Console.WriteLine(param);
			}
			return (true);
		}

		public static bool CommandAdd(string[] parameters)
		{
			int sum = 0;
			foreach (string param in parameters)
			{
				sum += int.Parse(param);
			}
			Console.WriteLine(sum);
			return (true);
		}
		public static bool CommandSub(string[] parameters)
		{
			int res = 0;
			foreach (string param in parameters)
			{
				res -= int.Parse(param);
			}
			Console.WriteLine(res);
			return (true);
		}
		public static bool CommandMult(string[] parameters)
		{
			int ab = 1;
			foreach (string param in parameters)
			{
				ab*= int.Parse(param);
			}
			Console.WriteLine(ab);
			return (true);
		}
		public static bool CommandDiv(string[] parameters)
		{
			int avg = 1;
			foreach (string param in parameters)
			{
				avg /= int.Parse(param);
			}
			Console.WriteLine(avg);
			return (true);
		}
	}
}
