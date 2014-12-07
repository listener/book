/********************************************
 *			 Made by MeiZhaoRui				*
 *			 2014年04月10日 更新				*
 *******************************************/

using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace curriculum_design
{
	public partial class BookManip : Form
	{
		Hashtable values;
		string ISBN;
		DataSet ds;
		public BookManip(string ISBN = "")
		{
			InitializeComponent();
			this.ISBN = ISBN;
			values = new Hashtable();
		}
		private void BookAdd_Load(object sender, EventArgs e)
		{
			try
			{
				ds = Program.sqlManage.GetDataSet("select vcClassName from BookClass;select vcPublishName from PublishInfo");

				for (int i = 0; i < ds.Tables[0].Rows.Count; ++i)
				{
					CBB_Class.Items.Add(ds.Tables[0].Rows[i][0].ToString().Trim());
				}
				for (int i = 0; i < ds.Tables[1].Rows.Count; ++i)
				{
					CBB_Publish.Items.Add(ds.Tables[1].Rows[i][0].ToString().Trim());
				}
				if (ISBN != "")
				{
					ModifyInit();
				}
			}
			catch (SqlException es)
			{
				MsgBox.ShowError(es.ToString());
			}
		}
		private void cISBN_KeyPress(object sender, KeyPressEventArgs e)
		{
			Global.cISBN_Check(ref cISBN, ref e);
		}

		private void btn_Add_Click(object sender, EventArgs e)
		{
			values.Clear();
			values.Add(			"cISBN",cISBN.Text.ToString().Trim());
			values.Add(	   "vcBookName",vcBookName.Text.ToString().Trim());
			values.Add(   "vcClassName",CBB_Class.Text.ToString().Trim());
			values.Add( "vcPublishName",CBB_Publish.Text.ToString().Trim());
			values.Add(  "dPublishDate",DTP_PublishDate.Text.ToString().Trim());
			values.Add(      "vcAuthor",vcAuthor.Text.ToString().Trim());
			values.Add( "tIntroduction",tIntroduction.Text.ToString().Trim());
			values.Add(      "mPriceIn", mPriceIn.Text.ToString().Trim());
			values.Add(     "mPriceOut",mPriceOut.Text.ToString().Trim());
			values.Add(		   "iTotal",iTotal.Text.ToString().Trim());

			foreach(string i in values.Keys)
			{
				if (values[i].ToString().Trim() == string.Empty && i != "tIntroduction")
				{
					MsgBox.ShowError("你还有空没有填呢！");
					return;
				}
			}
			if(ISBN == "")
			{
				if (Program.sqlManage.ExecuteNonQuery(SqlString.ToInsertStr("BookInfo", values)))
				{
					MsgBox.ShowInfor("已经添加成功！");
					cISBN.Text = vcBookName.Text = vcAuthor.Text = 
						tIntroduction.Text = mPriceIn.Text = 
						mPriceOut.Text = iTotal.Text = "";
					return;
				}
			}
			else
			{
				Hashtable temp = new Hashtable() { { "cISBN", ISBN } };
				if (Program.sqlManage.ExecuteNonQuery(SqlString.ToUpdateStr("BookInfo", temp, values)))
				{
					MsgBox.ShowInfor("已经修改成功！");
					this.Close();
					return;
				}
			}
			cISBN.Focus();
			MsgBox.ShowError("操作失败，请重试！");
		}

		private void btn_Exit_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		private void checkNum_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == '.' && ((TextBox)sender).Text.IndexOf(".") >= 0)
			{
				e.Handled = true;
				return;
			}
			Global.LockNums(ref e);

		}

		private void iTotal_KeyPress(object sender, KeyPressEventArgs e)
		{
			Global.LockNums(ref e);
		}

	}
}
