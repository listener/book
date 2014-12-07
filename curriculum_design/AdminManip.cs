/********************************************
 *			 员工管理中添加及删除				*
 *			 Made by MeiZhaoRui				*
 *			 2014年05月01日 更新				*
 *******************************************/

using System;
using System.Collections;
using System.Data;
using System.Windows.Forms;

namespace curriculum_design
{
	public partial class AdminManip : Form
	{
		DataSet ds = null;
		string UserName = "", Level = "";
		Hashtable OldValue;
		public AdminManip(string username = "", string level = "")
		{
			InitializeComponent();
			ds = Program.sqlManage.GetDataSet("select cAdminId,cLevel from Admins");
			this.UserName = username;
			this.Level = level;
			OldValue = new Hashtable(){{"cAdminId",username},{"cLevel",level}};
		}

		private void tb_UseName_Leave(object sender, EventArgs e)
		{
			if (Global.CheckStr(tb_UserName.Text.ToString().Trim(), true) == Global.CheckState.Forbidden)
			{
				MsgBox.ShowError("不能以数字开头或您输入的字符不合法\n" + Global.UnAcceptChars);
				tb_UserName.Focus();
				return;
			}
			if (UserName == Level  && tb_UserName.Text.Length > 0)
			{
				string level = radioButton1.Checked ? "2" : "1";
				for (int i = 0; i < ds.Tables[0].Rows.Count; ++i)
				{
					if (tb_UserName.Text.ToString().Trim() == ds.Tables[0].Rows[i][0].ToString().Trim()
						&& level == ds.Tables[0].Rows[i][1].ToString().Trim())
					{
						MsgBox.ShowError("同一类型用户中已存在相同用户，请使用其他用户名！");
						tb_UserName.Text = "";
						UserName_OK.Visible = false;
						tb_UserName.Focus();
						return;
					}
				}
				UserName_OK.Visible = true;
			}
		}
		private void Add_Click(object sender, EventArgs e)
		{
			if (Passwd_OK.Visible  && CheckPass_OK.Visible  && UserName_OK.Visible )
			{
				Hashtable NewValue = new Hashtable();
				
				NewValue.Add("cAdminId", tb_UserName.Text.Trim() );
				NewValue.Add("cLevel", radioButton1.Checked ? "2" : "1");
				NewValue.Add("vcPassWd", Global.MD5EnCrypt(tb_Passwd.Text) );

				if (button1.Text == "修改")
				{
					update_dabase(NewValue);
					this.Close();
				}
				else
					insert_database(NewValue);
				tb_UserName.Text = tb_Passwd.Text = tb_checkPass.Text = "";
			}
		}
		
		private void AdminManip_Load(object sender, EventArgs e)
		{
			if( UserName != Level )
			{
				string getrecond = String.Format("select * from Admins where cAdminId='{0}' and cLevel='{1}' ", UserName, Level);
				DataSet dd = Program.sqlManage.GetDataSet(getrecond);

				tb_UserName.Text = dd.Tables[0].Rows[0][0].ToString().Trim();
				tb_Passwd.Text = tb_checkPass.Text = dd.Tables[0].Rows[0][1].ToString().Trim();
				radioButton2.Checked = !(radioButton1.Checked = dd.Tables[0].Rows[0][2].ToString().Trim() == "2" );

				tb_UserName.Enabled = false;
				UserName_OK.Visible = true;
				button1.Text = "修改";
				this.Text = "修改信息";
			}
		}

		private void Close_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void tb_Passwd_TextChanged(object sender, EventArgs e)
		{
			Passwd_OK.Visible = tb_Passwd.Text.Length >= 6 ? true : false;
			button1.Enabled = CheckPass_OK.Visible = 
			(tb_Passwd.Text == tb_checkPass.Text &&
			Passwd_OK.Visible) ? true : false;
		}

		private void tb_checkPass_TextChanged(object sender, EventArgs e)
		{
			CheckPass_OK.Visible = button1.Enabled = 
			(tb_Passwd.Text == tb_checkPass.Text && 
			Passwd_OK.Visible == true)? true : false;
		}

		private void level_Click(object sender, EventArgs e)
		{
			if (tb_UserName.Text.Length == 0)
			{
				tb_UserName.Focus();
				return;
			}
			tb_UseName_Leave(null, null);
		}	
	}
}
