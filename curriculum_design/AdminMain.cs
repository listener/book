/********************************************
 *				员工管理主界面				*
 *			 Made by MeiZhaoRui				*
 *			 2014年05月01日 更新				*
 *******************************************/

using System;
using System.Data;
using System.Windows.Forms;
using System.Threading;
namespace curriculum_design
{
	public partial class AdminMain : Form
	{
		DataSet ds;
		public AdminMain()
		{
			InitializeComponent();
		}
		private void cISBN_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == 13)
			{
				new Thread(() =>
				{
					ds = Program.sqlManage.GetDataSet("proc_select_Admins_to_AdminMan");
					Invoke(new Action(() =>
					{
						dataGridView1.DataSource = ds.Tables[0].DefaultView;
					}));
				}).Start();
			}
		}
		private void updateDataGridView()
		{
			cISBN_KeyPress(null, new KeyPressEventArgs((char)13));
		}
		private void find_Click(object sender, EventArgs e)
		{
			updateDataGridView();
		}
		private void dataGridView1_SelectionChanged(object sender, EventArgs e)
		{
			if (dataGridView1.SelectedRows.Count == 1)
				TSB_Alter.Enabled = TSB_Del.Enabled = true;
			else if (dataGridView1.SelectedRows.Count > 1)
				TSB_Del.Enabled = !(TSB_Alter.Enabled = false);
			else
				TSB_Alter.Enabled = TSB_Del.Enabled = false;
		}
		private void TSB_Add_Click(object sender, EventArgs e)
		{
			new AdminManip().ShowDialog();
			updateDataGridView();
		}

		private void TSB_Alter_Click(object sender, EventArgs e)
		{
			string username = dataGridView1.SelectedRows[0].Cells[0].Value.ToString().Trim();
			string level = dataGridView1.SelectedRows[0].Cells[1].Value.ToString().Trim();

			if (new AdminManip(username, level).ShowDialog() == DialogResult.OK)
				updateDataGridView();
		}

		private void TSB_Exit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void TSB_Del_Click(object sender, EventArgs e)
		{
			if ( MsgBox.ShowChioces("你确定是否真的要删除？该操作无法恢复!") == DialogResult.OK)
			{
				string str = "proc_delete_Admins_from_AdminMan '{0}','{1}'";
				string delstr = "";
				for (int i = 0; i < dataGridView1.SelectedRows.Count; ++i)
				{
					delstr = string.Format(str, 
						dataGridView1.SelectedRows[i].Cells[0].Value.ToString().Trim(),
						dataGridView1.SelectedRows[i].Cells[1].Value.ToString().Trim());
					Program.sqlManage.ExecuteNonQuery(delstr);
				}
				updateDataGridView();
			}
		}
	}
}
