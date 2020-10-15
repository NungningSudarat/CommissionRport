namespace CommissionRport.Ul_Details
{
	partial class frmWarehouseDetails
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWarehouseDetails));
			this.toolStrip2 = new System.Windows.Forms.ToolStrip();
			this.btnExport = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.btnClose = new System.Windows.Forms.ToolStripButton();
			this.bntSave = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
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
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.cmbDOCNO = new kBeauty_Libary.Controls.kComboBox(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.toolStrip2.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.รายละเอียด.SuspendLayout();
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
			this.toolStrip2.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
			this.toolStrip2.Size = new System.Drawing.Size(984, 39);
			this.toolStrip2.TabIndex = 206;
			this.toolStrip2.Text = "toolStrip2";
			// 
			// btnExport
			// 
			this.btnExport.Image = ((System.Drawing.Image)(resources.GetObject("btnExport.Image")));
			this.btnExport.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.btnExport.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnExport.Name = "btnExport";
			this.btnExport.Size = new System.Drawing.Size(92, 36);
			this.btnExport.Text = "ส่งออก";
			this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
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
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// bntSave
			// 
			this.bntSave.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.bntSave.Location = new System.Drawing.Point(866, 22);
			this.bntSave.Name = "bntSave";
			this.bntSave.Size = new System.Drawing.Size(74, 31);
			this.bntSave.TabIndex = 15;
			this.bntSave.Text = "ตกลง";
			this.bntSave.UseVisualStyleBackColor = true;
			this.bntSave.Click += new System.EventHandler(this.bntSave_Click);
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
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.cmbDOCNO);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.bntSave);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 39);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(984, 115);
			this.panel1.TabIndex = 207;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.tabControl1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 154);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(984, 444);
			this.panel2.TabIndex = 208;
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.รายละเอียด);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(984, 444);
			this.tabControl1.TabIndex = 0;
			// 
			// รายละเอียด
			// 
			this.รายละเอียด.Controls.Add(this.lsvData);
			this.รายละเอียด.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.รายละเอียด.Location = new System.Drawing.Point(4, 28);
			this.รายละเอียด.Name = "รายละเอียด";
			this.รายละเอียด.Padding = new System.Windows.Forms.Padding(3);
			this.รายละเอียด.Size = new System.Drawing.Size(976, 412);
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
			this.lsvData.Size = new System.Drawing.Size(970, 406);
			this.lsvData.TabIndex = 210;
			this.lsvData.UseCompatibleStateImageBehavior = false;
			this.lsvData.View = System.Windows.Forms.View.Details;
			// 
			// txtStartDateFP
			// 
			this.txtStartDateFP.Enabled = false;
			this.txtStartDateFP.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.txtStartDateFP.Location = new System.Drawing.Point(264, 70);
			this.txtStartDateFP.MaxLength = 2;
			this.txtStartDateFP.Name = "txtStartDateFP";
			this.txtStartDateFP.Size = new System.Drawing.Size(100, 23);
			this.txtStartDateFP.TabIndex = 311;
			// 
			// txtEndDateFP
			// 
			this.txtEndDateFP.Enabled = false;
			this.txtEndDateFP.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.txtEndDateFP.Location = new System.Drawing.Point(458, 71);
			this.txtEndDateFP.MaxLength = 2;
			this.txtEndDateFP.Name = "txtEndDateFP";
			this.txtEndDateFP.Size = new System.Drawing.Size(100, 23);
			this.txtEndDateFP.TabIndex = 310;
			// 
			// txtStartDate
			// 
			this.txtStartDate.Enabled = false;
			this.txtStartDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.txtStartDate.Location = new System.Drawing.Point(264, 24);
			this.txtStartDate.MaxLength = 2;
			this.txtStartDate.Name = "txtStartDate";
			this.txtStartDate.Size = new System.Drawing.Size(100, 23);
			this.txtStartDate.TabIndex = 309;
			// 
			// txtEndDate
			// 
			this.txtEndDate.Enabled = false;
			this.txtEndDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.txtEndDate.Location = new System.Drawing.Point(458, 25);
			this.txtEndDate.MaxLength = 2;
			this.txtEndDate.Name = "txtEndDate";
			this.txtEndDate.Size = new System.Drawing.Size(100, 23);
			this.txtEndDate.TabIndex = 308;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.label9.Location = new System.Drawing.Point(49, 70);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(136, 16);
			this.label9.TabIndex = 307;
			this.label9.Text = "วันที่ค่าคอม FoodPanda";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.label8.Location = new System.Drawing.Point(116, 24);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(69, 16);
			this.label8.TabIndex = 306;
			this.label8.Text = "วันที่ค่าคอม";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.label6.Location = new System.Drawing.Point(217, 74);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(31, 16);
			this.label6.TabIndex = 304;
			this.label6.Text = "วันที่";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.label7.Location = new System.Drawing.Point(398, 75);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(45, 16);
			this.label7.TabIndex = 305;
			this.label7.Text = "ถึงวันที่";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.label3.Location = new System.Drawing.Point(217, 28);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(31, 16);
			this.label3.TabIndex = 302;
			this.label3.Text = "วันที่";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.label4.Location = new System.Drawing.Point(398, 29);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(45, 16);
			this.label4.TabIndex = 303;
			this.label4.Text = "ถึงวันที่";
			// 
			// cmbDOCNO
			// 
			this.cmbDOCNO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbDOCNO.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.cmbDOCNO.FormattingEnabled = true;
			this.cmbDOCNO.Location = new System.Drawing.Point(701, 25);
			this.cmbDOCNO.Margin = new System.Windows.Forms.Padding(4);
			this.cmbDOCNO.Name = "cmbDOCNO";
			this.cmbDOCNO.Size = new System.Drawing.Size(142, 22);
			this.cmbDOCNO.TabIndex = 301;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.label1.Location = new System.Drawing.Point(624, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(70, 14);
			this.label1.TabIndex = 300;
			this.label1.Text = "เลขที่เอกสาร";
			// 
			// frmWarehouseDetails
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(984, 598);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.toolStrip2);
			this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "frmWarehouseDetails";
			this.Text = "frmWarehouseDetails";
			this.Load += new System.EventHandler(this.frmWarehouseDetails_Load);
			this.toolStrip2.ResumeLayout(false);
			this.toolStrip2.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.tabControl1.ResumeLayout(false);
			this.รายละเอียด.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip toolStrip2;
		private System.Windows.Forms.ToolStripButton btnClose;
		private System.Windows.Forms.ToolStripButton btnExport;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.Button bntSave;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage รายละเอียด;
		private kBeauty_Libary.Controls.kListView lsvData;
		private System.Windows.Forms.TextBox txtStartDateFP;
		private System.Windows.Forms.TextBox txtEndDateFP;
		private System.Windows.Forms.TextBox txtStartDate;
		private System.Windows.Forms.TextBox txtEndDate;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private kBeauty_Libary.Controls.kComboBox cmbDOCNO;
		private System.Windows.Forms.Label label1;
	}
}