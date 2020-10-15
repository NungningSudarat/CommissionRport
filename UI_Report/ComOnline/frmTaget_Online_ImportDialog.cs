using cBeautyComm;
using kBeauty_Libary.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CommissionRport.UI_Report.ComOnline
{
	public partial class frmTaget_Online_ImportDialog : Form
	{
		private cBeauty _cBeauty;
		public frmTaget_Online_ImportDialog()
		{
			InitializeComponent();
		}
		public  frmTaget_Online_ImportDialog(cBeauty cBeauty)
		{
			InitializeComponent();
			_cBeauty = cBeauty;
		}
		private void frmcomonline_Taget_ImportDialog_Load(object sender, EventArgs e)
		{
			Init();
			LoadData();
		}
		private void Init()
		{
			lsvData.LabelWrap = false;
			// Add Columns
			lsvData.Columns.Add("No", 60, HorizontalAlignment.Right);
			lsvData.Columns.Add("รหัสสาขา", 80, HorizontalAlignment.Left);
			lsvData.Columns.Add("TAGET", 80, HorizontalAlignment.Left);
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
			string sql_com = "SELECT * FROM COMMISSION_TAGET  ";

			DataSet ds_com = cData.getDataSetWithSqlCommand(_cBeauty.GetConnectionBeautySystem(), sql_com, 10000, true);

			if (ds_com.Tables[0].Rows.Count > 0)
			{
				string sql_UPDATE = "TRUNCATE TABLE  COMMISSION_TAGET ";
				cData.getDataSetWithSqlCommand(_cBeauty.GetConnectionBeautySystem(), sql_UPDATE, 10000, true);

			}
			
		

			//string sql = "INSERT INTO COMMISSION_TAGET (WHCODE,TAGET,WORKDATE,CFLAG) VALUES (@WHCODE,@TAGET,@WORKDATE,@CFLAG)";
			string sql = @"INSERT INTO COMMISSION_TAGET (WHCODE,TAGET,WORKDATE,DOCNO,ComOnline_Net_whcode,ComOnline_Net_stcode,WORKDATE_ComOnline,CFLAG) 
							VALUES (@WHCODE,@TAGET,@WORKDATE,@DOCNO,@ComOnline_Net_whcode,@ComOnline_Net_stcode,@WORKDATE_ComOnline,@CFLAG)";

			string WHCODE;
			string TAGET;
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
							WHCODE = lsvData.Items[i].SubItems[1].Text;
							TAGET = lsvData.Items[i].SubItems[2].Text;

							comm.Parameters.Clear();
							comm.Parameters.AddWithValue("@WHCODE", WHCODE);
							comm.Parameters.AddWithValue("@TAGET", TAGET);
							comm.Parameters.AddWithValue("@WORKDATE", WORKDATE);
							comm.Parameters.AddWithValue("@DOCNO", DBNull.Value);
							comm.Parameters.AddWithValue("@ComOnline_Net_stcode", DBNull.Value);
							comm.Parameters.AddWithValue("@ComOnline_Net_whcode", DBNull.Value);
							comm.Parameters.AddWithValue("@WORKDATE_ComOnline", DBNull.Value);
							comm.Parameters.AddWithValue("@CFLAG", 0);
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

		private void btnClose_Click(object sender, EventArgs e)
		{
            this.Close();
		}
	}
}
