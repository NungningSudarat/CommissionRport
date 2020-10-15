namespace CommissionRport.Ul_Check.Sale
{
	partial class frmSale
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSale));
			this.toolStrip2 = new System.Windows.Forms.ToolStrip();
			this.btnSumbit = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.btnExport = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.btnClose = new System.Windows.Forms.ToolStripButton();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.dtp_EndDateFP = new kBeauty_Libary.Controls.kDateTimePicker(this.components);
			this.dtp_StartDateFP = new kBeauty_Libary.Controls.kDateTimePicker(this.components);
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.dtp_EndDate = new kBeauty_Libary.Controls.kDateTimePicker(this.components);
			this.dtp_StartDate = new kBeauty_Libary.Controls.kDateTimePicker(this.components);
			this.txtYEAR = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtMONTH = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtDOCNO = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.bntSave = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
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
            this.btnSumbit,
            this.toolStripSeparator2,
            this.btnExport,
            this.toolStripSeparator1,
            this.btnClose});
			this.toolStrip2.Location = new System.Drawing.Point(0, 0);
			this.toolStrip2.Name = "toolStrip2";
			this.toolStrip2.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
			this.toolStrip2.Size = new System.Drawing.Size(984, 39);
			this.toolStrip2.TabIndex = 206;
			this.toolStrip2.Text = "toolStrip2";
			// 
			// btnSumbit
			// 
			this.btnSumbit.Image = ((System.Drawing.Image)(resources.GetObject("btnSumbit.Image")));
			this.btnSumbit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.btnSumbit.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnSumbit.Name = "btnSumbit";
			this.btnSumbit.Size = new System.Drawing.Size(85, 36);
			this.btnSumbit.Text = "บันทึก";
			this.btnSumbit.Click += new System.EventHandler(this.btnSumbit_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
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
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
			this.toolStripSeparator1.Click += new System.EventHandler(this.toolStripSeparator1_Click);
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
			this.panel1.Controls.Add(this.label9);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.dtp_EndDateFP);
			this.panel1.Controls.Add(this.dtp_StartDateFP);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.dtp_EndDate);
			this.panel1.Controls.Add(this.dtp_StartDate);
			this.panel1.Controls.Add(this.txtYEAR);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.txtMONTH);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.txtDOCNO);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.bntSave);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 39);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(984, 112);
			this.panel1.TabIndex = 213;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.label9.Location = new System.Drawing.Point(344, 76);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(136, 16);
			this.label9.TabIndex = 36;
			this.label9.Text = "วันที่ค่าคอม FoodPanda";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.label8.Location = new System.Drawing.Point(411, 30);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(69, 16);
			this.label8.TabIndex = 35;
			this.label8.Text = "วันที่ค่าคอม";
			// 
			// dtp_EndDateFP
			// 
			this.dtp_EndDateFP._displayThai = false;
			this.dtp_EndDateFP.CustomFormat = "dd/MM/yyyy";
			this.dtp_EndDateFP.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.dtp_EndDateFP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtp_EndDateFP.Location = new System.Drawing.Point(753, 76);
			this.dtp_EndDateFP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dtp_EndDateFP.Name = "dtp_EndDateFP";
			this.dtp_EndDateFP.Size = new System.Drawing.Size(100, 22);
			this.dtp_EndDateFP.TabIndex = 34;
			// 
			// dtp_StartDateFP
			// 
			this.dtp_StartDateFP._displayThai = false;
			this.dtp_StartDateFP.CustomFormat = "dd/MM/yyyy";
			this.dtp_StartDateFP.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.dtp_StartDateFP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtp_StartDateFP.Location = new System.Drawing.Point(559, 75);
			this.dtp_StartDateFP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dtp_StartDateFP.Name = "dtp_StartDateFP";
			this.dtp_StartDateFP.Size = new System.Drawing.Size(100, 22);
			this.dtp_StartDateFP.TabIndex = 33;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.label6.Location = new System.Drawing.Point(512, 80);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(31, 16);
			this.label6.TabIndex = 31;
			this.label6.Text = "วันที่";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.label7.Location = new System.Drawing.Point(693, 81);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(45, 16);
			this.label7.TabIndex = 32;
			this.label7.Text = "ถึงวันที่";
			// 
			// dtp_EndDate
			// 
			this.dtp_EndDate._displayThai = false;
			this.dtp_EndDate.CustomFormat = "dd/MM/yyyy";
			this.dtp_EndDate.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.dtp_EndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtp_EndDate.Location = new System.Drawing.Point(753, 30);
			this.dtp_EndDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dtp_EndDate.Name = "dtp_EndDate";
			this.dtp_EndDate.Size = new System.Drawing.Size(100, 22);
			this.dtp_EndDate.TabIndex = 30;
			// 
			// dtp_StartDate
			// 
			this.dtp_StartDate._displayThai = false;
			this.dtp_StartDate.CustomFormat = "dd/MM/yyyy";
			this.dtp_StartDate.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.dtp_StartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtp_StartDate.Location = new System.Drawing.Point(559, 29);
			this.dtp_StartDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dtp_StartDate.Name = "dtp_StartDate";
			this.dtp_StartDate.Size = new System.Drawing.Size(100, 22);
			this.dtp_StartDate.TabIndex = 29;
			// 
			// txtYEAR
			// 
			this.txtYEAR.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.txtYEAR.Location = new System.Drawing.Point(229, 67);
			this.txtYEAR.MaxLength = 4;
			this.txtYEAR.Name = "txtYEAR";
			this.txtYEAR.Size = new System.Drawing.Size(54, 23);
			this.txtYEAR.TabIndex = 28;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.label5.Location = new System.Drawing.Point(169, 73);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(54, 16);
			this.label5.TabIndex = 27;
			this.label5.Text = "ปี (ค.ศ.)";
			// 
			// txtMONTH
			// 
			this.txtMONTH.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.txtMONTH.Location = new System.Drawing.Point(101, 66);
			this.txtMONTH.MaxLength = 2;
			this.txtMONTH.Name = "txtMONTH";
			this.txtMONTH.Size = new System.Drawing.Size(51, 23);
			this.txtMONTH.TabIndex = 26;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.label1.Location = new System.Drawing.Point(26, 73);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(69, 16);
			this.label1.TabIndex = 25;
			this.label1.Text = "ประจำเดือน";
			// 
			// txtDOCNO
			// 
			this.txtDOCNO.Enabled = false;
			this.txtDOCNO.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.txtDOCNO.Location = new System.Drawing.Point(101, 26);
			this.txtDOCNO.Name = "txtDOCNO";
			this.txtDOCNO.Size = new System.Drawing.Size(182, 23);
			this.txtDOCNO.TabIndex = 24;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.label2.Location = new System.Drawing.Point(18, 34);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(77, 16);
			this.label2.TabIndex = 23;
			this.label2.Text = "เลขที่เอกสาร";
			// 
			// bntSave
			// 
			this.bntSave.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.bntSave.Location = new System.Drawing.Point(879, 70);
			this.bntSave.Name = "bntSave";
			this.bntSave.Size = new System.Drawing.Size(74, 31);
			this.bntSave.TabIndex = 15;
			this.bntSave.Text = "ตกลง";
			this.bntSave.UseVisualStyleBackColor = true;
			this.bntSave.Click += new System.EventHandler(this.bntSave_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.label3.Location = new System.Drawing.Point(512, 34);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(31, 16);
			this.label3.TabIndex = 10;
			this.label3.Text = "วันที่";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.label4.Location = new System.Drawing.Point(693, 35);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(45, 16);
			this.label4.TabIndex = 11;
			this.label4.Text = "ถึงวันที่";
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.รายละเอียด);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 151);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(984, 447);
			this.tabControl1.TabIndex = 214;
			// 
			// รายละเอียด
			// 
			this.รายละเอียด.Controls.Add(this.lsvData);
			this.รายละเอียด.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.รายละเอียด.Location = new System.Drawing.Point(4, 28);
			this.รายละเอียด.Name = "รายละเอียด";
			this.รายละเอียด.Padding = new System.Windows.Forms.Padding(3);
			this.รายละเอียด.Size = new System.Drawing.Size(976, 415);
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
			this.lsvData.Size = new System.Drawing.Size(970, 409);
			this.lsvData.TabIndex = 208;
			this.lsvData.UseCompatibleStateImageBehavior = false;
			this.lsvData.View = System.Windows.Forms.View.Details;
			// 
			// frmSale
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(984, 598);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.toolStrip2);
			this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "frmSale";
			this.Text = "frmSale";
			this.Load += new System.EventHandler(this.frmSale_Load);
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
		private System.Windows.Forms.ToolStripButton btnSumbit;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripButton btnExport;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton btnClose;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox txtDOCNO;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button bntSave;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage รายละเอียด;
		private kBeauty_Libary.Controls.kListView lsvData;
		private System.Windows.Forms.TextBox txtYEAR;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtMONTH;
		private System.Windows.Forms.Label label1;
		private kBeauty_Libary.Controls.kDateTimePicker dtp_EndDate;
		private kBeauty_Libary.Controls.kDateTimePicker dtp_StartDate;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private kBeauty_Libary.Controls.kDateTimePicker dtp_EndDateFP;
		private kBeauty_Libary.Controls.kDateTimePicker dtp_StartDateFP;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
	}
}