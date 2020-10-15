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
	public partial class frmLOG_WholeSale : Form
	{
		cBeauty _cBeauty;
		string _ID;
		string _CFLAG;
		string _CFLAGnew;
		string _DVAL;
		string _DVALnew;
		string _BID;
		string REMARK;
		string _PRCODE;
		public frmLOG_WholeSale()
		{
			InitializeComponent();
		}
		public frmLOG_WholeSale(cBeauty cBeauty, string DVAL, string CFLAG, string ID , string BID, string PRCODE)
		{
			InitializeComponent();
			_ID = ID;
			_CFLAG = CFLAG;
			_DVAL = DVAL;
			_BID = BID;
			_cBeauty = cBeauty;
			_PRCODE = PRCODE;
		}
		private void frmLOG_WholeSale_Load(object sender, EventArgs e)
		{
			txtDVAL.Text = _DVAL;
			txtCFLAG.Text = _CFLAG;
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnSumbit_Click(object sender, EventArgs e)
		{

			if (txtDVAL.Text.Length < 0 || txtCFLAG.Text.Length < 0)
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
				
			}

		}

		private void SaveData()
		{
			_DVALnew = txtDVAL.Text;
			_CFLAGnew = txtCFLAG.Text;

			if (_DVAL != _DVALnew &&  _CFLAG != _CFLAGnew)
			{
				REMARK = _DVAL  + " เปลี่ยนเป็น " + _DVALnew +" และ "+ _CFLAG + " เปลี่ยนเป็น " + _CFLAGnew;
			}
			else if (_DVAL != _DVALnew)
			{
				REMARK = _DVAL + " เปลี่ยนเป็น " + _DVALnew;
			}
			else if(_CFLAGnew != _CFLAG)
			{
				REMARK = _CFLAG + " เปลี่ยนเป็น " + _CFLAGnew;
			}
			
			_cBeauty._WORKDATE = cDateTime.getDateForSql();

			string sql_LOG_ADJ = @"INSERT INTO COMMISSION_LOG_WholeSale (BRAND,PRCODE,DVAL,STCODE_LOG,REMARK,WORKEDATE)
							VALUES (@BRAND,@PRCODE,@DVAL,@STCODE_LOG,@REMARK,@WORKEDATE)";

			string sql_COM_PR = @"UPDATE COMMISSION_RATE 
							SET DVAL = @DVAL,
								CFLAG = @CFLAG
							WHERE BRAND = @BRAND  AND ID = @ID";


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
						comm.Parameters.AddWithValue("@DVAL", _DVALnew);
						comm.Parameters.AddWithValue("@CFLAG", _CFLAGnew);
						comm.Parameters.AddWithValue("@BRAND", _BID);
						comm.Parameters.AddWithValue("@ID", _ID);
						comm.ExecuteNonQuery();

						comm.CommandText = sql_LOG_ADJ;
						comm.Parameters.Clear();
						comm.Parameters.AddWithValue("@BRAND", _BID);
						comm.Parameters.AddWithValue("@DVAL", _DVALnew);
						comm.Parameters.AddWithValue("@PRCODE", _PRCODE);
						comm.Parameters.AddWithValue("@STCODE_LOG", _cBeauty._STCODE_LOG);
						comm.Parameters.AddWithValue("@REMARK", REMARK);
						comm.Parameters.AddWithValue("@WORKEDATE", _cBeauty._WORKDATE);
						
						comm.ExecuteNonQuery();

					}
					sqltrans.Commit();
					cMessage.ShowMessage("บันทึกข้อมูลเรียบร้อย");

					this.Close();
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
			txtCFLAG.Text = "";
			txtDVAL.Text = "";
			_cBeauty._STCODE_LOG = "";
			_cBeauty._DPCODE_LOG = "";
			_cBeauty._STNAME_LOG = "";
		}
	}
}
