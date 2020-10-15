namespace CommissionRport.UI_Report
{
	partial class frmSaleByWHcodeReport
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSaleByWHcodeReport));
			this.toolStrip2 = new System.Windows.Forms.ToolStrip();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.btnClose = new System.Windows.Forms.ToolStripButton();
			this.รายละเอียด = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.dtp_StartDate = new System.Windows.Forms.DateTimePicker();
			this.dtp_EndDate = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.btnExport = new System.Windows.Forms.ToolStripDropDownButton();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.mnuExportToExcel = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuExportToCSV = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuExportToTextTab = new System.Windows.Forms.ToolStripMenuItem();
			this.lsvData = new System.Windows.Forms.ListView();
			this.toolStrip2.SuspendLayout();
			this.รายละเอียด.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStrip2
			// 
			this.toolStrip2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExport,
            this.toolStripSeparator2,
            this.btnClose});
			this.toolStrip2.Location = new System.Drawing.Point(0, 0);
			this.toolStrip2.Name = "toolStrip2";
			this.toolStrip2.Padding = new System.Windows.Forms.Padding(0, 0, 6, 0);
			this.toolStrip2.Size = new System.Drawing.Size(725, 39);
			this.toolStrip2.TabIndex = 209;
			this.toolStrip2.Text = "toolStrip2";
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
			// 
			// btnClose
			// 
			this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
			this.btnClose.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.btnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(119, 36);
			this.btnClose.Text = "ปิดหน้าต่าง";
			// 
			// รายละเอียด
			// 
			this.รายละเอียด.Controls.Add(this.tabPage1);
			this.รายละเอียด.Location = new System.Drawing.Point(13, 117);
			this.รายละเอียด.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.รายละเอียด.Name = "รายละเอียด";
			this.รายละเอียด.SelectedIndex = 0;
			this.รายละเอียด.Size = new System.Drawing.Size(706, 416);
			this.รายละเอียด.TabIndex = 210;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.lsvData);
			this.tabPage1.Location = new System.Drawing.Point(4, 28);
			this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tabPage1.Size = new System.Drawing.Size(698, 384);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "tabPage1";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// dtp_StartDate
			// 
			this.dtp_StartDate.CustomFormat = "dd/MM/yyyy";
			this.dtp_StartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtp_StartDate.Location = new System.Drawing.Point(94, 61);
			this.dtp_StartDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.dtp_StartDate.Name = "dtp_StartDate";
			this.dtp_StartDate.Size = new System.Drawing.Size(166, 27);
			this.dtp_StartDate.TabIndex = 211;
			// 
			// dtp_EndDate
			// 
			this.dtp_EndDate.CustomFormat = "dd/MM/yyyy";
			this.dtp_EndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtp_EndDate.Location = new System.Drawing.Point(367, 63);
			this.dtp_EndDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.dtp_EndDate.Name = "dtp_EndDate";
			this.dtp_EndDate.Size = new System.Drawing.Size(166, 27);
			this.dtp_EndDate.TabIndex = 212;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(49, 67);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 19);
			this.label1.TabIndex = 213;
			this.label1.Text = "วันที่";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(305, 67);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(55, 19);
			this.label2.TabIndex = 214;
			this.label2.Text = "ถึงวันที่";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(576, 58);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(100, 41);
			this.button1.TabIndex = 215;
			this.button1.Text = "ตกลง";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// btnExport
			// 
			this.btnExport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExportToTextTab,
            this.mnuExportToCSV,
            this.toolStripMenuItem1,
            this.mnuExportToExcel});
			this.btnExport.Image = ((System.Drawing.Image)(resources.GetObject("btnExport.Image")));
			this.btnExport.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.btnExport.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnExport.Name = "btnExport";
			this.btnExport.Size = new System.Drawing.Size(101, 36);
			this.btnExport.Text = "ส่งออก";
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
			// 
			// mnuExportToExcel
			// 
			this.mnuExportToExcel.Name = "mnuExportToExcel";
			this.mnuExportToExcel.Size = new System.Drawing.Size(180, 24);
			this.mnuExportToExcel.Text = "Excel";
			// 
			// mnuExportToCSV
			// 
			this.mnuExportToCSV.Name = "mnuExportToCSV";
			this.mnuExportToCSV.Size = new System.Drawing.Size(180, 24);
			this.mnuExportToCSV.Text = "CSV";
			// 
			// mnuExportToTextTab
			// 
			this.mnuExportToTextTab.Name = "mnuExportToTextTab";
			this.mnuExportToTextTab.Size = new System.Drawing.Size(180, 24);
			this.mnuExportToTextTab.Text = "Text Tab";
			// 
			// lsvData
			// 
			this.lsvData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lsvData.FullRowSelect = true;
			this.lsvData.GridLines = true;
			this.lsvData.HideSelection = false;
			this.lsvData.Location = new System.Drawing.Point(4, 4);
			this.lsvData.Name = "lsvData";
			this.lsvData.Size = new System.Drawing.Size(690, 376);
			this.lsvData.TabIndex = 0;
			this.lsvData.UseCompatibleStateImageBehavior = false;
			this.lsvData.View = System.Windows.Forms.View.Details;
			// 
			// frmSaleByWHcodeReport
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(725, 531);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dtp_EndDate);
			this.Controls.Add(this.dtp_StartDate);
			this.Controls.Add(this.รายละเอียด);
			this.Controls.Add(this.toolStrip2);
			this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "frmSaleByWHcodeReport";
			this.Text = "frmSaleByWHcodeReport";
			this.toolStrip2.ResumeLayout(false);
			this.toolStrip2.PerformLayout();
			this.รายละเอียด.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip toolStrip2;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripButton btnClose;
		private System.Windows.Forms.ToolStripDropDownButton btnExport;
		private System.Windows.Forms.ToolStripMenuItem mnuExportToTextTab;
		private System.Windows.Forms.ToolStripMenuItem mnuExportToCSV;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem mnuExportToExcel;
		private System.Windows.Forms.TabControl รายละเอียด;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.ListView lsvData;
		private System.Windows.Forms.DateTimePicker dtp_StartDate;
		private System.Windows.Forms.DateTimePicker dtp_EndDate;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button1;
	}
}