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
	public partial class frmLOG_WHCODE_new : Form
	{
		cBeauty _cBeauty;
		string _docno;
		string _whcode;
		string _stcode;
		string _net;
		string _TYID;
		string _BID;
		int _ID;

		public frmLOG_WHCODE_new()
		{
			InitializeComponent();
		}
		public frmLOG_WHCODE_new(cBeauty cBeauty, string docno, string whcode, string stcode, string net, string TYID, string BID, int ID)
		{
			InitializeComponent();
			_docno = docno;
			_whcode = whcode;
			_stcode = stcode;
			_net = net;
			_TYID = TYID;
			_BID = BID;
			_ID = ID;
			_cBeauty = cBeauty;
		}

		private void frmLOG_WHCODE_new_Load(object sender, EventArgs e)
		{
			txtDOCNO.Text = _docno;
			txtBID.Text = _BID;
			txtnet.Text = _net;
			txtstcode.Text = _stcode;
			txtTYID.Text = _TYID;
			txtwhcode.Text = _whcode;
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}


		private void btnSumbit_Click(object sender, EventArgs e)
		{
			if ( txtWHCODEnew.Text.Length <= 0)
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
				SaveData();
				this.Close();
			}

		}


		private void SaveData()
		{

			string REMARK = "โอนยอดระหว่างสาขา จากสาขา "+ _whcode +" ไปยังสาขา "+ txtWHCODEnew.Text;
			_cBeauty._WORKDATE = cDateTime.getDateForSql();

			string sql_LOG_ADJ = @"INSERT INTO COMMISSION_LOG_ADJ (DOCNO,[TYPE],BRAND,WHCODE,WHCODE_NEW,STCODE,NET_TOTAL,NET_ADJ,STCODE_LOG,REMARK,WORKEDATE)
						VALUES (@DOCNO,@TYPE,@BRAND,@WHCODE,@WHCODE_NEW,@STCODE,@NET_TOTAL,@NET_ADJ,@STCODE_LOG,@REMARK,@WORKEDATE)";

			string sql_COM_DOC_I = @"UPDATE COMMISSION_DOC_I 
						SET WHCODE = @WHCODE
						WHERE ID = @ID AND DOCNO = @DOCNO ";


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

						comm.CommandText = sql_LOG_ADJ;
						comm.Parameters.Clear();
						comm.Parameters.AddWithValue("@DOCNO", txtDOCNO.Text);
						comm.Parameters.AddWithValue("@TYPE", _TYID);
						comm.Parameters.AddWithValue("@BRAND", _BID);
						comm.Parameters.AddWithValue("@WHCODE", _whcode);
						comm.Parameters.AddWithValue("@WHCODE_NEW", txtWHCODEnew.Text);
						comm.Parameters.AddWithValue("@STCODE", DBNull.Value);
						comm.Parameters.AddWithValue("@NET_TOTAL", 0);
						comm.Parameters.AddWithValue("@NET_ADJ", 0);
						comm.Parameters.AddWithValue("@STCODE_LOG", _cBeauty._STCODE_LOG);
						comm.Parameters.AddWithValue("@REMARK", REMARK);
						comm.Parameters.AddWithValue("@WORKEDATE", _cBeauty._WORKDATE);
						comm.ExecuteNonQuery();

						comm.CommandText = sql_COM_DOC_I;
						comm.Parameters.Clear();
						comm.Parameters.AddWithValue("@ID", _ID);
						comm.Parameters.AddWithValue("@DOCNO", _docno);
						comm.Parameters.AddWithValue("@WHCODE", txtWHCODEnew.Text);
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
