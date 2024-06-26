﻿using OfficeScheduler.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OfficeScheduler

{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			DBConnect.openConnection();
			Form login = new formLogin();
			login.ShowDialog();
			Application.Run(new formMainMenu());
			DBConnect.closeConnection();
		}
	}
}
