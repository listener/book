/********************************************
 *		    Designed by MeiZhaoRui			*
 *			 2014年04月16日 更新				*
 *******************************************/

#define debug

using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Threading;

namespace curriculum_design
{
	public partial class BookMain : Form
	{
		DataSet ds = null;
		private int Count = 0;
		public BookMain()
		{
			InitializeComponent();
		}
		private void btn_find_Click(object sender, EventArgs e)
		{
			string str = GetSelectStr();
			dataGridView1.Rows.Clear();
			new Thread(() =>
			{
				ds = Program.sqlManage.GetDataSet(str);
				Invoke(new Action(updateDataGridView));
				
			}).Start();
		}
		
		private void BookFind_Load(object sender, EventArgs e)
		{
			try
			{
				DataSet ds = Program.sqlManage.GetDataSet("get_className_and_publishName");
				CBB_BookClass.Items.Add(string.Empty);
				for (int i = 0; i < ds.Tables[0].Rows.Count; ++i)
				{
					CBB_BookClass.Items.Add(ds.Tables[0].Rows[i][0].ToString().Trim());
				}
				CBB_Publish.Items.Add(string.Empty);
				for (int i = 0; i < ds.Tables[1].Rows.Count; ++i)
				{
					CBB_Publish.Items.Add(ds.Tables[1].Rows[i][0].ToString().Trim());
				}
			}
			catch (SqlException es)
			{
				MsgBox.ShowError(es.Message);
			}
		}

		private void cISBN_KeyPress(object sender, KeyPressEventArgs e)
		{
			Global.cISBN_Check(ref cISBN, ref e);
		}
		private void TSB_Add_Click(object sender, EventArgs e)
		{
			new BookManip().ShowDialog();
		}

		private void TSB_Alter_Click(object sender, EventArgs e)
		{
			string ISBN = dataGridView1.SelectedRows[0].Cells[0].Value.ToString().Trim();
			new BookManip(ISBN).ShowDialog();
			btn_find_Click(null, null);
		}

		private void TSB_Del_Click(object sender, EventArgs e)
		{
			if (MsgBox.ShowChioces("你确定是否真的要删除？该操作无法恢复!") == DialogResult.OK)
			{
				deleteFromDatabase();
			}
		}
		private void Exit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void dataGridView1_SelectionChanged(object sender, EventArgs e)
		{
			Count = dataGridView1.SelectedRows.Count;
			if (Count == 1)
				TSB_Alter.Enabled = TSB_Del.Enabled = true;
			else if (dataGridView1.SelectedRows.Count >= 1)
				TSB_Del.Enabled = !(TSB_Alter.Enabled = false);
			else
				TSB_Alter.Enabled = TSB_Del.Enabled = false;
			try
			{
				string a = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
			}
			catch (Exception)
			{
				TSB_Alter.Enabled = TSB_Del.Enabled = false;
				return;
			}
		}

		private void TSB_export_Click(object sender, EventArgs e)
		{
			if (ds != null)
			{
				 new ExportToExcel(ds).Invoke();
			}
			else
			{
				MsgBox.ShowError("当前没有一条记录！");
			}
		}
	}
}
