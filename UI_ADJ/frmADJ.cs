using cBeautyComm;
using kBeauty_Libary.Helper;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommissionRport.UI_ADJ
{
	public partial class frmADJ : Form
	{
		cBeauty _cBeauty;
		ArrayList _menuList;
		public frmADJ()
		{
			InitializeComponent();
		}
		public frmADJ(cBeauty cBeauty, ref ArrayList menuList)
		{
			InitializeComponent();
			_cBeauty = cBeauty;
			_menuList = menuList;
		}
		private void frmInvoice_Online_Load(object sender, EventArgs e)
		{
			string sql_DOCNO = @" SELECT DOCNO FROM COMMISSION_DOC WHERE IT = 1 AND BR = 0 AND CFLAG = 0 ORDER BY CAST(WORKDATE as date) DESC ";
			//string sql_DOCNO = @" SELECT DOCNO FROM COMMISSION_DOC WHERE IT = 1 AND BR = 1 AND BR2 = 0 AND CFLAG = 0 ORDER BY DOCNO DESC ";

			DataSet ds_DOCNO = cData.getDataSetWithSqlCommand(_cBeauty.GetConnectionBeautySystem(), sql_DOCNO, 1000, true);

			cmbDOCNO.BeginUpdate();
			cmbDOCNO.DataSource = ds_DOCNO.Tables[0];
			cmbDOCNO.DisplayMember = "DOCNO";
			cmbDOCNO.ValueMember = "DOCNO";
			cmbDOCNO.EndUpdate();



			string sql_BID = @" SELECT BID,BNAME FROM MAS_BRAND WHERE CFLAG = 0";

			DataSet ds_BID = cData.getDataSetWithSqlCommand(_cBeauty.GetConnectionBeautySystem(), sql_BID, 1000, true);

			cmdBID.BeginUpdate();
			cmdBID.DataSource = ds_BID.Tables[0];
			cmdBID.DisplayMember = "BNAME";
			cmdBID.ValueMember = "BNAME";
			cmdBID.EndUpdate();


			string sql_TYID = @" SELECT TYID,NAME FROM MAS_TYPE WHERE CFLAG = 0 ";

			DataSet ds_TYID = cData.getDataSetWithSqlCommand(_cBeauty.GetConnectionBeautySystem(), sql_TYID, 1000, true);

			cmdTYID.BeginUpdate();
			cmdTYID.DataSource = ds_TYID.Tables[0];
			cmdTYID.DisplayMember = "NAME";
			cmdTYID.ValueMember = "NAME";
			cmdTYID.EndUpdate();



			lsvData.LabelWrap = false;
			// Add Columns                        
			lsvData.Columns.Add("#", 60, HorizontalAlignment.Right);
			lsvData.Columns.Add("เลขที่เอกสาร", 120, HorizontalAlignment.Left);
			lsvData.Columns.Add("เดือน", 80, HorizontalAlignment.Left);
			lsvData.Columns.Add("ปี", 80, HorizontalAlignment.Left);
			lsvData.Columns.Add("TYPE", 80, HorizontalAlignment.Left);
			lsvData.Columns.Add("BRAND", 80, HorizontalAlignment.Left);
			lsvData.Columns.Add("รหัสสาขา", 80, HorizontalAlignment.Left);
			lsvData.Columns.Add("ชื่อสาขา", 100, HorizontalAlignment.Left);
			lsvData.Columns.Add("รหัสพนักงาน", 80, HorizontalAlignment.Left);
			lsvData.Columns.Add("ชื่อพนักงาน", 200, HorizontalAlignment.Left);
			lsvData.Columns.Add("NET", 80, HorizontalAlignment.Left);
			lsvData.Columns.Add("ADJ", 80, HorizontalAlignment.Left);
			lsvData.Columns.Add("NET_ADJ", 80, HorizontalAlignment.Left);
			lsvData.Columns.Add("DVAL", 80, HorizontalAlignment.Left);

		}
		private void btnClose_Click(object sender, EventArgs e)
		{
			_menuList.Remove(this.Text);
			this.Close();
		}
		private void bntSave_Click(object sender, EventArgs e)
		{
			GetDatMY();
			
			
		}

		private void GetDatMY()
		{

			string sql = @"SELECT  MONTH,YEAR,CONVERT(VARCHAR,StartDate,103) AS StartDate ,
							CONVERT(VARCHAR,EndDate,103) AS EndDate ,CONVERT(VARCHAR,StartDate_FP,103) AS StartDate_FP,
							CONVERT(VARCHAR,EndDate_FP,103) AS EndDate_FP  FROM COMMISSION_DOC WHERE CFLAG= '0'  AND DOCNO = @DOCNO";

			using (SqlConnection conn = new SqlConnection(_cBeauty.GetConnectionBeautySystem()))
			{
				conn.Open();
				try
				{
					using (SqlCommand comm = new SqlCommand())
					{
						comm.CommandType = CommandType.Text;
						comm.CommandTimeout = 1000;
						comm.Connection = conn;

						comm.CommandText = sql;
						comm.Parameters.Clear();
						comm.Parameters.AddWithValue("@DOCNO", cmbDOCNO.SelectedValue.ToString());
						var dataReader = comm.ExecuteReader();
						var dataTable = new DataTable();
						dataTable.Load(dataReader);

						if (dataTable.Rows.Count > 0)
						{

							//txtMONTH.Text = dataTable.Rows[0]["MONTH"].ToString();
							//txtYEAR.Text = dataTable.Rows[0]["YEAR"].ToString();
							txtStartDate.Text = dataTable.Rows[0]["StartDate"].ToString();
							txtEndDate.Text = dataTable.Rows[0]["EndDate"].ToString();
							txtStartDateFP.Text = dataTable.Rows[0]["StartDate_FP"].ToString();
							txtEndDateFP.Text = dataTable.Rows[0]["EndDate_FP"].ToString();

						}
					}
				}
				catch (Exception ex)
				{
					cMessage.Error_NotCaption(ex.Message);
				}
			}
			GetData();
		}
		private void GetData()
		{
			string STCODE = txtscode.Text;
			string WHCODE = txtwhcode.Text;
			string DOCNO = cmbDOCNO.SelectedValue.ToString();
			string TYID = cmdTYID.SelectedValue.ToString();
			string BID = cmdBID.SelectedValue.ToString();
			string sql = @" SELECT DOCNO,[MONTH],[YEAR],[NAME],BNAME,WHCODE,ABBNAME,STCODE,FULLNAME,NET,
							CASE WHEN ADJ = 0.00 THEN NULL  ELSE ADJ END AS ADJ_J,NET_TOTAL,DVAL,ID
							FROM (
							SELECT A.DOCNO,A.MONTH,A.YEAR,E.NAME,D.BNAME,B.WHCODE,V.ABBNAME,B.STCODE,Y.FULLNAME,B.NET,B.NET_TOTAL,(B.NET - B.NET_TOTAL)  AS ADJ,B.DVAL,B.ID
							FROM COMMISSION_DOC A
							LEFT JOIN COMMISSION_DOC_I B ON A.DOCNO = B.DOCNO
							LEFT JOIN MAS_BRAND D ON B.BID = D.BID
							LEFT JOIN MAS_TYPE E  ON B.TYID = E.TYID
							LEFT JOIN [192.168.1.125].[kBeautySaleOder].[dbo].MAS_WH V  ON B.WHCODE = V.WHCODE
							LEFT JOIN [192.168.1.220,1433].[CMD-BX].[dbo].MAS_ST Y  ON B.STCODE = Y.STCODE
							WHERE A.DOCNO = '" + DOCNO + "' AND A.CFLAG ='0' AND B.CFLAG ='0' AND IT = 1";
			//string sql = @"SELECT DOCNO,[MONTH],[YEAR],[NAME],BNAME,WHCODE,WHNAME,STCODE,STNAME,NET,
			//				CASE WHEN ADJ = 0.00 THEN NULL  ELSE ADJ END AS ADJ_J,NET_TOTAL,
			//				DVAL,ID
			//				FROM (
			//				SELECT A.DOCNO,A.MONTH,A.YEAR,E.NAME,D.BNAME,B.WHCODE,B.WHNAME,B.STCODE,B.STNAME,B.NET,B.NET_TOTAL,(B.NET - B.NET_TOTAL)  AS ADJ,B.DVAL,B.ID
			//				FROM COMMISSION_DOC A
			//				LEFT JOIN COMMISSION_DOC_I B ON A.DOCNO = B.DOCNO
			//				LEFT JOIN MAS_BRAND D ON B.BID = D.BID
			//				LEFT JOIN MAS_TYPE E  ON B.TYID = E.TYID
			//				WHERE A.DOCNO = '" + DOCNO + "' AND A.CFLAG ='0' AND B.CFLAG ='0' AND IT = 1";
			if (WHCODE.Length > 0)
			{
				sql += " AND B.WHCODE = '" + WHCODE + "' ";
			}
			if (STCODE.Length > 0)
			{
				sql += " AND B.STCODE = '" + STCODE + "' ";
			}
			if (TYID.Length > 0)
			{
				sql += " AND  E.NAME  = '" + TYID + "' ";
			}
			if (BID.Length > 0)
			{
				sql += " AND D.BNAME = '" + BID + "' )O";
			}

			DataSet ds = cData.getDataSetWithSqlCommand(_cBeauty.GetConnectionBeautySystem(), sql, 1000, true);

			if (ds.Tables[0].Rows.Count <= 0)
			{
				cMessage.Error_NoData();
				return;
			}

			lsvData.AddDataWithDataset(ds, true, true, false);
			lsvData.SetAlternateColorRow();

		}
		
		private void clareData()
		{
			lsvData.Items.Clear();
			txtscode.Text = "";
			txtwhcode.Text = "";
			_cBeauty._STCODE_LOG = "";
			_cBeauty._DPCODE_LOG = "";
			_cBeauty._STNAME_LOG = "";
		}
		private void cNลดหนToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ListViewItem itemSelect = lsvData.SelectedItems[0];
			string docno = itemSelect.SubItems[1].Text;
			string whcode = itemSelect.SubItems[6].Text;
			string stcode = itemSelect.SubItems[8].Text;
			string net = itemSelect.SubItems[12].Text;
			string TYID = itemSelect.SubItems[4].Text;
			string BID = itemSelect.SubItems[5].Text;
			int ID = int.Parse(itemSelect.SubItems[14].Text);


			frmLOG_CN frm = new frmLOG_CN(_cBeauty, docno, whcode, stcode, net, TYID, BID, ID);
			frm.ShowDialog();

			clareData();
		}
		private void btnExport_Click(object sender, EventArgs e)
		{
			lsvData.ExportToExcelWithStringColumns("3");
		}
		private void โอนยอดระหวางสาขาToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			ListViewItem itemSelect = lsvData.SelectedItems[0];
			string docno = itemSelect.SubItems[1].Text;
			string whcode = itemSelect.SubItems[6].Text;
			string stcode = itemSelect.SubItems[8].Text;
			string net = itemSelect.SubItems[12].Text;
			string TYID = itemSelect.SubItems[4].Text;
			string BID = itemSelect.SubItems[5].Text;
			int ID = int.Parse(itemSelect.SubItems[14].Text);


			frmLOG_WHCODE_new frm = new frmLOG_WHCODE_new(_cBeauty, docno, whcode, stcode, net, TYID, BID, ID);
			frm.ShowDialog();

			clareData();
		}
		private void ขายสงToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ListViewItem itemSelect = lsvData.SelectedItems[0];
			string docno = itemSelect.SubItems[1].Text;
			string whcode = itemSelect.SubItems[6].Text;
			string net = itemSelect.SubItems[12].Text;
			string TYID = itemSelect.SubItems[4].Text;
			string BID = itemSelect.SubItems[5].Text;
			string DVAL = itemSelect.SubItems[13].Text;
			int ID = int.Parse(itemSelect.SubItems[14].Text);


			frmLOG_WholeSale frm = new frmLOG_WholeSale(_cBeauty, docno, whcode, net, TYID, BID, DVAL, ID, "UP");
			frm.ShowDialog();

			clareData();
		}
		private void bnt_add_ws_Click(object sender, EventArgs e)
		{
						
			
			string docno = cmbDOCNO.SelectedValue.ToString();
			string TYID = cmdTYID.SelectedValue.ToString();
			string BID = cmdBID.SelectedValue.ToString();

	
			frmLOG_WholeSale frm = new frmLOG_WholeSale(_cBeauty, docno,  TYID, BID, "IS");
			frm.ShowDialog();

			clareData();
		}
	}
}
