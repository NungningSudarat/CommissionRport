namespace CommissionRport.Ul_MASTER
{
	partial class frmWholeSale_MASTER
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWholeSale_MASTER));
			this.toolStrip2 = new System.Windows.Forms.ToolStrip();
			this.btnClose = new System.Windows.Forms.ToolStripButton();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.รายละเอียด = new System.Windows.Forms.TabPage();
			this.lsvData = new kBeauty_Libary.Controls.kListView(this.components);
			this.bntSave = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.cmdBID = new kBeauty_Libary.Controls.kComboBox(this.components);
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnsave = new System.Windows.Forms.Button();
			this.txtprcode = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.toolStrip2.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.รายละเอียด.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStrip2
			// 
			this.toolStrip2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnClose});
			this.toolStrip2.Location = new System.Drawing.Point(0, 0);
			this.toolStrip2.Name = "toolStrip2";
			this.toolStrip2.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
			this.toolStrip2.Size = new System.Drawing.Size(699, 39);
			this.toolStrip2.TabIndex = 210;
			this.toolStrip2.Text = "toolStrip2";
			// 
			// btnClose
			// 
			this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
			this.btnClose.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.btnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(119, 36);
			this.btnClose.Text = "ปิดหน้าต่าง";
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.รายละเอียด);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 156);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(699, 340);
			this.tabControl1.TabIndex = 215;
			// 
			// รายละเอียด
			// 
			this.รายละเอียด.Controls.Add(this.lsvData);
			this.รายละเอียด.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.รายละเอียด.Location = new System.Drawing.Point(4, 28);
			this.รายละเอียด.Name = "รายละเอียด";
			this.รายละเอียด.Padding = new System.Windows.Forms.Padding(3);
			this.รายละเอียด.Size = new System.Drawing.Size(691, 308);
			this.รายละเอียด.TabIndex = 0;
			this.รายละเอียด.Text = "รายละเอียด";
			this.รายละเอียด.UseVisualStyleBackColor = true;
			// 
			// lsvData
			// 
			this.lsvData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lsvData.FullRowSelect = true;
			this.lsvData.GridLines = true;
			this.lsvData.HideSelection = false;
			this.lsvData.Location = new System.Drawing.Point(3, 3);
			this.lsvData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.lsvData.MultiSelect = false;
			this.lsvData.Name = "lsvData";
			this.lsvData.Size = new System.Drawing.Size(685, 302);
			this.lsvData.TabIndex = 208;
			this.lsvData.UseCompatibleStateImageBehavior = false;
			this.lsvData.View = System.Windows.Forms.View.Details;
			this.lsvData.DoubleClick += new System.EventHandler(this.lsvData_DoubleClick);
			// 
			// bntSave
			// 
			this.bntSave.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.bntSave.Location = new System.Drawing.Point(304, 19);
			this.bntSave.Name = "bntSave";
			this.bntSave.Size = new System.Drawing.Size(93, 31);
			this.bntSave.TabIndex = 15;
			this.bntSave.Text = "ตกลง";
			this.bntSave.UseVisualStyleBackColor = true;
			this.bntSave.Click += new System.EventHandler(this.bntSave_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.label6.Location = new System.Drawing.Point(44, 34);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(41, 14);
			this.label6.TabIndex = 27;
			this.label6.Text = "แบรนด์";
			// 
			// cmdBID
			// 
			this.cmdBID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmdBID.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.cmdBID.FormattingEnabled = true;
			this.cmdBID.Location = new System.Drawing.Point(119, 24);
			this.cmdBID.Margin = new System.Windows.Forms.Padding(4);
			this.cmdBID.Name = "cmdBID";
			this.cmdBID.Size = new System.Drawing.Size(152, 22);
			this.cmdBID.TabIndex = 277;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnsave);
			this.panel1.Controls.Add(this.txtprcode);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.cmdBID);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.bntSave);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 39);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(699, 117);
			this.panel1.TabIndex = 214;
			// 
			// btnsave
			// 
			this.btnsave.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.btnsave.Location = new System.Drawing.Point(304, 68);
			this.btnsave.Name = "btnsave";
			this.btnsave.Size = new System.Drawing.Size(93, 31);
			this.btnsave.TabIndex = 281;
			this.btnsave.Text = "บันทึก";
			this.btnsave.UseVisualStyleBackColor = true;
			this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
			// 
			// txtprcode
			// 
			this.txtprcode.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.txtprcode.Location = new System.Drawing.Point(119, 72);
			this.txtprcode.Name = "txtprcode";
			this.txtprcode.Size = new System.Drawing.Size(152, 23);
			this.txtprcode.TabIndex = 280;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.label1.Location = new System.Drawing.Point(30, 79);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 16);
			this.label1.TabIndex = 279;
			this.label1.Text = "PRCODE";
			// 
			// frmWholeSale_MASTER
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(699, 496);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.toolStrip2);
			this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "frmWholeSale_MASTER";
			this.Text = "frmWholeSale_RATE";
			this.Load += new System.EventHandler(this.frmWholeSale_MASTER_Load);
			this.toolStrip2.ResumeLayout(false);
			this.toolStrip2.PerformLayout();
			this.tabControl1.ResumeLayout(false);
			this.รายละเอียด.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip toolStrip2;
		private System.Windows.Forms.ToolStripButton btnClose;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage รายละเอียด;
		private kBeauty_Libary.Controls.kListView lsvData;
		private System.Windows.Forms.Button bntSave;
		private System.Windows.Forms.Label label6;
		private kBeauty_Libary.Controls.kComboBox cmdBID;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox txtprcode;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnsave;
	}
}