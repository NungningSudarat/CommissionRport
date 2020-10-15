namespace CommissionRport.Ul_MASTER
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLOG_WholeSale));
			this.toolStrip2 = new System.Windows.Forms.ToolStrip();
			this.btnSumbit = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.btnClose = new System.Windows.Forms.ToolStripButton();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtCFLAG = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtDVAL = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
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
			this.toolStrip2.Size = new System.Drawing.Size(484, 39);
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
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.txtCFLAG);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.txtDVAL);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(0, 42);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(481, 180);
			this.panel1.TabIndex = 211;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.label3.ForeColor = System.Drawing.Color.Red;
			this.label3.Location = new System.Drawing.Point(365, 135);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(82, 14);
			this.label3.TabIndex = 14;
			this.label3.Text = "1 =  ปิดใช้งาน";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.label2.ForeColor = System.Drawing.Color.Red;
			this.label2.Location = new System.Drawing.Point(364, 112);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(82, 14);
			this.label2.TabIndex = 13;
			this.label2.Text = "0 = เปิดใช้งาน";
			// 
			// txtCFLAG
			// 
			this.txtCFLAG.Location = new System.Drawing.Point(128, 103);
			this.txtCFLAG.Name = "txtCFLAG";
			this.txtCFLAG.Size = new System.Drawing.Size(141, 27);
			this.txtCFLAG.TabIndex = 12;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(34, 106);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(57, 19);
			this.label7.TabIndex = 11;
			this.label7.Text = "CFLAG";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.label4.ForeColor = System.Drawing.Color.Red;
			this.label4.Location = new System.Drawing.Point(312, 112);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(39, 14);
			this.label4.TabIndex = 6;
			this.label4.Text = "สถานะ";
			// 
			// txtDVAL
			// 
			this.txtDVAL.Location = new System.Drawing.Point(128, 37);
			this.txtDVAL.Name = "txtDVAL";
			this.txtDVAL.Size = new System.Drawing.Size(141, 27);
			this.txtDVAL.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(34, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(49, 19);
			this.label1.TabIndex = 0;
			this.label1.Text = "DVAL";
			// 
			// frmLOG_WholeSale
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(484, 224);
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
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtDVAL;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtCFLAG;
		private System.Windows.Forms.Label label4;
	}
}