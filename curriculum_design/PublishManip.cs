/********************************************
 *			 Made by MeiZhaoRui				*
 *			 2014年04月16日 更新				*
 *******************************************/

using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace curriculum_design
{
	public partial class PublishManip : Form
	{
		DataSet ds;
		public PublishManip()
		{
			InitializeComponent();
		}
		private void Update_ds()
		{
			try
			{
				ds = Program.sqlManage.GetDataSet("proc_select_PublishInfo");
				comboBox1.Items.Add("");
				for (int i = 0; i < ds.Tables[0].Rows.Count; ++i)
				{
					comboBox1.Items.Add(ds.Tables[0].Rows[i][0].ToString().Trim());
				}
			}
			catch (SqlException es)
			{
				MsgBox.ShowError(es.ToString() );
			}
		}
		private void PublishManip_Load(object sender, EventArgs e)
		{
			Update_ds();
		}

		private void add_Click(object sender, EventArgs e)
		{
			string str = "execute proc_insert_publishInfo '" + comboBox1.Text + "','" + tInfomation.Text.ToString().Trim() + "'";
			if (Program.sqlManage.ExecuteNonQuery(str))
			{
				MsgBox.ShowNormal("添加成功");
				comboBox1.Items.Clear();
				tInfomation.Clear();
				Update_ds();
			}
			else
				MsgBox.ShowError("已存在此出版社信息，添加失败！");	
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (comboBox1.SelectedIndex != 0)
			{
				tb_del.Enabled = !(tb_add.Enabled = false);
				tInfomation.ReadOnly = true;
				tInfomation.Text = ds.Tables[0].Rows[comboBox1.SelectedIndex - 1][1].ToString().Trim();
			}
			else
			{
				tInfomation.Text = "";
				tInfomation.ReadOnly = false;
				tb_del.Enabled = !(tb_add.Enabled = true);
			}
		}

		private void del_Click(object sender, EventArgs e)
		{
			string str = "proc_delete_PublishInfo '" + comboBox1.Text + "'";

			if (Program.sqlManage.ExecuteNonQuery(str))
			{
				MsgBox.ShowInfor("删除成功");
				comboBox1.Items.Clear();
				tInfomation.Clear();
				Update_ds();
			}
			else
				MsgBox.ShowError("还有图书引用此出版社，请确定已无此出版社图书再操作！");
		}

		private void textBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !tb_add.Enabled;
		}
	}
}
