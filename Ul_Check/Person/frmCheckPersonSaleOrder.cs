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

namespace CommissionRport.Ul_Check.Person
{
	public partial class frmCheckPersonSaleOrder : Form
	{
		ArrayList _menuList;
		cBeauty _cBeauty;
		private int _wh;
		public frmCheckPersonSaleOrder()
		{
			InitializeComponent();
		}


		public frmCheckPersonSaleOrder(cBeauty cBeauty, int whcode, ref ArrayList menuList)
		{
			InitializeComponent();
			_cBeauty = cBeauty;
			_menuList = menuList;
			_wh= whcode;
		}
		private void frmCheckPersonSaleOrder_Load(object sender, EventArgs e)
		{

			lsvData.LabelWrap = false;
			// Add Columns                        
			lsvData.Columns.Add("#", 60, HorizontalAlignment.Right);
			lsvData.Columns.Add("รหัสสาขา", 80, HorizontalAlignment.Left);
			lsvData.Columns.Add("ชื่อสาขา", 80, HorizontalAlignment.Left);
			lsvData.Columns.Add("วันที่ขาย", 100, HorizontalAlignment.Left);
			lsvData.Columns.Add("เลขที่บิล", 170, HorizontalAlignment.Left);			
			lsvData.Columns.Add("รหัสพนักงาน", 100, HorizontalAlignment.Left);
			lsvData.Columns.Add("ชื่อพนักงาน", 130, HorizontalAlignment.Left);
			lsvData.Columns.Add("ยอดเงิน", 80, HorizontalAlignment.Left);
		}
		private void txtscode_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				if (txtscode.Text.Length <= 0)
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

			string STCODE = txtscode.Text;
			string WHCODE = txtwhcode.Text;

			string sql = @" 
					SELECT   WHCODE,ABBNAME,CONVERT(VARCHAR,WORKDATE,103) AS DATE ,ABBNO,STCODE,FULLNAME,CAST(NET AS decimal(18,2)) AS TOTAL_NET
					FROM (
					SELECT B.WHCODE,B.ABBNAME,C.STCODE,C.FULLNAME,A.ABBNO,WORKDATE,A.NET
							FROM POS_PT A
							right JOIN MAS_WH B
							ON A.WH_ID_REF = B.ID
							LEFT JOIN MAS_ST C
							ON A.ST_ID = C.ID
							WHERE A.WH_ID = '"+ _cBeauty._WH_ID_RT_ONLINE + "' AND PTSTATUS='S' AND WORKDATE  BETWEEN '" + dtp_StartDate.getDateOnlyForSql() + "' AND '" + dtp_EndDate.getDateOnlyForSql() + "' AND  WHCODE LIKE '" + _wh + "%' ";
					if (txtscode.Text != "")
					{
						sql += "AND C.STCODE = '" + STCODE + "'";
					}
					if (txtwhcode.Text != "")
					{
						sql += "AND WHCODE = '" + WHCODE + "'";
					}

					sql += @" UNION ALL

						SELECT WHCODE,ABBNAME,STCODE,FULLNAME,ABBNO,WORKDATE, SUM(NET+INVOICEAMOUNT) AS NET  FROM 
						(
							SELECT B.WHCODE,B.ABBNAME,C.STCODE,C.FULLNAME,A.ABBNO,WORKDATE,A.NET
								FROM POS_PT A
								right JOIN MAS_WH B
								ON A.WH_ID_REF = B.ID
								LEFT JOIN MAS_ST C
								ON A.ST_ID = C.ID
								WHERE A.WH_ID =  '" + _cBeauty._WH_ID_RT_ONLINE + "' AND PTSTATUS='S' AND WORKDATE  BETWEEN '" + dtp_StartDate.getDateOnlyForSql() + "' AND '" + dtp_EndDate.getDateOnlyForSql() + "' AND  WHCODE LIKE '" + _wh + "%'";
					if (txtscode.Text != "")
					{
						sql += "AND C.STCODE = '" + STCODE + "'";
					}
					if (txtwhcode.Text != "")
					{
						sql += "AND WHCODE = '" + WHCODE + "'";
					}
					sql += @") AA";
					sql += @"
						INNER JOIN 
						(
							SELECT B.INVOICEAMOUNT ,A.PURCHORDERFORMNUM 
							FROM [192.168.10.199].[AODPRD].[dbo].SALESTABLE A with(nolock)
							LEFT JOIN [192.168.10.199].[AODPRD].[dbo].CUSTINVOICEJOUR B with(nolock) ON A.SALESID = B.SALESID
							LEFT JOIN [192.168.10.199].[AODPRD].[dbo].CUSTINVOICETRANS C with(nolock) ON B.SALESID = C.SALESID AND B.INVOICEID = C.INVOICEID
							WHERE A.INVENTLOCATIONID = '" + _cBeauty._WH_RT_ONLINE + "'  AND A.SALESTYPE ='4' AND A.SALESSTATUS IN ('3') AND B.INVOICEDATE  BETWEEN '" + dtp_StartDate.getDateOnlyForSql() + "' AND '" + dtp_EndDate.getDateOnlyForSql() + "' ";

					sql += @" ) BB";
					sql += @" 	ON AA.ABBNO = BB.PURCHORDERFORMNUM
						GROUP BY WHCODE,ABBNAME,ABBNO,PURCHORDERFORMNUM,FULLNAME,STCODE,WORKDATE
						) R
					ORDER BY WORKDATE,WHCODE";


			DataSet ds = cData.getDataSetWithSqlCommand(_cBeauty.GetConnectionSO(), sql, 1000, true);

			if (ds.Tables[0].Rows.Count <= 0)
			{
				cMessage.Error_NoData();
				return;
			}

			lsvData.AddDataWithDataset(ds, true, true, false);
			lsvData.SetAlternateColorRow();
			

		}

		
		private void btnClose_Click(object sender, EventArgs e)
		{
			_menuList.Remove(this.Text);
			this.Close();
		}


		private void btnExport_Click_1(object sender, EventArgs e)
		{
			lsvData.ExportToExcelWithStringColumns("3");
		}

		
	}
}

