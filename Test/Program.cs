﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.IO;

using V;

namespace Test {
	class Program {
		static void Main(string[] args) {
			Console.Title = "V Test";

			Parser P = new Parser();
			P.Parse(File.ReadAllText("Test.v"));

			/*while (true) {
				P.Parse(Prompt(">> "));
			}*/

			Console.WriteLine("Done!");
			Console.ReadLine();
			Environment.Exit(0);
		}

		static string Prompt(string P) {
			string R;
			do {
				Console.Write(P);
				R = Console.ReadLine().Trim();
			} while (R.Length == 0);
			return R;
		}
	}
}