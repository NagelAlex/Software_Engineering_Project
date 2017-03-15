using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace NCTSYS
{
    public partial class frmHistory : Form
    {
        private Form parent;
        public frmHistory()
        {
            InitializeComponent();
        }
        public frmHistory(Form parent)
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

        private void btnCheckReg_Click(object sender, EventArgs e)
        {
            if (txtRegNo.Text == "")
            {
                MessageBox.Show("Please Enter Registration Number", "Confirmation",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtRegNo.Focus();
                return;
            }
            if (Car.isValidReg(txtRegNo.Text) == false)
            {
                MessageBox.Show("Registration Number you entered is invalid !\nPlease Re-enter", "Confirmation",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtRegNo.Focus();
                return;
            }

            getRegHistory(txtRegNo.Text.ToUpper());

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearForm();
        }
        public void getRegHistory(String regNo)
        {

            //Connect to the DB
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //Define SQL Query
            String strSQL = "SELECT C.REG_NO, CAR_MAKE, CAR_MODEL, SURNAME, FORENAME, TEL_NO, REG_DATE " +
                            "FROM CARS C, OWNERS O, REGISTRATIONS R "+ 
                            "WHERE C.REG_NO = R.REG_NO AND " +
                            "R.PPSN = O.PPSN  AND " + 
                            "C.REG_NO = '" + txtRegNo.Text.ToUpper() + "' " +
                            "ORDER BY REG_DATE DESC";

            //Execute SQL Query 
            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            OracleDataAdapter oda = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();

            oda.Fill(ds);
            if (ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Registration Number you entered in not in Database ", "Confirmation",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearForm();
                return;
            }

            grdHistory.DataSource = ds.Tables[0];

            // close DB
            myConn.Close();
            // make data grid visible
            grdHistory.Visible = true;
            //make txtRegNo.ReadOnly
            txtRegNo.ReadOnly = true;
            //make clear form button visible
            btnClear.Visible = true;
            //hide check button
            btnCheckReg.Visible = false;
            //make print button visible
            btnPrint.Visible = true;
        }
        public void clearForm()
        {
            grdHistory.Visible = false;
            btnClear.Visible = false;
            btnCheckReg.Visible = true;
            btnPrint.Visible = false;
            txtRegNo.Text = String.Empty;
            txtRegNo.ReadOnly = false;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Printing ...... ", "Confirmation",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
