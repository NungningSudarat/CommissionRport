
using cBeautyComm;
using kBeauty_Libary.Controls;
using kBeauty_Libary.Helper;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Linq;

namespace CommissionRport.Ul_Check.Person
{
	public partial class frmCheckPersonOffline : Form
	{
		private string _con;
		private string _barnd;
		cBeauty _cBeauty;
		
		public frmCheckPersonOffline(string con)
		{
			InitializeComponent();
			//_cBeauty = cBeauty;
			_con = con;
		}
		public frmCheckPersonOffline()
		{
			InitializeComponent();
		}
		private void frmCheckPerson_Load(object sender, EventArgs e)
		{
			dtp_StartDate.Value = DateTime.Now;
			dtp_EndDate.Value = DateTime.Now;

			lsvData.LabelWrap = false;
			// Add Columns                        
			lsvData.Columns.Add("#", 60, HorizontalAlignment.Right);
			lsvData.Columns.Add("รหัสสาขา", 80, HorizontalAlignment.Left);
			lsvData.Columns.Add("ชื่อสาขา", 80, HorizontalAlignment.Left);
			lsvData.Columns.Add("วันที่ขาย", 100, HorizontalAlignment.Left);
			lsvData.Columns.Add("เลขที่บิล", 100, HorizontalAlignment.Left);
			lsvData.Columns.Add("รหัสพนักงาน", 100, HorizontalAlignment.Left);
			lsvData.Columns.Add("ชื่อพนักงาน", 120, HorizontalAlignment.Left);
			lsvData.Columns.Add("ยอดเงิน", 80, HorizontalAlignment.Left);
		}		
		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		private void bntSave_Click_1(object sender, EventArgs e)
		{
			GetData();
		}
		private void GetData()
        {
			bool result = false;
			string STCODE = txtscode.Text;
			string WHCODE = txtwhcode.Text;
			string StartDate = dtp_StartDate.Value.ToString("yyyy-MM-dd");
			string EndDate = dtp_EndDate.Value.ToString("yyyy-MM-dd");


			string sql = @"SELECT  WHCODE,b.ABBNAME,CONVERT(VARCHAR,WORKDATE,103) AS DATE ,ABBNO,C.STCODE,C.FULLNAME,CAST(NET AS decimal(18,2)) AS TOTAL_NET
							FROM  POS_PT A			
							LEFT JOIN  MAS_WH B	ON A.WH_ID = B.ID 	
							LEFT JOIN MAS_ST C ON A.ST_ID = C.ID	 		
							WHERE PTSTATUS IN ('S','R') 
							AND WORKDATE  BETWEEN '" + StartDate + "' AND '" + EndDate + "'";
			if (txtscode.Text != "")
			{
				sql += "AND C.STCODE = '" + STCODE + "'";
			}
			if (txtwhcode.Text != "")
			{
				sql += "AND WHCODE = '" + WHCODE + "'";
			}
			sql += "ORDER BY WHCODE,WORKDATE";
			DataSet ds = cData.getDataSetWithSqlCommand(_cBeauty.GetConnection(), sql, 1000, true);
			if (ds.Tables[0].Rows.Count <= 0)
			{
				cMessage.Error_NoData();
				return;
			}

			lsvData.AddDataWithDataset(ds, true, true, false);
			lsvData.SetAlternateColorRow();
			//using (SqlConnection conn = new SqlConnection(_con))
			//{
			//	conn.Open();
			//	try
			//	{
			//		using (SqlCommand comm = new SqlCommand())
			//		{
			//			comm.CommandType = CommandType.Text;
			//			comm.CommandTimeout = 1000;
			//			comm.Connection = conn;

			//			comm.CommandText = sql;
			//			comm.Parameters.Clear();
			//			comm.Parameters.AddWithValue("@STCODE", txtUser.Text);
			//			comm.Parameters.AddWithValue("@STPASSWORD", txtPassword.Text);
			//			var dataReader = comm.ExecuteReader();
			//			var dataTable = new DataTable();
			//			dataTable.Load(dataReader);

			//			if (dataTable.Rows.Count > 0)
			//			{
			//				_cBeauty._ST_ID_LOG = dataTable.Rows[0]["ST_ID"].ToString();
			//				_cBeauty._STCODE_LOG = dataTable.Rows[0]["STCODE"].ToString();
			//				_cBeauty._STNAME_LOG = dataTable.Rows[0]["STNAME"].ToString();
			//				result = true;
			//			}

			//			//var reader = comm.ExecuteReader();
			//			//return reader.Read();
			//		}
			//	}
			//	catch (Exception ex)
			//	{
			//		cMessage.Error_NotCaption(ex.Message);
			//	}
			//}
			//return result;

			//show(lsvData, sql, false);
		}
		//private void show( ListView listView,string sqldata,bool autoColumns = true)
		//{

			
		//	DataTable data = new DataTable();
		//	listView.View = View.Details;
		//	listView.Items.Clear();
		//	using (SqlConnection cdb = new SqlConnection(_cBeauty.GetConnectionBB))
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
			ExportToExcelWithStringColumns("3");
		}
		public void ExportToExcelWithStringColumns(string stringColumn)
		{
			string[] str_column = stringColumn.Split(',');

			Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
			app.Visible = true;
			Microsoft.Office.Interop.Excel.Workbook wb = app.Workbooks.Add(1);
			Microsoft.Office.Interop.Excel.Worksheet ws = (Microsoft.Office.Interop.Excel.Worksheet)wb.Worksheets[1];
			int i = 1;
			int i2 = 2;
			int h1 = 1;

			string columnName;
			for (int h = 0; h < this.lsvData.Columns.Count; h++)
			{
				columnName = this.lsvData.Columns[h].Text;
				ws.Cells[1, h1] = columnName;

				h1++;
			}

			foreach (ListViewItem lvi in this.lsvData.Items)
			{
				i = 1;
				foreach (ListViewItem.ListViewSubItem lvs in lvi.SubItems)
				{
					if (str_column.Any((i.ToString()).Contains))
					{
						ws.Cells[i2, i] = "'" + lvs.Text;
					}
					else
					{
						ws.Cells[i2, i] = lvs.Text;
					}

					i++;
				}
				i2++;
			}

			cMessage.Export_Complete();
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
	}
}
