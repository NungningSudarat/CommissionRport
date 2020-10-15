
using cBeautyComm;
using CommissionRport.UI_ADJ;
using CommissionRport.UI_Report;
using CommissionRport.UI_Report.ComOnline;
using CommissionRport.Ul_Approve;
using CommissionRport.Ul_Check.Detail;
using CommissionRport.Ul_Check.Person;
using CommissionRport.Ul_Check.Sale;
using CommissionRport.Ul_Check.WholeSale;
using CommissionRport.Ul_Details;
using CommissionRport.Ul_Login;
using CommissionRport.Ul_MASTER;
using kBeauty_Libary.Helper;
using kBeauty_Libary.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Deployment.Application;
using System.Windows.Forms;

namespace CommissionRport.UI_Main
{
	public partial class frmMain : Form
	{
  //      public string conBC = "Data Source=192.168.1.24,1833;Initial Catalog=CMD-BX;User ID=sa;Password=0211";
		//public string conBB = "Data Source=192.168.1.220,1433;Initial Catalog=CMD-BX;User ID=sa;Password=0211";
		//public string conSO = "Data Source=192.168.1.125;Initial Catalog=kBeautySaleOder;User ID=sa;Password=0211";
		//public string conbeauty = "Data Source=192.168.10.243;Initial Catalog=BeautySystem;User ID=sa;Password=0211";
  //      public int _whBB  = 1;
		//public int _whBC = 5;
		//public int _whFCBB = 3;
		//public int _whFCBC = 0;
		//public string conAX = "[192.168.10.199].[AODPRD].[dbo].";
		//public string conOnline = "[192.168.1.125].[kBeautySaleOder].[dbo].";

        private string smsUpdate = string.Empty;
        private string verion = "";
        //ตัวแปรฟอร์ม แสดง Progreesbar ขณะดาวน์โหลดเวอร์ชั่นใหม่บนเซอร์ฟเวอร์
        private frmUpdateProgress frmUpdateProgress = null;


        private cBeauty _cBeauty;

		private ArrayList _menulist;

		/// <summary>
		/// //////////////////////////////////////////////////////////
		private void updateProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ถ้าเป็นการรันโปรแกรมจากการติดตั้งด้วย ClickOnce
            if (ApplicationDeployment.IsNetworkDeployed)
            {
                //เรียกเมธอด UpdateApplication
                UpdateApplication();
            }
        }

        private void UpdateApplication()
        {
            //ถ้าเป็นการรันโปรแกรมจากการติดตั้งด้วย ClickOnce
            if (ApplicationDeployment.IsNetworkDeployed)
            {
                //ประกาศตัวแปร checkUpdate เป็นประเภท ApplicationDeployment
                //กำหนดค่าให้มันเป็น CurrentDeployment ตัวที่ Deploy ล่าสุด
                ApplicationDeployment checkUpdate = ApplicationDeployment.CurrentDeployment;

                //สร้าง Event checkUpdate_CheckForUpdateCompleted
                checkUpdate.CheckForUpdateCompleted += new CheckForUpdateCompletedEventHandler(checkUpdate_CheckForUpdateCompleted);

                //สร้างEvent checkUpdate_CheckForUpdateProgressChanged
                checkUpdate.CheckForUpdateProgressChanged += new DeploymentProgressChangedEventHandler(checkUpdate_CheckForUpdateProgressChanged);

                //เรียกเมธอด CheckForUpdateAsync:ตรวจสอบเวอร์ชั่นใหม่บนเซอร์ฟเวอร์
                checkUpdate.CheckForUpdateAsync();

                //เรียกเมธอด แสดง ProgrssBar
                showProgrssBar();
            }
        }

        private void checkUpdate_CheckForUpdateProgressChanged(object sender, DeploymentProgressChangedEventArgs e)
        {
            //ประกาศตัวแปร progress เพื่อเก็บข้อมูลขนาดไฟล์ ของเวอร์ชั่นใหม่บนเซอร์ฟเวอร์
            string progress = String.Format("Downloading: {0}. {1:D}K of {2:D}K downloaded.", GetProgressString(e.State), e.BytesCompleted / 1024, e.BytesTotal / 1024);

            //นำข้อมูลใน progress ไปแสดงบนป้ายชื่อของ toolStripStatusLabel1.Text, label1.Text  ของฟอร์ม frmProgress
            frmUpdateProgress.toolStripStatusLabel1.Text = progress;
            frmUpdateProgress.label1.Text = progress;

            //นำค่าเปอร์เซ็นต์ความคืบหน้างานแบบอะซิงโครนัสที่ได้รับ จากตัวแปร e ไปแสดงบน toolStripProgressBar1 ของฟอร์ม frmProgress
            frmUpdateProgress.toolStripProgressBar1.Value = e.ProgressPercentage;
        }

        private void checkUpdate_CheckForUpdateCompleted(object sender, CheckForUpdateCompletedEventArgs e)
        {
            //ปิดฟอร์ม frmProgress
            frmUpdateProgress.Close();

            if (e.Error != null)
            {
                MessageBox.Show("ERROR: Could not retrieve new version of the application. Reason: \n" +
                    e.Error.Message + "\nPlease report this error to the system administrator.");
                return;
            }
            else if (e.Cancelled == true)
            {
                MessageBox.Show("The update was cancelled.");
            }

            //ถ้าเป็นการ Update
            if (e.UpdateAvailable)
            {
                //ประกาศตัวแปร verion โดยดึงค่าเวอร์ชั่นใหม่ บนเซอร์เวอร์
                string verion = e.AvailableVersion.ToString();

                //โดย MessageBox แจ้งให้ผู้ใช้งานทราบ ว่ามีเวอร์ชั่นใหม่
                //ขณะเดียวกันก็แสดงข้อมูลในตัวแปร smsUpdate ซึ่งสมมุติว่า เป็นการดึงรายการปรับปรุง ของเวอร์ชั่นใหม่ บนเซอร์ฟเวอร์ เพื่อให้ผู้ใช้งานทราบ
                //MessageBox.Show("โปรแกรมมีเวอร์ชั่นใหม่ [" + verion + "]"
                //       + Environment.NewLine + smsUpdate + Environment.NewLine +
                //       "กรุณา Update เพื่อให้คุณทันสมัย...", "ผลการตรวจสอบ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //เรียกเมธอด BeginUpdate เพื่อเริ่ม Update เวอร์ชั่นใหม่
                BeginUpdate();
            }
        }

        private void BeginUpdate()
        {
            //ประกาศตัวแปร beginUpdate เป็นประเภท ApplicationDeployment และกำหนดค่าให้เป็น CurrentDeployment (กล่าวคือโปรแกรมที่ติดตั้งล่าสุด ของเครื่องของ ผู้ใช้งาน)
            ApplicationDeployment beginUpdate = ApplicationDeployment.CurrentDeployment;

            //สร้าง Event beginUpdate_UpdateCompleted
            beginUpdate.UpdateCompleted += new AsyncCompletedEventHandler(beginUpdate_UpdateCompleted);

            //สร้าง Event beginUpdate_UpdateProgressChanged
            beginUpdate.UpdateProgressChanged += new DeploymentProgressChangedEventHandler(beginUpdate_UpdateProgressChanged);

            //เรียกเมธอด UpdateAsync เพื่อ Update แบบอะซิงโครนัส
            beginUpdate.UpdateAsync();

            //เรียกเมธอด showProgrssBar
            showProgrssBar();
        }

        private void beginUpdate_UpdateProgressChanged(object sender, DeploymentProgressChangedEventArgs e)
        {
            //ประกาศตัวแปร progress เพื่อเก็บข้อมูลขนาดไฟล์ ของเวอร์ชั่นใหม่บนเซอร์ฟเวอร์
            String progressText = String.Format("{0:D}K out of {1:D}K downloaded - {2:D}% complete", e.BytesCompleted / 1024, e.BytesTotal / 1024, e.ProgressPercentage);

            //นำข้อมูลใน progress ไปแสดงบนป้ายชื่อของ toolStripStatusLabel1.Text, label1.Text  ของฟอร์ม frmProgress
            frmUpdateProgress.toolStripStatusLabel1.Text = progressText;
            frmUpdateProgress.label1.Text = progressText;

            //นำค่าเปอร์เซ็นต์ความคืบหน้างานแบบอะซิงโครนัสที่ได้รับ จากตัวแปร e ไปแสดงบน toolStripProgressBar1 ของฟอร์ม frmProgress
            frmUpdateProgress.toolStripProgressBar1.Value = e.ProgressPercentage;
        }

        private void beginUpdate_UpdateCompleted(object sender, AsyncCompletedEventArgs e)
        {
            //ปิดฟอร์ม frmProgress
            frmUpdateProgress.Close();

            if (e.Cancelled)
            {
                MessageBox.Show("The update of the application's latest version was cancelled.");
                return;
            }
            else if (e.Error != null)
            {
                MessageBox.Show("ERROR: Could not install the latest version of the application. Reason: \n" + e.Error.Message + "\nPlease report this error to the system administrator.");
                return;
            }

            //เมื่อ Update เรียบร้อยแล้ว ClickOnce จะ ปิดและเปิดโปรแกรม ให้ใหม่
            Application.Restart();

            //String ApplicationEntryPoint = ApplicationDeployment.CurrentDeployment.UpdatedApplicationFullName;
            //String ApplicationEntryPoint = ApplicationDeployment.CurrentDeployment.UpdateLocation.AbsoluteUri;

            //Process.Start(ApplicationEntryPoint);
        }

        private string GetProgressString(DeploymentProgressState state)
        {
            if (state == DeploymentProgressState.DownloadingApplicationFiles)
            {
                return "application files";
            }
            else if (state == DeploymentProgressState.DownloadingApplicationInformation)
            {
                return "application manifest";
            }
            else
            {
                return "deployment manifest";
            }
        }

        private void showProgrssBar()
        {
            //สร้างออบเจ็กต์ ใหม่ให้ตัวแปร frmProgress
            frmUpdateProgress = new frmUpdateProgress();

            //ลบค่าบนป้าย toolStripStatusLabel1
            frmUpdateProgress.toolStripStatusLabel1.Text = string.Empty;

            ////ลบค่าบนป้าย toolStripProgressBar1
            frmUpdateProgress.toolStripProgressBar1.Value = 0;

            //แสดงฟอร์ม frmProgress
            frmUpdateProgress.ShowDialog();
        }
   
        /// </summary>
        ///

        public frmMain()
		{
			InitializeComponent();
            _cBeauty = new cBeauty();
            _menulist = new ArrayList();

            if (ApplicationDeployment.IsNetworkDeployed)
            {
                //รันโปรแกรมจากการติดตั้งของ Clickonce
                //ดึงเวอร์ชั่นไปแสดงบนไตเติ้ล ของฟอร์ม และป้ายชื่อ(Label)
                verion = ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString();
                this.Text =  " Version : " + verion;
            }
            else
            {
                //รันจากการ Debug โปรแกรมบน VS2008
                //ให้แสดงข้อมความอื่น บนไตเติ้ล ของฟอร์ม และป้ายชื่อ
                verion = "Debug";
                this.Text = " Version " + verion+" [not deployed via ClickOnce]";
                //lblVersion.Text = "Version : [not deployed via ClickOnce]";
            }
        }

        private void Init()
        {
            this.WindowState = FormWindowState.Maximized;

            frmFirst frm = new frmFirst();
            frm.Text = "หน้าแรก";
            tabControl1.TabPages.Add(frm);

            frmMainLogin frm_login = new frmMainLogin(_cBeauty);
            frm_login.Text = "เข้าสู่ระบบ";
            tabControl1.TabPages.Add(frm_login);

            //MenuAdmin();
        }
       
        private void frmMain_Load(object sender, EventArgs e)
		{
            smsUpdate =
               "ปรับปรุง:" + Environment.NewLine;
            //"1. เพิ่มรายงานสินค้า พร้อมราคาขาย , ราคาโปรโมชั่น" + Environment.NewLine;

            //ถ้าเป็นการรันโปรแกรมจากการติดตั้งด้วย ClickOnce
            if (ApplicationDeployment.IsNetworkDeployed)
            {
                //เรียกเมธอด UpdateApplication
                UpdateApplication();
            }

            Init();
        }

		private void mnuExit_Click(object sender, EventArgs e)
		{
			cMessage.Exit();
		}


	

		private void ขายส่BBToolStripMenuItem_Click(object sender, EventArgs e)
		{
            if (_cBeauty._LoginCompleted && !_menulist.Contains(ขายส่BBToolStripMenuItem.Text))
            {
                frmCheckWholeSale frm = new frmCheckWholeSale(_cBeauty, _cBeauty._BID_BB, _cBeauty._whBB, ref _menulist);
                frm.Text = ขายส่BBToolStripMenuItem.Text;
                tabControl1.TabPages.Add(frm);
                _menulist.Add(ขายส่BBToolStripMenuItem.Text);
            }
        }

        private void ขายสงBCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_cBeauty._LoginCompleted && !_menulist.Contains(ขายสงBCToolStripMenuItem.Text))
            {
                frmCheckWholeSale frm = new frmCheckWholeSale(_cBeauty, _cBeauty._BID_BC,_cBeauty._whBC, ref _menulist);
                frm.Text = ขายสงBCToolStripMenuItem.Text;
                tabControl1.TabPages.Add(frm);
                _menulist.Add(ขายสงBCToolStripMenuItem.Text);
            }
        }

		

		private void importยอดขายToolStripMenuItem_Click(object sender, EventArgs e)
		{
            //if (_cBeauty._LoginCompleted && !_menulist.Contains(importยอดขายToolStripMenuItem.Text) && _cBeauty._DPCODE_LOG_Main == "IT")
            if (_cBeauty._LoginCompleted && !_menulist.Contains(importยอดขายToolStripMenuItem.Text) )
                {
                frmSale frm = new frmSale(_cBeauty, ref _menulist);
                frm.Text = importยอดขายToolStripMenuItem.Text;
                tabControl1.TabPages.Add(frm);
                _menulist.Add(importยอดขายToolStripMenuItem.Text);
            }
        }

	

		private void ตรวจสอบยอดขายรายเดอนToolStripMenuItem_Click(object sender, EventArgs e)
		{
            //if (_cBeauty._LoginCompleted && !_menulist.Contains(ตรวจสอบยอดขายรายเดอนToolStripMenuItem.Text) && (_cBeauty._DPCODE_LOG_Main == "IT" || _cBeauty._DPCODE_LOG_Main == "OP-BB"))
            if (_cBeauty._LoginCompleted && !_menulist.Contains(ตรวจสอบยอดขายรายเดอนToolStripMenuItem.Text) )
            {
                frmBR_Approve frm = new frmBR_Approve(_cBeauty, ref _menulist);
                frm.Text = ตรวจสอบยอดขายรายเดอนToolStripMenuItem.Text;
                tabControl1.TabPages.Add(frm);
                _menulist.Add(ตรวจสอบยอดขายรายเดอนToolStripMenuItem.Text);

            }
        }

		

		private void ขายสงToolStripMenuItem_Click(object sender, EventArgs e)
		{
            if (ModifierKeys == (Keys.Shift | Keys.Control))
            {
                if (_cBeauty._LoginCompleted && !_menulist.Contains(ขายสงBCToolStripMenuItem.Text))
                {
                    frmWholeSale_MASTER frm = new frmWholeSale_MASTER(_cBeauty, ref _menulist);
                    frm.Text = ขายสงBCToolStripMenuItem.Text;
                    tabControl1.TabPages.Add(frm);
                    _menulist.Add(ขายสงBCToolStripMenuItem.Text);
                }
            }
            else
            {
                cMessage.Error_AdminPermission();
            }
        }


		private void รายบลToolStripMenuItem_Click(object sender, EventArgs e)
		{
            if (_cBeauty._LoginCompleted && !_menulist.Contains(รายบลToolStripMenuItem.Text))
            {
                frmCheckPerson frm = new frmCheckPerson(_cBeauty, _cBeauty._BID_BB, _cBeauty._CD_Foodpanda, ref _menulist);
                frm.Text = รายบลToolStripMenuItem.Text;
                tabControl1.TabPages.Add(frm);
                _menulist.Add(รายบลToolStripMenuItem.Text);
            }
        }

	

		private void รายบลออนไลนBBToolStripMenuItem_Click(object sender, EventArgs e)
		{
            if (_cBeauty._LoginCompleted && !_menulist.Contains(รายบลออนไลนBBToolStripMenuItem.Text))
            {
                frmCheckPersonSaleOrder frm = new frmCheckPersonSaleOrder(_cBeauty, _cBeauty._whBB, ref _menulist);
                frm.Text = รายบลออนไลนBBToolStripMenuItem.Text;
                tabControl1.TabPages.Add(frm);
                _menulist.Add(รายบลออนไลนBBToolStripMenuItem.Text);
            }
        }

		private void รายบลออนไลนBCToolStripMenuItem_Click(object sender, EventArgs e)
		{
            if (_cBeauty._LoginCompleted && !_menulist.Contains(รายบลออนไลนBCToolStripMenuItem.Text))
            {
                frmCheckPersonSaleOrder frm = new frmCheckPersonSaleOrder(_cBeauty, _cBeauty._whBC, ref _menulist);
                frm.Text = รายบลออนไลนBCToolStripMenuItem.Text;
                tabControl1.TabPages.Add(frm);
                _menulist.Add(รายบลออนไลนBCToolStripMenuItem.Text);
            }
        }

		private void รายวนหนารานBBToolStripMenuItem_Click(object sender, EventArgs e)
		{
            if (_cBeauty._LoginCompleted && !_menulist.Contains(รายวนหนารานBBToolStripMenuItem.Text))
            {
                frmCheckPerson_byDay frm = new frmCheckPerson_byDay(_cBeauty, _cBeauty._BID_BB, _cBeauty._CD_Foodpanda, ref _menulist);
                frm.Text = รายวนหนารานBBToolStripMenuItem.Text;
                tabControl1.TabPages.Add(frm);
                _menulist.Add(รายวนหนารานBBToolStripMenuItem.Text);
            }
        }

		private void รายวนหนารานBCToolStripMenuItem_Click(object sender, EventArgs e)
		{
            if (_cBeauty._LoginCompleted && !_menulist.Contains(รายวนหนารานBCToolStripMenuItem.Text))
            {
                frmCheckPerson_byDay frm = new frmCheckPerson_byDay(_cBeauty, _cBeauty._BID_BC, _cBeauty._CD_Foodpanda, ref _menulist);
                frm.Text = รายวนหนารานBCToolStripMenuItem.Text;
                tabControl1.TabPages.Add(frm);
                _menulist.Add(รายวนหนารานBCToolStripMenuItem.Text);
            }
        }

		private void รายวนออนไลนBBToolStripMenuItem_Click(object sender, EventArgs e)
		{

            if (_cBeauty._LoginCompleted && !_menulist.Contains(รายวนออนไลนBBToolStripMenuItem.Text))
            {
                frmCheckPersonSaleOrder_byDay frm = new frmCheckPersonSaleOrder_byDay(_cBeauty, _cBeauty._whBB, ref _menulist);
                frm.Text = รายวนออนไลนBBToolStripMenuItem.Text;
                tabControl1.TabPages.Add(frm);
                _menulist.Add(รายวนออนไลนBBToolStripMenuItem.Text);
            }
        }

		private void รายวนออนไลนBCToolStripMenuItem_Click(object sender, EventArgs e)
		{
            if (_cBeauty._LoginCompleted && !_menulist.Contains(รายวนออนไลนBCToolStripMenuItem.Text))
            {
                frmCheckPersonSaleOrder_byDay frm = new frmCheckPersonSaleOrder_byDay(_cBeauty, _cBeauty._whBC, ref _menulist);
                frm.Text = รายวนออนไลนBCToolStripMenuItem.Text;
                tabControl1.TabPages.Add(frm);
                _menulist.Add(รายวนออนไลนBCToolStripMenuItem.Text);
            }
        }

        private void รายบลหนารานBCToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (_cBeauty._LoginCompleted && !_menulist.Contains(รายบลหนารานBCToolStripMenuItem.Text))
            {

                frmCheckPerson frm = new frmCheckPerson(_cBeauty, _cBeauty._BID_BC, _cBeauty._CD_Foodpanda, ref _menulist);
                frm.Text = รายบลหนารานBCToolStripMenuItem.Text;
                tabControl1.TabPages.Add(frm);
                _menulist.Add(รายบลหนารานBCToolStripMenuItem.Text);

            }
        }

		private void สรปยอดขายรายคนBBToolStripMenuItem_Click(object sender, EventArgs e)
		{
            if (_cBeauty._LoginCompleted && !_menulist.Contains(สรปยอดขายรายคนBBToolStripMenuItem.Text))
            {
                frmPersonDetails frm = new frmPersonDetails(_cBeauty, _cBeauty._BID_BB, ref _menulist);
                frm.Text = สรปยอดขายรายคนBBToolStripMenuItem.Text;
                tabControl1.TabPages.Add(frm);
                _menulist.Add(สรปยอดขายรายคนBBToolStripMenuItem.Text);

            }
        }

		private void สรปยอดขายรายคนBCToolStripMenuItem_Click(object sender, EventArgs e)
		{
            if (_cBeauty._LoginCompleted && !_menulist.Contains(สรปยอดขายรายคนBCToolStripMenuItem.Text))
            {
                frmPersonDetails frm = new frmPersonDetails(_cBeauty, _cBeauty._BID_BC, ref _menulist);
                frm.Text = สรปยอดขายรายคนBCToolStripMenuItem.Text;
                tabControl1.TabPages.Add(frm);
                _menulist.Add(สรปยอดขายรายคนBCToolStripMenuItem.Text);

            }
        }

		private void สรปยอดขายรายสาขาBBToolStripMenuItem_Click(object sender, EventArgs e)
		{
            if (_cBeauty._LoginCompleted && !_menulist.Contains(สรปยอดขายรายสาขาBBToolStripMenuItem.Text))
            {
                frmWarehouseDetails frm = new frmWarehouseDetails(_cBeauty, _cBeauty._BID_BB, ref _menulist);
                frm.Text = สรปยอดขายรายสาขาBBToolStripMenuItem.Text;
                tabControl1.TabPages.Add(frm);
                _menulist.Add(สรปยอดขายรายสาขาBBToolStripMenuItem.Text);

            }
        }

		private void สรปยอดขายรายสาขาBCToolStripMenuItem_Click(object sender, EventArgs e)
		{
            if (_cBeauty._LoginCompleted && !_menulist.Contains(สรปยอดขายรายสาขาBCToolStripMenuItem.Text))
            {
                frmWarehouseDetails frm = new frmWarehouseDetails(_cBeauty, _cBeauty._BID_BC, ref _menulist);
                frm.Text = สรปยอดขายรายสาขาBCToolStripMenuItem.Text;
                tabControl1.TabPages.Add(frm);
                _menulist.Add(สรปยอดขายรายสาขาBCToolStripMenuItem.Text);

            }
        }

	

		private void รายบลหนารานFoodpandaToolStripMenuItem_Click(object sender, EventArgs e)
		{
            if (_cBeauty._LoginCompleted && !_menulist.Contains(รายบลหนารานFoodpandaToolStripMenuItem.Text))
            {
                frmCheckPerson_Foodpanda frm = new frmCheckPerson_Foodpanda(_cBeauty, _cBeauty._BID_BB, _cBeauty._CD_Foodpanda, ref _menulist);
                frm.Text = รายบลหนารานFoodpandaToolStripMenuItem.Text;
                tabControl1.TabPages.Add(frm);
                _menulist.Add(รายบลหนารานFoodpandaToolStripMenuItem.Text);
            }
        }

		

		private void รายวนหนารานFoodpandaToolStripMenuItem_Click(object sender, EventArgs e)
		{
            if (_cBeauty._LoginCompleted && !_menulist.Contains(รายวนหนารานFoodpandaToolStripMenuItem.Text))
            {
                frmCheckPerson_Foodpanda_byDay frm = new frmCheckPerson_Foodpanda_byDay(_cBeauty, _cBeauty._BID_BB, _cBeauty._CD_Foodpanda, ref _menulist);
                frm.Text = รายวนหนารานFoodpandaToolStripMenuItem.Text;
                tabControl1.TabPages.Add(frm);
                _menulist.Add(รายวนหนารานFoodpandaToolStripMenuItem.Text);
            }
        }


		private void adjustToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//if (_cBeauty._LoginCompleted && !_menulist.Contains(adjustToolStripMenuItem.Text) && (_cBeauty._DPCODE_LOG_Main  == "IT" || _cBeauty._DPCODE_LOG_Main  == "FA"))
			if (_cBeauty._LoginCompleted && !_menulist.Contains(adjustToolStripMenuItem.Text) )
			{
				frmADJ frm = new frmADJ(_cBeauty, ref _menulist);
				frm.Text = adjustToolStripMenuItem.Text;
				tabControl1.TabPages.Add(frm);
				_menulist.Add(adjustToolStripMenuItem.Text);

			}
		}

		private void คำนวณComOmlineToolStripMenuItem_Click(object sender, EventArgs e)
		{
            //if (_cBeauty._LoginCompleted && !_menulist.Contains(คำนวณComOmlineToolStripMenuItem.Text) && (_cBeauty._DPCODE_LOG_Main == "IT" || _cBeauty._DPCODE_LOG_Main == "HR"))
            if (_cBeauty._LoginCompleted && !_menulist.Contains(คำนวณComOmlineToolStripMenuItem.Text) )
            {
                frmCom_OnlineReport frm = new frmCom_OnlineReport(_cBeauty, ref _menulist);
                frm.Text = คำนวณComOmlineToolStripMenuItem.Text;
                tabControl1.TabPages.Add(frm);
                _menulist.Add(คำนวณComOmlineToolStripMenuItem.Text);

            }
        }

		
		private void จำนวนวนพนกงานทำงานToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_cBeauty._DPCODE_LOG_Main == "IT" || _cBeauty._DPCODE_LOG_Main == "HR")
            {
                frmNumDay_ImportDialog frm = new frmNumDay_ImportDialog(_cBeauty);
                frm.ShowDialog();
            }
        }

		private void tAGETComOnlineToolStripMenuItem_Click(object sender, EventArgs e)
		{
            if (_cBeauty._DPCODE_LOG_Main == "IT" || _cBeauty._DPCODE_LOG_Main == "HR")
            {
                frmTaget_Online_ImportDialog frm = new frmTaget_Online_ImportDialog(_cBeauty);
                frm.ShowDialog();
            }
        }

		private void tAGETComปลกToolStripMenuItem_Click(object sender, EventArgs e)
		{
            if (_cBeauty._DPCODE_LOG_Main == "IT" || _cBeauty._DPCODE_LOG_Main == "HR")
            {
                frmTaget_Retail_ImportDialog frm = new frmTaget_Retail_ImportDialog(_cBeauty);
                frm.ShowDialog();
            }
        }

		private void คำนวณComปลกToolStripMenuItem_Click(object sender, EventArgs e)
		{
            if (_cBeauty._LoginCompleted && !_menulist.Contains(คำนวณComปลกToolStripMenuItem.Text) && (_cBeauty._DPCODE_LOG_Main == "IT" || _cBeauty._DPCODE_LOG_Main == "HR"))
            {
                frmCom_RetailReport frm = new frmCom_RetailReport(_cBeauty, ref _menulist);
                frm.Text = คำนวณComปลกToolStripMenuItem.Text;
                tabControl1.TabPages.Add(frm);
                _menulist.Add(คำนวณComปลกToolStripMenuItem.Text);

            }
        }

		
	}
}
