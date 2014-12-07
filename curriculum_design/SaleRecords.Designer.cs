namespace curriculum_design
{
	partial class SaleRecords
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaleRecords));
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.dtp_time = new System.Windows.Forms.DateTimePicker();
			this.label2 = new System.Windows.Forms.Label();
			this.tb_username = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.tb_SaleId = new System.Windows.Forms.TextBox();
			this.bt_find = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.操作ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.清空ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.导出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.当前ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.所有ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.vcEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dSaleDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tSaleInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.flowLayoutPanel1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vcEmail,
            this.dSaleDate,
            this.tSaleInfo});
			this.dataGridView1.Location = new System.Drawing.Point(10, 145);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 23;
			this.dataGridView1.Size = new System.Drawing.Size(391, 259);
			this.dataGridView1.TabIndex = 99;
			this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.label1);
			this.flowLayoutPanel1.Controls.Add(this.dtp_time);
			this.flowLayoutPanel1.Controls.Add(this.label2);
			this.flowLayoutPanel1.Controls.Add(this.tb_username);
			this.flowLayoutPanel1.Controls.Add(this.label3);
			this.flowLayoutPanel1.Controls.Add(this.tb_SaleId);
			this.flowLayoutPanel1.Location = new System.Drawing.Point(10, 33);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(295, 106);
			this.flowLayoutPanel1.TabIndex = 11;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(81, 30);
			this.label1.TabIndex = 0;
			this.label1.Text = "销售日期";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dtp_time
			// 
			this.dtp_time.Font = new System.Drawing.Font("微软雅黑", 11F);
			this.dtp_time.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtp_time.Location = new System.Drawing.Point(90, 3);
			this.dtp_time.Name = "dtp_time";
			this.dtp_time.Size = new System.Drawing.Size(197, 27);
			this.dtp_time.TabIndex = 100;
			this.dtp_time.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_username_KeyPress);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.label2.Location = new System.Drawing.Point(3, 33);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(81, 30);
			this.label2.TabIndex = 0;
			this.label2.Text = "    用户名";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tb_username
			// 
			this.tb_username.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.tb_username.FormattingEnabled = true;
			this.tb_username.Location = new System.Drawing.Point(90, 36);
			this.tb_username.Name = "tb_username";
			this.tb_username.Size = new System.Drawing.Size(197, 29);
			this.tb_username.TabIndex = 101;
			this.tb_username.SelectedIndexChanged += new System.EventHandler(this.bt_find_Click);
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.label3.Location = new System.Drawing.Point(3, 68);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(81, 30);
			this.label3.TabIndex = 0;
			this.label3.Text = "    定单号";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tb_SaleId
			// 
			this.tb_SaleId.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.tb_SaleId.Location = new System.Drawing.Point(90, 71);
			this.tb_SaleId.MaxLength = 18;
			this.tb_SaleId.Name = "tb_SaleId";
			this.tb_SaleId.Size = new System.Drawing.Size(197, 29);
			this.tb_SaleId.TabIndex = 102;
			// 
			// bt_find
			// 
			this.bt_find.Font = new System.Drawing.Font("微软雅黑", 20F);
			this.bt_find.Location = new System.Drawing.Point(304, 33);
			this.bt_find.Name = "bt_find";
			this.bt_find.Size = new System.Drawing.Size(97, 106);
			this.bt_find.TabIndex = 2;
			this.bt_find.Text = "查询";
			this.bt_find.UseVisualStyleBackColor = true;
			this.bt_find.Click += new System.EventHandler(this.bt_find_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.操作ToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(412, 28);
			this.menuStrip1.TabIndex = 12;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// 操作ToolStripMenuItem
			// 
			this.操作ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.清空ToolStripMenuItem,
            this.导出ToolStripMenuItem});
			this.操作ToolStripMenuItem.Font = new System.Drawing.Font("微软雅黑", 11F);
			this.操作ToolStripMenuItem.Name = "操作ToolStripMenuItem";
			this.操作ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
			this.操作ToolStripMenuItem.Text = "操作";
			// 
			// 清空ToolStripMenuItem
			// 
			this.清空ToolStripMenuItem.Name = "清空ToolStripMenuItem";
			this.清空ToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
			this.清空ToolStripMenuItem.Text = "清空";
			this.清空ToolStripMenuItem.Click += new System.EventHandler(this.清空ToolStripMenuItem_Click);
			// 
			// 导出ToolStripMenuItem
			// 
			this.导出ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.当前ToolStripMenuItem,
            this.所有ToolStripMenuItem});
			this.导出ToolStripMenuItem.Name = "导出ToolStripMenuItem";
			this.导出ToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
			this.导出ToolStripMenuItem.Text = "导出";
			// 
			// 当前ToolStripMenuItem
			// 
			this.当前ToolStripMenuItem.Name = "当前ToolStripMenuItem";
			this.当前ToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
			this.当前ToolStripMenuItem.Text = "当前";
			this.当前ToolStripMenuItem.Click += new System.EventHandler(this.当前ToolStripMenuItem_Click);
			// 
			// 所有ToolStripMenuItem
			// 
			this.所有ToolStripMenuItem.Name = "所有ToolStripMenuItem";
			this.所有ToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
			this.所有ToolStripMenuItem.Text = "所有";
			this.所有ToolStripMenuItem.Click += new System.EventHandler(this.所有ToolStripMenuItem_Click);
			// 
			// vcEmail
			// 
			this.vcEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.vcEmail.HeaderText = "用户名";
			this.vcEmail.Name = "vcEmail";
			// 
			// dSaleDate
			// 
			this.dSaleDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dSaleDate.HeaderText = "销售日期";
			this.dSaleDate.Name = "dSaleDate";
			// 
			// tSaleInfo
			// 
			this.tSaleInfo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.tSaleInfo.HeaderText = "购买记录";
			this.tSaleInfo.Name = "tSaleInfo";
			// 
			// SaleRecords
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(412, 416);
			this.Controls.Add(this.flowLayoutPanel1);
			this.Controls.Add(this.bt_find);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.Name = "SaleRecords";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "销售记录";
			this.Load += new System.EventHandler(this.SaleRecords_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker dtp_time;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button bt_find;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem 操作ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 清空ToolStripMenuItem;
		private System.Windows.Forms.ComboBox tb_username;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tb_SaleId;
		private System.Windows.Forms.ToolStripMenuItem 导出ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 当前ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 所有ToolStripMenuItem;
		private System.Windows.Forms.DataGridViewTextBoxColumn vcEmail;
		private System.Windows.Forms.DataGridViewTextBoxColumn dSaleDate;
		private System.Windows.Forms.DataGridViewTextBoxColumn tSaleInfo;



	}
}