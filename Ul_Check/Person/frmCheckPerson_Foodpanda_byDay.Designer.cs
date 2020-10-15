namespace CommissionRport.Ul_Check.Detail
{
	partial class frmCheckPerson_Foodpanda_byDay
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCheckPerson_Foodpanda_byDay));
			this.toolStrip2 = new System.Windows.Forms.ToolStrip();
			this.btnExport = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.btnClose = new System.Windows.Forms.ToolStripButton();
			this.panel1 = new System.Windows.Forms.Panel();
			this.dtp_EndDate = new kBeauty_Libary.Controls.kDateTimePicker(this.components);
			this.dtp_StartDate = new kBeauty_Libary.Controls.kDateTimePicker(this.components);
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.bntSave = new System.Windows.Forms.Button();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.รายละเอียด = new System.Windows.Forms.TabPage();
			this.lsvData = new kBeauty_Libary.Controls.kListView(this.components);
			this.txtwhcode = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
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
            this.btnExport,
            this.toolStripSeparator1,
            this.btnClose});
			this.toolStrip2.Location = new System.Drawing.Point(0, 0);
			this.toolStrip2.Name = "toolStrip2";
			this.toolStrip2.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
			this.toolStrip2.Size = new System.Drawing.Size(984, 39);
			this.toolStrip2.TabIndex = 207;
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
			this.panel1.Controls.Add(this.txtwhcode);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.dtp_EndDate);
			this.panel1.Controls.Add(this.dtp_StartDate);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.bntSave);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 39);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(984, 73);
			this.panel1.TabIndex = 214;
			// 
			// dtp_EndDate
			// 
			this.dtp_EndDate._displayThai = false;
			this.dtp_EndDate.CustomFormat = "dd/MM/yyyy";
			this.dtp_EndDate.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.dtp_EndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtp_EndDate.Location = new System.Drawing.Point(473, 29);
			this.dtp_EndDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dtp_EndDate.Name = "dtp_EndDate";
			this.dtp_EndDate.Size = new System.Drawing.Size(100, 22);
			this.dtp_EndDate.TabIndex = 34;
			// 
			// dtp_StartDate
			// 
			this.dtp_StartDate._displayThai = false;
			this.dtp_StartDate.CustomFormat = "dd/MM/yyyy";
			this.dtp_StartDate.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.dtp_StartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtp_StartDate.Location = new System.Drawing.Point(279, 28);
			this.dtp_StartDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dtp_StartDate.Name = "dtp_StartDate";
			this.dtp_StartDate.Size = new System.Drawing.Size(100, 22);
			this.dtp_StartDate.TabIndex = 33;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.label3.Location = new System.Drawing.Point(232, 33);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(31, 16);
			this.label3.TabIndex = 31;
			this.label3.Text = "วันที่";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.label4.Location = new System.Drawing.Point(413, 34);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(45, 16);
			this.label4.TabIndex = 32;
			this.label4.Text = "ถึงวันที่";
			// 
			// bntSave
			// 
			this.bntSave.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.bntSave.Location = new System.Drawing.Point(606, 22);
			this.bntSave.Name = "bntSave";
			this.bntSave.Size = new System.Drawing.Size(74, 31);
			this.bntSave.TabIndex = 15;
			this.bntSave.Text = "ตกลง";
			this.bntSave.UseVisualStyleBackColor = true;
			this.bntSave.Click += new System.EventHandler(this.bntSave_Click);
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.รายละเอียด);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 112);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(984, 486);
			this.tabControl1.TabIndex = 215;
			// 
			// รายละเอียด
			// 
			this.รายละเอียด.Controls.Add(this.lsvData);
			this.รายละเอียด.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.รายละเอียด.Location = new System.Drawing.Point(4, 28);
			this.รายละเอียด.Name = "รายละเอียด";
			this.รายละเอียด.Padding = new System.Windows.Forms.Padding(3);
			this.รายละเอียด.Size = new System.Drawing.Size(976, 454);
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
			this.lsvData.Size = new System.Drawing.Size(970, 448);
			this.lsvData.TabIndex = 208;
			this.lsvData.UseCompatibleStateImageBehavior = false;
			this.lsvData.View = System.Windows.Forms.View.Details;
			// 
			// txtwhcode
			// 
			this.txtwhcode.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.txtwhcode.Location = new System.Drawing.Point(90, 26);
			this.txtwhcode.Name = "txtwhcode";
			this.txtwhcode.Size = new System.Drawing.Size(100, 23);
			this.txtwhcode.TabIndex = 38;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.label2.Location = new System.Drawing.Point(28, 33);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 16);
			this.label2.TabIndex = 37;
			this.label2.Text = "รหัสสาขา";
			// 
			// frmCheckPerson_Foodpanda_byDay
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(984, 598);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.toolStrip2);
			this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "frmCheckPerson_Foodpanda_byDay";
			this.Text = "frmCheckPerson_Foodpanda_byDay";
			this.Load += new System.EventHandler(this.frmCheckPerson_Foodpanda_byDay_Load);
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
		private System.Windows.Forms.ToolStripButton btnExport;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton btnClose;
		private System.Windows.Forms.Panel panel1;
		private kBeauty_Libary.Controls.kDateTimePicker dtp_EndDate;
		private kBeauty_Libary.Controls.kDateTimePicker dtp_StartDate;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button bntSave;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage รายละเอียด;
		private kBeauty_Libary.Controls.kListView lsvData;
		private System.Windows.Forms.TextBox txtwhcode;
		private System.Windows.Forms.Label label2;
	}
}