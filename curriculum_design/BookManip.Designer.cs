namespace curriculum_design
{
	partial class BookManip
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookManip));
			this.cISBN = new System.Windows.Forms.TextBox();
			this.vcBookName = new System.Windows.Forms.TextBox();
			this.vcAuthor = new System.Windows.Forms.TextBox();
			this.iTotal = new System.Windows.Forms.TextBox();
			this.btn_Add = new System.Windows.Forms.Button();
			this.mPriceIn = new System.Windows.Forms.TextBox();
			this.mPriceOut = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.tIntroduction = new System.Windows.Forms.RichTextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.btn_Exit = new System.Windows.Forms.Button();
			this.CBB_Publish = new System.Windows.Forms.ComboBox();
			this.CBB_Class = new System.Windows.Forms.ComboBox();
			this.DTP_PublishDate = new System.Windows.Forms.DateTimePicker();
			this.SuspendLayout();
			// 
			// cISBN
			// 
			this.cISBN.Location = new System.Drawing.Point(84, 24);
			this.cISBN.MaxLength = 17;
			this.cISBN.Name = "cISBN";
			this.cISBN.Size = new System.Drawing.Size(182, 21);
			this.cISBN.TabIndex = 1;
			this.cISBN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cISBN_KeyPress);
			// 
			// vcBookName
			// 
			this.vcBookName.Location = new System.Drawing.Point(378, 27);
			this.vcBookName.Name = "vcBookName";
			this.vcBookName.Size = new System.Drawing.Size(177, 21);
			this.vcBookName.TabIndex = 2;
			// 
			// vcAuthor
			// 
			this.vcAuthor.Location = new System.Drawing.Point(378, 112);
			this.vcAuthor.Name = "vcAuthor";
			this.vcAuthor.Size = new System.Drawing.Size(177, 21);
			this.vcAuthor.TabIndex = 6;
			// 
			// iTotal
			// 
			this.iTotal.Location = new System.Drawing.Point(378, 153);
			this.iTotal.Name = "iTotal";
			this.iTotal.Size = new System.Drawing.Size(177, 21);
			this.iTotal.TabIndex = 8;
			this.iTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.iTotal_KeyPress);
			// 
			// btn_Add
			// 
			this.btn_Add.BackColor = System.Drawing.Color.Transparent;
			this.btn_Add.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btn_Add.Location = new System.Drawing.Point(337, 318);
			this.btn_Add.Name = "btn_Add";
			this.btn_Add.Size = new System.Drawing.Size(103, 31);
			this.btn_Add.TabIndex = 12;
			this.btn_Add.Text = "添加";
			this.btn_Add.UseVisualStyleBackColor = false;
			this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
			// 
			// mPriceIn
			// 
			this.mPriceIn.Location = new System.Drawing.Point(84, 153);
			this.mPriceIn.Name = "mPriceIn";
			this.mPriceIn.Size = new System.Drawing.Size(182, 21);
			this.mPriceIn.TabIndex = 7;
			this.mPriceIn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkNum_KeyPress);
			// 
			// mPriceOut
			// 
			this.mPriceOut.Location = new System.Drawing.Point(85, 198);
			this.mPriceOut.Name = "mPriceOut";
			this.mPriceOut.Size = new System.Drawing.Size(181, 21);
			this.mPriceOut.TabIndex = 9;
			this.mPriceOut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkNum_KeyPress);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label1.Location = new System.Drawing.Point(38, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 16);
			this.label1.TabIndex = 3;
			this.label1.Text = "ISBN";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label2.Location = new System.Drawing.Point(334, 29);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(40, 16);
			this.label2.TabIndex = 3;
			this.label2.Text = "书名";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label3.Location = new System.Drawing.Point(38, 71);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(40, 16);
			this.label3.TabIndex = 3;
			this.label3.Text = "分类";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label4.Location = new System.Drawing.Point(321, 72);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(56, 16);
			this.label4.TabIndex = 3;
			this.label4.Text = "出版社";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label5.Location = new System.Drawing.Point(9, 114);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(72, 16);
			this.label5.TabIndex = 3;
			this.label5.Text = "出版日期";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label6.Location = new System.Drawing.Point(334, 115);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(40, 16);
			this.label6.TabIndex = 3;
			this.label6.Text = "作者";
			// 
			// tIntroduction
			// 
			this.tIntroduction.Location = new System.Drawing.Point(84, 236);
			this.tIntroduction.Name = "tIntroduction";
			this.tIntroduction.Size = new System.Drawing.Size(471, 58);
			this.tIntroduction.TabIndex = 10;
			this.tIntroduction.Text = "";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label7.Location = new System.Drawing.Point(12, 239);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(72, 16);
			this.label7.TabIndex = 3;
			this.label7.Text = "内容介绍";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label8.Location = new System.Drawing.Point(11, 156);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(72, 16);
			this.label8.TabIndex = 3;
			this.label8.Text = "进购价格";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.BackColor = System.Drawing.Color.Transparent;
			this.label9.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label9.Location = new System.Drawing.Point(305, 156);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(72, 16);
			this.label9.TabIndex = 3;
			this.label9.Text = "新增数量";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.BackColor = System.Drawing.Color.Transparent;
			this.label10.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label10.Location = new System.Drawing.Point(11, 200);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(72, 16);
			this.label10.TabIndex = 3;
			this.label10.Text = "销售价格";
			// 
			// btn_Exit
			// 
			this.btn_Exit.BackColor = System.Drawing.Color.Transparent;
			this.btn_Exit.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btn_Exit.Location = new System.Drawing.Point(163, 318);
			this.btn_Exit.Name = "btn_Exit";
			this.btn_Exit.Size = new System.Drawing.Size(103, 31);
			this.btn_Exit.TabIndex = 11;
			this.btn_Exit.Text = "返回";
			this.btn_Exit.UseVisualStyleBackColor = false;
			this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
			// 
			// CBB_Publish
			// 
			this.CBB_Publish.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.CBB_Publish.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.CBB_Publish.FormattingEnabled = true;
			this.CBB_Publish.Location = new System.Drawing.Point(378, 71);
			this.CBB_Publish.MaxLength = 8;
			this.CBB_Publish.Name = "CBB_Publish";
			this.CBB_Publish.Size = new System.Drawing.Size(177, 20);
			this.CBB_Publish.Sorted = true;
			this.CBB_Publish.TabIndex = 4;
			// 
			// CBB_Class
			// 
			this.CBB_Class.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.CBB_Class.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.CBB_Class.FormattingEnabled = true;
			this.CBB_Class.IntegralHeight = false;
			this.CBB_Class.ItemHeight = 12;
			this.CBB_Class.Location = new System.Drawing.Point(84, 71);
			this.CBB_Class.MaxLength = 8;
			this.CBB_Class.Name = "CBB_Class";
			this.CBB_Class.Size = new System.Drawing.Size(182, 20);
			this.CBB_Class.Sorted = true;
			this.CBB_Class.TabIndex = 3;
			// 
			// DTP_PublishDate
			// 
			this.DTP_PublishDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.DTP_PublishDate.Location = new System.Drawing.Point(84, 112);
			this.DTP_PublishDate.Name = "DTP_PublishDate";
			this.DTP_PublishDate.Size = new System.Drawing.Size(182, 21);
			this.DTP_PublishDate.TabIndex = 5;
			this.DTP_PublishDate.Value = new System.DateTime(2014, 3, 25, 0, 0, 0, 0);
			// 
			// BookManip
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(583, 367);
			this.Controls.Add(this.DTP_PublishDate);
			this.Controls.Add(this.CBB_Class);
			this.Controls.Add(this.CBB_Publish);
			this.Controls.Add(this.tIntroduction);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btn_Exit);
			this.Controls.Add(this.btn_Add);
			this.Controls.Add(this.mPriceOut);
			this.Controls.Add(this.mPriceIn);
			this.Controls.Add(this.iTotal);
			this.Controls.Add(this.vcAuthor);
			this.Controls.Add(this.vcBookName);
			this.Controls.Add(this.cISBN);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "BookManip";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "增加图书";
			this.Load += new System.EventHandler(this.BookAdd_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox cISBN;
		private System.Windows.Forms.TextBox vcBookName;
		private System.Windows.Forms.TextBox vcAuthor;
		private System.Windows.Forms.TextBox iTotal;
		private System.Windows.Forms.Button btn_Add;
		private System.Windows.Forms.TextBox mPriceIn;
		private System.Windows.Forms.TextBox mPriceOut;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.RichTextBox tIntroduction;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Button btn_Exit;
		private System.Windows.Forms.ComboBox CBB_Publish;
		private System.Windows.Forms.ComboBox CBB_Class;
		private System.Windows.Forms.DateTimePicker DTP_PublishDate;
	}
}