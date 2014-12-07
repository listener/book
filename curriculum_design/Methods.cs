/****************************************
 *  此文件主要放置相应类中的非自动方法		*
 *										*
 *				2014－05－07				*
 * **************************************/

using System;
using System.Collections;
using System.Windows.Forms;
using System.Threading;

namespace curriculum_design
{
	partial class MM { }
	partial class AdminManip
	{
		private void update_dabase(Hashtable values)
		{
			if (Program.sqlManage.ExecuteNonQuery(SqlString.ToUpdateStr("Admins", OldValue, values)))
				MsgBox.ShowInfor("已" + button1.Text + "成功");
			else
				MsgBox.ShowError(button1.Text + "失败");
		}
		private void insert_database(Hashtable values)
		{
			if (Program.sqlManage.ExecuteNonQuery(SqlString.ToInsertStr("Admins", values)))
				MsgBox.ShowInfor("已" + button1.Text + "成功");
			else
				MsgBox.ShowError(button1.Text + "失败");
		}
	}

	partial class BookMain
	{

		private string GetSelectStr()
		{
			string selectStr = "select cISBN AS 'ISBN',vcBookName As '书名',vcClassName AS '分类'" +
				",vcPublishName AS '出版社',iTotal as '库存' from BookInfo where";
			if (Global.CheckStr(cISBN.Text.Trim()) != Global.CheckState.Empty)
				selectStr += " cISBN = '" + cISBN.Text.ToString().Trim() + "'   and";
			if (Global.CheckStr(vcBookName.Text.Trim()) == Global.CheckState.Correct)
				selectStr += " vcBookName like '%" + vcBookName.Text.ToString().Trim() + "%'   and";
			if (Global.CheckStr(CBB_BookClass.Text.Trim()) == Global.CheckState.Correct)
				selectStr += " vcClassName = '" + CBB_BookClass.Text.ToString().Trim() + "'   and";
			if (Global.CheckStr(CBB_Publish.Text.Trim()) == Global.CheckState.Correct)
				selectStr += " vcPublishName = '" + CBB_Publish.Text.ToString().Trim() + "'   and";
			selectStr = selectStr.Substring(0, selectStr.Length - 5);

			return selectStr;
		}
		private void updateDataGridView()
		{
			if (ds.Tables[0].Rows.Count > 0)
			{
				ProgressForm pf = new ProgressForm();
				int n = 100 / ds.Tables[0].Rows.Count;
				pf.Step = n;
				pf.Show();
				for (int i = 0; i < ds.Tables[0].Rows.Count; ++i)
				{
					int index = this.dataGridView1.Rows.Add();
					for (int j = 0; j < ds.Tables[0].Columns.Count; ++j)
					{
						dataGridView1.Rows[index].Cells[j].Value = ds.Tables[0].Rows[i][j].ToString().Trim();
					}
					pf.PerformStep();
				}
				pf.PauseClose();
			}
			else
				MsgBox.ShowExclamation("库中没有此图书记录！");
		}
		private string SelectedValue(int row, int cell)
		{
			try
			{
				return dataGridView1.SelectedRows[row].Cells[cell].Value.ToString().Trim();
			}
			catch (Exception)
			{
				return "";
			}
		}
		private void deleteFromDatabase()
		{
			string delstr = "delete from {0} where {1} in ( ";
			try
			{
				for (int i = 0; i < dataGridView1.SelectedRows.Count; ++i)
				{
					delstr += string.Format("'{0}',", SelectedValue(i,0));
				}
			}
			catch (Exception)
			{
				MsgBox.ShowError("其中不应该有空行！");
				return;
			}
			delstr = string.Format(delstr.Substring(0, delstr.Length - 1) + ")", "BookInfo", "cISBN");
			
			new Thread(() => { Program.sqlManage.ExecuteNonQuery(delstr); }).Start();
			btn_find_Click(this, new EventArgs());
		}
	}

	partial class BookManip
	{
		private void ModifyInit()
		{
			this.btn_Add.Text = "修改";
			this.Text = "修改图书";
			ds = Program.sqlManage.GetDataSet(string.Format("select * from BookInfo where cISBN='{0}'", ISBN));
			System.Data.DataTable table = ds.Tables[0];
			cISBN.Text			= table.Rows[0][0].ToString().Trim();
			vcBookName.Text		= table.Rows[0][1].ToString().Trim();
			CBB_Class.Text		= table.Rows[0][2].ToString().Trim();
			CBB_Publish.Text	= table.Rows[0][3].ToString().Trim();
			DTP_PublishDate.Text = table.Rows[0][4].ToString().Trim();
			vcAuthor.Text		= table.Rows[0][5].ToString().Trim();
			tIntroduction.Text	= table.Rows[0][6].ToString().Trim();
			mPriceIn.Text		= (double.Parse(table.Rows[0][7].ToString())).ToString("F2");
			mPriceOut.Text		= (double.Parse(table.Rows[0][8].ToString())).ToString("F2");
			iTotal.Text			= table.Rows[0][9].ToString().Trim();
		}
	}

	partial class Receptionist
	{
		private void OnHotkey(int hotkeyId)
		{
			this.WindowState = FormWindowState.Normal;
			int index = hotkeys.IndexOf(hotkeyId);
			switch (index)
			{
				case 0: help_Click(null, null); break;
				case 1: tb_isbn.Focus(); break;
				case 2: tb_total.Focus(); break;
				case 3: tb_pay.Focus(); break;
				case 4:
					tb_memId.ReadOnly = false;
					tb_memId.Focus();
					break;
				case 5: ShowRecords(); break;
				case 6: Cancel_Click(null, null); break;
				case 7: undo_Click(null, null); break;
				case 8: tb_total.Value += 1; break;
				case 9:
					tb_total.Value -= tb_total.Value == 0 ? 0 : 1;
					break;
			}
		}
		Hotkey hotkey;
		private void RegisterHotkeys()
		{
			hotkey = new Hotkey(this.Handle);
			hotkeys[0] = hotkey.RegisterHotkey(Keys.F1, Hotkey.KeyFlags.None);
			hotkeys[1] = hotkey.RegisterHotkey(Keys.F2, Hotkey.KeyFlags.None);
			hotkeys[2] = hotkey.RegisterHotkey(Keys.F3, Hotkey.KeyFlags.None);
			hotkeys[3] = hotkey.RegisterHotkey(Keys.F4, Hotkey.KeyFlags.None);
			hotkeys[4] = hotkey.RegisterHotkey(Keys.F5, Hotkey.KeyFlags.None);
			hotkeys[5] = hotkey.RegisterHotkey(Keys.F6, Hotkey.KeyFlags.None);
			hotkeys[6] = hotkey.RegisterHotkey(Keys.F7, Hotkey.KeyFlags.None);
			hotkeys[7] = hotkey.RegisterHotkey(Keys.F8, Hotkey.KeyFlags.None);
			hotkeys[8] = hotkey.RegisterHotkey(Keys.Add, Hotkey.KeyFlags.None);
			hotkeys[9] = hotkey.RegisterHotkey(Keys.Subtract, Hotkey.KeyFlags.None);

			hotkey.OnHotkey += new HotkeyEventHandler(OnHotkey);
		}
		CheckOut cot = null;
		private void ShowRecords()
		{
			if (dataGridView1.Rows.Count > 1 && tb_pay.Text != "")
			{
				dPay = decimal.Parse(tb_pay.Text.Trim());
				cot = new CheckOut(dTotal, dPay, Discount);
				cot.ShowDialog(this);

				UpdateDataBase();
				tb_isbn.Text = tb_memId.Text = richTextBox1.Text = tb_pay.Text = "";
				label5.Text = Global.zeroFormatStr;
				dTotal = dPay = 0;
				Discount = tb_total.Value = 1;
				tb_isbn.Focus();
				dataGridView1.Rows.Clear();
				tb_memId.ReadOnly = false;
			}
			else
				MsgBox.ShowError("请输入现金额或没有此商品");
		}
		const string UpdateTotalPoint = "execute proc_update_bookInfo '{0}',{1}; " +
										"execute proc_update_memberpoint '{2}',{3}";
		const string InsertSaleRecord = "execute proc_insert_SaleRecords '{0}','{1}','{2}','{3}'";
		private void UpdateDataBase()
		{
			string usename = "";
			string[] values = new string[5];
			decimal discount = 0;

			usename = tb_memId.Text == "" ? "nobody" : tb_memId.Text;
			string saleId = DateTime.Now.ToString("8023yyyyMMddHHMMss");

			string saleinfo = "流水号: " + saleId + "\n用户名是: " + usename;
			for (int i = 0; i < dataGridView1.Rows.Count - 1; ++i)
			{
				values[0] = dataGridView1.Rows[i].Cells[0].Value.ToString().Trim();/*ISBN*/
				values[1] = dataGridView1.Rows[i].Cells[1].Value.ToString().Trim();/*BookName*/
				values[2] = dataGridView1.Rows[i].Cells[2].Value.ToString().Trim();/*PriceOut*/
				values[4] = dataGridView1.Rows[i].Cells[4].Value.ToString().Trim();/*Total*/
				discount = decimal.Parse(dataGridView1.Rows[i].Cells[5].Value.ToString().Trim());
				/*在BookInfo中减去相应的数量级增加相应的积分*/
				Program.sqlManage.ExecuteNonQuery(string.Format(UpdateTotalPoint, values[0], values[4], usename, (int)discount));
				saleinfo += "\n书号: " + values[0] + "\t书名:" + values[1] + "\n总数: " + values[4] + "\t总价:" + discount;
			}
			saleinfo += "\n总额: " + string.Format("{0,4:F2}", dTotal) + "\t折扣: " + string.Format("{0,4:F2}", dTotal * (1 - Discount));
			/*增加销售记录*/
			Program.sqlManage.ExecuteNonQuery(string.Format(InsertSaleRecord, usename, saleId, DateTime.Now.ToString("yyyy-MM-dd"), saleinfo));

		}
	}

	partial class MembersMain
	{
		private void UpdateViewByKeyPress()
		{
			Find_KeyPress(null, new KeyPressEventArgs((char)13));
		}
		private string SelectedValue(int row, int cell)
		{
			try
			{
				return dataGridView1.SelectedRows[row].Cells[cell].Value.ToString().Trim();
			}
			catch (Exception)
			{
				return "";
			}
		}
		private int SelectedCount
		{
			get { return dataGridView1.SelectedRows.Count; }
		}
		public string GetFSelectStr()
		{
			string selectStr = "select vcEmail AS '用户名',cIdCard As '身份证',cPhoneNo AS '电话'" +
				   ",cSex AS '姓别',vcAddress as '地址', dOpenDate As '开通日期',cStatus AS '状态'," +
				   " iMemberPoint As '积分' from Members where";
			if (Global.CheckStr(textBox1.Text.ToString().Trim()) != Global.CheckState.Empty)
				selectStr += " vcEmail like '%" + textBox1.Text.ToString().Trim() + "%'   and";

			if (Global.CheckStr(textBox2.Text.ToString().Trim()) == Global.CheckState.Correct)
				selectStr += " cIdCard = '" + textBox2.Text.ToString().Trim() + "'   and";

			if (Global.CheckStr(textBox3.Text.ToString().Trim()) == Global.CheckState.Correct)
				selectStr += " cPhoneNo like '%" + textBox3.Text.ToString().Trim() + "%'   and";
			return selectStr.Substring(0, selectStr.Length - 5);
		}

		private void updateDataGridView()
		{
			ProgressForm pf = new ProgressForm();
			pf.Show();
			int count = ds.Tables[0].Rows.Count;
			dataGridView1.Rows.Clear();
			if (count > 0)
			{
				int n = 80 / ds.Tables[0].Rows.Count;
				pf.Step = n;

				for (int i = 0; i < ds.Tables[0].Rows.Count; ++i)
				{
					pf.PerformStep();
					int index = dataGridView1.Rows.Add();
					for (int j = 0; j < ds.Tables[0].Columns.Count; ++j)
					{
						dataGridView1.Rows[index].Cells[j].Value = ds.Tables[0].Rows[i][j].ToString().Trim();
					}
				}
			}
			pf.PauseClose();
		}
	}
}