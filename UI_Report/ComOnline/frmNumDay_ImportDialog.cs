using cBeautyComm;
using kBeauty_Libary.Helper;
using System;
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
	public partial class frmNumDay_ImportDialog : Form
	{
		private cBeauty _cBeauty;
		private int numDAT;
		public frmNumDay_ImportDialog()
		{
			InitializeComponent();
		}
		public frmNumDay_ImportDialog(cBeauty cBeauty)
		{
			InitializeComponent();
			_cBeauty = cBeauty;
		}

		private void frmcomonline_numDay_ImportDialog_Load(object sender, EventArgs e)
		{
			Init();
			LoadData();
		}
		private void Init()
		{
            lsvData.LabelWrap = false;
			// Add Columns
			lsvData.Columns.Add("No", 60, HorizontalAlignment.Right);
			lsvData.Columns.Add("รหัสสาขา", 150, HorizontalAlignment.Left);
            lsvData.Columns.Add("รหัสพนักงาน", 150, HorizontalAlignment.Left);
            lsvData.Columns.Add("รหัสตำแหน่ง", 150, HorizontalAlignment.Left);
			lsvData.Columns.Add("เริ่มต้นได้ COM", 150, HorizontalAlignment.Left);
            lsvData.Columns.Add("วันที่สิ้นสุดได้ COM", 150, HorizontalAlignment.Left);
		}
		private void LoadData()
		{
			//lsvData.ImportDataExcelWithDialog(true);
			lsvData.ImportDataCsvWithDialog(true);

		}

		private void btnSave_Click(object sender, EventArgs e)
		{
            SaveData();
        }
        private void SaveData()
        {
			string sql_com = "SELECT * FROM COMMISSION_STCODE_numDAY  ";

			DataSet ds_com = cData.getDataSetWithSqlCommand(_cBeauty.GetConnectionBeautySystem(), sql_com, 10000, true);

			if (ds_com.Tables[0].Rows.Count > 0)
			{
				string sql_s = "TRUNCATE TABLE  COMMISSION_STCODE_numDAY ";
				//string sql_UPDATE = "UPDATE COMMISSION_STCODE_numDAY SET CFLAG = 1 ";
				cData.getDataSetWithSqlCommand(_cBeauty.GetConnectionBeautySystem(), sql_s, 10000, true);

			}

			string sql = "INSERT INTO COMMISSION_STCODE_numDAY (WHCODE,STCODE,numDAT,WORKDATE,DOCNO,amount_DAYs,ComOnline_Net,Difference,WORKDATE_ComOnline,CFLAG,ID_Position) " +
				"VALUES (@WHCODE,@STCODE,@numDAT,@WORKDATE,@DOCNO,@amount_DAYs,@ComOnline_Net,@Difference,@WORKDATE_ComOnline,@CFLAG,@ID_Position)";

		
			string WORKDATE = cDateTime.GetDateTimeForSql();

			if (lsvData.Items.Count <= 0)
			{
				return;
			}

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

						comm.CommandText = sql;
						for (int i = 0; i < lsvData.Items.Count; i++)
						{
							string WHCODE = lsvData.Items[i].SubItems[1].Text;
							string STCODE = lsvData.Items[i].SubItems[2].Text;
							string ID_Position = lsvData.Items[i].SubItems[3].Text;
							string start_date = lsvData.Items[i].SubItems[4].Text;
							string end_date = lsvData.Items[i].SubItems[5].Text;

							GETDATE(start_date, end_date);

							comm.Parameters.Clear();
							comm.Parameters.AddWithValue("@WHCODE", WHCODE);
							comm.Parameters.AddWithValue("@STCODE", STCODE);
							comm.Parameters.AddWithValue("@numDAT", numDAT);
							comm.Parameters.AddWithValue("@WORKDATE", WORKDATE);
							comm.Parameters.AddWithValue("@DOCNO", DBNull.Value);
							comm.Parameters.AddWithValue("@amount_DAYs", DBNull.Value);
							comm.Parameters.AddWithValue("@ComOnline_Net", DBNull.Value);
							comm.Parameters.AddWithValue("@Difference", DBNull.Value);
							comm.Parameters.AddWithValue("@WORKDATE_ComOnline", DBNull.Value);
							comm.Parameters.AddWithValue("@CFLAG", 0);
							comm.Parameters.AddWithValue("@ID_Position", ID_Position);
							
							comm.ExecuteNonQuery();
						}
					}

					sqltrans.Commit();
					cMessage.Complete_SaveData();

					this.Close();
				}
				catch (Exception ex)
				{
					sqltrans.Rollback();
					cMessage.Error_NotCaption(ex.Message);
				}
			}
		}
		private void GETDATE(string start_date, string end_date)
		{
			string sql = "SELECT DATEDIFF(day, '"+ start_date + "', '"+ end_date + "') +1 AS Date_Diff";
			DataSet ds = cData.getDataSetWithSqlCommand(_cBeauty.GetConnectionBeautySystem(), sql, 10000, true);

			if (ds.Tables[0].Rows.Count > 0)
			{
				foreach (DataRow dr in ds.Tables[0].Rows)
				{
					numDAT = int.Parse(dr["Date_Diff"].ToString());
					
				}
			}

		}

		private void btnClose_Click(object sender, EventArgs e)
		{
            this.Close();
		}
	}
}
