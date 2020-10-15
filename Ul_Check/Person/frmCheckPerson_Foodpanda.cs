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
	public partial class frmCheckPerson_Foodpanda : Form
	{
		cBeauty _cBeauty;
		private int _BID;
		private int _FP;
		private int _COMMISSION;
		ArrayList _menuList;

		public frmCheckPerson_Foodpanda(cBeauty cBeauty, int BID, int FP, ref ArrayList menuList)
		{
			InitializeComponent();
			_cBeauty = cBeauty;
			_menuList = menuList;
			_BID = BID;
			_FP = FP;
		}
		public frmCheckPerson_Foodpanda()
		{
			InitializeComponent();
		}

		private void frmCheckPerson_Foodpanda_Load(object sender, EventArgs e)
		{
			lsvData.LabelWrap = false;
			// Add Columns                        
			lsvData.Columns.Add("#", 60, HorizontalAlignment.Right);
			lsvData.Columns.Add("รหัสสาขา", 80, HorizontalAlignment.Left);
			lsvData.Columns.Add("ชื่อสาขา", 80, HorizontalAlignment.Left);
			lsvData.Columns.Add("วันที่ขาย", 100, HorizontalAlignment.Left);
			lsvData.Columns.Add("เลขที่บิล", 100, HorizontalAlignment.Left);
			lsvData.Columns.Add("รหัสพนักงาน", 100, HorizontalAlignment.Left);
			lsvData.Columns.Add("ชื่อพนักงาน", 120, HorizontalAlignment.Left);
			lsvData.Columns.Add("ยอดเงินสด", 100, HorizontalAlignment.Left);
			lsvData.Columns.Add("ยอดเงินเครดิต", 100, HorizontalAlignment.Left);
			lsvData.Columns.Add("ยอดเงินสุทธิ", 100, HorizontalAlignment.Left);
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

			string STCODE = txtscode.Text;
			string WHCODE = txtwhcode.Text;


			string sql = @"SELECT AA.WHCODE,AA.ABBNAME,CONVERT(VARCHAR,AA.WORKDATE,103) AS DATE ,AA.ABBNO,AA.STCODE,AA.FULLNAME,PAY_CASH,PAY_CARD1,AA.TOTAL_NET
							FROM (
									SELECT  WHCODE,B.ABBNAME,WORKDATE,ABBNO,C.STCODE,C.FULLNAME,CAST(PAY_CARD1 AS decimal(18,2)) AS TOTAL_NET,PAY_CASH,PAY_CARD1
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
							WHERE  BB.WHCODE IS NULL AND  BB.WORKDATE IS NULL AND BB.ABBNO  IS NULL ";


			if (txtscode.Text != "")
			{
				sql += " AND AA.STCODE = '" + STCODE + "'";
			}
			if (txtwhcode.Text != "")
			{
				sql += " AND AA.WHCODE = '" + WHCODE + "'";
			}
			sql += " ORDER BY AA.WORKDATE ,AA.WHCODE";



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
			lsvData.ExportToExcelWithStringColumns("3");
		}
	}
}
