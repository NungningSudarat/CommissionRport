using cBeautyComm;
using CommissionRport.UI_Report.ComOnline;
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

namespace CommissionRport.UI_Report
{
	public partial class frmCom_OnlineReport : Form
	{
		ArrayList _menuList;
		cBeauty _cBeauty;
		public frmCom_OnlineReport(cBeauty cBeauty,  ref ArrayList menuList)
		{
			InitializeComponent();
			_cBeauty = cBeauty;
			_menuList = menuList;
		}
		public frmCom_OnlineReport()
		{
			InitializeComponent();
		}
		private void frmCom_OnlineReport_Load(object sender, EventArgs e)
		{
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
			lsvData.Columns.Add("รหัสสาขา", 100, HorizontalAlignment.Left);
			lsvData.Columns.Add("ชื่อสาขา", 200, HorizontalAlignment.Left);
			lsvData.Columns.Add("รหัสพนักงาน", 100, HorizontalAlignment.Left);
			lsvData.Columns.Add("ชื่อพนักงาน", 200, HorizontalAlignment.Left);
			lsvData.Columns.Add("TAGET", 120, HorizontalAlignment.Left);
			lsvData.Columns.Add("ยอดขายสาขา", 120, HorizontalAlignment.Left);
			lsvData.Columns.Add("% Ach Online", 120, HorizontalAlignment.Left);
			lsvData.Columns.Add("จำนวนวันทำงาน", 120, HorizontalAlignment.Left);
			lsvData.Columns.Add("Com Online", 130, HorizontalAlignment.Left);

		}
		private void bntSave_Click(object sender, EventArgs e)
		{
			
				GetDatMY();

		}
		private void GetDatMY()
		{

			string sql_day = @"SELECT DAY(DATEADD(MONTH, DATEDIFF(MONTH, 0, DATEADD(MONTH, -1,GETDATE()) ) + 1, 0) - 1 ) AS DAY_s";

			DataSet ds = cData.getDataSetWithSqlCommand(_cBeauty.GetConnectionBeautySystem(), sql_day, 1000, true);
			if (ds.Tables[0].Rows.Count > 0)
			{
				foreach (DataRow dr in ds.Tables[0].Rows)
				{
					txtday.Text = dr["DAY_s"].ToString();
				}
			}

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
					clear();
				}
			}
		}
		private void btnComOnilne_Click(object sender, EventArgs e)
		{
			if (txtday.Text == "" || txtday.Text == null )
			{
				cMessage.Error_NoData();
			}
			else
			{
				SaveData_ComOnline();
				SaveData_ComOnline_NET_Difference();
				GETData_ComOnline_NET();

			}
		}		
		private void SaveData_ComOnline()
		{
			string sql = @"EXEC COMMISSION_Retail_COM '"+ cmbDOCNO.SelectedValue.ToString() + "'";

			DataSet ds = cData.getDataSetWithSqlCommand(_cBeauty.GetConnectionBeautySystem(), sql, 10000, true);

			if (ds.Tables[0].Rows.Count > 0)
			{
				foreach (DataRow dr in ds.Tables[0].Rows)
				{
					double net_TAGETper = double.Parse(dr["net_TAGETper"].ToString());
					string WHCODE = dr["WHCODE"].ToString();
					double net_WHCODE = double.Parse(dr["net_WHCODE"].ToString());
					int sumSTCIODE = int.Parse(dr["sumSTCIODE"].ToString());

					double NET = 0.00; //ค่าคอม 
					double ComOnline_Net_whcode = 0.00; 



					if (net_TAGETper > 100.00)
					{
						NET = (net_WHCODE * 3)/100 ;

						if (NET >= 3000)
						{
							ComOnline_Net_whcode = 3000;
						}
						else
						{
							ComOnline_Net_whcode = NET;
						}
					}
					else if (90.00 < net_TAGETper && net_TAGETper <= 100.00)
					{
						NET = (net_WHCODE * 1.5)/ 100;

						if (NET >= 1000)
						{
							ComOnline_Net_whcode = 1000;
						}
						else
						{
							ComOnline_Net_whcode = NET;
						}
					}
					else if (80.00 < net_TAGETper && net_TAGETper <= 90.00)
					{
						ComOnline_Net_whcode = (net_WHCODE * 1)/ 100;
					}
					else if (net_TAGETper <= 80.00)
					{
						ComOnline_Net_whcode = 0.00;
					}

					double ComOnline_Net_stcode = ComOnline_Net_whcode / sumSTCIODE; 


					SaveData_ComOnline_Net_stcode(WHCODE, ComOnline_Net_stcode, ComOnline_Net_whcode, net_TAGETper, net_WHCODE);
				}
			}
			else
			{
				cMessage.Error_NoData();
				clear();
				return;
			}

		
		}
		private void SaveData_ComOnline_Net_stcode(string WHCODE, double ComOnline_Net_stcode, double ComOnline_Net_whcode, double net_TAGETper, double net_WHCODE)
		{
			string sql_COM = @"UPDATE COMMISSION_TAGET 
								SET 
									DOCNO=@DOCNO,
									net_TAGETper = @net_TAGETper, 
									net_WHCODE = @net_WHCODE, 
									ComOnline_Net_stcode = @ComOnline_Net_stcode, 
									ComOnline_Net_whcode =@ComOnline_Net_whcode,
									WORKDATE_ComOnline = @WORKDATE_ComOnline
								WHERE WHCODE=@WHCODE  AND CFLAG=0";

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
						comm.Parameters.AddWithValue("@DOCNO", cmbDOCNO.SelectedValue.ToString());
						comm.Parameters.AddWithValue("@net_TAGETper", net_TAGETper);
						comm.Parameters.AddWithValue("@net_WHCODE", net_WHCODE);
						comm.Parameters.AddWithValue("@ComOnline_Net_whcode", ComOnline_Net_whcode);
						comm.Parameters.AddWithValue("@ComOnline_Net_stcode", ComOnline_Net_stcode);
						comm.Parameters.AddWithValue("@WORKDATE_ComOnline", _cBeauty._WORKDATE);
						comm.Parameters.AddWithValue("@WHCODE", WHCODE);
						comm.ExecuteNonQuery();

					}
					sqltrans.Commit();

				}
				catch (Exception ex)
				{
					sqltrans.Rollback();
					cMessage.Error_NotCaption(ex.Message);
				}
			}
		}
		private void SaveData_ComOnline_NET_Difference()
		{
			_cBeauty._WORKDATE = cDateTime.GetDateTimeForSql();
			int amount_DAYs = int.Parse(txtday.Text);

			string sql = @"SELECT A.WHCODE,B.STCODE,B.numDAT,A.ComOnline_Net_stcode FROM COMMISSION_TAGET A 
							INNER JOIN  COMMISSION_STCODE_numDAY B
							ON A.WHCODE = B.WHCODE
							WHERE A.CFLAG = 0 AND B.CFLAG= 0 AND ComOnline_Net_stcode IS NOT NULL";

			DataSet ds = cData.getDataSetWithSqlCommand(_cBeauty.GetConnectionBeautySystem(), sql, 10000, true);

			if (ds.Tables[0].Rows.Count > 0)
			{
				foreach (DataRow dr in ds.Tables[0].Rows)
				{
					string WHCODE = dr["WHCODE"].ToString();
					string STCODE = dr["STCODE"].ToString();
					double ComOnline_Net_stcode = double.Parse(dr["ComOnline_Net_stcode"].ToString());
					int numDAT = int.Parse(dr["numDAT"].ToString());
					

					double ComOnline_Net = 0.00;
					double Difference = 0.00;

					if (numDAT == amount_DAYs)
					{
						ComOnline_Net = ComOnline_Net_stcode;
					}
					else if (numDAT < amount_DAYs)
					{
						ComOnline_Net = (ComOnline_Net_stcode * numDAT) / amount_DAYs;

						Difference = ComOnline_Net_stcode - ComOnline_Net;

					}
					//Difference
					string sql_COM = @"UPDATE COMMISSION_STCODE_numDAY 
										SET 
											DOCNO=@DOCNO,
											ComOnline_Net = @ComOnline_Net,											
											Difference	 = @Difference,
											amount_DAYs =@amount_DAYs ,
											WORKDATE_ComOnline = @WORKDATE_ComOnline
										WHERE WHCODE=@WHCODE AND STCODE=@STCODE AND CFLAG=0";

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
								comm.Parameters.AddWithValue("@DOCNO", cmbDOCNO.SelectedValue.ToString());
								comm.Parameters.AddWithValue("@ComOnline_Net", ComOnline_Net);
								comm.Parameters.AddWithValue("@Difference", Difference);
								comm.Parameters.AddWithValue("@amount_DAYs", amount_DAYs);
								comm.Parameters.AddWithValue("@WHCODE", WHCODE);
								comm.Parameters.AddWithValue("@STCODE", STCODE);
								comm.Parameters.AddWithValue("@WORKDATE_ComOnline", _cBeauty._WORKDATE);
								comm.ExecuteNonQuery();

							}
							sqltrans.Commit();

						}
						catch (Exception ex)
						{
							sqltrans.Rollback();
							cMessage.Error_NotCaption(ex.Message);
							return;
						}
					}

				}
				
			}
		}	
		private void GETData_ComOnline_NET()
		{
			string sql = @"EXEC [dbo].[COMMISSION_Retail_COM_NET]";

			DataSet ds = cData.getDataSetWithSqlCommand(_cBeauty.GetConnectionBeautySystem(), sql, 10000, true);

			if (ds.Tables[0].Rows.Count <= 0)
			{
				cMessage.Error_NoData();
				return;
			}

			lsvData.AddDataWithDataset(ds, true, true, false);
			lsvData.SetAlternateColorRow();
		}
		private void btnClose_Click_1(object sender, EventArgs e)
		{
			
			_menuList.Remove(this.Text);
			this.Close();
		}
		private void btnExport_export_Click_1(object sender, EventArgs e)
		{
			lsvData.ExportToExcelWithStringColumns("3");
		}
		private void tAGETToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			frmTaget_Online_ImportDialog frm = new frmTaget_Online_ImportDialog(_cBeauty);
			frm.ShowDialog();
		}
		private void clear()
		{
			txtday.Text = "";
			txtEndDate.Text = "";
			txtEndDateFP.Text = "";
			txtStartDate.Text = "";
			txtStartDateFP.Text = "";
		}
		private void cmbDOCNO_ChangeUICues(object sender, UICuesEventArgs e)
		{
			if (txtday.Text == "" || txtday.Text == null)
			{
				cMessage.Error_NoData();
			}
			else
			{

				GetDatMY();

			}
		}
		private void จำนวนวนพนกงานทำงานToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmNumDay_ImportDialog frm = new frmNumDay_ImportDialog(_cBeauty);
			frm.ShowDialog();
		}
		private void btnSave_Click(object sender, EventArgs e)
		{
			string sql_com = "SELECT * FROM COMMISSION_COM_ONLINE WHERE DOCNO = '" + cmbDOCNO.SelectedValue.ToString() + "'  ";

			DataSet ds_com = cData.getDataSetWithSqlCommand(_cBeauty.GetConnectionBeautySystem(), sql_com, 10000, true);

			if (ds_com.Tables[0].Rows.Count > 0)
			{
			
				string sql_UPDATE = "UPDATE COMMISSION_COM_ONLINE SET CFLAG = 1  WHERE DOCNO = '" + cmbDOCNO.SelectedValue.ToString() + "'  ";
				cData.getDataSetWithSqlCommand(_cBeauty.GetConnectionBeautySystem(), sql_UPDATE, 10000, true);

			}


			string sql_COM = @"INSERT INTO COMMISSION_ONLINE_RETAIL(DOCNO,WHCODE,STCODE,STCODE_AREA,WHGROUP,COM_ONLINE,COM_RETAIL,ACHIEVE,TREATMENT,SERVICE_CHARGE,CARE_COSTS,WORKDATE,CFLAG) 
							VALUES (@DOCNO,@WHCODE,@STCODE,@STCODE_AREA,@WHGROUP,@COM_ONLINE,@COM_RETAIL,@ACHIEVE,@TREATMENT,@SERVICE_CHARGE,@CARE_COSTS,@WORKDATE,@CFLAG)";

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
						for (int i = 0; i < lsvData.Items.Count; i++)
						{
							string WHCODE = lsvData.Items[i].SubItems[1].Text;
							string STCODE = lsvData.Items[i].SubItems[3].Text;
							string COM_ONLINE = lsvData.Items[i].SubItems[9].Text;

						

							comm.Parameters.Clear();


							comm.Parameters.AddWithValue("@DOCNO", cmbDOCNO.SelectedValue.ToString());
							comm.Parameters.AddWithValue("@WHCODE", WHCODE);
							comm.Parameters.AddWithValue("@STCODE", STCODE);
							comm.Parameters.AddWithValue("@STCODE_AREA", DBNull.Value);
							comm.Parameters.AddWithValue("@WHGROUP", DBNull.Value);
							comm.Parameters.AddWithValue("@COM_ONLINE", COM_ONLINE);
							comm.Parameters.AddWithValue("@COM_RETAIL", DBNull.Value);
							comm.Parameters.AddWithValue("@ACHIEVE", DBNull.Value);
							comm.Parameters.AddWithValue("@TREATMENT", DBNull.Value);
							comm.Parameters.AddWithValue("@SERVICE_CHARGE", DBNull.Value);
							comm.Parameters.AddWithValue("@CARE_COSTS", DBNull.Value);
							comm.Parameters.AddWithValue("@WORKDATE", _cBeauty._WORKDATE);
							comm.Parameters.AddWithValue("@CFLAG", 0);
							comm.ExecuteNonQuery();
						}
					}
					sqltrans.Commit();
					cMessage.ShowMessage("บันทึกข้อมูลเรียบร้อย");
					clear();
					lsvData.Items.Clear();
				}
				catch (Exception ex)
				{
					sqltrans.Rollback();
					cMessage.Error_NotCaption(ex.Message);
				}
			}
		}
	}
}
