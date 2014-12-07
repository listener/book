/********************************************
 *		数据库连接类，统一连接关闭			*
 *			Made by MeiZhaoRui				*
 *			2014年05月01日 更新				*
 *******************************************/

/*************************/
//						 //
//#define Debug //发布时要删除
//						 //
/*************************/

using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections;
namespace curriculum_design
{
	/// <summary>
	/// 对Sql的操作包装成类，用户不再需要操作数据库的打开和关闭
	/// 只用关心对表的操作
	/// </summary>
	public class SqlManage : IDisposable
	{
		private SqlConnection conn = null;
		private string database;
		public SqlManage(string database)
		{
			this.database = database;
		}
		public void Dispose()
		{
			conn.Dispose();
		}
		public SqlManage Connect()
		{
			try
			{
				conn = new SqlConnection(GetConnectionStr(database));
				conn.Open();
				conn.Close();
			}
			catch (Exception)
			{
				if (SqlManage.AddDataBase(database) == false)
					return null;
			}
			finally
			{
				if (conn.State == ConnectionState.Open)
					conn.Close();
			}
			return this;
		}
		/// <summary>
		/// 用于返回数据库中的一个子表，保留表的结构
		/// </summary>
		/// <param name="sqlCmd">数据库操作命令如 select * from Admins </param>
		/// <returns></returns>
		public DataSet GetDataSet(string sqlCmd)
		{
			try
			{
				conn.Open();
				DataSet ds = new DataSet();
				SqlDataAdapter da = new SqlDataAdapter(sqlCmd, conn);
				da.Fill(ds);
				conn.Close();
				return ds;
			}
#if Debug
			catch (SqlException es)
			{

				MessageBox.Show("GetDataSet error at common 46\n" + es.ToString(),
					"错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
#else
			catch (SqlException )
			{
#endif
				return null;
			}
			finally
			{
				if (conn.State == ConnectionState.Open) conn.Close();
			}
		}
		/// <summary>
		/// 主要是运行没有返回值的语句如 存储过程，插入操作，更新操作
		/// </summary>
		/// <param name="sqlCmd"></param>
		/// <returns></returns>
		public bool ExecuteNonQuery(string sqlCmd)
		{
			try
			{
				conn.Open();
				SqlCommand comm = new SqlCommand(sqlCmd, conn);
				comm.ExecuteNonQuery();
				conn.Close();
				return true;
			}
#if Debug
			catch (SqlException es)
			{
				MessageBox.Show("ExecuteNonQuery error at common 63\n" + es.ToString(),
					"错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
#else
			catch (SqlException )
			{
#endif
				return false;
			}
			finally
			{
				if (conn.State == ConnectionState.Open) conn.Close();
			}
		}
		/// <summary>
		/// 要确保你要返回的类型可以转换
		/// 如 "abd" 你就不能转换为 int 类型
		/// </summary>
		public partial class NSObject
		{
			public object obj { set; get; }
		}
		/// <summary>
		/// 数据库选择操作，返回第一行第一列的对象
		/// 只需要返回一个数据的操作
		/// </summary>
		/// <param name="sqlCmd"></param>
		/// <returns></returns>
		public NSObject ExecuteScalar(string sqlCmd)
		{
			try
			{
				conn.Open();
				SqlCommand comm = new SqlCommand(sqlCmd, conn);
				NSObject obj = new NSObject();
				obj.obj = comm.ExecuteScalar();
				conn.Close();
				return obj;
			}
#if Debug
			catch (SqlException es)
			{
				MessageBox.Show("ExecuteScalar error at common 79\n" + es.ToString(),
					"错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
#else
			catch (SqlException )
			{
#endif
				return null;
			}
			finally
			{
				if (conn.State == ConnectionState.Open) conn.Close();
			}
		}
		public static string GetConnectionStr(string database)
		{
			SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
			scsb.ConnectTimeout = 1;
			scsb.InitialCatalog = database;
			scsb.DataSource = DES.Decrypt(INI.ReadValue("dataSource", "DataSource"));
			scsb.IntegratedSecurity = DES.Decrypt(INI.ReadValue("dataSource", "IntegratedSecurity")) == "true";
			if (scsb.IntegratedSecurity == false)
			{
				scsb.UserID = DES.Decrypt(INI.ReadValue("dataSource", "uid").Trim());
				scsb.Password = DES.Decrypt(INI.ReadValue("dataSource", "pwd").Trim());
			}
			return scsb.ConnectionString;
		}
		public static bool AddDataBase(string dataBase)
		{
			try
			{
				SqlConnection conn1 = new SqlConnection(GetConnectionStr("master"));
				SqlCommand cmd = new SqlCommand();
				cmd.Connection = conn1;

				cmd.CommandText = @"sp_attach_db";
				cmd.Parameters.Add(new SqlParameter(@"dbname", SqlDbType.NVarChar));
				cmd.Parameters["dbname"].Value = dataBase;
				cmd.Parameters.Add(new SqlParameter(@"filename1", SqlDbType.NVarChar));
				cmd.Parameters["filename1"].Value = Application.StartupPath + @"\" + dataBase + ".MDF";
				cmd.Parameters.Add(new SqlParameter(@"filename2", SqlDbType.NVarChar));
				cmd.Parameters["filename2"].Value = Application.StartupPath + @"\" + dataBase + "_log.LDF";
				cmd.CommandType = CommandType.StoredProcedure;
				if (conn1.State == ConnectionState.Open) conn1.Close();
				conn1.Open();
				cmd.ExecuteNonQuery();
				conn1.Close();
			}
			catch (SqlException es)
			{
				MsgBox.ShowError(es.Number.ToString() + ": 附加失败,请退出并手动添\n加安装目录下的数据库后再启动");
				return false;
			}
			return true;
		}
		public partial class NSObject
		{
			public int ToInteger()
			{
				try
				{
					return int.Parse(obj.ToString());
				}
				catch (Exception)
				{
					throw new Exception("Cannot cast to int");
				}
			}
			public double ToDouble()
			{
				try
				{
					return double.Parse(obj.ToString());
				}
				catch (Exception)
				{
					throw new Exception("Cannot cast to double");
				}
			}
			public bool ToBoolean()
			{
				if (ToString().ToLower() == "true")
					return true;
				else if (ToString().ToLower() == "false")
					return false;
				else
					throw new Exception("Cannot cast to boolean");
			}
			public new string ToString() { return obj.ToString(); }
		}
	}
	
}
