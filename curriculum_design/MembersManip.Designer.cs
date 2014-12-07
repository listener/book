namespace curriculum_design
{
	partial class MembersManip
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MembersManip));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tb_IdCard = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.rb_man = new System.Windows.Forms.RadioButton();
			this.rb_woman = new System.Windows.Forms.RadioButton();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label4 = new System.Windows.Forms.Label();
			this.rtb_addr = new System.Windows.Forms.RichTextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.tb_Phone = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.dtp_open = new System.Windows.Forms.DateTimePicker();
			this.label7 = new System.Windows.Forms.Label();
			this.tb_Passwd = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.tb_checkPass = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.tb_Email = new System.Windows.Forms.TextBox();
			this.Email_OK = new System.Windows.Forms.Label();
			this.IdCard_OK = new System.Windows.Forms.Label();
			this.Phone_OK = new System.Windows.Forms.Label();
			this.Passwd_OK = new System.Windows.Forms.Label();
			this.CheckPass_OK = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label1.Location = new System.Drawing.Point(52, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(51, 21);
			this.label1.TabIndex = 0;
			this.label1.Text = "Email";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.label2.Location = new System.Drawing.Point(12, 59);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(90, 21);
			this.label2.TabIndex = 0;
			this.label2.Text = "身份证号码";
			// 
			// tb_IdCard
			// 
			this.tb_IdCard.Font = new System.Drawing.Font("宋体", 11F);
			this.tb_IdCard.Location = new System.Drawing.Point(106, 59);
			this.tb_IdCard.MaxLength = 18;
			this.tb_IdCard.Name = "tb_IdCard";
			this.tb_IdCard.Size = new System.Drawing.Size(232, 24);
			this.tb_IdCard.TabIndex = 2;
			this.tb_IdCard.Leave += new System.EventHandler(this.tb_IdCard_Leave);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.label3.Location = new System.Drawing.Point(59, 94);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(42, 21);
			this.label3.TabIndex = 0;
			this.label3.Text = "姓别";
			// 
			// rb_man
			// 
			this.rb_man.AutoSize = true;
			this.rb_man.Font = new System.Drawing.Font("微软雅黑", 11F);
			this.rb_man.Location = new System.Drawing.Point(6, 12);
			this.rb_man.Name = "rb_man";
			this.rb_man.Size = new System.Drawing.Size(42, 24);
			this.rb_man.TabIndex = 3;
			this.rb_man.TabStop = true;
			this.rb_man.Text = "男";
			this.rb_man.UseVisualStyleBackColor = true;
			// 
			// rb_woman
			// 
			this.rb_woman.AutoSize = true;
			this.rb_woman.Font = new System.Drawing.Font("微软雅黑", 11F);
			this.rb_woman.Location = new System.Drawing.Point(49, 12);
			this.rb_woman.Name = "rb_woman";
			this.rb_woman.Size = new System.Drawing.Size(42, 24);
			this.rb_woman.TabIndex = 4;
			this.rb_woman.TabStop = true;
			this.rb_woman.Text = "女";
			this.rb_woman.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.groupBox1.Controls.Add(this.rb_man);
			this.groupBox1.Controls.Add(this.rb_woman);
			this.groupBox1.Location = new System.Drawing.Point(107, 81);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(91, 40);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.label4.Location = new System.Drawing.Point(27, 130);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(74, 21);
			this.label4.TabIndex = 0;
			this.label4.Text = "详细地址";
			// 
			// rtb_addr
			// 
			this.rtb_addr.Font = new System.Drawing.Font("宋体", 11F);
			this.rtb_addr.Location = new System.Drawing.Point(106, 134);
			this.rtb_addr.Name = "rtb_addr";
			this.rtb_addr.Size = new System.Drawing.Size(233, 61);
			this.rtb_addr.TabIndex = 5;
			this.rtb_addr.Text = "";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.label5.Location = new System.Drawing.Point(22, 216);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(74, 21);
			this.label5.TabIndex = 0;
			this.label5.Text = "电话号码";
			// 
			// tb_Phone
			// 
			this.tb_Phone.Font = new System.Drawing.Font("宋体", 11F);
			this.tb_Phone.Location = new System.Drawing.Point(105, 218);
			this.tb_Phone.MaxLength = 11;
			this.tb_Phone.Name = "tb_Phone";
			this.tb_Phone.Size = new System.Drawing.Size(233, 24);
			this.tb_Phone.TabIndex = 6;
			this.tb_Phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Phone_KeyPress);
			this.tb_Phone.Leave += new System.EventHandler(this.tb_Phone_Leave);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.label6.Location = new System.Drawing.Point(22, 256);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(74, 21);
			this.label6.TabIndex = 0;
			this.label6.Text = "开通日期";
			// 
			// dtp_open
			// 
			this.dtp_open.CalendarFont = new System.Drawing.Font("宋体", 11F);
			this.dtp_open.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtp_open.Location = new System.Drawing.Point(107, 257);
			this.dtp_open.Name = "dtp_open";
			this.dtp_open.Size = new System.Drawing.Size(231, 21);
			this.dtp_open.TabIndex = 99;
			this.dtp_open.Value = new System.DateTime(2014, 3, 30, 0, 0, 0, 0);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.label7.Location = new System.Drawing.Point(52, 296);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(42, 21);
			this.label7.TabIndex = 0;
			this.label7.Text = "密码";
			// 
			// tb_Passwd
			// 
			this.tb_Passwd.Font = new System.Drawing.Font("宋体", 11F);
			this.tb_Passwd.Location = new System.Drawing.Point(105, 296);
			this.tb_Passwd.MaxLength = 18;
			this.tb_Passwd.Name = "tb_Passwd";
			this.tb_Passwd.PasswordChar = '*';
			this.tb_Passwd.Size = new System.Drawing.Size(233, 24);
			this.tb_Passwd.TabIndex = 7;
			this.tb_Passwd.Leave += new System.EventHandler(this.tb_Passwd_Leave);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.label8.Location = new System.Drawing.Point(20, 332);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(74, 21);
			this.label8.TabIndex = 0;
			this.label8.Text = "密码确认";
			// 
			// tb_checkPass
			// 
			this.tb_checkPass.Font = new System.Drawing.Font("宋体", 11F);
			this.tb_checkPass.Location = new System.Drawing.Point(105, 332);
			this.tb_checkPass.MaxLength = 18;
			this.tb_checkPass.Name = "tb_checkPass";
			this.tb_checkPass.PasswordChar = '*';
			this.tb_checkPass.Size = new System.Drawing.Size(233, 24);
			this.tb_checkPass.TabIndex = 8;
			this.tb_checkPass.Leave += new System.EventHandler(this.tb_checkPass_Leave);
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("微软雅黑", 11F);
			this.button1.Location = new System.Drawing.Point(263, 362);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(76, 34);
			this.button1.TabIndex = 9;
			this.button1.Text = "添加";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Member_Add_Click);
			// 
			// tb_Email
			// 
			this.tb_Email.Font = new System.Drawing.Font("宋体", 11F);
			this.tb_Email.Location = new System.Drawing.Point(107, 23);
			this.tb_Email.Name = "tb_Email";
			this.tb_Email.Size = new System.Drawing.Size(232, 24);
			this.tb_Email.TabIndex = 1;
			this.tb_Email.Leave += new System.EventHandler(this.tb_Email_Leave);
			// 
			// Email_OK
			// 
			this.Email_OK.AutoSize = true;
			this.Email_OK.Image = global::curriculum_design.Properties.Resources.ok1;
			this.Email_OK.Location = new System.Drawing.Point(342, 25);
			this.Email_OK.MinimumSize = new System.Drawing.Size(18, 18);
			this.Email_OK.Name = "Email_OK";
			this.Email_OK.Size = new System.Drawing.Size(18, 18);
			this.Email_OK.TabIndex = 10;
			this.Email_OK.Visible = false;
			// 
			// IdCard_OK
			// 
			this.IdCard_OK.AutoSize = true;
			this.IdCard_OK.Image = global::curriculum_design.Properties.Resources.ok1;
			this.IdCard_OK.Location = new System.Drawing.Point(342, 61);
			this.IdCard_OK.MinimumSize = new System.Drawing.Size(18, 18);
			this.IdCard_OK.Name = "IdCard_OK";
			this.IdCard_OK.Size = new System.Drawing.Size(18, 18);
			this.IdCard_OK.TabIndex = 10;
			this.IdCard_OK.Visible = false;
			// 
			// Phone_OK
			// 
			this.Phone_OK.AutoSize = true;
			this.Phone_OK.Image = global::curriculum_design.Properties.Resources.ok1;
			this.Phone_OK.Location = new System.Drawing.Point(342, 220);
			this.Phone_OK.MinimumSize = new System.Drawing.Size(18, 18);
			this.Phone_OK.Name = "Phone_OK";
			this.Phone_OK.Size = new System.Drawing.Size(18, 18);
			this.Phone_OK.TabIndex = 10;
			this.Phone_OK.Visible = false;
			// 
			// Passwd_OK
			// 
			this.Passwd_OK.AutoSize = true;
			this.Passwd_OK.Image = global::curriculum_design.Properties.Resources.ok1;
			this.Passwd_OK.Location = new System.Drawing.Point(341, 299);
			this.Passwd_OK.MinimumSize = new System.Drawing.Size(18, 18);
			this.Passwd_OK.Name = "Passwd_OK";
			this.Passwd_OK.Size = new System.Drawing.Size(18, 18);
			this.Passwd_OK.TabIndex = 10;
			this.Passwd_OK.Visible = false;
			// 
			// CheckPass_OK
			// 
			this.CheckPass_OK.AutoSize = true;
			this.CheckPass_OK.Image = global::curriculum_design.Properties.Resources.ok1;
			this.CheckPass_OK.Location = new System.Drawing.Point(341, 335);
			this.CheckPass_OK.MinimumSize = new System.Drawing.Size(18, 18);
			this.CheckPass_OK.Name = "CheckPass_OK";
			this.CheckPass_OK.Size = new System.Drawing.Size(18, 18);
			this.CheckPass_OK.TabIndex = 10;
			this.CheckPass_OK.Visible = false;
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("微软雅黑", 11F);
			this.button2.Location = new System.Drawing.Point(181, 362);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(76, 34);
			this.button2.TabIndex = 10;
			this.button2.Text = "返回";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Close_Click);
			// 
			// MembersManip
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(386, 408);
			this.Controls.Add(this.CheckPass_OK);
			this.Controls.Add(this.Passwd_OK);
			this.Controls.Add(this.Phone_OK);
			this.Controls.Add(this.IdCard_OK);
			this.Controls.Add(this.Email_OK);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.dtp_open);
			this.Controls.Add(this.rtb_addr);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.tb_checkPass);
			this.Controls.Add(this.tb_Passwd);
			this.Controls.Add(this.tb_Phone);
			this.Controls.Add(this.tb_Email);
			this.Controls.Add(this.tb_IdCard);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "MembersManip";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "添加会员";
			this.Load += new System.EventHandler(this.Members_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tb_IdCard;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.RadioButton rb_man;
		private System.Windows.Forms.RadioButton rb_woman;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.RichTextBox rtb_addr;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox tb_Phone;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.DateTimePicker dtp_open;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox tb_Passwd;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox tb_checkPass;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox tb_Email;
		private System.Windows.Forms.Label Email_OK;
		private System.Windows.Forms.Label IdCard_OK;
		private System.Windows.Forms.Label Phone_OK;
		private System.Windows.Forms.Label Passwd_OK;
		private System.Windows.Forms.Label CheckPass_OK;
		private System.Windows.Forms.Button button2;
	}
}