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

namespace CommissionRport.Ul_Check.Sale
{
	public partial class frmSale : Form
	{
		ArrayList _menuList;
		cBeauty _cBeauty;
		public frmSale()
		{
			InitializeComponent();
		}

		public frmSale(cBeauty cBeauty, ref ArrayList menuList)
		{
			InitializeComponent();
			_cBeauty = cBeauty;
			_menuList = menuList;
		}

		private void frmSale_Load(object sender, EventArgs e)
		{

			lsvData.LabelWrap = false;
			// Add Columns                        
			lsvData.Columns.Add("#", 60, HorizontalAlignment.Right);
			lsvData.Columns.Add("แบรนด์", 80, HorizontalAlignment.Left);
			lsvData.Columns.Add("TYPE", 80, HorizontalAlignment.Left);
			lsvData.Columns.Add("รหัสสาขา", 80, HorizontalAlignment.Left);
			lsvData.Columns.Add("ชื่อสาขา", 80, HorizontalAlignment.Left);
			lsvData.Columns.Add("รหัสพนักงาน", 100, HorizontalAlignment.Left);
			lsvData.Columns.Add("ชื่อพนักงาน", 120, HorizontalAlignment.Left);
			lsvData.Columns.Add("จำนวนบิล", 120, HorizontalAlignment.Left);
			lsvData.Columns.Add("ยอดเงิน", 80, HorizontalAlignment.Left);
			lsvData.Columns.Add("DVAL", 80, HorizontalAlignment.Left);
			lsvData.Columns.Add("TYID", 0, HorizontalAlignment.Left);
			lsvData.Columns.Add("BID", 0, HorizontalAlignment.Left);

			LoadDocno();
		}

		private void LoadDocno()
		{
			txtDOCNO.Text = _cBeauty.GetRunningDocno( _cBeauty._TYPE_COM);
		}
		private void runDOC()
		{
			txtDOCNO.Text = _cBeauty.RunDOC(_cBeauty._TYPE_COM);
		}
		private void btnClose_Click(object sender, EventArgs e)
		{
			_menuList.Remove(this.Text);
			this.Close();
		}
		private void bntSave_Click(object sender, EventArgs e)
		{
			GetData();
		}
		private void GetData()
		{
			cMessage.ShowMessage("กรุณารอสักครู่ กำลังดำเนินการ");
			string sql = @"SELECT  B.BNAME,C.NAME,A.WHCODE,A.WHNAME,A.STCODE,A.FULLNAME,A.ABBNO,A.NET,A.DVAL ,A.TYID,A.BID
							FROM CHF_COMMISSION_COMONLINE ('" + dtp_StartDate.getDateOnlyForSql() + "','" + dtp_EndDate.getDateOnlyForSql() + "','" + dtp_StartDateFP.getDateOnlyForSql() + "','" + dtp_EndDateFP.getDateOnlyForSql() + "') A";
			sql += @" LEFT JOIN MAS_BRAND B ON A.BID=B.BID
						    LEFT JOIN MAS_TYPE C ON A.TYID=C.TYID
							ORDER BY A.TYID,A.BID,A.WHCODE,A.STCODE";
		
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

		
		private void btnSumbit_Click(object sender, EventArgs e)
		{

			if (txtMONTH.Text.Length <= 0 || txtYEAR.Text.Length <= 0 || txtDOCNO.Text.Length <= 0 || lsvData.Items.Count <= 0)
			{
				cMessage.Error_InvalidData();
				return;
			}

			frmLogin frm = new frmLogin(_cBeauty, "IT");
			frm.ShowDialog();

			if (_cBeauty._STCODE_LOG == null || _cBeauty._STCODE_LOG == "" || _cBeauty._DPCODE_LOG == null || _cBeauty._DPCODE_LOG == ""
				|| _cBeauty._STNAME_LOG == null || _cBeauty._STNAME_LOG == "")
			{
				cMessage.Error_InvalidData();
				return;
				
			} else
			{
				SaveData();

				LoadDocno();
			}

		}
	
		private void SaveData()
		{
			cMessage.ShowMessage("กรุณารอสักครู่ กำลังดำเนินการ");
			string sql_COM = @"INSERT INTO COMMISSION_DOC(DOCNO,MONTH,YEAR,StartDate,EndDate,StartDate_FP,EndDate_FP,WORKDATE,IT_STCODE,IT,IT_DATE,BR_STCODE,BR,BR_DATE,CFLAG) 
							VALUES (@DOCNO,@MONTH,@YEAR,@StartDate,@EndDate,@StartDate_FP,@EndDate_FP,@WORKDATE,@IT_STCODE,@IT,@IT_DATE,@BR_STCODE,@BR,@BR_DATE,@CFLAG)";

			//string sql_COM_I = @"INSERT INTO COMMISSION_DOC_I (DOCNO,WHCODE,BID,TYID,WHNAME,STCODE,STNAME,ABBNO,NET,NET_TOTAL,DVAL,CFLAG)
			//                                     VALUES(@DOCNO,@WHCODE,@BID,@TYID,@WHNAME,@STCODE,@STNAME,@ABBNO,@NET,@NET_TOTAL,@DVAL,@CFLAG)";
			string sql_COM_I = @"INSERT INTO COMMISSION_DOC_I (DOCNO,WHCODE,BID,TYID,STCODE,ABBNO,NET,NET_TOTAL,DVAL,CFLAG)
			                                     VALUES(@DOCNO,@WHCODE,@BID,@TYID,@STCODE,@ABBNO,@NET,@NET_TOTAL,@DVAL,@CFLAG)";

			_cBeauty._WORKDATE = cDateTime.GetDateTimeForSql();


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

						comm.CommandText = sql_COM;
						comm.Parameters.Clear();
						comm.Parameters.AddWithValue("@DOCNO", txtDOCNO.Text);
						comm.Parameters.AddWithValue("@MONTH", txtMONTH.Text);
						comm.Parameters.AddWithValue("@YEAR", txtYEAR.Text);
						comm.Parameters.AddWithValue("@StartDate", dtp_StartDate.Value);
						comm.Parameters.AddWithValue("@EndDate", dtp_EndDate.Value);
						comm.Parameters.AddWithValue("@StartDate_FP", dtp_StartDateFP.Value);
						comm.Parameters.AddWithValue("@EndDate_FP", dtp_EndDateFP.Value);
						comm.Parameters.AddWithValue("@WORKDATE", _cBeauty._WORKDATE);
						comm.Parameters.AddWithValue("@IT_STCODE", _cBeauty._STCODE_LOG);
						comm.Parameters.AddWithValue("@IT", 1);
						comm.Parameters.AddWithValue("@IT_DATE", _cBeauty._WORKDATE);
						comm.Parameters.AddWithValue("@BR_STCODE", DBNull.Value);
						comm.Parameters.AddWithValue("@BR", 0);
						comm.Parameters.AddWithValue("@BR_DATE", DBNull.Value);
						comm.Parameters.AddWithValue("@CFLAG", 0);
						comm.ExecuteNonQuery();


						foreach (ListViewItem item in lsvData.Items)
						{
							string BID = item.SubItems[11].Text;
							string TYID = item.SubItems[10].Text;
							string WHCODE = item.SubItems[3].Text;
							//string WHNAME = item.SubItems[4].Text;
							string STCODE = item.SubItems[5].Text;
							//string STNAME = item.SubItems[6].Text;
							string NET	  =item.SubItems[8].Text;
							string DVAL   = item.SubItems[9].Text;
							string ABBNO = item.SubItems[7].Text;

							
							comm.CommandText = sql_COM_I;
							comm.Parameters.Clear();
							comm.Parameters.AddWithValue("@DOCNO", txtDOCNO.Text);
							comm.Parameters.AddWithValue("@WHCODE", WHCODE);
							comm.Parameters.AddWithValue("@BID", BID);
							comm.Parameters.AddWithValue("@TYID", TYID);
							//comm.Parameters.AddWithValue("@WHNAME", WHNAME);
							comm.Parameters.AddWithValue("@STCODE", STCODE);
							//comm.Parameters.AddWithValue("@STNAME", STNAME);
							comm.Parameters.AddWithValue("@ABBNO", ABBNO);
							comm.Parameters.AddWithValue("@NET", double.Parse(NET));
							comm.Parameters.AddWithValue("@NET_TOTAL", double.Parse(NET));
							comm.Parameters.AddWithValue("@DVAL", DVAL);
							comm.Parameters.AddWithValue("@CFLAG", 0);
							comm.ExecuteNonQuery();
						}
						
					}
					sqltrans.Commit();
					cMessage.ShowMessage("บันทึกข้อมูลเรียบร้อย");
					clareData();
					runDOC();
				}
				catch (Exception ex)
				{
					sqltrans.Rollback();
					cMessage.Error_NotCaption(ex.Message);
					clareData();
				}
			}
		}

		private void clareData()
		{
			txtMONTH.Text = "";
			txtYEAR.Text = "";
			lsvData.Items.Clear();
			_cBeauty._STCODE_LOG = "";
			_cBeauty._DPCODE_LOG = "";
			_cBeauty._STNAME_LOG = "";
		}

		private void toolStripSeparator1_Click(object sender, EventArgs e)
		{

		}
	}
}
