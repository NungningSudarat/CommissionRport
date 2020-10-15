namespace CommissionRport.UI_ADJ
{
	partial class frmADJ
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmADJ));
			this.toolStrip2 = new System.Windows.Forms.ToolStrip();
			this.btnExport = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.btnClose = new System.Windows.Forms.ToolStripButton();
			this.panel1 = new System.Windows.Forms.Panel();
			this.bnt_add_ws = new System.Windows.Forms.Button();
			this.txtStartDateFP = new System.Windows.Forms.TextBox();
			this.txtEndDateFP = new System.Windows.Forms.TextBox();
			this.txtStartDate = new System.Windows.Forms.TextBox();
			this.txtEndDate = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.cmdTYID = new kBeauty_Libary.Controls.kComboBox(this.components);
			this.cmdBID = new kBeauty_Libary.Controls.kComboBox(this.components);
			this.cmbDOCNO = new kBeauty_Libary.Controls.kComboBox(this.components);
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtwhcode = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtscode = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.bntSave = new System.Windows.Forms.Button();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.รายละเอียด = new System.Windows.Forms.TabPage();
			this.lsvData = new kBeauty_Libary.Controls.kListView(this.components);
			this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.cNลดหนToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ขายสงToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.โอนยอดระหวางสาขาToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStrip2.SuspendLayout();
			this.panel1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.รายละเอียด.SuspendLayout();
			this.contextMenuStrip2.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStrip2
			// 
			this.toolStrip2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExport,
            this.toolStripSeparator1,
            this.btnClose});
			this.toolStrip2.Location = new System.Drawing.Point(0, 0);
			this.toolStrip2.Name = "toolStrip2";
			this.toolStrip2.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
			this.toolStrip2.Size = new System.Drawing.Size(1205, 39);
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
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
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
			this.panel1.Controls.Add(this.bnt_add_ws);
			this.panel1.Controls.Add(this.txtStartDateFP);
			this.panel1.Controls.Add(this.txtEndDateFP);
			this.panel1.Controls.Add(this.txtStartDate);
			this.panel1.Controls.Add(this.txtEndDate);
			this.panel1.Controls.Add(this.label9);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.label10);
			this.panel1.Controls.Add(this.label11);
			this.panel1.Controls.Add(this.label12);
			this.panel1.Controls.Add(this.label13);
			this.panel1.Controls.Add(this.cmdTYID);
			this.panel1.Controls.Add(this.cmdBID);
			this.panel1.Controls.Add(this.cmbDOCNO);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.txtwhcode);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.txtscode);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.bntSave);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 39);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1205, 224);
			this.panel1.TabIndex = 213;
			// 
			// bnt_add_ws
			// 
			this.bnt_add_ws.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.bnt_add_ws.Location = new System.Drawing.Point(853, 164);
			this.bnt_add_ws.Name = "bnt_add_ws";
			this.bnt_add_ws.Size = new System.Drawing.Size(93, 31);
			this.bnt_add_ws.TabIndex = 309;
			this.bnt_add_ws.Text = "ADD ขายส่ง";
			this.bnt_add_ws.UseVisualStyleBackColor = true;
			this.bnt_add_ws.Click += new System.EventHandler(this.bnt_add_ws_Click);
			// 
			// txtStartDateFP
			// 
			this.txtStartDateFP.Enabled = false;
			this.txtStartDateFP.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.txtStartDateFP.Location = new System.Drawing.Point(226, 58);
			this.txtStartDateFP.MaxLength = 2;
			this.txtStartDateFP.Name = "txtStartDateFP";
			this.txtStartDateFP.Size = new System.Drawing.Size(100, 23);
			this.txtStartDateFP.TabIndex = 308;
			// 
			// txtEndDateFP
			// 
			this.txtEndDateFP.Enabled = false;
			this.txtEndDateFP.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.txtEndDateFP.Location = new System.Drawing.Point(423, 56);
			this.txtEndDateFP.MaxLength = 2;
			this.txtEndDateFP.Name = "txtEndDateFP";
			this.txtEndDateFP.Size = new System.Drawing.Size(100, 23);
			this.txtEndDateFP.TabIndex = 307;
			// 
			// txtStartDate
			// 
			this.txtStartDate.Enabled = false;
			this.txtStartDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.txtStartDate.Location = new System.Drawing.Point(226, 19);
			this.txtStartDate.MaxLength = 2;
			this.txtStartDate.Name = "txtStartDate";
			this.txtStartDate.Size = new System.Drawing.Size(100, 23);
			this.txtStartDate.TabIndex = 306;
			// 
			// txtEndDate
			// 
			this.txtEndDate.Enabled = false;
			this.txtEndDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.txtEndDate.Location = new System.Drawing.Point(423, 18);
			this.txtEndDate.MaxLength = 2;
			this.txtEndDate.Name = "txtEndDate";
			this.txtEndDate.Size = new System.Drawing.Size(100, 23);
			this.txtEndDate.TabIndex = 305;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.label9.Location = new System.Drawing.Point(20, 61);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(136, 16);
			this.label9.TabIndex = 304;
			this.label9.Text = "วันที่ค่าคอม FoodPanda";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.label8.Location = new System.Drawing.Point(87, 21);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(69, 16);
			this.label8.TabIndex = 303;
			this.label8.Text = "วันที่ค่าคอม";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.label10.Location = new System.Drawing.Point(179, 62);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(31, 16);
			this.label10.TabIndex = 301;
			this.label10.Text = "วันที่";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.label11.Location = new System.Drawing.Point(363, 62);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(45, 16);
			this.label11.TabIndex = 302;
			this.label11.Text = "ถึงวันที่";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.label12.Location = new System.Drawing.Point(179, 23);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(31, 16);
			this.label12.TabIndex = 299;
			this.label12.Text = "วันที่";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.label13.Location = new System.Drawing.Point(363, 22);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(45, 16);
			this.label13.TabIndex = 300;
			this.label13.Text = "ถึงวันที่";
			// 
			// cmdTYID
			// 
			this.cmdTYID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmdTYID.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.cmdTYID.FormattingEnabled = true;
			this.cmdTYID.Location = new System.Drawing.Point(687, 123);
			this.cmdTYID.Margin = new System.Windows.Forms.Padding(4);
			this.cmdTYID.Name = "cmdTYID";
			this.cmdTYID.Size = new System.Drawing.Size(118, 22);
			this.cmdTYID.TabIndex = 278;
			// 
			// cmdBID
			// 
			this.cmdBID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmdBID.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.cmdBID.FormattingEnabled = true;
			this.cmdBID.Location = new System.Drawing.Point(424, 126);
			this.cmdBID.Margin = new System.Windows.Forms.Padding(4);
			this.cmdBID.Name = "cmdBID";
			this.cmdBID.Size = new System.Drawing.Size(112, 22);
			this.cmdBID.TabIndex = 277;
			// 
			// cmbDOCNO
			// 
			this.cmbDOCNO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbDOCNO.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.cmbDOCNO.FormattingEnabled = true;
			this.cmbDOCNO.Location = new System.Drawing.Point(182, 123);
			this.cmbDOCNO.Margin = new System.Windows.Forms.Padding(4);
			this.cmbDOCNO.Name = "cmbDOCNO";
			this.cmbDOCNO.Size = new System.Drawing.Size(144, 22);
			this.cmbDOCNO.TabIndex = 276;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.label7.Location = new System.Drawing.Point(628, 126);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(37, 14);
			this.label7.TabIndex = 29;
			this.label7.Text = "TYPE";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.label6.Location = new System.Drawing.Point(363, 129);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(41, 14);
			this.label6.TabIndex = 27;
			this.label6.Text = "แบรนด์";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.label3.Location = new System.Drawing.Point(86, 129);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(70, 14);
			this.label3.TabIndex = 25;
			this.label3.Text = "เลขที่เอกสาร";
			// 
			// txtwhcode
			// 
			this.txtwhcode.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.txtwhcode.Location = new System.Drawing.Point(423, 164);
			this.txtwhcode.Name = "txtwhcode";
			this.txtwhcode.Size = new System.Drawing.Size(111, 23);
			this.txtwhcode.TabIndex = 24;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.label2.Location = new System.Drawing.Point(348, 171);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 16);
			this.label2.TabIndex = 23;
			this.label2.Text = "รหัสสาขา";
			// 
			// txtscode
			// 
			this.txtscode.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.txtscode.Location = new System.Drawing.Point(685, 164);
			this.txtscode.Name = "txtscode";
			this.txtscode.Size = new System.Drawing.Size(118, 23);
			this.txtscode.TabIndex = 22;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.label1.Location = new System.Drawing.Point(588, 171);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(75, 16);
			this.label1.TabIndex = 21;
			this.label1.Text = "รหัสพนักงาน";
			// 
			// bntSave
			// 
			this.bntSave.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.bntSave.Location = new System.Drawing.Point(853, 118);
			this.bntSave.Name = "bntSave";
			this.bntSave.Size = new System.Drawing.Size(93, 31);
			this.bntSave.TabIndex = 15;
			this.bntSave.Text = "ตกลง";
			this.bntSave.UseVisualStyleBackColor = true;
			this.bntSave.Click += new System.EventHandler(this.bntSave_Click);
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.รายละเอียด);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 263);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1205, 335);
			this.tabControl1.TabIndex = 214;
			// 
			// รายละเอียด
			// 
			this.รายละเอียด.Controls.Add(this.lsvData);
			this.รายละเอียด.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.รายละเอียด.Location = new System.Drawing.Point(4, 28);
			this.รายละเอียด.Name = "รายละเอียด";
			this.รายละเอียด.Padding = new System.Windows.Forms.Padding(3);
			this.รายละเอียด.Size = new System.Drawing.Size(1197, 303);
			this.รายละเอียด.TabIndex = 0;
			this.รายละเอียด.Text = "รายละเอียด";
			this.รายละเอียด.UseVisualStyleBackColor = true;
			// 
			// lsvData
			// 
			this.lsvData.ContextMenuStrip = this.contextMenuStrip2;
			this.lsvData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lsvData.FullRowSelect = true;
			this.lsvData.GridLines = true;
			this.lsvData.HideSelection = false;
			this.lsvData.Location = new System.Drawing.Point(3, 3);
			this.lsvData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.lsvData.MultiSelect = false;
			this.lsvData.Name = "lsvData";
			this.lsvData.Size = new System.Drawing.Size(1191, 297);
			this.lsvData.TabIndex = 208;
			this.lsvData.UseCompatibleStateImageBehavior = false;
			this.lsvData.View = System.Windows.Forms.View.Details;
			// 
			// contextMenuStrip2
			// 
			this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cNลดหนToolStripMenuItem,
            this.ขายสงToolStripMenuItem,
            this.โอนยอดระหวางสาขาToolStripMenuItem1});
			this.contextMenuStrip2.Name = "contextMenuStrip2";
			this.contextMenuStrip2.Size = new System.Drawing.Size(188, 70);
			// 
			// cNลดหนToolStripMenuItem
			// 
			this.cNลดหนToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cNลดหนToolStripMenuItem.Name = "cNลดหนToolStripMenuItem";
			this.cNลดหนToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
			this.cNลดหนToolStripMenuItem.Text = "CN(ลดหนี้)";
			this.cNลดหนToolStripMenuItem.Click += new System.EventHandler(this.cNลดหนToolStripMenuItem_Click);
			// 
			// ขายสงToolStripMenuItem
			// 
			this.ขายสงToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ขายสงToolStripMenuItem.Name = "ขายสงToolStripMenuItem";
			this.ขายสงToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
			this.ขายสงToolStripMenuItem.Text = "แก้ไข DVAL ขายส่ง";
			this.ขายสงToolStripMenuItem.Click += new System.EventHandler(this.ขายสงToolStripMenuItem_Click);
			// 
			// โอนยอดระหวางสาขาToolStripMenuItem1
			// 
			this.โอนยอดระหวางสาขาToolStripMenuItem1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.โอนยอดระหวางสาขาToolStripMenuItem1.Name = "โอนยอดระหวางสาขาToolStripMenuItem1";
			this.โอนยอดระหวางสาขาToolStripMenuItem1.Size = new System.Drawing.Size(187, 22);
			this.โอนยอดระหวางสาขาToolStripMenuItem1.Text = "โอนยอดระหว่างสาขา";
			this.โอนยอดระหวางสาขาToolStripMenuItem1.Click += new System.EventHandler(this.โอนยอดระหวางสาขาToolStripMenuItem1_Click);
			// 
			// frmADJ
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1205, 598);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.toolStrip2);
			this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "frmADJ";
			this.Text = "frmInvoice_Online";
			this.Load += new System.EventHandler(this.frmInvoice_Online_Load);
			this.toolStrip2.ResumeLayout(false);
			this.toolStrip2.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.tabControl1.ResumeLayout(false);
			this.รายละเอียด.ResumeLayout(false);
			this.contextMenuStrip2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip toolStrip2;
		private System.Windows.Forms.ToolStripButton btnClose;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox txtwhcode;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtscode;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button bntSave;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage รายละเอียด;
		private kBeauty_Libary.Controls.kListView lsvData;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private kBeauty_Libary.Controls.kComboBox cmbDOCNO;
		private kBeauty_Libary.Controls.kComboBox cmdTYID;
		private kBeauty_Libary.Controls.kComboBox cmdBID;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
		private System.Windows.Forms.ToolStripMenuItem cNลดหนToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ขายสงToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem โอนยอดระหวางสาขาToolStripMenuItem1;
		private System.Windows.Forms.ToolStripButton btnExport;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.TextBox txtStartDateFP;
		private System.Windows.Forms.TextBox txtEndDateFP;
		private System.Windows.Forms.TextBox txtStartDate;
		private System.Windows.Forms.TextBox txtEndDate;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Button bnt_add_ws;
	}
}