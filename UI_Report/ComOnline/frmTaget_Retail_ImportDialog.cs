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
	public partial class frmTaget_Retail_ImportDialog : Form
	{
		private cBeauty _cBeauty;

		public frmTaget_Retail_ImportDialog(cBeauty cBeauty)
		{
			InitializeComponent();
			_cBeauty = cBeauty;
		}
		public frmTaget_Retail_ImportDialog()
		{
			InitializeComponent();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void frmTaget_Retail_ImportDialog_Load(object sender, EventArgs e)
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
			lsvData.Columns.Add("รหัสพนักงาน area", 150, HorizontalAlignment.Left);
			lsvData.Columns.Add("WHGROUP", 150, HorizontalAlignment.Left);
			lsvData.Columns.Add("TARGET", 150, HorizontalAlignment.Left);
			lsvData.Columns.Add("NET", 150, HorizontalAlignment.Left);
			lsvData.Columns.Add("TARGET_WS", 150, HorizontalAlignment.Left);
			lsvData.Columns.Add("NET_WS", 150, HorizontalAlignment.Left);
			lsvData.Columns.Add("SHOPCARE", 150, HorizontalAlignment.Left);
		}
		private void LoadData()
		{
			lsvData.ImportDataCsvWithDialog(true);
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			SaveData();
		}
		private void SaveData()
		{
			string sql_com = "SELECT * FROM COMMISSION_TAGET_RETAIL  ";

			DataSet ds_com = cData.getDataSetWithSqlCommand(_cBeauty.GetConnectionBeautySystem(), sql_com, 10000, true);

			if (ds_com.Tables[0].Rows.Count > 0)
			{
				string sql_UPDATE = "TRUNCATE TABLE  COMMISSION_TAGET_RETAIL  ";
				cData.getDataSetWithSqlCommand(_cBeauty.GetConnectionBeautySystem(), sql_UPDATE, 10000, true);

			}

			string sql = @"INSERT INTO COMMISSION_TAGET_RETAIL (WHCODE,STCODE_area,WHGROUP,TARGET,NET,TARGET_WS,NET_WS,SHOPCARE,WORKDATE,CFLAG) 
						VALUES (@WHCODE,@STCODE_area,@WHGROUP,@TARGET,@NET,@TARGET_WS,@NET_WS,@SHOPCARE,@WORKDATE,@CFLAG)";


			
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
							string STCODE_area = lsvData.Items[i].SubItems[2].Text;
							string WHGROUP = lsvData.Items[i].SubItems[3].Text;
							string TARGET = lsvData.Items[i].SubItems[4].Text;
							string NET = lsvData.Items[i].SubItems[5].Text;
							string TARGET_WS = lsvData.Items[i].SubItems[6].Text;
							string NET_WS = lsvData.Items[i].SubItems[7].Text;
							string SHOPCARE = lsvData.Items[i].SubItems[8].Text;

							comm.Parameters.Clear();
							comm.Parameters.AddWithValue("@WHCODE", WHCODE);
							comm.Parameters.AddWithValue("@STCODE_area", STCODE_area);
							comm.Parameters.AddWithValue("@WHGROUP", WHGROUP);
							comm.Parameters.AddWithValue("@TARGET", TARGET);
							comm.Parameters.AddWithValue("@NET", NET);
							comm.Parameters.AddWithValue("@TARGET_WS", TARGET_WS);
							comm.Parameters.AddWithValue("@NET_WS", NET_WS);
							comm.Parameters.AddWithValue("@SHOPCARE", SHOPCARE);
							comm.Parameters.AddWithValue("@WORKDATE", cDateTime.GetDateTimeForSql());
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

	}
}
