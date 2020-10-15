using CommissionRport.UI_Main;
using CommissionRport.Ul_Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CommissionRport
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
			Application.Run(new frmMain());
			//Application.Run(new frmMainLogin());
		}
	}
}
