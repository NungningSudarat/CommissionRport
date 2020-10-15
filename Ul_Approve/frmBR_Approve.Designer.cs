namespace CommissionRport.Ul_Approve
{
	partial class frmBR_Approve
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBR_Approve));
			this.toolStrip2 = new System.Windows.Forms.ToolStrip();
			this.btnApprove = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.btnNoApprove = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.btnExport = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
			this.panel1 = new System.Windows.Forms.Panel();
			this.cmbDOCNO = new kBeauty_Libary.Controls.kComboBox(this.components);
			this.label3 = new System.Windows.Forms.Label();
			this.bntSave = new System.Windows.Forms.Button();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.รายละเอียด = new System.Windows.Forms.TabPage();
			this.lsvData = new kBeauty_Libary.Controls.kListView(this.components);
			this.txtStartDateFP = new System.Windows.Forms.TextBox();
			this.txtEndDateFP = new System.Windows.Forms.TextBox();
			this.txtStartDate = new System.Windows.Forms.TextBox();
			this.txtEndDate = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.toolStrip2.SuspendLayout();
			this.panel1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.รายละเอียด.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStrip2
			// 
			this.toolStrip2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnApprove,
            this.toolStripSeparator1,
            this.btnNoApprove,
            this.toolStripSeparator3,
            this.btnExport,
            this.toolStripSeparator2,
            this.toolStripButton2});
			this.toolStrip2.Location = new System.Drawing.Point(0, 0);
			this.toolStrip2.Name = "toolStrip2";
			this.toolStrip2.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
			this.toolStrip2.Size = new System.Drawing.Size(984, 43);
			this.toolStrip2.TabIndex = 207;
			this.toolStrip2.Text = "toolStrip2";
			// 
			// btnApprove
			// 
			this.btnApprove.Image = ((System.Drawing.Image)(resources.GetObject("btnApprove.Image")));
			this.btnApprove.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.btnApprove.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnApprove.Name = "btnApprove";
			this.btnApprove.Size = new System.Drawing.Size(104, 40);
			this.btnApprove.Text = "อนุมัติ";
			this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 43);
			// 
			// btnNoApprove
			// 
			this.btnNoApprove.Image = ((System.Drawing.Image)(resources.GetObject("btnNoApprove.Image")));
			this.btnNoApprove.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.btnNoApprove.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnNoApprove.Name = "btnNoApprove";
			this.btnNoApprove.Size = new System.Drawing.Size(122, 40);
			this.btnNoApprove.Text = "ไม่อนุมัติ";
			this.btnNoApprove.Click += new System.EventHandler(this.btnNoApprove_Click);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(6, 43);
			// 
			// btnExport
			// 
			this.btnExport.Image = ((System.Drawing.Image)(resources.GetObject("btnExport.Image")));
			this.btnExport.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.btnExport.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnExport.Name = "btnExport";
			this.btnExport.Size = new System.Drawing.Size(92, 40);
			this.btnExport.Text = "ส่งออก";
			this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 43);
			// 
			// toolStripButton2
			// 
			this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
			this.toolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton2.Name = "toolStripButton2";
			this.toolStripButton2.Size = new System.Drawing.Size(119, 40);
			this.toolStripButton2.Text = "ปิดหน้าต่าง";
			this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.txtStartDateFP);
			this.panel1.Controls.Add(this.txtEndDateFP);
			this.panel1.Controls.Add(this.txtStartDate);
			this.panel1.Controls.Add(this.txtEndDate);
			this.panel1.Controls.Add(this.label9);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.cmbDOCNO);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.bntSave);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 43);
			this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(984, 130);
			this.panel1.TabIndex = 214;
			// 
			// cmbDOCNO
			// 
			this.cmbDOCNO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbDOCNO.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.cmbDOCNO.FormattingEnabled = true;
			this.cmbDOCNO.Location = new System.Drawing.Point(678, 32);
			this.cmbDOCNO.Margin = new System.Windows.Forms.Padding(6);
			this.cmbDOCNO.Name = "cmbDOCNO";
			this.cmbDOCNO.Size = new System.Drawing.Size(160, 22);
			this.cmbDOCNO.TabIndex = 276;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.label3.Location = new System.Drawing.Point(587, 35);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(70, 14);
			this.label3.TabIndex = 25;
			this.label3.Text = "เลขที่เอกสาร";
			// 
			// bntSave
			// 
			this.bntSave.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.bntSave.Location = new System.Drawing.Point(865, 25);
			this.bntSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.bntSave.Name = "bntSave";
			this.bntSave.Size = new System.Drawing.Size(68, 34);
			this.bntSave.TabIndex = 15;
			this.bntSave.Text = "ตกลง";
			this.bntSave.UseVisualStyleBackColor = true;
			this.bntSave.Click += new System.EventHandler(this.bntSave_Click);
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.รายละเอียด);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tabControl1.Location = new System.Drawing.Point(0, 173);
			this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(984, 425);
			this.tabControl1.TabIndex = 215;
			// 
			// รายละเอียด
			// 
			this.รายละเอียด.Controls.Add(this.lsvData);
			this.รายละเอียด.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.รายละเอียด.Location = new System.Drawing.Point(4, 28);
			this.รายละเอียด.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.รายละเอียด.Name = "รายละเอียด";
			this.รายละเอียด.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.รายละเอียด.Size = new System.Drawing.Size(976, 393);
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
			this.lsvData.Location = new System.Drawing.Point(4, 5);
			this.lsvData.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.lsvData.MultiSelect = false;
			this.lsvData.Name = "lsvData";
			this.lsvData.Size = new System.Drawing.Size(968, 383);
			this.lsvData.TabIndex = 208;
			this.lsvData.UseCompatibleStateImageBehavior = false;
			this.lsvData.View = System.Windows.Forms.View.Details;
			// 
			// txtStartDateFP
			// 
			this.txtStartDateFP.Enabled = false;
			this.txtStartDateFP.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.txtStartDateFP.Location = new System.Drawing.Point(235, 75);
			this.txtStartDateFP.MaxLength = 2;
			this.txtStartDateFP.Name = "txtStartDateFP";
			this.txtStartDateFP.Size = new System.Drawing.Size(100, 23);
			this.txtStartDateFP.TabIndex = 308;
			// 
			// txtEndDateFP
			// 
			this.txtEndDateFP.Enabled = false;
			this.txtEndDateFP.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.txtEndDateFP.Location = new System.Drawing.Point(429, 76);
			this.txtEndDateFP.MaxLength = 2;
			this.txtEndDateFP.Name = "txtEndDateFP";
			this.txtEndDateFP.Size = new System.Drawing.Size(100, 23);
			this.txtEndDateFP.TabIndex = 307;
			// 
			// txtStartDate
			// 
			this.txtStartDate.Enabled = false;
			this.txtStartDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.txtStartDate.Location = new System.Drawing.Point(235, 29);
			this.txtStartDate.MaxLength = 2;
			this.txtStartDate.Name = "txtStartDate";
			this.txtStartDate.Size = new System.Drawing.Size(100, 23);
			this.txtStartDate.TabIndex = 306;
			// 
			// txtEndDate
			// 
			this.txtEndDate.Enabled = false;
			this.txtEndDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.txtEndDate.Location = new System.Drawing.Point(429, 30);
			this.txtEndDate.MaxLength = 2;
			this.txtEndDate.Name = "txtEndDate";
			this.txtEndDate.Size = new System.Drawing.Size(100, 23);
			this.txtEndDate.TabIndex = 305;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.label9.Location = new System.Drawing.Point(20, 75);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(136, 16);
			this.label9.TabIndex = 304;
			this.label9.Text = "วันที่ค่าคอม FoodPanda";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.label8.Location = new System.Drawing.Point(87, 29);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(69, 16);
			this.label8.TabIndex = 303;
			this.label8.Text = "วันที่ค่าคอม";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.label6.Location = new System.Drawing.Point(188, 79);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(31, 16);
			this.label6.TabIndex = 301;
			this.label6.Text = "วันที่";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.label7.Location = new System.Drawing.Point(369, 80);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(45, 16);
			this.label7.TabIndex = 302;
			this.label7.Text = "ถึงวันที่";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.label1.Location = new System.Drawing.Point(188, 33);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(31, 16);
			this.label1.TabIndex = 299;
			this.label1.Text = "วันที่";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.label4.Location = new System.Drawing.Point(369, 34);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(45, 16);
			this.label4.TabIndex = 300;
			this.label4.Text = "ถึงวันที่";
			// 
			// frmBR_Approve
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(984, 598);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.toolStrip2);
			this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "frmBR_Approve";
			this.Text = "BR_Approve";
			this.Load += new System.EventHandler(this.BR_Approve_Load);
			this.toolStrip2.ResumeLayout(false);
			this.toolStrip2.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.tabControl1.ResumeLayout(false);
			this.รายละเอียด.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip toolStrip2;
		private System.Windows.Forms.ToolStripButton btnApprove;
		private System.Windows.Forms.Panel panel1;
		private kBeauty_Libary.Controls.kComboBox cmbDOCNO;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button bntSave;
		private System.Windows.Forms.ToolStripButton toolStripButton2;
		private System.Windows.Forms.ToolStripButton btnNoApprove;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage รายละเอียด;
		private kBeauty_Libary.Controls.kListView lsvData;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripButton btnExport;
		private System.Windows.Forms.TextBox txtStartDateFP;
		private System.Windows.Forms.TextBox txtEndDateFP;
		private System.Windows.Forms.TextBox txtStartDate;
		private System.Windows.Forms.TextBox txtEndDate;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label4;
	}
}