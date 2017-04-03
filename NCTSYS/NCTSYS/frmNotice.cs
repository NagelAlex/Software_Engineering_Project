using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Text.RegularExpressions;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Net.Mail;

namespace NCTSYS
{
    public partial class frmNotice : Form
    {
        private Form parent;
        public frmNotice()
        {
            InitializeComponent();
        }
        public frmNotice(Form parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmNotice_Load(object sender, EventArgs e)
        {

            dtpCurrDate.Enabled = false;
            
        }

        private void btnCheckDueNct_Click(object sender, EventArgs e)
        {
            getDueForNct();
        }
        public void getDueForNct()
        {
            //Connect to the DB
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //Define SQL Query
            String strSQL = "SELECT Reg_No,CAR_MAKE as MAKE,CAR_MODEL as MODEL ,First_Reg_Date AS REGDATE, SURNAME, FORENAME, EMAIL FROM CARS C, OWNERS O " +
                            "WHERE O.PPSN = C.CURRENTOWNER AND CAR_STATUS = 'A' AND TRUNC(Add_Months(First_Reg_Date,48)) = TRUNC(Add_Months(SYSdate,1)) OR " +
                            "TRUNC(Add_Months(First_Reg_Date,72)) = TRUNC(Add_Months(SYSdate,1)) OR " +
                            "TRUNC(Add_Months(First_Reg_Date,96)) = TRUNC(Add_Months(SYSdate,1)) OR " +
                            "TRUNC(Add_Months(First_Reg_Date,120)) = TRUNC(Add_Months(SYSdate,1)) OR " +
                            "TRUNC(Add_Months(First_Reg_Date,132)) = TRUNC(Add_Months(SYSdate,1))";

            //Execute SQL Query 
            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            OracleDataAdapter oda = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();

            oda.Fill(ds);

            if (ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("No active Vihicles due for NCT Today. \nPlease do remember this function must be irritated daily!", "Confirmation",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                grdNotice.DataSource = ds.Tables[0];
                grdNotice.AllowUserToAddRows = false;
                this.grdNotice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            }
                // close DB
                myConn.Close();
                // make data grid visible
                grdNotice.Visible = true;
                //make notiece button visible
                btnNotice.Visible = true;
        }

        private void btnNotice_Click(object sender, EventArgs e)
        {
            issueNotice();
        }

        private void issueNotice()
        {
            foreach (DataGridViewRow row in grdNotice.Rows)
            {
                MessageBox.Show(grdNotice.Columns[6].ToString().Trim(), "Confirmation",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                MailMessage mail = new MailMessage("nct@nct.ie", grdNotice.Columns["EMAIL"].ToString().Trim());
                SmtpClient client = new SmtpClient();
                client.Port = 25;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Host = "smtp.google.com";
                mail.Subject = "NCT reminder.";
                mail.Body = "Dear " + grdNotice.Columns["SURNAME"].ToString().Trim() + " " + grdNotice.Columns["FORENAME"].ToString().Trim() + "\n" +
                    "This is your NCT reminder. Please retain as you will not receive a renewal notice in the post." +
                    "\n\n\nThe NCT for your " + grdNotice.Columns["MAKE"].ToString().Trim() + " " + grdNotice.Columns["MODELS"].ToString().Trim() + " " + grdNotice.Columns["REG_NO"].ToString().Trim() + "due on " + DateTime.Today.AddDays(-28);
                client.Send(mail);
            }
        }
    }
}
