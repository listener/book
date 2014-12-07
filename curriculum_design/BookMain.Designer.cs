namespace curriculum_design
{
	partial class BookMain
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookMain));
			this.vcBookName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.cISBN = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PublishName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CBB_BookClass = new System.Windows.Forms.ComboBox();
			this.CBB_Publish = new System.Windows.Forms.ComboBox();
			this.btn_find = new System.Windows.Forms.Button();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.TSB_Add = new System.Windows.Forms.ToolStripButton();
			this.TSB_Alter = new System.Windows.Forms.ToolStripButton();
			this.TSB_Del = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
			this.tsb_export = new System.Windows.Forms.ToolStripButton();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// vcBookName
			// 
			this.vcBookName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.vcBookName.Location = new System.Drawing.Point(356, 82);
			this.vcBookName.Name = "vcBookName";
			this.vcBookName.Size = new System.Drawing.Size(186, 29);
			this.vcBookName.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label1.Location = new System.Drawing.Point(52, 88);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 16);
			this.label1.TabIndex = 1;
			this.label1.Text = "ISBN";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label2.Location = new System.Drawing.Point(310, 88);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(40, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "书名";
			// 
			// cISBN
			// 
			this.cISBN.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.cISBN.Location = new System.Drawing.Point(98, 83);
			this.cISBN.MaxLength = 17;
			this.cISBN.Name = "cISBN";
			this.cISBN.Size = new System.Drawing.Size(186, 29);
			this.cISBN.TabIndex = 1;
			this.cISBN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cISBN_KeyPress);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label3.Location = new System.Drawing.Point(52, 124);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(40, 16);
			this.label3.TabIndex = 1;
			this.label3.Text = "分类";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label4.Location = new System.Drawing.Point(298, 126);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(56, 16);
			this.label4.TabIndex = 1;
			this.label4.Text = "出版社";
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ISBN,
            this.BookName,
            this.ClassName,
            this.PublishName,
            this.Total});
			this.dataGridView1.Location = new System.Drawing.Point(48, 165);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowTemplate.Height = 23;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(628, 291);
			this.dataGridView1.TabIndex = 6;
			this.dataGridView1.TabStop = false;
			this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
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
			// ClassName
			// 
			this.ClassName.HeaderText = "分类";
			this.ClassName.Name = "ClassName";
			this.ClassName.ReadOnly = true;
			// 
			// PublishName
			// 
			this.PublishName.HeaderText = "出版社";
			this.PublishName.Name = "PublishName";
			this.PublishName.ReadOnly = true;
			// 
			// Total
			// 
			this.Total.HeaderText = "库存";
			this.Total.Name = "Total";
			this.Total.ReadOnly = true;
			// 
			// CBB_BookClass
			// 
			this.CBB_BookClass.DropDownHeight = 125;
			this.CBB_BookClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.CBB_BookClass.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.CBB_BookClass.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.CBB_BookClass.FormattingEnabled = true;
			this.CBB_BookClass.IntegralHeight = false;
			this.CBB_BookClass.Location = new System.Drawing.Point(98, 120);
			this.CBB_BookClass.MaxDropDownItems = 5;
			this.CBB_BookClass.Name = "CBB_BookClass";
			this.CBB_BookClass.Size = new System.Drawing.Size(186, 29);
			this.CBB_BookClass.TabIndex = 3;
			// 
			// CBB_Publish
			// 
			this.CBB_Publish.DropDownHeight = 125;
			this.CBB_Publish.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.CBB_Publish.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.CBB_Publish.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.CBB_Publish.FormattingEnabled = true;
			this.CBB_Publish.IntegralHeight = false;
			this.CBB_Publish.Location = new System.Drawing.Point(356, 120);
			this.CBB_Publish.MaxDropDownItems = 5;
			this.CBB_Publish.Name = "CBB_Publish";
			this.CBB_Publish.Size = new System.Drawing.Size(186, 29);
			this.CBB_Publish.TabIndex = 4;
			// 
			// btn_find
			// 
			this.btn_find.BackColor = System.Drawing.Color.Transparent;
			this.btn_find.Font = new System.Drawing.Font("宋体", 15F);
			this.btn_find.Location = new System.Drawing.Point(573, 82);
			this.btn_find.Name = "btn_find";
			this.btn_find.Size = new System.Drawing.Size(103, 67);
			this.btn_find.TabIndex = 5;
			this.btn_find.Text = "查找";
			this.btn_find.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
			this.btn_find.UseVisualStyleBackColor = false;
			this.btn_find.Click += new System.EventHandler(this.btn_find_Click);
			// 
			// toolStrip1
			// 
			this.toolStrip1.BackColor = System.Drawing.Color.White;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.TSB_Add,
            this.TSB_Alter,
            this.TSB_Del,
            this.toolStripButton2,
            this.tsb_export});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.MinimumSize = new System.Drawing.Size(636, 35);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(717, 35);
			this.toolStrip1.TabIndex = 9;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.Image = global::curriculum_design.Properties.Resources.Exit;
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new System.Drawing.Size(52, 32);
			this.toolStripButton1.Text = "退出";
			this.toolStripButton1.Click += new System.EventHandler(this.Exit_Click);
			// 
			// TSB_Add
			// 
			this.TSB_Add.Image = global::curriculum_design.Properties.Resources.add;
			this.TSB_Add.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.TSB_Add.Name = "TSB_Add";
			this.TSB_Add.Size = new System.Drawing.Size(52, 32);
			this.TSB_Add.Text = "添加";
			this.TSB_Add.Click += new System.EventHandler(this.TSB_Add_Click);
			// 
			// TSB_Alter
			// 
			this.TSB_Alter.Enabled = false;
			this.TSB_Alter.Image = global::curriculum_design.Properties.Resources.modify;
			this.TSB_Alter.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.TSB_Alter.Name = "TSB_Alter";
			this.TSB_Alter.Size = new System.Drawing.Size(52, 32);
			this.TSB_Alter.Text = "修改";
			this.TSB_Alter.Click += new System.EventHandler(this.TSB_Alter_Click);
			// 
			// TSB_Del
			// 
			this.TSB_Del.Enabled = false;
			this.TSB_Del.Image = global::curriculum_design.Properties.Resources.del;
			this.TSB_Del.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.TSB_Del.Name = "TSB_Del";
			this.TSB_Del.Size = new System.Drawing.Size(52, 32);
			this.TSB_Del.Text = "删除";
			this.TSB_Del.Click += new System.EventHandler(this.TSB_Del_Click);
			// 
			// toolStripButton2
			// 
			this.toolStripButton2.Image = global::curriculum_design.Properties.Resources.find;
			this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton2.Name = "toolStripButton2";
			this.toolStripButton2.Size = new System.Drawing.Size(52, 32);
			this.toolStripButton2.Text = "查找";
			this.toolStripButton2.Click += new System.EventHandler(this.btn_find_Click);
			// 
			// tsb_export
			// 
			this.tsb_export.Image = ((System.Drawing.Image)(resources.GetObject("tsb_export.Image")));
			this.tsb_export.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsb_export.Name = "tsb_export";
			this.tsb_export.Size = new System.Drawing.Size(52, 32);
			this.tsb_export.Text = "导出";
			this.tsb_export.Click += new System.EventHandler(this.TSB_export_Click);
			// 
			// BookMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(717, 530);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.btn_find);
			this.Controls.Add(this.CBB_Publish);
			this.Controls.Add(this.CBB_BookClass);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cISBN);
			this.Controls.Add(this.vcBookName);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "BookMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "图书管理";
			this.Load += new System.EventHandler(this.BookFind_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox vcBookName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox cISBN;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.ComboBox CBB_BookClass;
		private System.Windows.Forms.ComboBox CBB_Publish;
		private System.Windows.Forms.Button btn_find;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton TSB_Add;
		private System.Windows.Forms.ToolStripButton TSB_Del;
		private System.Windows.Forms.ToolStripButton TSB_Alter;
		private System.Windows.Forms.ToolStripButton toolStripButton1;
		private System.Windows.Forms.ToolStripButton toolStripButton2;
		private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
		private System.Windows.Forms.DataGridViewTextBoxColumn BookName;
		private System.Windows.Forms.DataGridViewTextBoxColumn ClassName;
		private System.Windows.Forms.DataGridViewTextBoxColumn PublishName;
		private System.Windows.Forms.DataGridViewTextBoxColumn Total;
		private System.Windows.Forms.ToolStripButton tsb_export;
	}
}