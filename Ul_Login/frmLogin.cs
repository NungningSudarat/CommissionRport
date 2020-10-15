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

namespace CommissionRport.Ul_Login
{
	public partial class frmLogin : Form
	{
        cBeauty _cBeauty;
        string _DPCODE;
        public frmLogin()
        {
            InitializeComponent();
        }
        public frmLogin(cBeauty cBeauty, string DPCODE)
        {
            InitializeComponent();
            _cBeauty = cBeauty;
            _DPCODE = DPCODE;
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
            this.Close();
            return;
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (CheckLogin())
            {
                this.Close();
            }
            else
            {
               
                MessageBox.Show("ข้อมูลไม่ถูกต้อง", "เกิดข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                            _cBeauty._STCODE_LOG = dataTable.Rows[0]["STCODE"].ToString();
                            _cBeauty._DPCODE_LOG = dataTable.Rows[0]["DPCODE"].ToString();
                            _cBeauty._STNAME_LOG = dataTable.Rows[0]["STNAME"].ToString();
							if (_DPCODE == _cBeauty._DPCODE_LOG)
							{
                                result = true;
                            }else
							{
                                result = false;
                            }
                           
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