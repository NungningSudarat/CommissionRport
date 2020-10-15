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

namespace CommissionRport.Ul_Check.Person
{
	public partial class frmCheckPersonSaleOrder_byDay : Form
	{
		ArrayList _menuList;
		cBeauty _cBeauty;
		private int _wh;
		public frmCheckPersonSaleOrder_byDay()
		{
			InitializeComponent();
		}
		public frmCheckPersonSaleOrder_byDay(cBeauty cBeauty, int whcode, ref ArrayList menuList)
		{
			InitializeComponent();
			_cBeauty = cBeauty;
			_menuList = menuList;
			_wh = whcode;
		}
		private void frmCheckPersonSaleOrder_byDay_Load(object sender, EventArgs e)
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
			string WHCODE = txtwhcode.Text;


			string sql = @"  SELECT * FROM   
						(
							SELECT 
								DATES,WHCODE,NET
							FROM 
								 (SELECT   CONCAT('day_',Datepart(Day,WORKDATE)) AS DATES ,WHCODE,ABBNAME,SUM(TOTAL_NET) AS NET
														FROM 
														(

										SELECT   WHCODE, ABBNAME, WORKDATE, ABBNO, STCODE, FULLNAME, CAST(NET AS decimal(18, 2)) AS TOTAL_NET
															FROM(
															SELECT B.WHCODE, B.ABBNAME, C.STCODE, C.FULLNAME, A.ABBNO, WORKDATE, A.NET
																	FROM POS_PT A
																	right JOIN MAS_WH B
																	ON A.WH_ID_REF = B.ID
																	LEFT JOIN MAS_ST C
																	ON A.ST_ID = C.ID
																	WHERE A.WH_ID = '" + _cBeauty._WH_ID_RT_ONLINE + "' AND PTSTATUS = 'S' AND WORKDATE  BETWEEN '" + dtp_StartDate.getDateOnlyForSql() + "' AND '" + dtp_EndDate.getDateOnlyForSql() + "' AND  WHCODE LIKE '" + _wh + "%' ";
			

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
									) R";
			if (txtwhcode.Text != "")
			{
				sql += " WHERE WHCODE = '" + WHCODE + "'";
			}
			sql += @"
								) O 
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

		private void btnExport_Click(object sender, EventArgs e)
		{
			lsvData.ExportToExcelWithStringColumns("1");
		}
	}
}
