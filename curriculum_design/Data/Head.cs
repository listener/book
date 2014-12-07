/****************************************
 *				全局函数类				*
 *			Made by MeiZhaoRui			*
 *			2014年05月01日 更新			*
 ***************************************/

using System;
using System.Collections;
using System.Data;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace curriculum_design
{
	class Global
	{
		public const string UnAcceptChars = "^+-*`=<>~!#$%^&(){}[]|;\':\",./?\\ ";
		public const string zeroFormatStr = "0.00";
		public const string Man = "M", Woman = "W";
		public static bool ShowCloseOption { get; set; }/*窗口应用关闭时是否有提示*/
		private Global() { }
		/// <summary>
		/// 判断是否存在于UnAcceptChars中的出现的非法字符串
		/// </summary>
		public enum CheckState { Empty, Forbidden, Correct };
		/// <summary>
		/// 判断输入的字符是否合法
		/// </summary>
		/// <param name="str">待检测的字符串</param>
		/// <param name="CheckUserName">因为用户名首字母不能为数字</param>
		/// <returns></returns>
		public static CheckState CheckStr(string str, bool CheckUserName = false)
		{
			if (str.Length == 0)
				return CheckState.Empty;
			if (CheckUserName && (str[0] >= '0' && str[0] <= '9'))
				return CheckState.Forbidden;
			else
				foreach (char i in str)
				{
					if (UnAcceptChars.IndexOf(i) != -1)
						return CheckState.Forbidden;
				}
			return CheckState.Correct;
		}
		/// <summary>
		/// 规范金钱的输入格式
		/// </summary>
		/// <param name="sender">TextBox 控件</param>
		/// <param name="e">按钮按下事件</param>
		public static void CheckMoney(ref object sender, ref KeyPressEventArgs e)
		{
			if (e.KeyChar == '.' && ((TextBox)sender).Text.IndexOf(".") >= 0)
			{
				e.Handled = true; return;
			}
			LockNums(ref e);
		}
		/// <summary>
		/// 只让输入数字和基本按钮
		/// </summary>
		/// <param name="e">只能传递引用</param>
		public static void LockNums(ref KeyPressEventArgs e)
		{
			if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 13 ) e.Handled = true;
		}
		/// <summary>
		/// 验证 ISBN 的输入的正确性
		/// </summary>
		/// <param name="cISBN"></param>
		/// <param name="e"></param>
		public static void cISBN_Check(ref TextBox cISBN, ref KeyPressEventArgs e)
		{
			int i = cISBN.Text.Length;
			if (i == 3 || i == 5 || i == 9 || i == 15)
			{
				cISBN.AppendText("-");
			}
			if (i < 17 && (e.KeyChar < 48 || e.KeyChar > 57) && 
				e.KeyChar != 8 && e.KeyChar != 13 && e.KeyChar != 46) e.Handled = true;
		}

		/// <summary>
		/// 获得 MD5 加密字符串
		/// </summary>
		/// <param name="str">待加密的字符串</param>
		/// <returns>加密后的32位字符串</returns>
		public static string MD5EnCrypt(string str)
		{
			if (str.Length != 0)
			{
				MD5CryptoServiceProvider md5CSP = new MD5CryptoServiceProvider();
				byte[] testEncrypt = System.Text.Encoding.Default.GetBytes(str.Trim());
				byte[] resultEncrypt = md5CSP.ComputeHash(testEncrypt);

				string ss = "";
				for (int i = 0; i < resultEncrypt.Length; ++i)
				{
					ss += resultEncrypt[i].ToString("x").PadLeft(2, '0');
				}
				return ss;
			}
			return "";
		}
	}
	class MsgBox
	{
		public static void ShowError(string str,string caption="错误")
		{
			MessageBox.Show(null, str, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
		public static void ShowNormal(string str, string caption = "提示")
		{
			MessageBox.Show(null, str, caption, MessageBoxButtons.OK, MessageBoxIcon.None);
		}
		public static void ShowInfor(string str, string caption = "提示")
		{
			MessageBox.Show(null, str, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
		public static void ShowAsterisk(string str, string caption = "警告")
		{
			MessageBox.Show(null, str, caption, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}
		public static void ShowQuestion(string str,string caption="提示")
		{
			MessageBox.Show(null, str, caption, MessageBoxButtons.OK, MessageBoxIcon.Question);
		}
		public static void ShowExclamation(string str,string caption="提示")
		{
			MessageBox.Show(null, str, caption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
		public static DialogResult ShowChioces(string str,string caption="提示")
		{
			return MessageBox.Show(null, str, caption, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
		}
	}
	class DES
	{
		private DES() { }
		/// <summary>
		/// DES加密
		/// </summary>
		/// <param name="str">待加密的字符串</param>
		/// <returns>加密后的字符串</returns>
		public static string Encrypt(string str)
		{
			if (str == "") return "";
			string sKey = "20140501";
			DESCryptoServiceProvider des = new DESCryptoServiceProvider();
			byte[] inputByteArray = Encoding.Default.GetBytes(str);
			des.Key = ASCIIEncoding.ASCII.GetBytes(sKey);
			des.IV = ASCIIEncoding.ASCII.GetBytes(sKey);
			MemoryStream ms = new MemoryStream();
			CryptoStream cs = new CryptoStream(ms, des.CreateEncryptor(), CryptoStreamMode.Write);
			cs.Write(inputByteArray, 0, inputByteArray.Length); cs.FlushFinalBlock();
			StringBuilder ret = new StringBuilder();
			foreach (byte b in ms.ToArray())
			{
				ret.AppendFormat("{0:X2}", b);
			}
			return ret.ToString();
		}
		/// <summary>
		/// DES解密 
		/// </summary>
		/// <param name="str">待解密的字符串</param>
		/// <returns>解密后的字符串</returns>
		public static string Decrypt(string str)
		{
			if (str == "") return "";
			string sKey = "20140501";
			DESCryptoServiceProvider des = new DESCryptoServiceProvider();
			byte[] inputByteArray = new byte[str.Length / 2];
			for (int x = 0; x < str.Length / 2; x++)
			{
				int i = (Convert.ToInt32(str.Substring(x * 2, 2), 16));
				inputByteArray[x] = (byte)i;
			}
			des.Key = ASCIIEncoding.ASCII.GetBytes(sKey);
			des.IV = ASCIIEncoding.ASCII.GetBytes(sKey);
			MemoryStream ms = new MemoryStream();
			CryptoStream cs = new CryptoStream(ms, des.CreateDecryptor(), CryptoStreamMode.Write);
			cs.Write(inputByteArray, 0, inputByteArray.Length);
			try
			{
				cs.FlushFinalBlock();
				StringBuilder ret = new StringBuilder();
			}
			catch
			{
				MessageBox.Show("溢出，解密有误"); return "";
			}
			return System.Text.Encoding.Default.GetString(ms.ToArray());
		}
	}
	/// <summary>
	/// 通过一定的键值对关系的 Hashtable 返回格式化后的相应字符串 
	/// </summary>
	class SqlString
	{
		private SqlString() { }
		public static string ToInsertStr(string table, Hashtable value)
		{
			string _insert = "insert into " + table + " ( ";
			foreach (string i in value.Keys)
			{
				_insert += i + ", ";
			}
			_insert = _insert.Substring(0, _insert.Length - 2) + ") values( ";
			foreach (string i in value.Keys)
			{
				if (value[i].GetType() == Type.GetType("System.String"))
					_insert += " '" + value[i].ToString() + "', ";
				else
					_insert += value[i].ToString() + ", ";
			}
			return _insert.Substring(0, _insert.Length - 2) + " )";
		}
		public static string ToUpdateStr(string table, Hashtable condition, Hashtable value)
		{
			string _update = "update " + table + " set ";
			foreach (string i in value.Keys)
			{
				if (value[i].GetType() == Type.GetType("System.String"))
					_update += string.Format(" {0}='{1}' ,", i, value[i]);
				else
					_update += string.Format(" {0}={1} ,", i, value[i]);
			}
			_update = _update.Substring(0, _update.Length - 1);
			if (condition.Count != 0)
			{
				_update += " where ";
				foreach (string i in condition.Keys)
				{
					if (value[i].GetType() == Type.GetType("System.String"))
						_update += string.Format(" {0}='{1}' and", i, value[i]);
					else
						_update += string.Format(" {0}={1} and", i, value[i]);
				}
				_update = _update.Substring(0, _update.Length - 3);
			}
			return _update;
		}
	}

	class INI
	{
		public static string strFilePath = Application.StartupPath + @"\Config.ini";//获取INI文件路径
		private INI() { }
		/// <summary>
		/// 写入INI文件
		/// </summary>
		/// <param name="section">节点名称[如[TypeName]]</param>
		/// <param name="key">键</param>
		/// <param name="val">值</param>
		/// <param name="filepath">文件路径</param>
		/// <returns></returns>
		[DllImport("kernel32")]
		private static extern long WritePrivateProfileString(string section, string key, string val, string filepath);
		/// <summary>
		/// 读取INI文件
		/// </summary>
		/// <param name="section">节点名称</param>
		/// <param name="key">键</param>
		/// <param name="def">值</param>
		/// <param name="retval">stringbulider对象</param>
		/// <param name="size">字节大小</param>
		/// <param name="filePath">文件路径</param>
		/// <returns></returns>
		[DllImport("kernel32")]
		private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retval, int size, string filePath);

		/// <summary>
		/// 自定义读取INI文件中的内容方法
		/// </summary>
		/// <param name="Section">节点</param>
		/// <param name="key">键</param>
		/// <returns></returns>
		public static string ReadValue(string Section, string key)
		{
			StringBuilder temp = new StringBuilder(256);
			GetPrivateProfileString(Section, key, "", temp, 256, strFilePath);
			return temp.ToString().Trim();
		}
		/// <summary>
		/// 自定义写入INI文件中的内容方法
		/// </summary>
		/// <param name="Section">节点</param>
		/// <param name="key">键</param>
		/// <param name="value">值</param>
		public static void WriteValue(string Section, string key, string value)
		{
			WritePrivateProfileString(Section, key, value, strFilePath);
		}
		/// <summary>
		/// 清空某一节点的所有值
		/// </summary>
		/// <param name="section">节点</param>
		public static void Clear(string section)
		{
			WriteValue(section, null, null);
		}
	}
	/// <summary>
	/// 新的线程，用来运行 --保存模式对话框 --
	/// </summary>
	class ExportToExcel : IDisposable
	{
		private SaveFileDialog InvokeDialog;
		private Thread InvokeThread;
		private DataSet ds = new DataSet();
		public DataSet dataset
		{
			get { return ds; }
			set { ds = value; }
		}
		public ExportToExcel()
		{
			Init();
		}
		public ExportToExcel(DataSet ds)
		{
			dataset = ds;
			Init();
		}
		/// <summary>
		/// 开始新的线程
		/// </summary>
		public void Invoke()
		{
			InvokeThread.Start();
		}
		/// <summary>
		/// 初始化 线程及相关参数
		/// </summary>
		private void Init()
		{
			InvokeDialog = new SaveFileDialog();
			InvokeDialog.OverwritePrompt = true;

			InvokeDialog.DefaultExt = "xls";
			InvokeDialog.Filter = "Excel文件|*.xls";

			InvokeThread = new Thread(new ThreadStart(InvokeMethod));
			InvokeThread.SetApartmentState(ApartmentState.STA);
		}
		private void InvokeMethod()
		{
			if (InvokeDialog.ShowDialog() == DialogResult.OK)
			{
				Export(ds, InvokeDialog.FileName);
			}
		}
		private void Export(DataSet ds, string FileName)
		{
			
			System.Data.DataTable table = ds.Tables[0];
			if (table.Rows.Count + table.Columns.Count > 1)
			{
				ProgressForm pf = new ProgressForm();
				pf.Show();
				pf.Step = 100 / (table.Rows.Count + table.Columns.Count);

				Excel.Application excel = new Excel.Application();
				excel.Visible = false;
				excel.Application.Workbooks.Add();


				int rowIndex = 1, colIndex = 0;
				foreach (DataColumn col in table.Columns)
				{
					colIndex++;
					excel.Cells[1, colIndex] = col.ColumnName.ToString().Trim();

					pf.PerformStep();
				}
				foreach (DataRow row in table.Rows)
				{
					rowIndex++;
					colIndex = 0;
					foreach (DataColumn col in table.Columns)
					{
						colIndex++;
						excel.Cells[rowIndex, colIndex] = row[col.ColumnName].ToString().Trim();
					}
					pf.PerformStep();
				}
				excel.DisplayAlerts = false;/*禁止一切可视控件*/
				excel.ActiveWorkbook.SaveAs(FileName, Excel.XlFileFormat.xlExcel8, null, null, false, false,
					Excel.XlSaveAsAccessMode.xlNoChange);
				excel.DisplayAlerts = true;/*恢复*/

				pf.PerformStep();

				excel.Quit();
				excel = null;
				pf.PauseClose();

				GC.Collect();//垃圾回收
			}
		}
		public void Dispose()
		{
			InvokeDialog.Dispose();
		}
	}
}