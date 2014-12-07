/********************************************
 *			 Made by MeiZhaoRui				*
 *			 2014年05月01日 更新				*
 *******************************************/

using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using System.Windows.Forms;

namespace curriculum_design
{
	public partial class Login : Form
	{
		public Login()
		{
			InitializeComponent();
			UserName.Focus();
		}
		private void Submit_Click(object sender, EventArgs e)
		{
			string ss = UserPassWd.Text.Length >= 18 ? UserPassWd.Text : Global.MD5EnCrypt(UserPassWd.Text);
			int level = cb_admin.Checked ? 1 : 2;
			try
			{
				string select = string.Format("proc_select_Admins_to_Login '{0}','{1}'", UserName.Text.Trim(), level);
				string pawd = Program.sqlManage.ExecuteScalar(select).ToString();
				if (pawd != "" && pawd == ss)
				{
					Global.ShowCloseOption = false;
					SetPasswdToINI(ss);
					if (level == 1)
						new Thread(new ThreadStart(() =>
						{
							MainForm mf = new MainForm();
							Application.Run(mf);
						})).Start();
					else
						new Thread(new ThreadStart(() =>
						{
							Receptionist rt = new Receptionist();
							Application.Run(rt);
						})).Start();
					this.Close();
				}
				else
				{
					MsgBox.ShowError("用户名或密码错误，重新输入");
					UserName.Focus();
				}
			}
			catch (Exception)
			{
				return;
			}
		}
		private void SetPasswdToINI(string ss)
		{
			if (cb_passwd.Checked)
			{
				INI.WriteValue("Login", "uid", DES.Encrypt(UserName.Text));
				INI.WriteValue("Login", "pwd", ss);
				INI.WriteValue("Login", "ckpd", "1");
				INI.WriteValue("Login", "ckad", cb_admin.Checked ? "1" : "2");
			}
		}
		private void Cancel_Click(object sender, EventArgs e)
		{
			UserName.Text = UserPassWd.Text = "";
			cb_admin.Checked = false;
			cb_passwd.Checked = false;
		}

		private void UserName_Leave(object sender, EventArgs e)
		{
			if (Global.CheckStr(UserName.Text.ToString().Trim(), true) == Global.CheckState.Forbidden)
			{
				MsgBox.ShowError("不能以数字开头或您输入的字符不合法\n" + Global.UnAcceptChars );
				UserName.Text = string.Empty;
			}
		}

		private void Setting_Click(object sender, EventArgs e)
		{
			this.Hide();
			DataSourceSetting dss = new DataSourceSetting();
			dss.bShowClosedInfo = false;
			dss.ShowDialog();
			this.Show();
		}
		private struct UseInfo
		{
			public string name;
			public string passwd;
			public bool cp_passwd;
			public bool cb_admin;
		}
		private UseInfo user = new UseInfo();
		private void Login_Load(object sender, EventArgs e)
		{
			string ss = INI.ReadValue("Login","ckpd");
			if(ss != "")
			{
				user.name = DES.Decrypt(INI.ReadValue("Login", "uid"));
				user.passwd = INI.ReadValue("Login", "pwd");
				user.cp_passwd  = ss == "1" ? true : false;
				user.cb_admin = INI.ReadValue("Login", "ckad") == "1" ? true : false;

				UserName.Items.Add(user.name);
			}
			Global.ShowCloseOption = true;
		}

		private void UserName_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(UserName.Text == user.name)
			{
				cb_admin.Checked  = user.cb_admin;
				cb_passwd.Checked  = user.cp_passwd;
				UserPassWd.Text = user.passwd;
			}
			else
			{
				cb_admin.Checked = false;
				cb_passwd.Checked = false;
				UserPassWd.Text = "";
			}
		}

		private void Login_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (Global.ShowCloseOption)
			{
				e.Cancel = MsgBox.ShowChioces("确定是否真的要退出？") == DialogResult.Cancel ;
			}
		}

		private void UserName_KeyPress(object sender, KeyPressEventArgs e)
		{
			cb_admin.Checked = false;
			cb_passwd.Checked = false;
			UserPassWd.Text = "";
		}
	}
}
