namespace curriculum_design
{
	partial class Login
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.UserPassWd = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.Cancel = new System.Windows.Forms.Button();
			this.Submit = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.menuStrip2 = new System.Windows.Forms.MenuStrip();
			this.配置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.选择服务器ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cb_admin = new System.Windows.Forms.CheckBox();
			this.cb_passwd = new System.Windows.Forms.CheckBox();
			this.UserName = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.menuStrip2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label2.Location = new System.Drawing.Point(11, 91);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 21);
			this.label2.TabIndex = 0;
			this.label2.Text = "登陆名";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label3.Location = new System.Drawing.Point(27, 130);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(42, 21);
			this.label3.TabIndex = 0;
			this.label3.Text = "密码";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// UserPassWd
			// 
			this.UserPassWd.AcceptsReturn = true;
			this.UserPassWd.AcceptsTab = true;
			this.UserPassWd.Font = new System.Drawing.Font("微软雅黑", 11F);
			this.UserPassWd.Location = new System.Drawing.Point(72, 130);
			this.UserPassWd.MaxLength = 18;
			this.UserPassWd.Name = "UserPassWd";
			this.UserPassWd.PasswordChar = '*';
			this.UserPassWd.ShortcutsEnabled = false;
			this.UserPassWd.Size = new System.Drawing.Size(188, 27);
			this.UserPassWd.TabIndex = 2;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(0, 28);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(300, 44);
			this.pictureBox1.TabIndex = 4;
			this.pictureBox1.TabStop = false;
			// 
			// Cancel
			// 
			this.Cancel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.Cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Cancel.Location = new System.Drawing.Point(47, 202);
			this.Cancel.Name = "Cancel";
			this.Cancel.Size = new System.Drawing.Size(91, 30);
			this.Cancel.TabIndex = 5;
			this.Cancel.Text = "重 填";
			this.Cancel.UseVisualStyleBackColor = true;
			this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
			// 
			// Submit
			// 
			this.Submit.AccessibleName = "bc";
			this.Submit.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.Submit.Location = new System.Drawing.Point(169, 202);
			this.Submit.Name = "Submit";
			this.Submit.Size = new System.Drawing.Size(91, 30);
			this.Submit.TabIndex = 6;
			this.Submit.Text = "登 陆";
			this.Submit.UseVisualStyleBackColor = true;
			this.Submit.Click += new System.EventHandler(this.Submit_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Location = new System.Drawing.Point(0, 25);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(301, 24);
			this.menuStrip1.TabIndex = 7;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// menuStrip2
			// 
			this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.配置ToolStripMenuItem});
			this.menuStrip2.Location = new System.Drawing.Point(0, 0);
			this.menuStrip2.Name = "menuStrip2";
			this.menuStrip2.Size = new System.Drawing.Size(301, 25);
			this.menuStrip2.TabIndex = 8;
			this.menuStrip2.Text = "menuStrip2";
			// 
			// 配置ToolStripMenuItem
			// 
			this.配置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.选择服务器ToolStripMenuItem});
			this.配置ToolStripMenuItem.Name = "配置ToolStripMenuItem";
			this.配置ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
			this.配置ToolStripMenuItem.Text = "配置";
			// 
			// 选择服务器ToolStripMenuItem
			// 
			this.选择服务器ToolStripMenuItem.Name = "选择服务器ToolStripMenuItem";
			this.选择服务器ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.选择服务器ToolStripMenuItem.Text = "选择服务器";
			this.选择服务器ToolStripMenuItem.Click += new System.EventHandler(this.Setting_Click);
			// 
			// cb_admin
			// 
			this.cb_admin.AutoSize = true;
			this.cb_admin.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.cb_admin.Location = new System.Drawing.Point(82, 172);
			this.cb_admin.Name = "cb_admin";
			this.cb_admin.Size = new System.Drawing.Size(67, 23);
			this.cb_admin.TabIndex = 3;
			this.cb_admin.Text = "管理员";
			this.cb_admin.UseVisualStyleBackColor = true;
			// 
			// cb_passwd
			// 
			this.cb_passwd.AutoSize = true;
			this.cb_passwd.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.cb_passwd.Location = new System.Drawing.Point(169, 172);
			this.cb_passwd.Name = "cb_passwd";
			this.cb_passwd.Size = new System.Drawing.Size(80, 23);
			this.cb_passwd.TabIndex = 4;
			this.cb_passwd.Text = "记住密码";
			this.cb_passwd.UseVisualStyleBackColor = true;
			// 
			// UserName
			// 
			this.UserName.Font = new System.Drawing.Font("微软雅黑", 11F);
			this.UserName.FormattingEnabled = true;
			this.UserName.Location = new System.Drawing.Point(72, 89);
			this.UserName.Name = "UserName";
			this.UserName.Size = new System.Drawing.Size(188, 28);
			this.UserName.TabIndex = 1;
			this.UserName.SelectedIndexChanged += new System.EventHandler(this.UserName_SelectedIndexChanged);
			this.UserName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UserName_KeyPress);
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(301, 249);
			this.Controls.Add(this.UserName);
			this.Controls.Add(this.cb_passwd);
			this.Controls.Add(this.cb_admin);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.UserPassWd);
			this.Controls.Add(this.Cancel);
			this.Controls.Add(this.Submit);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.menuStrip2);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Login";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "图书销售系统登陆";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
			this.Load += new System.EventHandler(this.Login_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.menuStrip2.ResumeLayout(false);
			this.menuStrip2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox UserPassWd;
		private System.Windows.Forms.Button Submit;
		private System.Windows.Forms.Button Cancel;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.MenuStrip menuStrip2;
		private System.Windows.Forms.ToolStripMenuItem 配置ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 选择服务器ToolStripMenuItem;
		private System.Windows.Forms.CheckBox cb_admin;
		private System.Windows.Forms.CheckBox cb_passwd;
		private System.Windows.Forms.ComboBox UserName;
	}
}

