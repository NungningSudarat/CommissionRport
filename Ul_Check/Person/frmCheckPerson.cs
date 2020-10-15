
using kBeauty_Libary.Helper;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Linq;
using cBeautyComm;
using System.Collections;

namespace CommissionRport.Ul_Check.Person
{
	public partial class frmCheckPerson : Form
	{
		cBeauty _cBeauty;
		private int _BID;
		private int _FP;
		private int _COMMISSION;
		ArrayList _menuList;
		public frmCheckPerson()
		{
			InitializeComponent();
		}
		
		public frmCheckPerson(cBeauty cBeauty, int BID, int FP,ref ArrayList menuList)
		{
			InitializeComponent();
			_cBeauty = cBeauty;
			_menuList = menuList;
			_BID = BID;
			_FP = FP;
		}

		private void frmCheckPerson_Load(object sender, EventArgs e)
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
									SELECT  WHCODE,B.ABBNAME,WORKDATE,ABBNO,C.STCODE,C.FULLNAME,CAST(NET AS decimal(18,2)) AS TOTAL_NET,PAY_CASH,PAY_CARD1
													FROM  POS_PT A			
													LEFT JOIN  MAS_WH B							
													ON A.WH_ID = B.ID			
													LEFT JOIN MAS_ST C
													ON A.ST_ID = C.ID			
												WHERE PTSTATUS IN ('S','R') 
												AND WORKDATE  BETWEEN '" + dtp_StartDate.getDateOnlyForSql() + @"' AND '" + dtp_EndDate.getDateOnlyForSql() + @"'";

			sql += " AND ISNULL(PAY_CARD_CD_ID1,0) <> '" + _FP + "'";

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

		//private void show( ListView listView,string sqldata,bool autoColumns = true)
		//{

			
		//	DataTable data = new DataTable();
		//	listView.View = View.Details;
		//	listView.Items.Clear();
		//	using (SqlConnection cdb = new SqlConnection(_con))
		//	{
		//		cdb.Open();
		//		SqlDataAdapter adapter = new SqlDataAdapter(sqldata, cdb);
		//		adapter.Fill(data);
		//		if (data.Rows.Count > 0) {
		//			listView.Items.Clear();
		//			int n = 0;
		//			if (autoColumns)
		//			{
		//				listView.Columns.Clear();
		//				listView.LabelWrap = false;
		//				listView.Columns.Add("No.",50);
		//				foreach (DataColumn column in data.Columns)
		//				{
		//					listView.Columns.Add(column.ColumnName,150);
		//				}
		//			}
		//			foreach (DataRow row in data.Rows) {
		//				ListViewItem item  = new ListViewItem();
		//				item.Text = (n + 1).ToString();
		//				for (int i= 0; i<data.Columns.Count ; i++){
		//					string text = row[i].ToString();
		//					item.SubItems.Add(text);
		//				}
		//				n++;
		//				listView.Items.Add(item);
		//			}

		//		}

		//	}
		//	if (listView.Items.Count > 0)
		//	{
		//		//cMessage.Complete_SaveData();
		//	}
		//	else
		//	{
		//		cMessage.Error_InvalidData();
		//	}

		//}
		
		
		private void btnExport_Click(object sender, EventArgs e)
		{
			lsvData.ExportToExcelWithStringColumns("3");
		}
		
	}
}
