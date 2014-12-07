/********************************************
 *			 Made by MeiZhaoRui				*
 *			 2014年05月02日 更新				*
 *******************************************/

using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace curriculum_design
{
	public partial class MembersManip : Form
	{
		DataSet ds = null;
		string Email = "";
		Hashtable temp = new Hashtable();
		public MembersManip(string vcEmail = "")
		{
			InitializeComponent();
			this.Email = vcEmail;
			ds = Program.sqlManage.GetDataSet("proc_select_Members_to_membersmanip");
		}
		private void Members_Load(object sender, EventArgs e)
		{
			#region 当操作为修改时
			try
			{
				if (Email != "")
				{
					ds = Program.sqlManage.GetDataSet("proc_select_memberinfo_to_membersmanip '" + Email + "'");
					bool isMan = ds.Tables[0].Rows[0][2].ToString().Trim() == Global.Man ;					
					tb_Email.Text	= ds.Tables[0].Rows[0][0].ToString().Trim();
					tb_IdCard.Text	= ds.Tables[0].Rows[0][1].ToString().Trim();
					rb_woman.Checked = !isMan;
					rb_man.Checked	= isMan;
					rtb_addr.Text	= ds.Tables[0].Rows[0][3].ToString().Trim();
					tb_Phone.Text	= ds.Tables[0].Rows[0][4].ToString().Trim();
					dtp_open.Text	= ds.Tables[0].Rows[0][5].ToString().Trim();
					tb_Passwd.Text	= tb_checkPass.Text = ds.Tables[0].Rows[0][6].ToString().Trim();

					Email_OK.Visible = CheckPass_OK.Visible = Passwd_OK.Visible =
											IdCard_OK.Visible = CheckPass_OK.Visible = true;
					button1.Text = "修改";
					tb_Email.Enabled = false;
					this.Text = "修改信息";
				}
			}
			catch (SqlException)
			{
				MessageBox.Show(null, "信息提取失败！请重试！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			#endregion
		}

		private void Member_Add_Click(object sender, EventArgs e)
		{
			if (Email_OK.Visible == true && CheckPass_OK.Visible == true && Passwd_OK.Visible == true && 
				IdCard_OK.Visible == true && CheckPass_OK.Visible == true)
			{
				string pwd = tb_Passwd.Text.Length != 32 ? Global.MD5EnCrypt(tb_Passwd.Text.Trim()) : tb_Passwd.Text.Trim();

				temp.Clear();
				temp.Add("vcEmail", tb_Email.Text.Trim());
				temp.Add("cPassWd", pwd);
				temp.Add("cIdCard", tb_IdCard.Text.Trim());
				temp.Add("cSex", rb_man.Checked ? Global.Man : Global.Woman);
				temp.Add("vcAddress", rtb_addr.Text.Trim());
				temp.Add("cPhoneNo", tb_Phone.Text.Trim());
				temp.Add("dOpenDate", dtp_open.Text.Trim());

				if (Email == "")
					Program.sqlManage.ExecuteNonQuery(SqlString.ToInsertStr("Members", temp));
				else
				{
					Hashtable condition = new Hashtable();
					condition.Add("vcEmail", tb_Email.Text.Trim());
					Program.sqlManage.ExecuteNonQuery(SqlString.ToUpdateStr("Members", condition, temp));
				}
				MessageBox.Show(this, button1.Text + "会员成功！", "提示");
				Clear();
			}
			else
			{
				MessageBox.Show(Owner, "你还有空没有填呢！", "操作失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void Clear()
		{
			tb_Email.Text = tb_Passwd.Text = tb_IdCard.Text = rtb_addr.Text =tb_Phone.Text = tb_Phone.Text = tb_checkPass.Text = "";
			CheckPass_OK.Visible = Passwd_OK.Visible = Email_OK.Visible = IdCard_OK.Visible = Phone_OK.Visible = false;
		}
	
		private void tb_Email_Leave(object sender, EventArgs e)
		{
			if (button1.Text == "添加" && tb_Email.Text.Length > 0)
			{
				for (int i = 0; i < ds.Tables[0].Rows.Count; ++i)
					if (tb_Email.Text.ToString().Trim() == ds.Tables[0].Rows[i][0].ToString().Trim())
					{
						MsgBox.ShowError("此帐号已存在！请重新选择！");
						Email_OK.Visible = false;
						tb_Email.Focus();
						tb_Email.Text = "";
						return;
					}
				Email_OK.Visible = true;
			}
		}

		private void Close_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		private void tb_Phone_KeyPress(object sender, KeyPressEventArgs e)
		{
			Global.LockNums(ref e);
		}

		private void tb_Passwd_Leave(object sender, EventArgs e)
		{
			if (tb_Passwd.Text.ToString().Trim().Length >= 5)
				Passwd_OK.Visible = true;
			else
				Passwd_OK.Visible = false;
		}

		private void tb_checkPass_Leave(object sender, EventArgs e)
		{
			if (tb_Passwd.Text.Trim() == tb_checkPass.Text.Trim())
				CheckPass_OK.Visible = true;
			else
				CheckPass_OK.Visible = false;
		}

		private void tb_Phone_Leave(object sender, EventArgs e)
		{
			if (tb_Phone.Text.Length == 11)
				Phone_OK.Visible = true;
			else
				Phone_OK.Visible = false;
		}

		private void tb_IdCard_Leave(object sender, EventArgs e)
		{
			if (tb_IdCard.Text.Length == 18)
				IdCard_OK.Visible = true;
			else
				IdCard_OK.Visible = false;
		}		
	}
}
