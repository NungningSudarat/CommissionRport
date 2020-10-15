using cBeautyComm;
using kBeauty_Libary.Helper;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommissionRport.Ul_Check.Detail
{
	public partial class frmCheckPerson_Foodpanda_byDay : Form
	{
		cBeauty _cBeauty;
		private int _BID;
		private int _FP;
		private int _COMMISSION;
		ArrayList _menuList;

		public frmCheckPerson_Foodpanda_byDay(cBeauty cBeauty, int BID, int FP, ref ArrayList menuList)
		{
			InitializeComponent();
			_cBeauty = cBeauty;
			_menuList = menuList;
			_BID = BID;
			_FP = FP;
		}
		public frmCheckPerson_Foodpanda_byDay()
		{
			InitializeComponent();
		}

		private void frmCheckPerson_Foodpanda_byDay_Load(object sender, EventArgs e)
		{
			lsvData.LabelWrap = false;
			// Add Columns                        
			lsvData.Columns.Add("#", 60, HorizontalAlignment.Right);
			lsvData.Columns.Add("รหัสสาขา", 80, HorizontalAlignment.Left);
			lsvData.Columns.Add("day_1", 80, HorizontalAlignment.Left);
			lsvData.Columns.Add("day_2", 80, HorizontalAlignment.Left);
			lsvData.Columns.Add("day_3", 80, HorizontalAlignment.Left);
			lsvData.Columns.Add("day_4", 80, HorizontalAlignment.Left);
			lsvData.Columns.Add("day_5", 80, HorizontalAlignment.Left);
			lsvData.Columns.Add("day_6", 80, HorizontalAlignment.Left);
			lsvData.Columns.Add("day_7", 80, HorizontalAlignment.Left);
			lsvData.Columns.Add("day_8", 80, HorizontalAlignment.Left);
			lsvData.Columns.Add("day_9", 80, HorizontalAlignment.Left);
			lsvData.Columns.Add("day_10", 80, HorizontalAlignment.Left);
			lsvData.Columns.Add("day_11", 80, HorizontalAlignment.Left);
			lsvData.Columns.Add("day_12", 80, HorizontalAlignment.Left);
			lsvData.Columns.Add("day_13", 80, HorizontalAlignment.Left);
			lsvData.Columns.Add("day_14", 80, HorizontalAlignment.Left);
			lsvData.Columns.Add("day_15", 80, HorizontalAlignment.Left);
			lsvData.Columns.Add("day_16", 80, HorizontalAlignment.Left);
			lsvData.Columns.Add("day_17", 80, HorizontalAlignment.Left);
			lsvData.Columns.Add("day_18", 80, HorizontalAlignment.Left);
			lsvData.Columns.Add("day_19", 80, HorizontalAlignment.Left);
			lsvData.Columns.Add("day_20", 80, HorizontalAlignment.Left);
			lsvData.Columns.Add("day_21", 80, HorizontalAlignment.Left);
			lsvData.Columns.Add("day_22", 80, HorizontalAlignment.Left);
			lsvData.Columns.Add("day_23", 80, HorizontalAlignment.Left);
			lsvData.Columns.Add("day_24", 80, HorizontalAlignment.Left);
			lsvData.Columns.Add("day_25", 80, HorizontalAlignment.Left);
			lsvData.Columns.Add("day_26", 80, HorizontalAlignment.Left);
			lsvData.Columns.Add("day_27", 80, HorizontalAlignment.Left);
			lsvData.Columns.Add("day_28", 80, HorizontalAlignment.Left);
			lsvData.Columns.Add("day_29", 80, HorizontalAlignment.Left);
			lsvData.Columns.Add("day_30", 80, HorizontalAlignment.Left);
			lsvData.Columns.Add("day_31", 80, HorizontalAlignment.Left);
		}

		private void bntSave_Click(object sender, EventArgs e)
		{
			GetData();
		}

		private void GetData()
		{
			string Connection = "";
			if (_BID == 1)
			{
				Connection = _cBeauty.GetConnectionBB();
				_COMMISSION = 1;

			}
			else if (_BID == 2)
			{
				Connection = _cBeauty.GetConnectionBC();
				_COMMISSION = 2;
			}

			string WHCODE = txtwhcode.Text;


			string sql = @"SELECT * FROM   
							(
								SELECT 
									DATES,WHCODE,NET
								FROM 
									 (SELECT   CONCAT('day_',Datepart(Day,WORKDATE)) AS DATES ,WHCODE,ABBNAME,SUM(TOTAL_NET) AS NET
								FROM 
								(
								 SELECT AA.WHCODE,AA.ABBNAME,AA.WORKDATE ,AA.ABBNO,AA.STCODE,AA.FULLNAME,AA.TOTAL_NET
								FROM (
										SELECT  WHCODE,B.ABBNAME,WORKDATE,ABBNO,C.STCODE,C.FULLNAME,CAST(PAY_CARD1 AS decimal(18,2)) AS TOTAL_NET
														FROM  POS_PT A			
														LEFT JOIN  MAS_WH B							
														ON A.WH_ID = B.ID			
														LEFT JOIN MAS_ST C
														ON A.ST_ID = C.ID			
													WHERE PTSTATUS IN ('S','R') 
													AND WORKDATE  BETWEEN '" + dtp_StartDate.getDateOnlyForSql() + @"' AND '" + dtp_EndDate.getDateOnlyForSql() + @"'";

			sql += " AND ISNULL(PAY_CARD_CD_ID1,0) = '" + _FP + "'";

			sql += @") AA
								LEFT JOIN 
								(
										SELECT B.WHCODE,B.ABBNAME AS WHNAME,WORKDATE, ABBNO,
												TOTALB4DISC,DISCOUNTAMT,TOTALB4DISC - DISCOUNTAMT AS NET ,CAST(DVAL AS decimal(18, 2)) AS DVAL
												FROM POS_PT_PR A
												LEFT JOIN MAS_WH B ON A.WH_ID = B.ID
												WHERE  A.PRCODE = (
												SELECT PRCODE FROM [192.168.10.243].[BeautySystem].[dbo].COMMISSION_PRCODE  WHERE CFLAG = 0 AND BRAND = '" + _COMMISSION + @"'
											)   
											AND A.DVAL IN (
												SELECT DVAL FROM [192.168.10.243].[BeautySystem].[dbo].COMMISSION_RATE  WHERE CFLAG = 0 AND BRAND = '" + _COMMISSION + @"'
											)
											AND WORKDATE BETWEEN '" + dtp_StartDate.getDateOnlyForSql() + @"' AND '" + dtp_EndDate.getDateOnlyForSql() + @"'
								) BB
								ON AA.WHCODE = BB.WHCODE AND AA.WORKDATE = BB.WORKDATE AND AA.ABBNO = BB.ABBNO  
								WHERE  BB.WHCODE IS NULL AND  BB.WORKDATE IS NULL AND BB.ABBNO  IS NULL
								";
			if (txtwhcode.Text != "")
			{
				sql += "AND AA.WHCODE = '" + WHCODE + "'";
			}
			sql += @") O
								GROUP BY WHCODE,ABBNAME,WORKDATE
								)aa
							) t 
							PIVOT(
								sum(NET) 
								FOR DATES IN (
									[day_1], 
									[day_2],
									[day_3],
									[day_4],
									[day_5],
									[day_6],
									[day_7],
									[day_8],
									[day_9],
									[day_10],
									[day_11],
									[day_12],
									[day_13],
									[day_14],
									[day_15],
									[day_16],
									[day_17],
									[day_18],
									[day_19],
									[day_20],
									[day_21],
									[day_22],
									[day_23],
									[day_24],
									[day_25],
									[day_26],
									[day_27],
									[day_28],
									[day_29],
									[day_30],
									[day_31]
									)
							) AS pivot_table
							ORDER BY WHCODE";



			DataSet ds = cData.getDataSetWithSqlCommand(Connection, sql, 1000, true);

			if (ds.Tables[0].Rows.Count <= 0)
			{
				cMessage.Error_NoData();
				return;
			}

			lsvData.AddDataWithDataset(ds, true, true, false);
			lsvData.SetAlternateColorRow();
			//show(lsvData, sql, false);
		}

		private void btnExport_Click(object sender, EventArgs e)
		{
			lsvData.ExportToExcelWithStringColumns("1");
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			_menuList.Remove(this.Text);
			this.Close();
		}
	}
}
