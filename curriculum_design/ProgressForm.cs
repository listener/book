/****************************************
 *			Made by MeiZhaoRui			*
 *			2014年05月04日 更新			*
 ***************************************/
//#define debug

using System.Threading;
using System.Windows.Forms;

namespace curriculum_design
{
	/// <summary>
	/// 自定义的进度条窗口，显示后台任务的进度
	/// </summary>
	partial class ProgressForm : Form
	{
		public ProgressForm()
		{
			InitializeComponent();
		}
		public int Step
		{
			get { return progressBar1.Step; }
			set { progressBar1.Step = value; }
		}

		public void PerformStep()
		{
			progressBar1.PerformStep();
			this.Text = "进度提示" + progressBar1.Value + "%";
		}

		public void PauseClose()
		{
#if debug
			Thread.Sleep(500);
#endif
			this.Close();
		}

		private void ProgressForm_Load(object sender, System.EventArgs e)
		{
			this.StartPosition =FormStartPosition.CenterScreen;
		}
	}
}
