/********************************************
 *			 Made by MeiZhaoRui				*
 *			 2014年05月01日 更新				*
 *******************************************/

using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.Win32;

namespace curriculum_design
{
	public partial class DataSourceSetting : Form
	{
		public DataSourceSetting()
		{
			InitializeComponent();
		}
		public bool isFirstTime = true;
		private void DataSourceSetting_Load(object sender, EventArgs e)
		{
			cb_ways.SelectedIndex = 0;
			foreach(string i in DataSources)
			{
				cbb_servername.Items.Add(i);
			}
			if (cbb_servername.Items.Count > 0)
				cbb_servername.SelectedIndex = 0;
			Global.ShowCloseOption = true;
		}
		private ArrayList DataSources
		{
			get
			{
				RegistryKey rk = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Microsoft SQL Server");
				string[] instances = (String[])rk.GetValue("InstalledInstances");
				ArrayList array = new ArrayList();
				if (instances.Length > 0)
				{
					foreach (String element in instances)
					{
						if (element == "MSSQLSERVER")
							array.Insert(0, Environment.MachineName);
						else
							array.Insert(0, Environment.MachineName + @"\" + element);
					}
				}
				return array;
			}
		}

		private void cb_ways_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cb_ways.SelectedIndex == 1)
			{
				tb_username.Enabled = label3.Enabled = tb_passwd.Enabled = label2.Enabled = true;
				tb_username.Text = DES.Decrypt(INI.ReadValue("dataSource", "uid").Trim());
				tb_passwd.Text = DES.Decrypt(INI.ReadValue("dataSource", "pwd").Trim());
			}
			else
			{
				tb_username.Enabled = label3.Enabled = tb_passwd.Enabled = label2.Enabled = false;
				tb_username.Text = tb_passwd.Text = "";
			}
		}

		private void Setting_Click(object sender, EventArgs e)
		{
			isFirstTime = false;
			INI.Clear("dataSource");
			INI.WriteValue("dataSource", "DataSource", DES.Encrypt(cbb_servername.Text.Trim()));
			if( cb_ways.SelectedIndex == 0)
				INI.WriteValue("dataSource", "IntegratedSecurity", "AE7E7C55962EF391");
			else
			{
				INI.WriteValue("dataSource", "IntegratedSecurity", "44BD18DC75116AD7");
				INI.WriteValue("dataSource", "uid", DES.Encrypt(tb_username.Text.Trim()));
				INI.WriteValue("dataSource", "pwd", DES.Encrypt(tb_passwd.Text.Trim()));
			}			
			this.Close();
		}

		private void TestConnect_Click(object sender, EventArgs e)
		{
			SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
			scsb.ConnectTimeout = 1;
			scsb.InitialCatalog = "master";
			scsb.DataSource = cbb_servername.Text.Trim();
			scsb.IntegratedSecurity = cb_ways.SelectedIndex == 0 ? true : false;

			if (scsb.IntegratedSecurity == false)
			{
				scsb.UserID = tb_username.Text.Trim();
				scsb.Password = tb_passwd.Text.Trim();
			}
			SqlConnection conn = new SqlConnection(scsb.ConnectionString);
			try
			{
				conn.Open();
			}
			catch (Exception)
			{
				MsgBox.ShowInfor("连接失败！请重新选择！");
				return;
			}
			finally
			{
				if (conn.State == ConnectionState.Open) conn.Close();
			}
			MsgBox.ShowInfor("连接测试成功！");
		}

		private void Cancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		public bool bShowClosedInfo = true;
		private void DataSourceSetting_FormClosing(object sender, FormClosingEventArgs e)
		{
			if(bShowClosedInfo) MsgBox.ShowInfor("生成成功！单击确定进入登陆界面！");
		}	
	}
}
