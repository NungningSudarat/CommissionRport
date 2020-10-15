namespace CommissionRport.UI_ADJ
{
	partial class frmLOG_WholeSale
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLOG_WholeSale));
			this.toolStrip2 = new System.Windows.Forms.ToolStrip();
			this.btnSumbit = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.btnClose = new System.Windows.Forms.ToolStripButton();
			this.panel1 = new System.Windows.Forms.Panel();
			this.cmbTYID = new kBeauty_Libary.Controls.kComboBox(this.components);
			this.label5 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.txtnet = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txtTYID = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtBID = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtDVAL = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtwhcode = new System.Windows.Forms.TextBox();
			this.txtDOCNO = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.cmbBID = new kBeauty_Libary.Controls.kComboBox(this.components);
			this.toolStrip2.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStrip2
			// 
			this.toolStrip2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSumbit,
            this.toolStripSeparator2,
            this.btnClose});
			this.toolStrip2.Location = new System.Drawing.Point(0, 0);
			this.toolStrip2.Name = "toolStrip2";
			this.toolStrip2.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
			this.toolStrip2.Size = new System.Drawing.Size(767, 39);
			this.toolStrip2.TabIndex = 210;
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
			this.panel1.Controls.Add(this.cmbBID);
			this.panel1.Controls.Add(this.cmbTYID);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label9);
			this.panel1.Controls.Add(this.txtnet);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.txtTYID);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.txtBID);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.txtDVAL);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.txtwhcode);
			this.panel1.Controls.Add(this.txtDOCNO);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(12, 42);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(753, 288);
			this.panel1.TabIndex = 211;
			// 
			// cmbTYID
			// 
			this.cmbTYID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbTYID.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.cmbTYID.FormattingEnabled = true;
			this.cmbTYID.Location = new System.Drawing.Point(137, 190);
			this.cmbTYID.Margin = new System.Windows.Forms.Padding(4);
			this.cmbTYID.Name = "cmbTYID";
			this.cmbTYID.Size = new System.Drawing.Size(141, 27);
			this.cmbTYID.TabIndex = 280;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.label5.ForeColor = System.Drawing.Color.Red;
			this.label5.Location = new System.Drawing.Point(129, 221);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(138, 13);
			this.label5.TabIndex = 279;
			this.label5.Text = "กรุณาระบุก่อนบันทึก ทุกครั้ง ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.label2.ForeColor = System.Drawing.Color.Red;
			this.label2.Location = new System.Drawing.Point(480, 117);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(161, 13);
			this.label2.TabIndex = 277;
			this.label2.Text = "ระบุทศนิยม 2 ต่ำแหน่ง เช่น 40.00";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(644, 43);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(38, 19);
			this.label9.TabIndex = 15;
			this.label9.Text = "บาท";
			// 
			// txtnet
			// 
			this.txtnet.Enabled = false;
			this.txtnet.Location = new System.Drawing.Point(482, 40);
			this.txtnet.Name = "txtnet";
			this.txtnet.Size = new System.Drawing.Size(141, 27);
			this.txtnet.TabIndex = 14;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(393, 40);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(61, 19);
			this.label8.TabIndex = 13;
			this.label8.Text = "ยอดเงิน";
			// 
			// txtTYID
			// 
			this.txtTYID.Enabled = false;
			this.txtTYID.Location = new System.Drawing.Point(304, 193);
			this.txtTYID.Name = "txtTYID";
			this.txtTYID.Size = new System.Drawing.Size(141, 27);
			this.txtTYID.TabIndex = 12;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(66, 193);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(47, 19);
			this.label7.TabIndex = 11;
			this.label7.Text = "TYPE";
			// 
			// txtBID
			// 
			this.txtBID.Enabled = false;
			this.txtBID.Location = new System.Drawing.Point(305, 142);
			this.txtBID.Name = "txtBID";
			this.txtBID.Size = new System.Drawing.Size(141, 27);
			this.txtBID.TabIndex = 10;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(68, 142);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(55, 19);
			this.label6.TabIndex = 9;
			this.label6.Text = "แบรนด์";
			// 
			// txtDVAL
			// 
			this.txtDVAL.Location = new System.Drawing.Point(482, 87);
			this.txtDVAL.Name = "txtDVAL";
			this.txtDVAL.Size = new System.Drawing.Size(141, 27);
			this.txtDVAL.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(409, 87);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(49, 19);
			this.label4.TabIndex = 6;
			this.label4.Text = "DVAL";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(46, 93);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(72, 19);
			this.label3.TabIndex = 4;
			this.label3.Text = "รหัสสาขา";
			// 
			// txtwhcode
			// 
			this.txtwhcode.Enabled = false;
			this.txtwhcode.Location = new System.Drawing.Point(137, 87);
			this.txtwhcode.Name = "txtwhcode";
			this.txtwhcode.Size = new System.Drawing.Size(141, 27);
			this.txtwhcode.TabIndex = 3;
			// 
			// txtDOCNO
			// 
			this.txtDOCNO.Enabled = false;
			this.txtDOCNO.Location = new System.Drawing.Point(137, 37);
			this.txtDOCNO.Name = "txtDOCNO";
			this.txtDOCNO.Size = new System.Drawing.Size(141, 27);
			this.txtDOCNO.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(34, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(94, 19);
			this.label1.TabIndex = 0;
			this.label1.Text = "เลขที่เอกสาร";
			// 
			// cmbBID
			// 
			this.cmbBID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbBID.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.cmbBID.FormattingEnabled = true;
			this.cmbBID.Location = new System.Drawing.Point(137, 142);
			this.cmbBID.Margin = new System.Windows.Forms.Padding(4);
			this.cmbBID.Name = "cmbBID";
			this.cmbBID.Size = new System.Drawing.Size(141, 27);
			this.cmbBID.TabIndex = 281;
			// 
			// frmLOG_WholeSale
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(767, 336);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.toolStrip2);
			this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "frmLOG_WholeSale";
			this.Text = "frmLOG_WholeSale";
			this.Load += new System.EventHandler(this.frmLOG_WholeSale_Load);
			this.toolStrip2.ResumeLayout(false);
			this.toolStrip2.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip toolStrip2;
		private System.Windows.Forms.ToolStripButton btnSumbit;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripButton btnClose;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtnet;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtTYID;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtBID;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtDVAL;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtwhcode;
		private System.Windows.Forms.TextBox txtDOCNO;
		private System.Windows.Forms.Label label1;
		private kBeauty_Libary.Controls.kComboBox cmbDIB;
		private kBeauty_Libary.Controls.kComboBox cmbBID;
		private System.Windows.Forms.Label label2;
		private kBeauty_Libary.Controls.kComboBox cmdBID;
		private System.Windows.Forms.Label label5;
		private kBeauty_Libary.Controls.kComboBox cmbTYID;
	}
}