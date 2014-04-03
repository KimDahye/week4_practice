using System;

namespace week4_lab2
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.Write ("Enter the first number : ");
			int num1 = int.Parse (Console.ReadLine ());  
			Console.Write ("Enter the second number : ");
			int num2 = int.Parse (Console.ReadLine ());
			Console.Write ("Enter the operaton(+,-, *, /, %, are allowed): ");
			string operation = Console.ReadLine ();

			switch (operation) {
			case "+":
				Console.WriteLine ("{0}+{1} = {2}", num1, num2, num1 + num2);
				break;
			case "-":
				Console.WriteLine ("{0}-{1} = {2}", num1, num2, num1 - num2);
				break;
			case "*":
				Console.WriteLine ("{0}*{1} = {2}", num1, num2, num1 * num2);
				break;
			case "/":
				Console.WriteLine ("{0}/{1} = {2}", num1, num2, num1 / num2);
				break;
			case "%":
				Console.WriteLine ("{0}%{1} = {2}", num1, num2, num1 % num2);
				break;
			default:
				Console.WriteLine ("You entered {0}. I don't know about {0}.", operation);
				break;
			}
		}
	}
}
