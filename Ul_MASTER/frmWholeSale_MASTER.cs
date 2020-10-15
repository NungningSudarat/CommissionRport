using cBeautyComm;
using CommissionRport.Ul_Login;
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

namespace CommissionRport.Ul_MASTER
{
	public partial class frmWholeSale_MASTER : Form
	{
		cBeauty _cBeauty;
		ArrayList _menuList;
		private string prcode;
		private string prcode_new;
		private string BID;

		public frmWholeSale_MASTER()
		{
			InitializeComponent();
		}
		public frmWholeSale_MASTER(cBeauty cBeauty, ref ArrayList menuList)
		{
			InitializeComponent();
			_cBeauty = cBeauty;
			_menuList = menuList;
		}
		private void frmWholeSale_MASTER_Load(object sender, EventArgs e)
		{
			Init();
			lsvData.LabelWrap = false;
			// Add Columns                        
			lsvData.Columns.Add("#", 60, HorizontalAlignment.Right);
			lsvData.Columns.Add("PRCODE", 100, HorizontalAlignment.Left);
			lsvData.Columns.Add("DVAL", 100, HorizontalAlignment.Left);
			lsvData.Columns.Add("สถานะ", 100, HorizontalAlignment.Left);
			lsvData.Columns.Add("ID", 0, HorizontalAlignment.Left);
			lsvData.Columns.Add("CFLAG", 0, HorizontalAlignment.Left);
		}
		private void Init()
		{
			string sql_BID = @" SELECT BID,BNAME FROM MAS_BRAND WHERE CFLAG = 0";

			DataSet ds_BID = cData.getDataSetWithSqlCommand(_cBeauty.GetConnectionBeautySystem(), sql_BID, 1000, true);

			cmdBID.BeginUpdate();
			cmdBID.DataSource = ds_BID.Tables[0];
			cmdBID.DisplayMember = "BNAME";
			cmdBID.ValueMember = "BID";
			cmdBID.EndUpdate();
		}
		private void btnClose_Click(object sender, EventArgs e)
		{
			_menuList.Remove(this.Text);
			this.Close();
		}
		private void bntSave_Click(object sender, EventArgs e)
		{
			BID = cmdBID.SelectedValue.ToString();
			GetData();
			GetData2();
		}
		private void GetData()
		{
			string sql = @"SELECT A.PRCODE,B.DVAL,
							CASE 
								WHEN B.CFLAG = 0 THEN 'เปิดใช้งาน'
								WHEN B.CFLAG = 1 THEN 'ปิด'
							END AS CFLAG,B.ID,B.CFLAG
							FROM COMMISSION_PRCODE A
							LEFT JOIN COMMISSION_RATE B
							ON A.BRAND = B.BRAND
							WHERE A.BRAND ='" + BID + "'";
			DataSet ds = cData.getDataSetWithSqlCommand(_cBeauty.GetConnectionBeautySystem(), sql, 1000, true);

			if (ds.Tables[0].Rows.Count <= 0)
			{
				cMessage.Error_NoData();
				return;
			}
			
			lsvData.AddDataWithDataset(ds, true, true, false);
			lsvData.SetAlternateColorRow();

		}
		private void GetData2()
		{

			string sql = @"SELECT * FROM COMMISSION_PRCODE WHERE CFLAG= '0' AND BRAND = @BRAND";

			using (SqlConnection conn = new SqlConnection(_cBeauty.GetConnectionBeautySystem()))
			{
					conn.Open();
					try
					{
						using (SqlCommand comm = new SqlCommand())
						{
							comm.CommandType = CommandType.Text;
							comm.CommandTimeout = 1000;
							comm.Connection = conn;

							comm.CommandText = sql;
							comm.Parameters.Clear();
							comm.Parameters.AddWithValue("@BRAND", BID);
							var dataReader = comm.ExecuteReader();
							var dataTable = new DataTable();
							dataTable.Load(dataReader);

							if (dataTable.Rows.Count > 0)
							{

								 prcode = dataTable.Rows[0]["PRCODE"].ToString();
								txtprcode.Text = prcode;

							}
						}
					}
					catch (Exception ex)
					{
						cMessage.Error_NotCaption(ex.Message);
					}
			}
		}

		private void btnsave_Click(object sender, EventArgs e)
		{
			if (txtprcode.Text.Length < 0)
			{
				cMessage.Error_InvalidData();
				clareData();
				return;
			}

			frmLogin frm = new frmLogin(_cBeauty, "IT");
			frm.ShowDialog();

			if (_cBeauty._STCODE_LOG == null || _cBeauty._STCODE_LOG == "" || _cBeauty._DPCODE_LOG == null || _cBeauty._DPCODE_LOG == ""
				|| _cBeauty._STNAME_LOG == null || _cBeauty._STNAME_LOG == "")
			{
				cMessage.Error_InvalidData();
				clareData();
				return;

			}
			else
			{
				SaveData();
				clareData();
				Init();

			}

		}

		private void SaveData()
		{
			prcode_new = txtprcode.Text;
			string REMARK = prcode +" เปลี่ยนเป็น "+ prcode_new;
			_cBeauty._WORKDATE = cDateTime.getDateForSql();
			string _BID = cmdBID.SelectedValue.ToString();

			string sql_LOG_ADJ = @"INSERT INTO COMMISSION_LOG_WholeSale (BRAND,PRCODE,STCODE_LOG,REMARK,WORKEDATE)
							VALUES (@BRAND,@PRCODE,@STCODE_LOG,@REMARK,@WORKEDATE)";

			string sql_COM_PR = @"UPDATE COMMISSION_PRCODE 
							SET PRCODE = @PRCODE
							WHERE BRAND = @BRAND AND CFLAG = 0";


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

						comm.CommandText = sql_COM_PR;
						comm.Parameters.Clear();
						comm.Parameters.AddWithValue("@PRCODE", prcode_new);
						comm.Parameters.AddWithValue("@BRAND", _BID);
						comm.ExecuteNonQuery();

						comm.CommandText = sql_LOG_ADJ;
						comm.Parameters.Clear();
						comm.Parameters.AddWithValue("@BRAND", _BID);
						comm.Parameters.AddWithValue("@STCODE_LOG", _cBeauty._STCODE_LOG);
						comm.Parameters.AddWithValue("@REMARK", REMARK);
						comm.Parameters.AddWithValue("@WORKEDATE", _cBeauty._WORKDATE);
						comm.Parameters.AddWithValue("@PRCODE", prcode_new);
						comm.ExecuteNonQuery();

					}
					sqltrans.Commit();
					cMessage.ShowMessage("บันทึกข้อมูลเรียบร้อย");
				}
				catch (Exception ex)
				{
					sqltrans.Rollback();
					cMessage.Error_NotCaption(ex.Message);
				}
			}
		}

		private void clareData()
		{
			lsvData.Items.Clear();
			txtprcode.Text = "";
			_cBeauty._STCODE_LOG = "";
			_cBeauty._DPCODE_LOG = "";
			_cBeauty._STNAME_LOG = "";
		}

		private void lsvData_DoubleClick(object sender, EventArgs e)
		{
			ListViewItem itemSelect = lsvData.SelectedItems[0];
			string DVAL = itemSelect.SubItems[2].Text;
			string CFLAG = itemSelect.SubItems[5].Text;
			string ID = itemSelect.SubItems[4].Text;
			string PRCODE = txtprcode.Text;

			frmLOG_WholeSale frm = new frmLOG_WholeSale(_cBeauty, DVAL, CFLAG, ID, BID, PRCODE);
			frm.ShowDialog();

			clareData();
		}
	}
}
