namespace curriculum_design
{
	partial class MembersMain
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MembersMain));
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.TSB_Exit = new System.Windows.Forms.ToolStripButton();
			this.TSB_Add = new System.Windows.Forms.ToolStripButton();
			this.TSB_Alter = new System.Windows.Forms.ToolStripButton();
			this.TSB_Del = new System.Windows.Forms.ToolStripButton();
			this.tsb_ice = new System.Windows.Forms.ToolStripButton();
			this.TSB_Find = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
			this.vcEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cIdCard = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cPhoneNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.vcAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dOpenDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.iMemberPoint = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("微软雅黑", 11F);
			this.label1.Location = new System.Drawing.Point(17, 42);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(54, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "用户名";
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("宋体", 11F);
			this.textBox1.Location = new System.Drawing.Point(71, 41);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(176, 24);
			this.textBox1.TabIndex = 1;
			this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Find_KeyPress);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("微软雅黑", 11F);
			this.label2.Location = new System.Drawing.Point(507, 39);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(54, 20);
			this.label2.TabIndex = 2;
			this.label2.Text = "身份证";
			// 
			// textBox2
			// 
			this.textBox2.Font = new System.Drawing.Font("宋体", 11F);
			this.textBox2.Location = new System.Drawing.Point(562, 37);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(192, 24);
			this.textBox2.TabIndex = 3;
			this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Find_KeyPress);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("微软雅黑", 11F);
			this.label3.Location = new System.Drawing.Point(271, 41);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(39, 20);
			this.label3.TabIndex = 2;
			this.label3.Text = "电话";
			// 
			// textBox3
			// 
			this.textBox3.Font = new System.Drawing.Font("宋体", 11F);
			this.textBox3.Location = new System.Drawing.Point(313, 39);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(176, 24);
			this.textBox3.TabIndex = 3;
			this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Find_KeyPress);
			// 
			// dataGridView1
			// 
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vcEmail,
            this.cIdCard,
            this.cPhoneNo,
            this.cSex,
            this.vcAddress,
            this.dOpenDate,
            this.cStatus,
            this.iMemberPoint});
			this.dataGridView1.Location = new System.Drawing.Point(7, 85);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersWidth = 80;
			this.dataGridView1.RowTemplate.Height = 23;
			this.dataGridView1.Size = new System.Drawing.Size(747, 264);
			this.dataGridView1.TabIndex = 4;
			this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSB_Exit,
            this.TSB_Add,
            this.TSB_Alter,
            this.TSB_Del,
            this.tsb_ice,
            this.TSB_Find,
            this.toolStripButton6});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.MinimumSize = new System.Drawing.Size(706, 32);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(766, 32);
			this.toolStrip1.TabIndex = 6;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// TSB_Exit
			// 
			this.TSB_Exit.Image = global::curriculum_design.Properties.Resources.Exit;
			this.TSB_Exit.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.TSB_Exit.Name = "TSB_Exit";
			this.TSB_Exit.Size = new System.Drawing.Size(52, 29);
			this.TSB_Exit.Text = "退出";
			this.TSB_Exit.ToolTipText = "退出";
			this.TSB_Exit.Click += new System.EventHandler(this.TSB_Exit_Click);
			// 
			// TSB_Add
			// 
			this.TSB_Add.Image = global::curriculum_design.Properties.Resources.add;
			this.TSB_Add.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.TSB_Add.Name = "TSB_Add";
			this.TSB_Add.Size = new System.Drawing.Size(52, 29);
			this.TSB_Add.Text = "新增";
			this.TSB_Add.Click += new System.EventHandler(this.Add_Click);
			// 
			// TSB_Alter
			// 
			this.TSB_Alter.Enabled = false;
			this.TSB_Alter.Image = global::curriculum_design.Properties.Resources.modify;
			this.TSB_Alter.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.TSB_Alter.Name = "TSB_Alter";
			this.TSB_Alter.Size = new System.Drawing.Size(52, 29);
			this.TSB_Alter.Text = "修改";
			this.TSB_Alter.Click += new System.EventHandler(this.Alter_Click);
			// 
			// TSB_Del
			// 
			this.TSB_Del.Enabled = false;
			this.TSB_Del.Image = global::curriculum_design.Properties.Resources.del;
			this.TSB_Del.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.TSB_Del.Name = "TSB_Del";
			this.TSB_Del.Size = new System.Drawing.Size(52, 29);
			this.TSB_Del.Text = "删除";
			this.TSB_Del.Click += new System.EventHandler(this.Del_Click);
			// 
			// tsb_ice
			// 
			this.tsb_ice.Enabled = false;
			this.tsb_ice.Image = ((System.Drawing.Image)(resources.GetObject("tsb_ice.Image")));
			this.tsb_ice.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsb_ice.Name = "tsb_ice";
			this.tsb_ice.Size = new System.Drawing.Size(52, 29);
			this.tsb_ice.Text = "冻结";
			this.tsb_ice.Click += new System.EventHandler(this.tsb_ice_Click);
			// 
			// TSB_Find
			// 
			this.TSB_Find.Image = global::curriculum_design.Properties.Resources.find;
			this.TSB_Find.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.TSB_Find.Name = "TSB_Find";
			this.TSB_Find.Size = new System.Drawing.Size(52, 29);
			this.TSB_Find.Text = "查找";
			this.TSB_Find.Click += new System.EventHandler(this.Find_Press);
			// 
			// toolStripButton6
			// 
			this.toolStripButton6.AutoSize = false;
			this.toolStripButton6.Image = global::curriculum_design.Properties.Resources.Help;
			this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton6.Name = "toolStripButton6";
			this.toolStripButton6.Size = new System.Drawing.Size(54, 32);
			this.toolStripButton6.Text = "帮助";
			// 
			// vcEmail
			// 
			this.vcEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.vcEmail.HeaderText = "用户名";
			this.vcEmail.Name = "vcEmail";
			this.vcEmail.ReadOnly = true;
			// 
			// cIdCard
			// 
			this.cIdCard.HeaderText = "身份证";
			this.cIdCard.Name = "cIdCard";
			this.cIdCard.ReadOnly = true;
			// 
			// cPhoneNo
			// 
			this.cPhoneNo.HeaderText = "电话";
			this.cPhoneNo.Name = "cPhoneNo";
			this.cPhoneNo.ReadOnly = true;
			// 
			// cSex
			// 
			this.cSex.HeaderText = "姓别";
			this.cSex.Name = "cSex";
			this.cSex.ReadOnly = true;
			// 
			// vcAddress
			// 
			this.vcAddress.HeaderText = "地址";
			this.vcAddress.Name = "vcAddress";
			this.vcAddress.ReadOnly = true;
			// 
			// dOpenDate
			// 
			this.dOpenDate.HeaderText = "开通日期";
			this.dOpenDate.Name = "dOpenDate";
			this.dOpenDate.ReadOnly = true;
			// 
			// cStatus
			// 
			this.cStatus.HeaderText = "状态";
			this.cStatus.Name = "cStatus";
			this.cStatus.ReadOnly = true;
			// 
			// iMemberPoint
			// 
			this.iMemberPoint.HeaderText = "积分";
			this.iMemberPoint.Name = "iMemberPoint";
			this.iMemberPoint.ReadOnly = true;
			// 
			// MembersMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(766, 361);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.Cursor = System.Windows.Forms.Cursors.Default;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "MembersMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "会员管理";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton TSB_Exit;
		private System.Windows.Forms.ToolStripButton TSB_Add;
		private System.Windows.Forms.ToolStripButton TSB_Alter;
		private System.Windows.Forms.ToolStripButton TSB_Del;
		private System.Windows.Forms.ToolStripButton TSB_Find;
		private System.Windows.Forms.ToolStripButton toolStripButton6;
		private System.Windows.Forms.ToolStripButton tsb_ice;
		private System.Windows.Forms.DataGridViewTextBoxColumn vcEmail;
		private System.Windows.Forms.DataGridViewTextBoxColumn cIdCard;
		private System.Windows.Forms.DataGridViewTextBoxColumn cPhoneNo;
		private System.Windows.Forms.DataGridViewTextBoxColumn cSex;
		private System.Windows.Forms.DataGridViewTextBoxColumn vcAddress;
		private System.Windows.Forms.DataGridViewTextBoxColumn dOpenDate;
		private System.Windows.Forms.DataGridViewTextBoxColumn cStatus;
		private System.Windows.Forms.DataGridViewTextBoxColumn iMemberPoint;
	}
}