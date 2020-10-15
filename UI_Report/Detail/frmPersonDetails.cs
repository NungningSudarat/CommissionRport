using cBeautyComm;
using kBeauty_Libary.Helper;
using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CommissionRport.Ul_Details
{
	public partial class frmPersonDetails : Form
	{
		ArrayList _menuList;
		cBeauty _cBeauty;
		int _BID;

		public frmPersonDetails(cBeauty cBeauty, int BID, ref ArrayList menuList)
		{
			InitializeComponent();
			_cBeauty = cBeauty;
			_menuList = menuList;
			_BID = BID;
		}

		
		public frmPersonDetails()
		{
			InitializeComponent();
		}

		private void frmPersonDetails_Load(object sender, EventArgs e)
		{
			//string sql_DOCNO = @" SELECT DOCNO FROM COMMISSION_DOC WHERE IT = 1 AND BR = 0  AND CFLAG = 0 ORDER BY DOCNO DESC ";
			string sql_DOCNO = @" SELECT DOCNO FROM COMMISSION_DOC WHERE IT = 1 AND BR = 1  AND CFLAG = 0 ORDER BY CAST(WORKDATE as date) DESC ";
			//string sql_DOCNO = @" SELECT DOCNO FROM COMMISSION_DOC WHERE IT = 1 AND BR = 1   AND BR2 = 1 AND CFLAG = 0 ORDER BY DOCNO DESC ";

			DataSet ds_DOCNO = cData.getDataSetWithSqlCommand(_cBeauty.GetConnectionBeautySystem(), sql_DOCNO, 1000, true);

			cmbDOCNO.BeginUpdate();
			cmbDOCNO.DataSource = ds_DOCNO.Tables[0];
			cmbDOCNO.DisplayMember = "DOCNO";
			cmbDOCNO.ValueMember = "DOCNO";
			cmbDOCNO.EndUpdate();


			lsvData.LabelWrap = false;
			// Add Columns                        
			lsvData.Columns.Add("#", 60, HorizontalAlignment.Right);
			lsvData.Columns.Add("รหัสสาขา", 80, HorizontalAlignment.Left);
			lsvData.Columns.Add("ชื่อสาขา", 80, HorizontalAlignment.Left);
			lsvData.Columns.Add("รหัสพนักงาน", 100, HorizontalAlignment.Left);
			lsvData.Columns.Add("ชื่อพนักงาน", 120, HorizontalAlignment.Left);
			lsvData.Columns.Add("จำนวนบิลขายปกติ", 130, HorizontalAlignment.Left);
			lsvData.Columns.Add("TOTAL NET", 80, HorizontalAlignment.Left);
			lsvData.Columns.Add("AVG (NET/Bills)", 130, HorizontalAlignment.Left);
			lsvData.Columns.Add("จำนวนบิลขายออนไลน์", 150, HorizontalAlignment.Left);
			lsvData.Columns.Add("TOTAL NET", 80, HorizontalAlignment.Left);
			lsvData.Columns.Add("AVG (NET/Bills)", 130, HorizontalAlignment.Left);
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
			SaveData();
		}
		private void SaveData()
		{
			string DOCNO = cmbDOCNO.SelectedValue.ToString();

			string sql = @"EXEC COMMISSION_STCODE '" + DOCNO + "' , '" + _BID + "'";

			DataSet ds = cData.getDataSetWithSqlCommand(_cBeauty.GetConnectionBeautySystem(), sql, 10000, true);

			if (ds.Tables[0].Rows.Count <= 0)
			{
				cMessage.Error_NoData();
				return;
			}

			lsvData.AddDataWithDataset(ds, true, true, false);
			lsvData.SetAlternateColorRow();
		}


		private void btnExport_Click(object sender, EventArgs e)
		{
			lsvData.ExportToExcelWithStringColumns("3");
		}
	}
}
