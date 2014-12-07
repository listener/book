namespace curriculum_design
{
	partial class Receptionist
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Receptionist));
			this.tb_isbn = new System.Windows.Forms.TextBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PriceOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.isDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.sum = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label1 = new System.Windows.Forms.Label();
			this.tb_total = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.tb_memId = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
			this.tsb_about = new System.Windows.Forms.ToolStripButton();
			this.tb_pay = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.tb_kucun = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tb_total)).BeginInit();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tb_isbn
			// 
			this.tb_isbn.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.tb_isbn.Location = new System.Drawing.Point(64, 324);
			this.tb_isbn.MaxLength = 17;
			this.tb_isbn.Name = "tb_isbn";
			this.tb_isbn.Size = new System.Drawing.Size(162, 26);
			this.tb_isbn.TabIndex = 1;
			this.tb_isbn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ISBN_KeyPress);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ISBN,
            this.BookName,
            this.PriceOut,
            this.isDiscount,
            this.total,
            this.sum});
			this.dataGridView1.Location = new System.Drawing.Point(26, 38);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 23;
			this.dataGridView1.Size = new System.Drawing.Size(785, 272);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.TabStop = false;
			// 
			// ISBN
			// 
			this.ISBN.HeaderText = "ISBN";
			this.ISBN.Name = "ISBN";
			this.ISBN.ReadOnly = true;
			// 
			// BookName
			// 
			this.BookName.HeaderText = "书名";
			this.BookName.Name = "BookName";
			this.BookName.ReadOnly = true;
			// 
			// PriceOut
			// 
			this.PriceOut.HeaderText = "单价";
			this.PriceOut.Name = "PriceOut";
			this.PriceOut.ReadOnly = true;
			// 
			// isDiscount
			// 
			this.isDiscount.HeaderText = "折扣等级";
			this.isDiscount.Name = "isDiscount";
			// 
			// total
			// 
			this.total.HeaderText = "数目";
			this.total.Name = "total";
			this.total.ReadOnly = true;
			// 
			// sum
			// 
			this.sum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.sum.HeaderText = "总款";
			this.sum.Name = "sum";
			this.sum.ReadOnly = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label1.Location = new System.Drawing.Point(19, 325);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(47, 21);
			this.label1.TabIndex = 3;
			this.label1.Text = "ISBN";
			// 
			// tb_total
			// 
			this.tb_total.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.tb_total.Location = new System.Drawing.Point(277, 325);
			this.tb_total.Name = "tb_total";
			this.tb_total.Size = new System.Drawing.Size(52, 26);
			this.tb_total.TabIndex = 2;
			this.tb_total.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.tb_total.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Total_KeyPress);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label2.Location = new System.Drawing.Point(231, 328);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(42, 21);
			this.label2.TabIndex = 3;
			this.label2.Text = "数量";
			// 
			// tb_memId
			// 
			this.tb_memId.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.tb_memId.Location = new System.Drawing.Point(631, 325);
			this.tb_memId.Name = "tb_memId";
			this.tb_memId.Size = new System.Drawing.Size(180, 26);
			this.tb_memId.TabIndex = 3;
			this.tb_memId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_memId_KeyPress);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label3.Location = new System.Drawing.Point(570, 327);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(58, 21);
			this.label3.TabIndex = 3;
			this.label3.Text = "会员号";
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button1.Font = new System.Drawing.Font("宋体", 9F);
			this.button1.Location = new System.Drawing.Point(349, 369);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(59, 33);
			this.button1.TabIndex = 5;
			this.button1.Text = "结帐 F6";
			this.button1.UseMnemonic = false;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			this.button1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button1_KeyPress);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Black;
			this.label4.Font = new System.Drawing.Font("宋体", 24F);
			this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label4.Location = new System.Drawing.Point(24, 364);
			this.label4.MinimumSize = new System.Drawing.Size(50, 80);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(95, 80);
			this.label4.TabIndex = 6;
			this.label4.Text = "总额:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label5.BackColor = System.Drawing.Color.Black;
			this.label5.Font = new System.Drawing.Font("方正姚体", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label5.Location = new System.Drawing.Point(98, 364);
			this.label5.MinimumSize = new System.Drawing.Size(170, 80);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(179, 80);
			this.label5.TabIndex = 6;
			this.label5.Text = "0.00";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.Black;
			this.label6.Font = new System.Drawing.Font("宋体", 28F);
			this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label6.Location = new System.Drawing.Point(277, 364);
			this.label6.MinimumSize = new System.Drawing.Size(55, 80);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(55, 80);
			this.label6.TabIndex = 6;
			this.label6.Text = "元";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// button3
			// 
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button3.Font = new System.Drawing.Font("宋体", 9F);
			this.button3.Location = new System.Drawing.Point(411, 369);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(59, 33);
			this.button3.TabIndex = 6;
			this.button3.Text = "取消 F7";
			this.button3.UseMnemonic = false;
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Cancel_Click);
			this.button3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button1_KeyPress);
			// 
			// button4
			// 
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button4.Font = new System.Drawing.Font("宋体", 9F);
			this.button4.Location = new System.Drawing.Point(349, 408);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(59, 33);
			this.button4.TabIndex = 7;
			this.button4.Text = "撤消 F8";
			this.button4.UseMnemonic = false;
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.undo_Click);
			this.button4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button1_KeyPress);
			// 
			// button5
			// 
			this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button5.Font = new System.Drawing.Font("宋体", 9F);
			this.button5.Location = new System.Drawing.Point(411, 408);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(59, 33);
			this.button5.TabIndex = 8;
			this.button5.Text = "待定 F9";
			this.button5.UseMnemonic = false;
			this.button5.UseVisualStyleBackColor = true;
			this.button5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button1_KeyPress);
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.tsb_about});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(834, 25);
			this.toolStrip1.TabIndex = 8;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.Image = global::curriculum_design.Properties.Resources.Exit;
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new System.Drawing.Size(52, 22);
			this.toolStripButton1.Text = "注消";
			this.toolStripButton1.Click += new System.EventHandler(this.注销_Click);
			// 
			// toolStripButton2
			// 
			this.toolStripButton2.Image = global::curriculum_design.Properties.Resources.Help;
			this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton2.Name = "toolStripButton2";
			this.toolStripButton2.Size = new System.Drawing.Size(52, 22);
			this.toolStripButton2.Text = "帮助";
			this.toolStripButton2.Click += new System.EventHandler(this.help_Click);
			// 
			// tsb_about
			// 
			this.tsb_about.Image = ((System.Drawing.Image)(resources.GetObject("tsb_about.Image")));
			this.tsb_about.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsb_about.Name = "tsb_about";
			this.tsb_about.Size = new System.Drawing.Size(52, 22);
			this.tsb_about.Text = "关于";
			this.tsb_about.Click += new System.EventHandler(this.tsb_about_Click);
			// 
			// tb_pay
			// 
			this.tb_pay.Font = new System.Drawing.Font("微软雅黑", 11F);
			this.tb_pay.Location = new System.Drawing.Point(474, 324);
			this.tb_pay.Name = "tb_pay";
			this.tb_pay.Size = new System.Drawing.Size(65, 27);
			this.tb_pay.TabIndex = 4;
			this.tb_pay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_pay_KeyPress);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label7.Location = new System.Drawing.Point(431, 329);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(42, 21);
			this.label7.TabIndex = 3;
			this.label7.Text = "实付";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label8.Location = new System.Drawing.Point(544, 328);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(26, 21);
			this.label8.TabIndex = 3;
			this.label8.Text = "元";
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(560, 364);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.ReadOnly = true;
			this.richTextBox1.Size = new System.Drawing.Size(251, 80);
			this.richTextBox1.TabIndex = 9;
			this.richTextBox1.Text = "";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label9.Location = new System.Drawing.Point(333, 329);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(42, 21);
			this.label9.TabIndex = 3;
			this.label9.Text = "库存";
			// 
			// tb_kucun
			// 
			this.tb_kucun.Font = new System.Drawing.Font("微软雅黑", 11F);
			this.tb_kucun.Location = new System.Drawing.Point(379, 325);
			this.tb_kucun.Name = "tb_kucun";
			this.tb_kucun.ReadOnly = true;
			this.tb_kucun.Size = new System.Drawing.Size(47, 27);
			this.tb_kucun.TabIndex = 4;
			this.tb_kucun.TabStop = false;
			this.tb_kucun.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_pay_KeyPress);
			// 
			// Receptionist
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.ClientSize = new System.Drawing.Size(834, 461);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.tb_total);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.tb_kucun);
			this.Controls.Add(this.tb_pay);
			this.Controls.Add(this.tb_memId);
			this.Controls.Add(this.tb_isbn);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Receptionist";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "前台销售";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Receptionist_FormClosing);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Receptionist_FormClosed);
			this.Load += new System.EventHandler(this.Receptionist_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tb_total)).EndInit();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tb_isbn;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown tb_total;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tb_memId;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
		private System.Windows.Forms.DataGridViewTextBoxColumn BookName;
		private System.Windows.Forms.DataGridViewTextBoxColumn PriceOut;
		private System.Windows.Forms.DataGridViewTextBoxColumn isDiscount;
		private System.Windows.Forms.DataGridViewTextBoxColumn total;
		private System.Windows.Forms.DataGridViewTextBoxColumn sum;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton toolStripButton1;
		private System.Windows.Forms.ToolStripButton toolStripButton2;
		private System.Windows.Forms.TextBox tb_pay;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.ToolStripButton tsb_about;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox tb_kucun;
	}
}