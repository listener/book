/********************************************
 *			 Made by MeiZhaoRui				*
 *			 2014年04月10日 更新				*
 *******************************************/

using System;
using System.Threading;
using System.Windows.Forms;
namespace curriculum_design
{
	public partial class MainForm : Form
	{
		
		public MainForm()
		{
			InitializeComponent();
		}
		/// <summary>
		/// 切换用户
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void 注消ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (MsgBox.ShowChioces("是否真的要注销？") == DialogResult.OK)
			{
				Global.ShowCloseOption = false;
				new Thread(
					new ThreadStart(() =>
					{
						Login mf = new Login();
						Application.Run(mf);
					}
					)).Start();
				this.Close();
				Global.ShowCloseOption = true;
			}
		}

		private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void 会员管理ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				new MembersMain().ShowDialog();
			}catch(Exception es)
			{
				MessageBox.Show(es.ToString());
			}
		}

		private void 图书管理ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			 new BookMain().ShowDialog();
		}
		/// <summary>
		/// 从这里登陆的无法注销到登陆界面
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void 前台销售ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Hide();
			 Receptionist rt = new Receptionist();
			rt.TSBIsVisiable = false;
			rt.ShowDialog();
			this.Visible = true;
		}

		private void 员工管理ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new AdminMain().ShowDialog();
		}

		private void 出版社管理ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new PublishManip().ShowDialog();
		}

		private void 销售记录ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new SaleRecords().ShowDialog();
		}

		private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new About().ShowDialog();
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (Global.ShowCloseOption)
			{
				e.Cancel = MsgBox.ShowChioces("确定是否真的要退出？") == DialogResult.Cancel;
			}
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			Global.ShowCloseOption = true;
		}
	}
}