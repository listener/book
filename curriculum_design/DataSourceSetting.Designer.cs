namespace curriculum_design
{
	partial class DataSourceSetting
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataSourceSetting));
			this.label1 = new System.Windows.Forms.Label();
			this.cbb_servername = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.tb_username = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.cb_ways = new System.Windows.Forms.ComboBox();
			this.tb_passwd = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("微软雅黑", 9F);
			this.label1.Location = new System.Drawing.Point(45, 30);
			this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "服务器名称：";
			// 
			// cbb_servername
			// 
			this.cbb_servername.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbb_servername.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.cbb_servername.Font = new System.Drawing.Font("微软雅黑", 9F);
			this.cbb_servername.FormattingEnabled = true;
			this.cbb_servername.Location = new System.Drawing.Point(128, 27);
			this.cbb_servername.Name = "cbb_servername";
			this.cbb_servername.Size = new System.Drawing.Size(193, 25);
			this.cbb_servername.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Enabled = false;
			this.label2.Font = new System.Drawing.Font("微软雅黑", 7F);
			this.label2.Location = new System.Drawing.Point(77, 115);
			this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 16);
			this.label2.TabIndex = 0;
			this.label2.Text = "用户名：";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Enabled = false;
			this.label3.Font = new System.Drawing.Font("微软雅黑", 7F);
			this.label3.Location = new System.Drawing.Point(86, 145);
			this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(38, 16);
			this.label3.TabIndex = 0;
			this.label3.Text = "密码：";
			// 
			// tb_username
			// 
			this.tb_username.Enabled = false;
			this.tb_username.Font = new System.Drawing.Font("微软雅黑", 8F);
			this.tb_username.Location = new System.Drawing.Point(128, 111);
			this.tb_username.Name = "tb_username";
			this.tb_username.Size = new System.Drawing.Size(193, 22);
			this.tb_username.TabIndex = 2;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("微软雅黑", 9F);
			this.button1.Location = new System.Drawing.Point(48, 181);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(89, 29);
			this.button1.TabIndex = 4;
			this.button1.Text = "连接测试";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.TestConnect_Click);
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("微软雅黑", 9F);
			this.button2.Location = new System.Drawing.Point(151, 181);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(87, 29);
			this.button2.TabIndex = 4;
			this.button2.Text = "取  消";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Cancel_Click);
			// 
			// button3
			// 
			this.button3.Font = new System.Drawing.Font("微软雅黑", 9F);
			this.button3.Location = new System.Drawing.Point(253, 181);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(95, 29);
			this.button3.TabIndex = 4;
			this.button3.Text = "确  认";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Setting_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("微软雅黑", 9F);
			this.label4.Location = new System.Drawing.Point(55, 71);
			this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(68, 17);
			this.label4.TabIndex = 0;
			this.label4.Text = "连接方式：";
			// 
			// cb_ways
			// 
			this.cb_ways.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_ways.Font = new System.Drawing.Font("微软雅黑", 9F);
			this.cb_ways.FormattingEnabled = true;
			this.cb_ways.Items.AddRange(new object[] {
            "Windows 身份认证",
            "SQL Server 身份认证"});
			this.cb_ways.Location = new System.Drawing.Point(128, 68);
			this.cb_ways.Name = "cb_ways";
			this.cb_ways.Size = new System.Drawing.Size(193, 25);
			this.cb_ways.TabIndex = 1;
			this.cb_ways.SelectedIndexChanged += new System.EventHandler(this.cb_ways_SelectedIndexChanged);
			// 
			// tb_passwd
			// 
			this.tb_passwd.Enabled = false;
			this.tb_passwd.Font = new System.Drawing.Font("微软雅黑", 8F);
			this.tb_passwd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.tb_passwd.Location = new System.Drawing.Point(128, 141);
			this.tb_passwd.MaxLength = 18;
			this.tb_passwd.Name = "tb_passwd";
			this.tb_passwd.PasswordChar = '*';
			this.tb_passwd.Size = new System.Drawing.Size(193, 22);
			this.tb_passwd.TabIndex = 2;
			// 
			// DataSourceSetting
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(396, 232);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.tb_passwd);
			this.Controls.Add(this.tb_username);
			this.Controls.Add(this.cb_ways);
			this.Controls.Add(this.cbb_servername);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(5);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "DataSourceSetting";
			this.RightToLeftLayout = true;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "配置";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DataSourceSetting_FormClosing);
			this.Load += new System.EventHandler(this.DataSourceSetting_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cbb_servername;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tb_username;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox cb_ways;
		private System.Windows.Forms.TextBox tb_passwd;
	}
}