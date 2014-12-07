/********************************************
 *			 Made by MeiZhaoRui				*
 *			 2014年04月10日 更新				*
 *******************************************/
using System.Windows.Forms;

namespace curriculum_design
{
	public partial class CheckOut : Form
	{
		const string formatToStr = "{0,3:F1}";
		public CheckOut(decimal dTotal, decimal dPaid_in, decimal Discount)
		{
			InitializeComponent();
			label7.Text = string.Format(formatToStr, dTotal);
			label8.Text = string.Format(formatToStr, dPaid_in);
			label9.Text = string.Format(formatToStr, dPaid_in - dTotal * Discount);

			if (Discount != 1)
			{
				label12.Text = string.Format(formatToStr, dTotal * (1 - Discount));
			}
			else
			{
				this.Height -= label10.Height;
				label11.Visible = label10.Visible = label12.Visible = false;
			}
		}

		private void CheckOut_KeyPress(object sender, KeyPressEventArgs e)
		{
			this.Close();
		}
	}
}
