namespace CommissionRport.UI_Report.ComOnline
{
	partial class frmCom_RetailReport
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCom_RetailReport));
			this.toolStrip2 = new System.Windows.Forms.ToolStrip();
			this.btnSave = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.btnExport_export = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.btnClose = new System.Windows.Forms.ToolStripButton();
			this.panel1 = new System.Windows.Forms.Panel();
			this.txtStartDateFP = new System.Windows.Forms.TextBox();
			this.txtEndDateFP = new System.Windows.Forms.TextBox();
			this.txtStartDate = new System.Windows.Forms.TextBox();
			this.txtEndDate = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.btnComOnilne = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.txtday = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.cmbDOCNO = new kBeauty_Libary.Controls.kComboBox(this.components);
			this.bntSave = new System.Windows.Forms.Button();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.รายละเอียด = new System.Windows.Forms.TabPage();
			this.lsvData = new kBeauty_Libary.Controls.kListView(this.components);
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
            this.btnSave,
            this.toolStripSeparator1,
            this.btnExport_export,
            this.toolStripSeparator3,
            this.btnClose});
			this.toolStrip2.Location = new System.Drawing.Point(0, 0);
			this.toolStrip2.Name = "toolStrip2";
			this.toolStrip2.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
			this.toolStrip2.Size = new System.Drawing.Size(984, 39);
			this.toolStrip2.TabIndex = 210;
			this.toolStrip2.Text = "toolStrip2";
			// 
			// btnSave
			// 
			this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
			this.btnSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(85, 36);
			this.btnSave.Text = "บันทึก";
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
			// 
			// btnExport_export
			// 
			this.btnExport_export.Image = ((System.Drawing.Image)(resources.GetObject("btnExport_export.Image")));
			this.btnExport_export.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.btnExport_export.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnExport_export.Name = "btnExport_export";
			this.btnExport_export.Size = new System.Drawing.Size(92, 36);
			this.btnExport_export.Text = "ส่งออก";
			this.btnExport_export.Click += new System.EventHandler(this.btnExport_export_Click);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(6, 39);
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
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label10);
			this.panel1.Controls.Add(this.btnComOnilne);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.txtday);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.cmbDOCNO);
			this.panel1.Controls.Add(this.bntSave);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 39);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(984, 157);
			this.panel1.TabIndex = 211;
			// 
			// txtStartDateFP
			// 
			this.txtStartDateFP.Enabled = false;
			this.txtStartDateFP.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.txtStartDateFP.Location = new System.Drawing.Point(240, 110);
			this.txtStartDateFP.MaxLength = 2;
			this.txtStartDateFP.Name = "txtStartDateFP";
			this.txtStartDateFP.Size = new System.Drawing.Size(100, 23);
			this.txtStartDateFP.TabIndex = 321;
			// 
			// txtEndDateFP
			// 
			this.txtEndDateFP.Enabled = false;
			this.txtEndDateFP.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.txtEndDateFP.Location = new System.Drawing.Point(434, 111);
			this.txtEndDateFP.MaxLength = 2;
			this.txtEndDateFP.Name = "txtEndDateFP";
			this.txtEndDateFP.Size = new System.Drawing.Size(100, 23);
			this.txtEndDateFP.TabIndex = 320;
			// 
			// txtStartDate
			// 
			this.txtStartDate.Enabled = false;
			this.txtStartDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.txtStartDate.Location = new System.Drawing.Point(240, 64);
			this.txtStartDate.MaxLength = 2;
			this.txtStartDate.Name = "txtStartDate";
			this.txtStartDate.Size = new System.Drawing.Size(100, 23);
			this.txtStartDate.TabIndex = 319;
			// 
			// txtEndDate
			// 
			this.txtEndDate.Enabled = false;
			this.txtEndDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.txtEndDate.Location = new System.Drawing.Point(434, 65);
			this.txtEndDate.MaxLength = 2;
			this.txtEndDate.Name = "txtEndDate";
			this.txtEndDate.Size = new System.Drawing.Size(100, 23);
			this.txtEndDate.TabIndex = 318;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.label9.Location = new System.Drawing.Point(25, 110);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(136, 16);
			this.label9.TabIndex = 317;
			this.label9.Text = "วันที่ค่าคอม FoodPanda";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.label8.Location = new System.Drawing.Point(92, 64);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(69, 16);
			this.label8.TabIndex = 316;
			this.label8.Text = "วันที่ค่าคอม";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.label6.Location = new System.Drawing.Point(193, 114);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(31, 16);
			this.label6.TabIndex = 314;
			this.label6.Text = "วันที่";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.label7.Location = new System.Drawing.Point(374, 115);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(45, 16);
			this.label7.TabIndex = 315;
			this.label7.Text = "ถึงวันที่";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.label4.Location = new System.Drawing.Point(193, 68);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(31, 16);
			this.label4.TabIndex = 312;
			this.label4.Text = "วันที่";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.label10.Location = new System.Drawing.Point(374, 69);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(45, 16);
			this.label10.TabIndex = 313;
			this.label10.Text = "ถึงวันที่";
			// 
			// btnComOnilne
			// 
			this.btnComOnilne.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.btnComOnilne.Location = new System.Drawing.Point(812, 106);
			this.btnComOnilne.Name = "btnComOnilne";
			this.btnComOnilne.Size = new System.Drawing.Size(118, 31);
			this.btnComOnilne.TabIndex = 300;
			this.btnComOnilne.Text = "คำนวณ Comปลีก";
			this.btnComOnilne.UseVisualStyleBackColor = true;
			this.btnComOnilne.Click += new System.EventHandler(this.btnComOnilne_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.label5.Location = new System.Drawing.Point(84, 26);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(77, 16);
			this.label5.TabIndex = 295;
			this.label5.Text = "เลขที่เอกสาร";
			// 
			// txtday
			// 
			this.txtday.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.txtday.Location = new System.Drawing.Point(736, 110);
			this.txtday.MaxLength = 2;
			this.txtday.Name = "txtday";
			this.txtday.Size = new System.Drawing.Size(57, 23);
			this.txtday.TabIndex = 294;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.label3.Location = new System.Drawing.Point(567, 117);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(150, 16);
			this.label3.TabIndex = 293;
			this.label3.Text = "จำนวนวันทำงาน(เต็มเดือน)";
			// 
			// cmbDOCNO
			// 
			this.cmbDOCNO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbDOCNO.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.cmbDOCNO.FormattingEnabled = true;
			this.cmbDOCNO.Location = new System.Drawing.Point(238, 20);
			this.cmbDOCNO.Margin = new System.Windows.Forms.Padding(4);
			this.cmbDOCNO.Name = "cmbDOCNO";
			this.cmbDOCNO.Size = new System.Drawing.Size(181, 22);
			this.cmbDOCNO.TabIndex = 280;
			// 
			// bntSave
			// 
			this.bntSave.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.bntSave.Location = new System.Drawing.Point(434, 20);
			this.bntSave.Name = "bntSave";
			this.bntSave.Size = new System.Drawing.Size(100, 31);
			this.bntSave.TabIndex = 15;
			this.bntSave.Text = "ตกลง";
			this.bntSave.UseVisualStyleBackColor = true;
			this.bntSave.Click += new System.EventHandler(this.bntSave_Click);
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.รายละเอียด);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 196);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(984, 402);
			this.tabControl1.TabIndex = 212;
			// 
			// รายละเอียด
			// 
			this.รายละเอียด.Controls.Add(this.lsvData);
			this.รายละเอียด.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.รายละเอียด.Location = new System.Drawing.Point(4, 28);
			this.รายละเอียด.Name = "รายละเอียด";
			this.รายละเอียด.Padding = new System.Windows.Forms.Padding(3);
			this.รายละเอียด.Size = new System.Drawing.Size(976, 370);
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
			this.lsvData.Size = new System.Drawing.Size(970, 364);
			this.lsvData.TabIndex = 209;
			this.lsvData.UseCompatibleStateImageBehavior = false;
			this.lsvData.View = System.Windows.Forms.View.Details;
			// 
			// frmCom_RetailReport
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(984, 598);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.toolStrip2);
			this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "frmCom_RetailReport";
			this.Text = "frmCom_RetailReport";
			this.Load += new System.EventHandler(this.frmCom_RetailReport_Load);
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
		private System.Windows.Forms.ToolStripButton btnSave;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton btnExport_export;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripButton btnClose;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox txtStartDateFP;
		private System.Windows.Forms.TextBox txtEndDateFP;
		private System.Windows.Forms.TextBox txtStartDate;
		private System.Windows.Forms.TextBox txtEndDate;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Button btnComOnilne;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtday;
		private System.Windows.Forms.Label label3;
		private kBeauty_Libary.Controls.kComboBox cmbDOCNO;
		private System.Windows.Forms.Button bntSave;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage รายละเอียด;
		private kBeauty_Libary.Controls.kListView lsvData;
	}
}