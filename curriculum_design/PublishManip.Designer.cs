namespace curriculum_design
{
	partial class PublishManip
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PublishManip));
			this.label1 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.tInfomation = new System.Windows.Forms.RichTextBox();
			this.tb_del = new System.Windows.Forms.Button();
			this.tb_add = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("微软雅黑", 11F);
			this.label1.Location = new System.Drawing.Point(17, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(54, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "出版社";
			// 
			// comboBox1
			// 
			this.comboBox1.Font = new System.Drawing.Font("微软雅黑", 11F);
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(85, 18);
			this.comboBox1.MaxDropDownItems = 5;
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(230, 28);
			this.comboBox1.TabIndex = 1;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			this.comboBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
			// 
			// tInfomation
			// 
			this.tInfomation.Font = new System.Drawing.Font("宋体", 11F);
			this.tInfomation.Location = new System.Drawing.Point(26, 67);
			this.tInfomation.Name = "tInfomation";
			this.tInfomation.Size = new System.Drawing.Size(291, 222);
			this.tInfomation.TabIndex = 2;
			this.tInfomation.Text = "";
			// 
			// tb_del
			// 
			this.tb_del.Enabled = false;
			this.tb_del.Font = new System.Drawing.Font("微软雅黑", 11F);
			this.tb_del.Location = new System.Drawing.Point(52, 299);
			this.tb_del.Name = "tb_del";
			this.tb_del.Size = new System.Drawing.Size(90, 43);
			this.tb_del.TabIndex = 3;
			this.tb_del.Text = "删除";
			this.tb_del.UseVisualStyleBackColor = true;
			this.tb_del.Click += new System.EventHandler(this.del_Click);
			// 
			// tb_add
			// 
			this.tb_add.Font = new System.Drawing.Font("微软雅黑", 11F);
			this.tb_add.Location = new System.Drawing.Point(177, 299);
			this.tb_add.Name = "tb_add";
			this.tb_add.Size = new System.Drawing.Size(97, 43);
			this.tb_add.TabIndex = 3;
			this.tb_add.Text = "添加";
			this.tb_add.UseVisualStyleBackColor = true;
			this.tb_add.Click += new System.EventHandler(this.add_Click);
			// 
			// PublishManip
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(337, 354);
			this.Controls.Add(this.tb_add);
			this.Controls.Add(this.tb_del);
			this.Controls.Add(this.tInfomation);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "PublishManip";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "出版社管理";
			this.Load += new System.EventHandler(this.PublishManip_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.RichTextBox tInfomation;
		private System.Windows.Forms.Button tb_del;
		private System.Windows.Forms.Button tb_add;
	}
}