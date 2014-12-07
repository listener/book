/********************************************
 *			 Made by MeiZhaoRui				*
 *			 2014年04月25日 更新				*
 *******************************************/

using System;
using System.Data;
using System.Windows.Forms;
using System.Threading;

namespace curriculum_design
{
	public partial class SaleRecords : Form
	{
		DataSet ds;
		public SaleRecords()
		{
			InitializeComponent();
		}

		private void bt_find_Click(object sender, EventArgs e)
		{
			string select = string.Format("proc_select_SaleRecord_to_SaleRecords '{0}','{1}','{2}'", dtp_time.Text, tb_username.Text.Trim(), tb_SaleId.Text.Trim());
			new Thread(() =>
			{
				ds = Program.sqlManage.GetDataSet(select);
				if (ds.Tables[1].Rows.Count > 0)
				{
					Invoke(new Action(() =>
					{
						tb_username.Items.Clear();
						for (int i = 0; i < ds.Tables[1].Rows.Count; ++i)
						{
							tb_username.Items.Add(ds.Tables[1].Rows[i][0].ToString());
						}
						dataGridView1.Rows.Clear();

						ProgressForm pf = new ProgressForm();
						pf.Show();
						int n = 100 / ds.Tables[0].Rows.Count;
						pf.Step = n;
						for (int i = 0; i < ds.Tables[0].Rows.Count; ++i)
						{
							pf.PerformStep();
							int index = this.dataGridView1.Rows.Add();
							for (int j = 0; j < ds.Tables[0].Columns.Count; ++j)
							{
								dataGridView1.Rows[index].Cells[j].Value = ds.Tables[0].Rows[i][j].ToString().Trim();
							}
						}
						pf.PauseClose();
					}));
				}
				else
					Invoke(new Action(() =>
					{
						MsgBox.ShowExclamation("当日没有记录！");
					}));
			}).Start();
		}
		
		private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if(e.ColumnIndex == 2)
				MsgBox.ShowNormal(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
		}

		private void tb_username_KeyPress(object sender, KeyPressEventArgs e)
		{
			if(e.KeyChar == 13)bt_find_Click(null, null);
		}
		private void SaleRecords_Load(object sender, EventArgs e)
		{
			tb_username.Focus();			
		}
		private void 清空ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			DialogResult OK = MsgBox.ShowChioces("你确定是否真的要清空当日记录？该操作无法恢复!");
			if ( OK == DialogResult.OK)
			{
				string s = dtp_time.Text;
				new Thread(() => { Program.sqlManage.ExecuteNonQuery("proc_delete_SaleRecords '" + s + "'"); }).Start();
				bt_find_Click(null, null);
			}
		}

		private void 当前ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (ds != null)
			{
				ExportToExcel sd = new ExportToExcel(ds);
				sd.Invoke();
			}
			else
			{
				MsgBox.ShowError("当前没有一条记录！");
			}
		}

		private void 所有ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new Thread(() =>
			{
				DataSet ds = Program.sqlManage.GetDataSet("proc_select_all_SaleRecords");
				if (ds != null)
				{
					ExportToExcel et = new ExportToExcel();
					et.dataset = ds;
					et.Invoke();
				}
				else
				{
					Invoke(new Action(() => 
					{ 
						MessageBox.Show(this, "当前没有一条记录！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error); 
					}));
				}
			}).Start();
		}
	}
}
