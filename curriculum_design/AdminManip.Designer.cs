namespace curriculum_design
{
	partial class AdminManip
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminManip));
			this.CheckPass_OK = new System.Windows.Forms.Label();
			this.Passwd_OK = new System.Windows.Forms.Label();
			this.UserName_OK = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.tb_checkPass = new System.Windows.Forms.TextBox();
			this.tb_Passwd = new System.Windows.Forms.TextBox();
			this.tb_UserName = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// CheckPass_OK
			// 
			this.CheckPass_OK.AutoSize = true;
			this.CheckPass_OK.Image = global::curriculum_design.Properties.Resources.ok1;
			this.CheckPass_OK.Location = new System.Drawing.Point(341, 143);
			this.CheckPass_OK.MinimumSize = new System.Drawing.Size(18, 18);
			this.CheckPass_OK.Name = "CheckPass_OK";
			this.CheckPass_OK.Size = new System.Drawing.Size(18, 18);
			this.CheckPass_OK.TabIndex = 33;
			this.CheckPass_OK.Visible = false;
			// 
			// Passwd_OK
			// 
			this.Passwd_OK.AutoSize = true;
			this.Passwd_OK.Image = global::curriculum_design.Properties.Resources.ok1;
			this.Passwd_OK.Location = new System.Drawing.Point(341, 107);
			this.Passwd_OK.MinimumSize = new System.Drawing.Size(18, 18);
			this.Passwd_OK.Name = "Passwd_OK";
			this.Passwd_OK.Size = new System.Drawing.Size(18, 18);
			this.Passwd_OK.TabIndex = 32;
			this.Passwd_OK.Visible = false;
			// 
			// UserName_OK
			// 
			this.UserName_OK.AutoSize = true;
			this.UserName_OK.Image = global::curriculum_design.Properties.Resources.ok1;
			this.UserName_OK.Location = new System.Drawing.Point(341, 22);
			this.UserName_OK.MinimumSize = new System.Drawing.Size(18, 18);
			this.UserName_OK.Name = "UserName_OK";
			this.UserName_OK.Size = new System.Drawing.Size(18, 18);
			this.UserName_OK.TabIndex = 29;
			this.UserName_OK.Visible = false;
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("微软雅黑", 11F);
			this.button2.Location = new System.Drawing.Point(180, 194);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(76, 34);
			this.button2.TabIndex = 8;
			this.button2.Text = "返回";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Close_Click);
			// 
			// button1
			// 
			this.button1.Enabled = false;
			this.button1.Font = new System.Drawing.Font("微软雅黑", 11F);
			this.button1.Location = new System.Drawing.Point(262, 194);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(76, 34);
			this.button1.TabIndex = 8;
			this.button1.Text = "添加";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Add_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.groupBox1.Controls.Add(this.radioButton1);
			this.groupBox1.Controls.Add(this.radioButton2);
			this.groupBox1.Location = new System.Drawing.Point(106, 48);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(150, 40);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			// 
			// radioButton1
			// 
			this.radioButton1.AutoSize = true;
			this.radioButton1.Checked = true;
			this.radioButton1.Font = new System.Drawing.Font("微软雅黑", 11F);
			this.radioButton1.Location = new System.Drawing.Point(6, 12);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(57, 24);
			this.radioButton1.TabIndex = 3;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "前台";
			this.radioButton1.UseVisualStyleBackColor = true;
			this.radioButton1.Click += new System.EventHandler(this.level_Click);
			// 
			// radioButton2
			// 
			this.radioButton2.AutoSize = true;
			this.radioButton2.Font = new System.Drawing.Font("微软雅黑", 11F);
			this.radioButton2.Location = new System.Drawing.Point(68, 12);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(72, 24);
			this.radioButton2.TabIndex = 4;
			this.radioButton2.Text = "管理员";
			this.radioButton2.UseVisualStyleBackColor = true;
			this.radioButton2.Click += new System.EventHandler(this.level_Click);
			// 
			// tb_checkPass
			// 
			this.tb_checkPass.Font = new System.Drawing.Font("宋体", 11F);
			this.tb_checkPass.Location = new System.Drawing.Point(105, 140);
			this.tb_checkPass.Name = "tb_checkPass";
			this.tb_checkPass.PasswordChar = '*';
			this.tb_checkPass.Size = new System.Drawing.Size(233, 24);
			this.tb_checkPass.TabIndex = 6;
			this.tb_checkPass.TextChanged += new System.EventHandler(this.tb_checkPass_TextChanged);
			// 
			// tb_Passwd
			// 
			this.tb_Passwd.Font = new System.Drawing.Font("宋体", 11F);
			this.tb_Passwd.Location = new System.Drawing.Point(105, 104);
			this.tb_Passwd.Name = "tb_Passwd";
			this.tb_Passwd.PasswordChar = '*';
			this.tb_Passwd.Size = new System.Drawing.Size(233, 24);
			this.tb_Passwd.TabIndex = 5;
			this.tb_Passwd.TextChanged += new System.EventHandler(this.tb_Passwd_TextChanged);
			// 
			// tb_UserName
			// 
			this.tb_UserName.Font = new System.Drawing.Font("宋体", 11F);
			this.tb_UserName.Location = new System.Drawing.Point(106, 20);
			this.tb_UserName.Name = "tb_UserName";
			this.tb_UserName.Size = new System.Drawing.Size(232, 24);
			this.tb_UserName.TabIndex = 1;
			this.tb_UserName.Leave += new System.EventHandler(this.tb_UseName_Leave);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.label8.Location = new System.Drawing.Point(26, 140);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(74, 21);
			this.label8.TabIndex = 16;
			this.label8.Text = "密码确认";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.label3.Location = new System.Drawing.Point(59, 61);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(42, 21);
			this.label3.TabIndex = 15;
			this.label3.Text = "等级";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.label7.Location = new System.Drawing.Point(58, 104);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(42, 21);
			this.label7.TabIndex = 14;
			this.label7.Text = "密码";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label1.Location = new System.Drawing.Point(43, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(58, 21);
			this.label1.TabIndex = 11;
			this.label1.Text = "用户名";
			// 
			// AdminManip
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(374, 248);
			this.Controls.Add(this.CheckPass_OK);
			this.Controls.Add(this.Passwd_OK);
			this.Controls.Add(this.UserName_OK);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.tb_checkPass);
			this.Controls.Add(this.tb_Passwd);
			this.Controls.Add(this.tb_UserName);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "AdminManip";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "添加员工";
			this.Load += new System.EventHandler(this.AdminManip_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label CheckPass_OK;
		private System.Windows.Forms.Label Passwd_OK;
		private System.Windows.Forms.Label UserName_OK;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.TextBox tb_checkPass;
		private System.Windows.Forms.TextBox tb_Passwd;
		private System.Windows.Forms.TextBox tb_UserName;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label1;
	}
}