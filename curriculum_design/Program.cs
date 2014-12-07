/********************************************
 *			 Made by MeiZhaoRui				*
 *			 2014年05月01日 更新				*
 *******************************************/

using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace curriculum_design
{
	static class Program
	{
		public static SqlManage sqlManage;
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			if (ManyProcess() || isFirstTimeLogin()) return;
			try
			{
				sqlManage = new SqlManage("BookSale").Connect();
			}
			catch(Exception)
			{
				MsgBox.ShowError("数据库初始化失败！请删除本程序目录\n下的Config.ini文件再重新运行本程序！");
				return;
			}
			Application.Run(new Login());
			return;
		}
		private static bool ManyProcess()
		{
			///只允许一个实例
			Process pCurrent = Process.GetCurrentProcess();
			Process[] pList = Process.GetProcessesByName(pCurrent.ProcessName);
			if (pList.Length >= 2)
			{
				MsgBox.ShowError("已有程序正在运行，请等待上一个操作！", "初始化错误");
				return true;
			}
			return false;
		}

		private static bool isFirstTimeLogin()
		{
			DataSourceSetting dss = new DataSourceSetting();
			string str = INI.ReadValue("dataSource", "DataSource");
			if (str == "")
			{
				MsgBox.ShowInfor("这是您第一次登陆使用！请先配置相关！");
				dss.ShowDialog();	
			}
			else
				return false;
			return dss.isFirstTime;
		}
	}
}
