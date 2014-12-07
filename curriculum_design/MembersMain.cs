/********************************************
 *			 Made by MeiZhaoRui				*
 *			 2014年05月04日 更新				*
 *******************************************/

using System;
using System.Data;
using System.Windows.Forms;
using System.Collections;
using System.Threading;
using System.ComponentModel;

namespace curriculum_design
{
	public partial class MembersMain : Form
	{
		public MembersMain()
		{
			InitializeComponent();
		}

		private void Find_Press(object sender, EventArgs e)
		{
			UpdateViewByKeyPress();
		}
		DataSet ds;
		private void Find_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)13)
			{
				string str = GetFSelectStr();
				new Thread(() =>
				{
					ds = Program.sqlManage.GetDataSet(str);			
					Invoke(new Action(updateDataGridView));
				}).Start();
			}
		}

		private void Add_Click(object sender, EventArgs e)
		{
			new MembersManip().ShowDialog();
		}

		private void Alter_Click(object sender, EventArgs e)
		{
			if (SelectedCount >= 1)
			{
				string Email = SelectedValue(0, 0);
				new MembersManip(Email).ShowDialog();
				UpdateViewByKeyPress();
			}
		}
		private void Del_Click(object sender, EventArgs e)
		{
			DialogResult dr = MsgBox.ShowChioces("你确定是否真的要删除？该操作无法恢复!");
			if (dataGridView1.SelectedRows.Count >= 1 && dr == DialogResult.OK)
			{
				string delstr = "delete from {0} where {1} in ( ";
				for (int i = 0; i < SelectedCount; ++i)
				{
					delstr += string.Format("'{0}',", SelectedValue(i, 0));
				}
				delstr = string.Format(delstr.Substring(0, delstr.Length - 1) + ")", "Members", "vcEmail");
				if (Program.sqlManage.ExecuteNonQuery(delstr))
				{
					UpdateViewByKeyPress();
				}
			}
		}

		private void dataGridView1_SelectionChanged(object sender, EventArgs e)
		{
			if (SelectedCount == 1 && SelectedValue(0, 0) != "")
			{
				TSB_Alter.Enabled = TSB_Del.Enabled = tsb_ice.Enabled = true;
				if (SelectedValue(0, 6) == "1")
					tsb_ice.Text = "冻结";
				else if (SelectedValue(0, 6) == "2")
					tsb_ice.Text = "解除";
			}
			else if (SelectedCount > 1)
				TSB_Del.Enabled = !(tsb_ice.Enabled = TSB_Alter.Enabled = false);
			else
				TSB_Alter.Enabled = tsb_ice.Enabled = TSB_Del.Enabled = false;
		}

		private void tsb_ice_Click(object sender, EventArgs e)
		{
			string email = SelectedValue(0, 0);
			if (email != "")
			{
				if (tsb_ice.Text == "冻结")
				{
					Program.sqlManage.ExecuteNonQuery("update Members set cStatus ='2' where vcEmail='" + email + "'");
					tsb_ice.Text = "解除";
				}
				else
				{
					Program.sqlManage.ExecuteNonQuery("update Members set cStatus ='1' where vcEmail='" + email + "'");
					tsb_ice.Text = "冻结";
				}
				UpdateViewByKeyPress();
			}
		}

		private void TSB_Exit_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
