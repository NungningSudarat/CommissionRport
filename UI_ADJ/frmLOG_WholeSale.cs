using cBeautyComm;
using CommissionRport.Ul_Login;
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

namespace CommissionRport.UI_ADJ
{
	public partial class frmLOG_WholeSale : Form
	{
		cBeauty _cBeauty;
		string _docno;
		string _whcode;
		string _net;
		string _TYPE_N;
		string _BID;
		int _ID;
		string _DVAL;
		string _chack;


		string TYPE;
		string TYPE_NEW;
		string BID;
		string BID_NEW;
		string ABBNAME;
		string con_wh;
		string REMARK;
		public frmLOG_WholeSale(cBeauty cBeauty, string docno, string whcode, string net, string TYID, string BID, string DVAL, int ID, string chack)
		{
			InitializeComponent();
			_docno = docno;
			_whcode = whcode;
			_net = net;
			_TYPE_N = TYID;
			_BID = BID;
			_ID = ID;
			_chack = chack;
			_DVAL = DVAL;
			_cBeauty = cBeauty;
			cmbBID.Visible = false;
		}
		public frmLOG_WholeSale(cBeauty cBeauty, string docno,  string TYID, string BID, string chack)
		{
			InitializeComponent();
			_docno = docno;
			_TYPE_N = TYID;
			_BID = BID;
			_chack = chack;
			_cBeauty = cBeauty;
			txtwhcode.Enabled = true;
			txtnet.Enabled = true;
			txtTYID.Visible = false;
			txtBID.Visible = false;
			txtDVAL.Enabled = true;
		}
		public frmLOG_WholeSale()
		{
			InitializeComponent();
		}

		private void frmLOG_WholeSale_Load(object sender, EventArgs e)
		{

			string sql_chanel = @" SELECT TYID, NAME FROM MAS_TYPE WHERE CFLAG = 0 ";

			DataSet ds_chanel = cData.getDataSetWithSqlCommand(_cBeauty.GetConnectionBeautySystem(), sql_chanel, 1000, true);

			cmbTYID.BeginUpdate();
			cmbTYID.DataSource = ds_chanel.Tables[0];
			cmbTYID.DisplayMember = "NAME";
			cmbTYID.ValueMember = "TYID";
			cmbTYID.EndUpdate();

			cmbTYID.SelectedIndex = -1;

			if (_chack == "IS")
			{
				string sql_bid = @" SELECT BID, BNAME FROM MAS_BRAND WHERE CFLAG = 0 ";

				DataSet ds_bid = cData.getDataSetWithSqlCommand(_cBeauty.GetConnectionBeautySystem(), sql_bid, 1000, true);

				cmbBID.BeginUpdate();
				cmbBID.DataSource = ds_bid.Tables[0];
				cmbBID.DisplayMember = "BNAME";
				cmbBID.ValueMember = "BID";
				cmbBID.EndUpdate();

				cmbBID.SelectedIndex = -1;
			}
			
			txtDOCNO.Text = _docno;
			txtBID.Text = _BID;
			txtnet.Text = _net;
			txtTYID.Text = _TYPE_N;
			txtwhcode.Text = _whcode;
			txtDVAL.Text = _DVAL;
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnSumbit_Click(object sender, EventArgs e)
		{
			if (txtDVAL.Text.Length <= 0 )
			{
				cMessage.Error_InvalidData();
				return;
			}

			frmLogin frm = new frmLogin(_cBeauty, "FA");
			frm.ShowDialog();

			if (_cBeauty._STCODE_LOG == null || _cBeauty._STCODE_LOG == "" || _cBeauty._DPCODE_LOG == null || _cBeauty._DPCODE_LOG == ""
				|| _cBeauty._STNAME_LOG == null || _cBeauty._STNAME_LOG == "")
			{
				cMessage.Error_InvalidData();
				return;

			}
			else
			{
				TYPE = cmbTYID.SelectedValue.ToString();

				if (TYPE == "1")
				{
					TYPE_NEW = "หน้าร้าน";
				}
				else if (TYPE == "2")
				{
					TYPE_NEW = "ออนไลน์";
				}
				else if (TYPE == "3")
				{
					TYPE_NEW = "ขายส่ง";
				}
				else if (TYPE == "4")
				{
					TYPE_NEW = "Foodpanda";
				}

				if (_chack == "IS")
				{
					BID = cmbBID.SelectedValue.ToString();

				if (BID == "1")
				{
					BID_NEW = "BB";
						con_wh = _cBeauty.GetConnectionBB();
					}
				else if (BID == "2")
				{
					BID_NEW = "BC";
						con_wh = _cBeauty.GetConnectionBC();
					}
				}
				


				if (_chack == "IS")
				{
					SaveData_IS();
				}
				else if (_chack == "UP")
				{
					SaveData_UP();
				}
				

				this.Close();
			}

		}

		private void SaveData_UP()
		{
			string DVAL_ADJ = txtDVAL.Text;
			REMARK = "แก้ไขขายส่ง";

			//if (_DVAL != DVAL_ADJ && _TYPE_N != TYPE && BID_NEW != _BID)
			//{
			//	REMARK = "แก้ไข TYPE BRAND และ DVAL ขายส่ง";
			//}
			//else if ( _TYPE_N != TYPE && BID_NEW != _BID)
			//{
			//	REMARK = "แก้ไข  BRAND และ TYPE";
			//}
			//else if (BID_NEW != _BID && _TYPE_N != TYPE)
			//{
			//	REMARK = "แก้ไข  BRAND และ DVAL ขายส่ง";
			//}
			//else if (_DVAL != DVAL_ADJ && _TYPE_N != TYPE)
			//{
			//	REMARK = "แก้ไข TYPE  และ DVAL ขายส่ง";
			//}
			//else 	if (_TYPE_N != TYPE)
			//{
			//	REMARK = "แก้ไข TYPE ";
			//}
			//else if (BID_NEW != _BID)
			//{
			//	REMARK = "แก้ไข BRAND ";
			//}
			//else if (_DVAL != DVAL_ADJ)
			//{
			//	REMARK = "แก้ไข DVAL ขายส่ง";
			//}





			_cBeauty._WORKDATE = cDateTime.getDateForSql();
			
			

			string sql_LOG_ADJ = @"INSERT INTO  COMMISSION_LOG_ADJ (DOCNO,TYPE,TYPE_NEW,BRAND,WHCODE,STCODE,NET_TOTAL,NET_ADJ,DVAL,DVAL_ADJ,STCODE_LOG,REMARK,WORKEDATE)
								VALUES (@DOCNO,@TYPE,@TYPE_NEW,@BRAND,@WHCODE,@STCODE,@NET_TOTAL,@NET_ADJ,@DVAL,@DVAL_ADJ,@STCODE_LOG,@REMARK,@WORKEDATE)";

			string sql_COM_DOC_I = @"UPDATE COMMISSION_DOC_I 
									SET TYID = @TYPE, DVAL=@DVAL 
									WHERE ID = @ID AND DOCNO = @DOCNO AND WHCODE = @WHCODE";


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

						comm.CommandText = sql_COM_DOC_I;
						comm.Parameters.Clear();
						comm.Parameters.AddWithValue("@TYPE", TYPE);
						comm.Parameters.AddWithValue("@ID", _ID);
						comm.Parameters.AddWithValue("@DVAL", DVAL_ADJ);
						comm.Parameters.AddWithValue("@DOCNO", _docno);
						comm.Parameters.AddWithValue("@WHCODE", _whcode);
						comm.ExecuteNonQuery();

						comm.CommandText = sql_LOG_ADJ;
						comm.Parameters.Clear();
						comm.Parameters.AddWithValue("@DOCNO", txtDOCNO.Text);
						comm.Parameters.AddWithValue("@TYPE", _TYPE_N);
						comm.Parameters.AddWithValue("@TYPE_NEW", TYPE_NEW);
						comm.Parameters.AddWithValue("@BRAND", _BID);
						comm.Parameters.AddWithValue("@WHCODE", _whcode);
						comm.Parameters.AddWithValue("@STCODE", DBNull.Value);
						comm.Parameters.AddWithValue("@NET_TOTAL", _net);
						comm.Parameters.AddWithValue("@NET_ADJ", 0.00);
						comm.Parameters.AddWithValue("@DVAL", _DVAL);
						comm.Parameters.AddWithValue("@DVAL_ADJ", DVAL_ADJ);
						comm.Parameters.AddWithValue("@STCODE_LOG", _cBeauty._STCODE_LOG);
						comm.Parameters.AddWithValue("@REMARK", REMARK);
						comm.Parameters.AddWithValue("@WORKEDATE", _cBeauty._WORKDATE);
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
	
		private void SaveData_IS()
		{
			string REMARK = "ADD ขายส่ง";
			_cBeauty._WORKDATE = cDateTime.getDateForSql();

			
			string sql_ = @"SELECT * FROM MAS_WH WHERE WHCODE = '"+ txtwhcode.Text + "'";

			DataSet ds = cData.getDataSetWithSqlCommand(con_wh, sql_, 1000, true);
			if (ds.Tables[0].Rows.Count > 0)
			{
				foreach (DataRow dr in ds.Tables[0].Rows)
				{
					ABBNAME = dr["ABBNAME"].ToString();
				}
			}


			string sql_LOG_ADJ = @"INSERT INTO  COMMISSION_LOG_ADJ (DOCNO,TYPE,TYPE_NEW,BRAND,WHCODE,STCODE,NET_TOTAL,NET_ADJ,DVAL,DVAL_ADJ,STCODE_LOG,REMARK,WORKEDATE)
								VALUES (@DOCNO,@TYPE,@TYPE_NEW,@BRAND,@WHCODE,@STCODE,@NET_TOTAL,@NET_ADJ,@DVAL,@DVAL_ADJ,@STCODE_LOG,@REMARK,@WORKEDATE)";
			string sql_COM_DOC_I = @"INSERT INTO  COMMISSION_DOC_I (DOCNO,BID,TYID,WHCODE,WHNAME,STCODE,STNAME,ABBNO,NET,NET_TOTAL,DVAL,CFLAG)
								VALUES (@DOCNO,@BID,@TYID,@WHCODE,@WHNAME,@STCODE,@STNAME,@ABBNO,@NET,@NET_TOTAL,@DVAL,@CFLAG)";

			using (SqlConnection con = new SqlConnection(_cBeauty.GetConnectionBeautySystem()))
			{
				con.Open();
				SqlTransaction sqltrans = null;
				sqltrans = con.BeginTransaction();
				try
				{
					using (SqlCommand comm = new SqlCommand())
					{
						comm.CommandType = CommandType.Text;
						comm.CommandTimeout = 1000;
						comm.Connection = con;
						comm.Transaction = sqltrans;

						comm.CommandText = sql_COM_DOC_I;
						comm.Parameters.Clear();
						comm.Parameters.AddWithValue("@DOCNO", txtDOCNO.Text);
						comm.Parameters.AddWithValue("@BID", cmbBID.SelectedValue.ToString());
						comm.Parameters.AddWithValue("@TYID", cmbTYID.SelectedValue.ToString());
						comm.Parameters.AddWithValue("@WHCODE", txtwhcode.Text);
						comm.Parameters.AddWithValue("@WHNAME", ABBNAME);
						comm.Parameters.AddWithValue("@STCODE", DBNull.Value);
						comm.Parameters.AddWithValue("@STNAME", DBNull.Value);
						comm.Parameters.AddWithValue("@ABBNO", 1);
						comm.Parameters.AddWithValue("@NET", txtnet.Text);
						comm.Parameters.AddWithValue("@NET_TOTAL", txtnet.Text);
						comm.Parameters.AddWithValue("@DVAL", txtDVAL.Text);
						comm.Parameters.AddWithValue("@CFLAG", 0);
						comm.ExecuteNonQuery();

						comm.CommandText = sql_LOG_ADJ;
						comm.Parameters.Clear();
						comm.Parameters.AddWithValue("@DOCNO", txtDOCNO.Text);
						comm.Parameters.AddWithValue("@TYPE", DBNull.Value);
						comm.Parameters.AddWithValue("@TYPE_NEW", TYPE_NEW);
						comm.Parameters.AddWithValue("@BRAND", BID_NEW);
						comm.Parameters.AddWithValue("@WHCODE", txtwhcode.Text);
						comm.Parameters.AddWithValue("@STCODE", DBNull.Value);
						comm.Parameters.AddWithValue("@NET_TOTAL", txtnet.Text);
						comm.Parameters.AddWithValue("@NET_ADJ", 0.00);
						comm.Parameters.AddWithValue("@DVAL", txtDVAL.Text);
						comm.Parameters.AddWithValue("@DVAL_ADJ", DBNull.Value);
						comm.Parameters.AddWithValue("@STCODE_LOG", _cBeauty._STCODE_LOG);
						comm.Parameters.AddWithValue("@REMARK", REMARK);
						comm.Parameters.AddWithValue("@WORKEDATE", _cBeauty._WORKDATE);
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
	}
}
