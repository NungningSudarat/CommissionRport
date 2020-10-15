using cBeautyComm;
using CommissionRport.Ul_Login;
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

namespace CommissionRport.Ul_Approve
{
	public partial class frmBR_Approve : Form
	{
		cBeauty _cBeauty;
		ArrayList _menuList;
		public frmBR_Approve()
		{
			InitializeComponent();
		}
		public frmBR_Approve(cBeauty cBeauty, ref ArrayList menuList)
		{
			InitializeComponent();
			_cBeauty = cBeauty;
			_menuList = menuList;
		}
		private void BR_Approve_Load(object sender, EventArgs e)
		{
			Init();

			lsvData.LabelWrap = false;
			// Add Columns                        
			lsvData.Columns.Add("#", 60, HorizontalAlignment.Right);
			lsvData.Columns.Add("รหัสสาขา", 80, HorizontalAlignment.Left);
			//lsvData.Columns.Add("ชื่อสาขา", 80, HorizontalAlignment.Left);
			lsvData.Columns.Add("จำนวนบิลขายปกติ", 130, HorizontalAlignment.Left);
			lsvData.Columns.Add("TOTAL NET", 80, HorizontalAlignment.Left);
			lsvData.Columns.Add("AVG (NET/Bills)", 130, HorizontalAlignment.Left);
			lsvData.Columns.Add("จำนวนบิลขายออนไลน์", 150, HorizontalAlignment.Left);
			lsvData.Columns.Add("TOTAL NET", 80, HorizontalAlignment.Left);
			lsvData.Columns.Add("AVG (NET/Bills)", 130, HorizontalAlignment.Left);
			lsvData.Columns.Add("จำนวนบิลขายส่ง 20 %", 150, HorizontalAlignment.Left); ;
			lsvData.Columns.Add("TOTAL NET", 80, HorizontalAlignment.Left);
			lsvData.Columns.Add("AVG (NET/Bills)", 130, HorizontalAlignment.Left);
			lsvData.Columns.Add("จำนวนบิลขายส่ง 30 %", 150, HorizontalAlignment.Left); ;
			lsvData.Columns.Add("TOTAL NET", 80, HorizontalAlignment.Left);
			lsvData.Columns.Add("AVG (NET/Bills)", 130, HorizontalAlignment.Left);
			lsvData.Columns.Add("จำนวนบิลขายส่ง 35 %", 150, HorizontalAlignment.Left); ;
			lsvData.Columns.Add("TOTAL NET", 80, HorizontalAlignment.Left);
			lsvData.Columns.Add("AVG (NET/Bills)", 130, HorizontalAlignment.Left);
			lsvData.Columns.Add("จำนวนบิลขายส่ง 40 %", 150, HorizontalAlignment.Left); ;
			lsvData.Columns.Add("TOTAL NET", 80, HorizontalAlignment.Left);
			lsvData.Columns.Add("AVG (NET/Bills)", 130, HorizontalAlignment.Left);
			lsvData.Columns.Add("จำนวนบิลขายส่ง 45 %", 150, HorizontalAlignment.Left); ;
			lsvData.Columns.Add("TOTAL NET", 80, HorizontalAlignment.Left);
			lsvData.Columns.Add("AVG (NET/Bills)", 130, HorizontalAlignment.Left);
			
			//lsvData.LabelWrap = false;
			//// Add Columns                        
			//lsvData.Columns.Add("#", 60, HorizontalAlignment.Right);
			//lsvData.Columns.Add("เลขที่เอกสาร", 120, HorizontalAlignment.Left);
			//lsvData.Columns.Add("เดือน", 80, HorizontalAlignment.Left);
			//lsvData.Columns.Add("ปี", 80, HorizontalAlignment.Left);
			//lsvData.Columns.Add("TYPE", 80, HorizontalAlignment.Left);
			//lsvData.Columns.Add("BRAND", 80, HorizontalAlignment.Left);
			//lsvData.Columns.Add("รหัสสาขา", 80, HorizontalAlignment.Left);
			//lsvData.Columns.Add("ชื่อสาขา", 100, HorizontalAlignment.Left);
			//lsvData.Columns.Add("รหัสพนักงาน", 80, HorizontalAlignment.Left);
			//lsvData.Columns.Add("ชื่อพนักงาน", 200, HorizontalAlignment.Left);
			//lsvData.Columns.Add("ยอดเงิน", 80, HorizontalAlignment.Left);
			//lsvData.Columns.Add("DVAL", 80, HorizontalAlignment.Left);
			////lsvData.Columns.Add("ID", 0, HorizontalAlignment.Left);
		}

		private void Init()
		{

			string sql_DOCNO = @" SELECT DOCNO FROM COMMISSION_DOC WHERE IT = 1  AND BR = 0 AND CFLAG = 0 ORDER BY DOCNO DESC ";

			DataSet ds_DOCNO = cData.getDataSetWithSqlCommand(_cBeauty.GetConnectionBeautySystem(), sql_DOCNO, 1000, true);

			cmbDOCNO.BeginUpdate();
			cmbDOCNO.DataSource = ds_DOCNO.Tables[0];
			cmbDOCNO.DisplayMember = "DOCNO";
			cmbDOCNO.ValueMember = "DOCNO";
			cmbDOCNO.EndUpdate();

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
			string DOCNO = cmbDOCNO.SelectedValue.ToString();

			string sql = @"EXEC COMMISSION_WHCODE_APPROVE_BR '" + DOCNO + "'";

			DataSet ds = cData.getDataSetWithSqlCommand(_cBeauty.GetConnectionBeautySystem(), sql, 10000, true);

			if (ds.Tables[0].Rows.Count <= 0)
			{
				cMessage.Error_NoData();
				return;
			}

			lsvData.AddDataWithDataset(ds, true, true, false);
			lsvData.SetAlternateColorRow();

			//string DOCNO = cmbDOCNO.SelectedValue.ToString();

			//string sql = @"SELECT A.DOCNO,A.MONTH,A.YEAR,E.NAME,D.BNAME,B.WHCODE,B.WHNAME,B.STCODE,B.STNAME,B.NET_TOTAL,B.DVAL,B.ID
			//				FROM COMMISSION_DOC A
			//				LEFT JOIN COMMISSION_DOC_I B ON A.DOCNO = B.DOCNO
			//				LEFT JOIN MAS_BRAND D ON B.BID = D.BID
			//				LEFT JOIN MAS_TYPE E  ON B.TYID = E.TYID
			//				WHERE A.DOCNO = '" + DOCNO + "' AND A.CFLAG ='0' AND B.CFLAG ='0'";

			//DataSet ds = cData.getDataSetWithSqlCommand(_cBeauty.GetConnectionBeautySystem(), sql, 1000, true);

			//if (ds.Tables[0].Rows.Count <= 0)
			//{
			//	cMessage.Error_NoData();
			//	return;
			//}

			//lsvData.AddDataWithDataset(ds, true, true, false);
			//lsvData.SetAlternateColorRow();
		}

	
		private void login()
		{
			if (lsvData.Items.Count <= 0)
			{
				return;
			}
			else
			{
				frmLogin frm = new frmLogin(_cBeauty, "OP-BB");
				frm.ShowDialog();
				
			}
		}

		private void btnApprove_Click(object sender, EventArgs e)
		{
			login();

			if (_cBeauty._STCODE_LOG == null || _cBeauty._STCODE_LOG == "" || _cBeauty._DPCODE_LOG == null || _cBeauty._DPCODE_LOG == ""
					|| _cBeauty._STNAME_LOG == null || _cBeauty._STNAME_LOG == "")
			{
				cMessage.Error_InvalidData();
				return;

			}

			_cBeauty._WORKDATE = cDateTime.GetDateTimeForSql();

			string sql = @"UPDATE COMMISSION_DOC SET BR_STCODE = @BR_STCODE, BR = @BR, BR_DATE = @BR_DATE WHERE DOCNO =@DOCNO";
			using (SqlConnection conn = new SqlConnection(_cBeauty.GetConnectionBeautySystem()))
			{
				conn.Open();
				SqlTransaction sqltrans = null;
				sqltrans = conn.BeginTransaction();
				try
				{
					using (SqlCommand comm = new SqlCommand())
					{
						comm.CommandType = CommandType.Text;
						comm.CommandTimeout = 1000;
						comm.Connection = conn;
						comm.Transaction = sqltrans;

						comm.CommandText = sql;
						comm.Parameters.Clear();
						comm.Parameters.AddWithValue("@DOCNO", cmbDOCNO.SelectedValue.ToString());
						comm.Parameters.AddWithValue("@BR_STCODE", _cBeauty._STCODE_LOG);
						comm.Parameters.AddWithValue("@BR", 1);
						comm.Parameters.AddWithValue("@BR_DATE", _cBeauty._WORKDATE);
						comm.ExecuteNonQuery();
					}
					sqltrans.Commit();
					cMessage.ShowMessage("บันทึกข้อมูลเรียบร้อย");
				}
				catch (Exception ex)
				{
					sqltrans.Rollback();
					cMessage.Error_NotCaption(ex.Message);
				}
				clareData();
				Init();
			}
		}

		private void btnNoApprove_Click(object sender, EventArgs e)
		{
			login();

			if (_cBeauty._STCODE_LOG == null || _cBeauty._STCODE_LOG == "" || _cBeauty._DPCODE_LOG == null || _cBeauty._DPCODE_LOG == ""
					|| _cBeauty._STNAME_LOG == null || _cBeauty._STNAME_LOG == "")
			{
				cMessage.Error_InvalidData();
				return;

			}

			_cBeauty._WORKDATE = cDateTime.GetDateTimeForSql();

			string sql = @"UPDATE COMMISSION_DOC SET BR_STCODE = @BR_STCODE, BR = @BR, BR_DATE = @BR_DATE WHERE DOCNO =@DOCNO";
			using (SqlConnection conn = new SqlConnection(_cBeauty.GetConnectionBeautySystem()))
			{
				conn.Open();
				SqlTransaction sqltrans = null;
				sqltrans = conn.BeginTransaction();
				try
				{
					using (SqlCommand comm = new SqlCommand())
					{
						comm.CommandType = CommandType.Text;
						comm.CommandTimeout = 1000;
						comm.Connection = conn;
						comm.Transaction = sqltrans;

						comm.CommandText = sql;
						comm.Parameters.Clear();
						comm.Parameters.AddWithValue("@DOCNO", cmbDOCNO.SelectedValue.ToString());
						comm.Parameters.AddWithValue("@BR_STCODE", _cBeauty._STCODE_LOG);
						comm.Parameters.AddWithValue("@BR", 2);
						comm.Parameters.AddWithValue("@BR_DATE", _cBeauty._WORKDATE);
						comm.ExecuteNonQuery();
					}
					sqltrans.Commit();
					cMessage.ShowMessage("บันทึกข้อมูลเรียบร้อย");

				}
				catch (Exception ex)
				{
					sqltrans.Rollback();
					cMessage.Error_NotCaption(ex.Message);
				}
				clareData();
				Init();
			}
		}

		private void toolStripButton2_Click(object sender, EventArgs e)
		{
			_menuList.Remove(this.Text);
			this.Close();
		}

		private void clareData()
		{
		
			lsvData.Items.Clear();
			_cBeauty._STCODE_LOG = "";
			_cBeauty._DPCODE_LOG = "";
			_cBeauty._STNAME_LOG = "";
		}

		private void btnExport_Click(object sender, EventArgs e)
		{
			lsvData.ExportToExcelWithStringColumns("3");
		}
	}
}
