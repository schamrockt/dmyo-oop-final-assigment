﻿using System;
using System.Windows.Forms;
using dmyo_oop_final_assigment.Forms;

namespace dmyo_oop_final_assigment
{
	internal static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
	}
}
