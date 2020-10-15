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

namespace CommissionRport.UI_Report.ComOnline
{

	public partial class frmCom_RetailReport : Form
	{
		private cBeauty _cBeauty;
		private ArrayList _menuList;

		//RT
		double WH_COM_RETAIL_RT;

		//ค่าดูแลสาขา
		double WH_CARE_COSTS_RT;
		double WH_CARE_COSTS_WS;


		//WS
		double WH_COM_RETAIL_WS;

		//บริหารร้าน
		double WH_SERVICE_CHARGE;


		//ACHIEVE
		double WH_ACHIEVE;


		//ค่ารักษาสินค้า
		double WH_TREATMENT;



		int day;
		double ComRT = 0.00;
		double DifRT = 0.00;
		double ComCARE_COSTS = 0.00;
		double DifCARE_COSTS = 0.00;
		public frmCom_RetailReport()
		{
			InitializeComponent();
		}

		public frmCom_RetailReport(cBeauty cBeauty, ref ArrayList menuList)
		{
			InitializeComponent();
			_cBeauty = cBeauty;
			_menuList = menuList;
		}

		private void frmCom_RetailReport_Load(object sender, EventArgs e)
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
			lsvData.Columns.Add("ชื่อสาขา", 100, HorizontalAlignment.Left);
			lsvData.Columns.Add("รหัสพนักงาน", 100, HorizontalAlignment.Left);
			lsvData.Columns.Add("ชื่อพนักงาน", 200, HorizontalAlignment.Left);
			lsvData.Columns.Add("รหัสแอร์เรีย", 100, HorizontalAlignment.Left);
			lsvData.Columns.Add("ชื่อแอร์เรีย", 200, HorizontalAlignment.Left);
			lsvData.Columns.Add("WHGROUP", 100, HorizontalAlignment.Left);
			lsvData.Columns.Add("คอมสาขา COM_RETAIL", 120, HorizontalAlignment.Left);
			lsvData.Columns.Add("ACHIEVE", 120, HorizontalAlignment.Left);
			lsvData.Columns.Add("ค่ารักษาสินค้า TREATMENT", 120, HorizontalAlignment.Left);
			lsvData.Columns.Add("ค่าบริหาร SERVICE_CHARGE", 120, HorizontalAlignment.Left);
			lsvData.Columns.Add("ดูแลสาขา CARE_COSTS", 130, HorizontalAlignment.Left);
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
		private void clear()
		{
			txtday.Text = "";
			txtEndDate.Text = "";
			txtEndDateFP.Text = "";
			txtStartDate.Text = "";
			txtStartDateFP.Text = "";
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			_menuList.Remove(this.Text);
			this.Close();
		}

		private void btnExport_export_Click(object sender, EventArgs e)
		{
			lsvData.ExportToExcelWithStringColumns("3");
		}

		private void btnComOnilne_Click(object sender, EventArgs e)
		{
			if (txtday.Text == "" || txtday.Text == null)
			{
				cMessage.Error_NoData();
			}
			else
			{
				 day = int.Parse(txtday.Text);
				data_RT();
				//data_WS();
				//data();
				
			}
		}
		
		private void data_RT()
		{
			string sql = @"SELECT AA.WHCODE,NET,TAGET_RT,sumSTCIODE FROM
							(
								SELECT WHCODE,NET,CAST(ISNULL(NET,0)/ISNULL(TAGET,0) AS decimal(15,2) ) AS TAGET_RT 
								FROM COMMISSION_TAGET_RETAIL
							 )
							 AA
							INNER JOIN (
								SELECT WHCODE , COUNT(STCODE) AS sumSTCIODE 
								FROM COMMISSION_STCODE_numDAY
								WHERE CFLAG = 0 GROUP BY WHCODE
							)BB
							ON AA.WHCODE= BB.WHCODE ";

			DataSet ds = cData.getDataSetWithSqlCommand(_cBeauty.GetConnectionBeautySystem(), sql, 10000, true);

			if (ds.Tables[0].Rows.Count > 0)
			{
				foreach (DataRow dr in ds.Tables[0].Rows)
				{
					string WHCODE = dr["WHCODE"].ToString();
					double NET_RT = double.Parse(dr["NET"].ToString());
					double AVG_TAGET_RT = double.Parse(dr["TAGET_RT"].ToString());
					double sumSTCIODE_RT = double.Parse(dr["sumSTCIODE"].ToString());


					if (AVG_TAGET_RT > 100.00)
					{
						WH_COM_RETAIL_RT = ((NET_RT * 3) / 100) / sumSTCIODE_RT;						
					}
					else if (90.00 < AVG_TAGET_RT && AVG_TAGET_RT <= 100.00)
					{
						WH_COM_RETAIL_RT = ( (NET_RT * 2.25) / 100 ) / sumSTCIODE_RT;
					}
					else if (80.00 < AVG_TAGET_RT && AVG_TAGET_RT <= 90.00)
					{
						WH_COM_RETAIL_RT = ( (NET_RT * 1.75) / 100 ) / sumSTCIODE_RT;
					}
					else if (AVG_TAGET_RT <= 80.00)
					{
						WH_CARE_COSTS_RT = ( (NET_RT * 1) / 100 ) / sumSTCIODE_RT;
					}

					string sql_numDay = @"SELECT  STCODE,numDAT,STCODE_AREA,WHGROUP,ID_Position
											FROM COMMISSION_STCODE_numDAY A
											LEFT JOIN COMMISSION_TAGET_RETAIL B
											ON A.WHCODE = B.WHCODE WHERE A.WHCODE = '" + WHCODE + "'";

					DataSet ds2 = cData.getDataSetWithSqlCommand(_cBeauty.GetConnectionBeautySystem(), sql_numDay, 1000, true);

					if (ds2.Tables[0].Rows.Count >0)
					{
						foreach (DataRow dr2 in ds2.Tables[0].Rows)
						{
							string STCODE = dr2["STCODE"].ToString();
							string STCODE_AREA = dr2["STCODE_AREA"].ToString();
							string WHGROUP = dr2["WHGROUP"].ToString();
							string ID_Position = dr2["ID_Position"].ToString();
							int numDAT = int.Parse(dr2["numDAT"].ToString());
							
							//Com RT รายคน
							if (WH_COM_RETAIL_RT >= 0)
							{
								if (numDAT < day)
								{
									ComRT = (WH_COM_RETAIL_RT * numDAT) / day;

									DifRT = WH_COM_RETAIL_RT - ComRT;

								}
								else if (numDAT == day)
								{
									ComRT = WH_COM_RETAIL_RT;
								}
							}


							//ค่าดูแลสาขา รายคน
							if (WH_CARE_COSTS_RT >= 0)
							{
								if (numDAT < day)
								{
									ComCARE_COSTS = (WH_CARE_COSTS_RT * numDAT) / day;

									DifCARE_COSTS = WH_COM_RETAIL_RT - ComCARE_COSTS;

								}
								else if (numDAT == day)
								{
									ComCARE_COSTS = WH_CARE_COSTS_RT;
								}
							}


							//	save
							string inset_COM = @"INSERT INTO COMMISSON_COM_RETAIL";
							using (SqlConnection con = new SqlConnection(_cBeauty.GetConnectionBeautySystem()))
							{
								con.Open();
								SqlTransaction sqltrans = null;
								sqltrans = con.BeginTransaction();
								try
								{
									using (SqlCommand comm = new SqlCommand())
									{
										comm.CommandType = CommandType.Text;
										comm.CommandTimeout = 1000;
										comm.Connection = con;
										comm.Transaction = sqltrans;

										comm.CommandText = inset_COM;
										comm.Parameters.Clear();
										comm.Parameters.AddWithValue("@DOCNO", cmbDOCNO.SelectedValue.ToString());
										comm.Parameters.AddWithValue("@WHCODE", WHCODE);
										comm.Parameters.AddWithValue("@STCODE_AREA", STCODE_AREA);
										comm.Parameters.AddWithValue("@STCODE", STCODE);
										comm.Parameters.AddWithValue("@ID_Position", ID_Position);
										comm.Parameters.AddWithValue("@WHGROUP", WHGROUP);
										comm.Parameters.AddWithValue("@numDAT", numDAT);
										comm.Parameters.AddWithValue("@amount_DAYs", day);
										comm.Parameters.AddWithValue("@ComRT", ComRT);
										comm.Parameters.AddWithValue("@DifRT", DifRT);
										comm.Parameters.AddWithValue("@ComCARE_COSTS", ComCARE_COSTS);
										comm.Parameters.AddWithValue("@DifCARE_COSTS", DifCARE_COSTS);
										comm.ExecuteNonQuery();
									}
								}
								catch ( Exception ex)
								{
									sqltrans.Rollback();
									cMessage.Error_NotCaption(ex.Message);
								}
							}
						}
						
					}
					

				}
			}
		}
		private void data_WS()
		{
			string sql = @"SELECT AA.WHCODE,NET_WS,TAGET_WS,sumSTCIODE FROM
							(
								SELECT WHCODE,NET_WS,CAST(ISNULL(NET_WS,0)/ISNULL(TAGET_WS,0) AS decimal(15,2) ) AS TAGET_WS 
								FROM COMMISSION_TAGET_RETAIL
								WHERE NET_WS <> 0 OR TAGET_WS <> 0
							 )
							 AA
							INNER JOIN (
								SELECT WHCODE , COUNT(STCODE) AS sumSTCIODE 
								FROM COMMISSION_STCODE_numDAY
								WHERE CFLAG = 0 GROUP BY WHCODE
							)BB
							ON AA.WHCODE= BB.WHCODE";

			DataSet ds = cData.getDataSetWithSqlCommand(_cBeauty.GetConnectionBeautySystem(), sql, 10000, true);

			if (ds.Tables[0].Rows.Count > 0)
			{
				foreach (DataRow dr in ds.Tables[0].Rows)
				{
					string WHCODE = dr["WHCODE"].ToString();
					double NET_WS = double.Parse(dr["NET_WS"].ToString());
					double AVG_TAGET_WS = double.Parse(dr["TAGET_WS"].ToString());
					double sumSTCIODE_RT = double.Parse(dr["sumSTCIODE"].ToString());

					if (AVG_TAGET_WS > 100.00)
					{
						WH_COM_RETAIL_WS = ( (NET_WS * 0.80) / 100 ) / sumSTCIODE_RT;

					}
					else if (90.00 < AVG_TAGET_WS && AVG_TAGET_WS <= 100.00)
					{
						WH_COM_RETAIL_WS = ( (NET_WS * 0.50) / 100 ) / sumSTCIODE_RT;
					}
					else if (80.00 < AVG_TAGET_WS && AVG_TAGET_WS <= 90.00)
					{
						WH_COM_RETAIL_RT = ( (NET_WS * 0.40) / 100 ) / sumSTCIODE_RT;
					}
					else if (AVG_TAGET_WS <= 80.00)
					{
						WH_CARE_COSTS_WS =  ( (NET_WS * 0.40) / 100 ) / sumSTCIODE_RT;
					}

				}
			}
		}
		private void data()
		{
			string sql = @"SELECT AA.WHCODE,WHGROUP,STCODE_area,SHOPCARE,NET,AVG_TAGET,sumSTCIODE ,ID_Position
							FROM
							(
							SELECT WHCODE,WHGROUP,STCODE_area,SHOPCARE,
							CAST(ISNULL(NET+NET_WS,0) AS decimal(15,2) ) AS NET,
							CAST(ISNULL(NET+NET_WS,0)/ISNULL(TAGET+TAGET_WS,0) AS decimal(15,2) ) AS AVG_TAGET
							FROM COMMISSION_TAGET_RETAIL
							 )
							 AA
							INNER JOIN (
								SELECT WHCODE , COUNT(STCODE) AS sumSTCIODE ,ID_Position
								FROM COMMISSION_STCODE_numDAY
								WHERE CFLAG = 0 GROUP BY WHCODE
							)BB
							ON AA.WHCODE= BB.WHCODE ";

			DataSet ds = cData.getDataSetWithSqlCommand(_cBeauty.GetConnectionBeautySystem(), sql, 10000, true);

			if (ds.Tables[0].Rows.Count > 0)
			{
				foreach (DataRow dr in ds.Tables[0].Rows)
				{
					double NET = double.Parse(dr["NET"].ToString());
					double AVG_TAGET = double.Parse(dr["AVG_TAGET"].ToString());
					double SHOPCARE = double.Parse(dr["SHOPCARE"].ToString());
					string WHGROUP = dr["WHGROUP"].ToString();
					string ID_Position = dr["ID_Position"].ToString();
					string WHCODE = dr["WHCODE"].ToString();
					double sumSTCIODE_RT = double.Parse(dr["sumSTCIODE"].ToString());
					
					//ค่าบริหาร SERVICE_CHARGE
					if (AVG_TAGET > 100.00)
					{
						WH_SERVICE_CHARGE = ( (NET * 0.35) / 100 ) / sumSTCIODE_RT;

					}
					else if (90.00 < AVG_TAGET && AVG_TAGET <= 100.00)
					{
						WH_SERVICE_CHARGE = ( (AVG_TAGET * 0.30) / 100 ) / sumSTCIODE_RT;
					}
					else if (80.00 < AVG_TAGET && AVG_TAGET <= 90.00)
					{
						WH_SERVICE_CHARGE = ( (NET * 0.25) / 100 ) / sumSTCIODE_RT;
					}


					//ACHIEVE
					//P001 ผู้จัดการสาขา-บิ้วตี้ บุฟเฟต์
					//P002 ผู้จัดการสาขาฝึกหัด-บิ้วตี้ บุฟเฟต์
					//P004 พนักงานแต่งหน้า
					//P006 พนักงานแนะนำความงาม-บิ้วตี้ บุฟเฟต์
					if (ID_Position == "P001" || ID_Position == "P002")
					{
						if (AVG_TAGET > 105.00)
						{
							if (WHGROUP == "A")
							{
								WH_ACHIEVE = 4000;
							}
							else if (WHGROUP == "B")
							{
								WH_ACHIEVE = 3000;
							}
							else if (WHGROUP == "C")
							{
								WH_ACHIEVE = 2000;
							}
							else if (WHGROUP == "D")
							{
								WH_ACHIEVE = 1000;
							}

						}
						else if (110.00 < AVG_TAGET && AVG_TAGET <= 105.00)
						{
							if (WHGROUP == "A")
							{
								WH_ACHIEVE = 8000;
							}
							else if (WHGROUP == "B")
							{
								WH_ACHIEVE = 6000;
							}
							else if (WHGROUP == "C")
							{
								WH_ACHIEVE = 4000;
							}
							else if (WHGROUP == "D")
							{
								WH_ACHIEVE = 3000;
							}
						}
					}
					


					//ค่ารักษาสินค้า TREATMENT
					if (SHOPCARE ==  0) //สินค้าศูนย์หาย
					{
						WH_TREATMENT = (NET * 0.20) / 100;

					}
					else if (SHOPCARE ==1) //สินค้าไม่ศูนย์หาย
					{
						WH_TREATMENT = (NET * 0.25) / 100;
					}
				}
			}
		}

		
		


		//save
		private void btnSave_Click(object sender, EventArgs e)
		{
			//string sql_COM = @"INSERT INTO COMMISSION_ONLINE_RETAIL(DOCNO,WHCODE,STCODE,STCODE_AREA,WHGROUP,COM_ONLINE,COM_RETAIL,ACHIEVE,TREATMENT,SERVICE_CHARGE,CARE_COSTS,WORKDATE,CFLAG) 
			//				VALUES (@DOCNO,@WHCODE,@STCODE,@STCODE_AREA,@WHGROUP,@COM_ONLINE,@COM_RETAIL,@ACHIEVE,@TREATMENT,@SERVICE_CHARGE,@CARE_COSTS,@WORKDATE,@CFLAG)";

			//_cBeauty._WORKDATE = cDateTime.GetDateTimeForSql();

			//using (SqlConnection conn = new SqlConnection(_cBeauty.GetConnectionBeautySystem()))
			//{
			//	conn.Open();
			//	SqlTransaction sqltrans = null;
			//	sqltrans = conn.BeginTransaction();
			//	try
			//	{
			//		using (SqlCommand comm = new SqlCommand())
			//		{
			//			comm.CommandType = CommandType.Text;
			//			comm.CommandTimeout = 1000;
			//			comm.Connection = conn;
			//			comm.Transaction = sqltrans;

			//			comm.CommandText = sql_COM;
			//			for (int i = 0; i < lsvData.Items.Count; i++)
			//			{
			//				string WHCODE = lsvData.Items[i].SubItems[1].Text;
			//				string STCODE = lsvData.Items[i].SubItems[3].Text;
			//				string COM_ONLINE = lsvData.Items[i].SubItems[9].Text;



			//				comm.Parameters.Clear();


			//				comm.Parameters.AddWithValue("@DOCNO", cmbDOCNO.SelectedValue.ToString());
			//				comm.Parameters.AddWithValue("@WHCODE", WHCODE);
			//				comm.Parameters.AddWithValue("@STCODE", STCODE);
			//				comm.Parameters.AddWithValue("@STCODE_AREA", DBNull.Value);
			//				comm.Parameters.AddWithValue("@WHGROUP", DBNull.Value);
			//				comm.Parameters.AddWithValue("@COM_ONLINE", COM_ONLINE);
			//				comm.Parameters.AddWithValue("@COM_RETAIL", DBNull.Value);
			//				comm.Parameters.AddWithValue("@ACHIEVE", DBNull.Value);
			//				comm.Parameters.AddWithValue("@TREATMENT", DBNull.Value);
			//				comm.Parameters.AddWithValue("@SERVICE_CHARGE", DBNull.Value);
			//				comm.Parameters.AddWithValue("@CARE_COSTS", DBNull.Value);
			//				comm.Parameters.AddWithValue("@WORKDATE", _cBeauty._WORKDATE);
			//				comm.Parameters.AddWithValue("@CFLAG", 0);
			//				comm.ExecuteNonQuery();
			//			}
			//		}
			//		sqltrans.Commit();
			//		cMessage.ShowMessage("บันทึกข้อมูลเรียบร้อย");
			//		clear();
			//		lsvData.Items.Clear();
			//	}
			//	catch (Exception ex)
			//	{
			//		sqltrans.Rollback();
			//		cMessage.Error_NotCaption(ex.Message);
			//	}
			//}
		}
	}
}
