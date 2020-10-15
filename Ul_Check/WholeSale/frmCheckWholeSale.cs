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

namespace CommissionRport.Ul_Check.WholeSale
{
	public partial class frmCheckWholeSale : Form
	{
		ArrayList _menuList;
		cBeauty _cBeauty;
		private int _BID;
		private int _wh;
		public frmCheckWholeSale(cBeauty cBeauty, int BID,  int whcode, ref ArrayList menuList)
		{
			InitializeComponent();
			_cBeauty = cBeauty;
			_BID = BID;
			_menuList = menuList;
			_wh = whcode;
		}
		public frmCheckWholeSale()
		{
			InitializeComponent();
		}
		private void frmCheckWholeSale_Load(object sender, EventArgs e)
		{
			lsvData.LabelWrap = false;
			// Add Columns                        
			lsvData.Columns.Add("#", 60, HorizontalAlignment.Right);
			lsvData.Columns.Add("รหัสสาขา", 80, HorizontalAlignment.Left);
			lsvData.Columns.Add("ชื่อสาขา", 80, HorizontalAlignment.Left);
			lsvData.Columns.Add("วันที่ขาย", 80, HorizontalAlignment.Left);
			lsvData.Columns.Add("เลขที่บิล", 150, HorizontalAlignment.Left);
			lsvData.Columns.Add("ยอดเงิน", 100, HorizontalAlignment.Left);
			lsvData.Columns.Add("ส่วนลด", 100, HorizontalAlignment.Left);
			lsvData.Columns.Add("ยอดสุทธิ", 100, HorizontalAlignment.Left);
			lsvData.Columns.Add("DVAL", 100, HorizontalAlignment.Left);


		}

		private void txtwhcode_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				if (txtwhcode.Text.Length <= 0)
				{
					cMessage.Error_InvalidData();
					return;

				}
				GetData();
			}
		}

		private void bntSave_Click(object sender, EventArgs e)
		{
			GetData();
		}
		private void GetData()
		{
			string whcode = txtwhcode.Text;

			string sql = @"SELECT B.WHCODE,B.ABBNAME AS WHNAME,CONVERT(VARCHAR,WORKDATE,103) AS DATE, ABBNO,TOTALB4DISC,DISCOUNTAMT,TOTALB4DISC - DISCOUNTAMT AS NET ,CAST(DVAL AS decimal(18, 2)) AS DVAL
						FROM POS_PT_PR A
						LEFT JOIN MAS_WH B
						ON A.WH_ID = B.ID
						WHERE  A.PRCODE = (SELECT PRCODE FROM [192.168.10.243].[BeautySystem].[dbo].COMMISSION_PRCODE  WHERE CFLAG = 0 AND BRAND = '" + _BID + "')";
			       sql += "AND A.DVAL IN (SELECT DVAL FROM [192.168.10.243].[BeautySystem].[dbo].COMMISSION_RATE  WHERE CFLAG = 0 AND BRAND = '" + _BID + "')";
				   sql += "AND WORKDATE BETWEEN '" + dtp_StartDate.getDateOnlyForSql() + "' AND '" + dtp_EndDate.getDateOnlyForSql() + "'";

			if (txtwhcode.Text != "")
			{
				sql += "AND WHCODE = '" + whcode + "'";
			}
			sql += @" UNION ALL
						SELECT E.WHCODE,E.WHNAME, CONVERT(VARCHAR, B.INVOICEDATE, 103) AS DATES,A.SALESID AS ABBNO
						,CAST((B.SALESBALANCE + B.SUMTAX) AS decimal(18, 2)) AS TOTALB4DISC --ก่อนลด
						,CAST(B.ENDDISC  AS decimal(18, 2)) AS DISCOUNTAMT --ลด
						,CAST(B.INVOICEAMOUNT  AS decimal(18, 2)) AS NET --รวมเงินทั้งสิ้น
						,CAST(DISCPERCENT AS decimal(18, 2)) AS DVAL 
						FROM [192.168.10.199].[AODPRD].[dbo].SALESTABLE A with(nolock)
						LEFT JOIN [192.168.10.199].[AODPRD].[dbo].CUSTINVOICEJOUR B with(nolock) ON A.SALESID = B.SALESID
						LEFT JOIN [192.168.10.199].[AODPRD].[dbo].DEFAULTDIMENSIONVIEW D with(nolock) ON A.DEFAULTDIMENSION = D.DEFAULTDIMENSION
						LEFT JOIN [192.168.10.199].[AODPRD].[dbo].BCM_DOC_ST_WH E with(nolock) ON A.SALESID = E.SALESID
						WHERE  A.CUSTOMERREF LIKE '%WS%'   AND (B.INVOICEDATE BETWEEN '" + dtp_StartDate.getDateOnlyForSql() + "' AND '" + dtp_EndDate.getDateOnlyForSql() + "' AND  WHCODE LIKE '" + _wh + "%')";
			sql += " GROUP BY  E.WHCODE,E.WHNAME,A.CUSTOMERREF,B.INVOICEDATE,B.SALESBALANCE,B.SUMTAX ,B.ENDDISC,B.INVOICEAMOUNT ,A.DISCPERCENT,a.SALESPOOLID,A.SALESID";

			string Connection = "";
			if (_BID == 1)
			{
				Connection = _cBeauty.GetConnectionBB();
			}
			else if (_BID == 2)
			{
				Connection = _cBeauty.GetConnectionBC();
			}
			DataSet ds = cData.getDataSetWithSqlCommand(Connection, sql, 1000, true);

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
			lsvData.ExportToExcelWithStringColumns("4");
		}
		
		private void btnClose_Click(object sender, EventArgs e)
		{
			_menuList.Remove(this.Text);
			this.Close();
		}

		
	}
}
