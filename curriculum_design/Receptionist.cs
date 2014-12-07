/********************************************
 *			 Made by MeiZhaoRui				*
 *			 2014年05月05日 更新				*
 *******************************************/

using System;
using System.Data;
using System.Threading;
using System.Collections;
using System.Windows.Forms;

namespace curriculum_design
{
	public partial class Receptionist : Form
	{
		static ArrayList hotkeys = new ArrayList 
		{
			0/*help	 */, 0/*isbn  */, 0/*sum */, 0/*pay   */, 0/*memId*/,
			0/*record*/, 0/*cancel*/, 0/*undo*/, 0/*sum++ */, 0/*sum--*/
		};
		decimal dTotal = 0, dPay = 0, Discount = 1;
		Hashtable stock = new Hashtable();
		public bool TSBIsVisiable
		{
			set { toolStripButton1.Visible = value; }
		}
		public Receptionist()
		{
			InitializeComponent();
			label5.Text = Global.zeroFormatStr;
		}
		
		private void Receptionist_Load(object sender, EventArgs e)
		{
			Global.ShowCloseOption = true;
			RegisterHotkeys();
		}

		private void Receptionist_FormClosed(object sender, FormClosedEventArgs e)
		{
			hotkey.UnRegisterHotkeys();
		}
		private void ISBN_KeyPress(object sender, KeyPressEventArgs e)
		{
			Global.cISBN_Check(ref tb_isbn, ref e);
			Total_KeyPress(null, e);
		}
		const string SelectWhereISBN = " proc_select_BookInfo_to_Receptionist '{0}'";
		private int kucun
		{
			set { tb_kucun.Text = Convert.ToString(value); }
			get { return int.Parse(tb_kucun.Text); }
		}
		private void Total_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == 13)
			{
				string selectStr = string.Format(SelectWhereISBN, tb_isbn.Text.ToString().Trim());
				DataSet ds = Program.sqlManage.GetDataSet(selectStr);
				kucun = int.Parse(ds.Tables[0].Rows[0][3].ToString().Trim()/*书数*/);
				if (kucun - tb_total.Value > 0 && ds.Tables[0].Rows.Count != 0)
				{
					int index = this.dataGridView1.Rows.Add();
					decimal count = tb_total.Value * decimal.Parse(ds.Tables[0].Rows[0][2].ToString().Trim());
					dataGridView1.Rows[index].Cells[0].Value = ds.Tables[0].Rows[0][0].ToString().Trim();
					dataGridView1.Rows[index].Cells[1].Value = ds.Tables[0].Rows[0][1].ToString().Trim();
					dataGridView1.Rows[index].Cells[2].Value = string.Format("{0,4:F2}", ds.Tables[0].Rows[0][2].ToString().Trim());
					dataGridView1.Rows[index].Cells[3].Value = string.Format("{0,4:F2}", 1);
					dataGridView1.Rows[index].Cells[4].Value = string.Format("{0}", tb_total.Value);
					dataGridView1.Rows[index].Cells[5].Value = string.Format("{0,4:F2}", count);

					dTotal = decimal.Parse(string.Format("{0}", label5.Text.ToString().Trim())) + count;
					label5.Text = string.Format("{0,4:F2}", dTotal);
				}
				else
					MessageBox.Show("本图书册数不够！\n", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
				tb_total.Focus();
			}
		}
				
		private void button1_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == 13) ShowRecords();
		}

		private void 注销_Click(object sender, EventArgs e)
		{
			DialogResult OK = MsgBox.ShowChioces("是否真的要注销？");
			if (OK == DialogResult.OK)
			{
				Global.ShowCloseOption = false;
				new Thread(new ThreadStart(() => { Login mf = new Login(); Application.Run(mf); })).Start();
				this.Close();
			}
		}

		private void Cancel_Click(object sender, EventArgs e)
		{
			tb_isbn.Text = tb_memId.Text = richTextBox1.Text = "";
			dataGridView1.Rows.Clear();
			dTotal = dPay = 0;
			Discount = tb_total.Value = 1;
			label5.Text = Global.zeroFormatStr;
		}

		private void undo_Click(object sender, EventArgs e)
		{
			int RowsCount = dataGridView1.Rows.Count;
			if (RowsCount >= 2)
			{
				string total = dataGridView1.Rows[RowsCount- 2].Cells[5].Value.ToString().Trim();
				dTotal -= Decimal.Parse(total);
				label5.Text = string.Format("{0,4:F2}", dTotal);
				dataGridView1.Rows.RemoveAt(RowsCount - 2);
			}
		}

		private void help_Click(object sender, EventArgs e)
		{
			MsgBox.ShowInfor(
				"F1: 帮助信息\t\tF2: ISBN文本框获得焦点\n" +
				"F3: 数量文本框获得焦点\tF4: 收款文本框获得焦点\n" +
				"F5: 会员号文本框获得焦点\tF6: 弹出付款信息并打印\n" +
				"F7: 取消本次服务\t\tF8: 取消当前操作\n" +
				"加号: 增加图书数量\t\t减号: 减少图书数量"
				);
		}

		private void tb_pay_KeyPress(object sender, KeyPressEventArgs e)
		{
			Global.CheckMoney(ref sender, ref e);
			if (e.KeyChar == 13 && tb_pay.Text != "")
			{
				ShowRecords();
			}
		}
		private void button1_Click(object sender, EventArgs e)
		{
			ShowRecords();
		}

		private void tsb_about_Click(object sender, EventArgs e)
		{
			new About().ShowDialog();
		}

		private void Receptionist_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (Global.ShowCloseOption)
			{
				e.Cancel = MsgBox.ShowChioces("确定是否真的要退出？") == DialogResult.Cancel;
			}
		}
		DataSet ds;
		private void tb_memId_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == 13)
			{
				string selectstr = "proc_select_Member_to_Receptionist '" + tb_memId.Text.ToString().Trim() + "'";
				ds = Program.sqlManage.GetDataSet(selectstr);
				if (ds.Tables[0].Rows.Count > 0)
				{
					if (ds.Tables[0].Rows[0][3].ToString().Trim() == "1")
					{
						tb_memId.ReadOnly = true;
						string s = "proc_select_iDiscount_to_Receptionist " + ds.Tables[0].Rows[0][2].ToString().Trim();
						Discount = Convert.ToDecimal(Program.sqlManage.ExecuteScalar(s).ToDouble());
						richTextBox1.Text =
							"身份证号: " + ds.Tables[0].Rows[0][0].ToString().Trim() + "\n" +
							"  手机号: " + ds.Tables[0].Rows[0][1].ToString().Trim() + "\n" +
							"    积分: " + ds.Tables[0].Rows[0][2].ToString().Trim() + "\n" +
							"    等级: " + Discount;
					}
					else
					{
						richTextBox1.Text = "该用户已经冻结，请联系管理员！";
						tb_memId.Text = "";
					}
				}
				else
				{
					tb_memId.Text = richTextBox1.Text = "";
				}
				Discount = 1;
			}
		}
	}
}
