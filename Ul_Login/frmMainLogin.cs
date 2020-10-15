
using cBeautyComm;
using kBeauty_Libary.Helper;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CommissionRport.Ul_Login
{
	public partial class frmMainLogin : Form
	{
		//private string _con;

  //      public string  _STCODE_LOG;
  //      public string _DPCODE_LOG;
  //      public string _STNAME_LOG;

        cBeauty _cBeauty;
        public frmMainLogin()
		{
			InitializeComponent();
		}
		public frmMainLogin(cBeauty cBeauty)
		{
			InitializeComponent();
            _cBeauty = cBeauty;
		}
		private void frmMainLogin_Load(object sender, EventArgs e)
		{
			this.ActiveControl = txtUser;
		}

		private void txtUser_KeyDown(object sender, KeyEventArgs e)
		{
            if (e.KeyCode == Keys.Enter)
            {
                txtPassword.Focus();
            }
        }

		private void txtPassword_KeyDown(object sender, KeyEventArgs e)
		{
            if (e.KeyCode == Keys.Enter)
            {
                btnSubmit.Focus();
            }
        }

		private void btnCancel_Click(object sender, EventArgs e)
		{
            cMessage.Exit();
        }
		private void btnSubmit_Click(object sender, EventArgs e)
		{
            if (CheckLogin())
            {
                _cBeauty._LoginCompleted = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("ไม่พบข้อมูล","เกิดข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private bool CheckLogin()
        {

            bool result = false;

            string sql = @"SELECT A.STCODE,A.FULLNAME AS STNAME, A.DPCODE
           FROM MAS_USER_SYSTEM A
            WHERE A.STCODE = @STCODE
            AND A.PASS = @STPASSWORD
            AND FLAG = 1";

            using (SqlConnection conn = new SqlConnection(_cBeauty.GetConnectionBS()))
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
                        comm.Parameters.AddWithValue("@STCODE", txtUser.Text);
                        comm.Parameters.AddWithValue("@STPASSWORD", txtPassword.Text);
                        var dataReader = comm.ExecuteReader();
                        var dataTable = new DataTable();
                        dataTable.Load(dataReader);

                        if (dataTable.Rows.Count > 0)
                        {
                            //string sql_t = @"SELECT STCODE,TITLE FROM COMMISSION_STCODE_TITLE where CFLAG = 0 and stcode = '"+ txtUser.Text +"'";
                            //DataSet ds = cData.getDataSetWithSqlCommand(_cBeauty.GetConnectionBeautySystem(), sql_t, 10000, true);

                            //if (ds.Tables[0].Rows.Count > 0)
                            //{
                            //    foreach (DataRow dr in ds.Tables[0].Rows)
                            //    {
                            //        _cBeauty._STCODE_LOG_TITLE = dr["TITLE"].ToString();
                            //    }
                            //}

                            _cBeauty._STCODE_LOG_Main = dataTable.Rows[0]["STCODE"].ToString();
                            _cBeauty._DPCODE_LOG_Main = dataTable.Rows[0]["DPCODE"].ToString();
                            _cBeauty._STNAME_LOG_Main = dataTable.Rows[0]["STNAME"].ToString();
                            result = true;
                        }
                        
                    }
                }
                catch (Exception ex)
                {
                    cMessage.Error_NotCaption(ex.Message);
                }
            }
             return result;
        }
	}
}
