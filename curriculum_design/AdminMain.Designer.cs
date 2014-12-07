namespace curriculum_design
{
	partial class AdminMain
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMain));
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.TSB_Add = new System.Windows.Forms.ToolStripButton();
			this.TSB_Alter = new System.Windows.Forms.ToolStripButton();
			this.TSB_Del = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
			this.label1 = new System.Windows.Forms.Label();
			this.cISBN = new System.Windows.Forms.TextBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.toolStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.TSB_Add,
            this.TSB_Alter,
            this.TSB_Del,
            this.toolStripButton2});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.MinimumSize = new System.Drawing.Size(445, 35);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(445, 35);
			this.toolStrip1.TabIndex = 10;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.Image = global::curriculum_design.Properties.Resources.Exit;
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new System.Drawing.Size(52, 32);
			this.toolStripButton1.Text = "退出";
			this.toolStripButton1.Click += new System.EventHandler(this.TSB_Exit_Click);
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
			this.toolStripButton2.Click += new System.EventHandler(this.find_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label1.Location = new System.Drawing.Point(9, 41);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 16);
			this.label1.TabIndex = 13;
			this.label1.Text = "用户名";
			// 
			// cISBN
			// 
			this.cISBN.Location = new System.Drawing.Point(69, 40);
			this.cISBN.MaxLength = 17;
			this.cISBN.Name = "cISBN";
			this.cISBN.Size = new System.Drawing.Size(197, 21);
			this.cISBN.TabIndex = 11;
			this.cISBN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cISBN_KeyPress);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(10, 79);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowTemplate.Height = 23;
			this.dataGridView1.Size = new System.Drawing.Size(256, 271);
			this.dataGridView1.TabIndex = 14;
			this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
			// 
			// AdminMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(289, 373);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cISBN);
			this.Controls.Add(this.toolStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "AdminMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "员工管理";
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton toolStripButton1;
		private System.Windows.Forms.ToolStripButton TSB_Add;
		private System.Windows.Forms.ToolStripButton TSB_Alter;
		private System.Windows.Forms.ToolStripButton TSB_Del;
		private System.Windows.Forms.ToolStripButton toolStripButton2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox cISBN;
		private System.Windows.Forms.DataGridView dataGridView1;
	}
}