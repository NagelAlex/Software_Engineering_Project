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
    public partial class frmCloseCentre : Form
    {
        private Form parent;
        public frmCloseCentre()
        {
            InitializeComponent();
        }
        public frmCloseCentre(Form parent)
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
        private void frmCloseCentre_Load(object sender, EventArgs e)
        {
            loadCounties();
            cboCounty.DropDownStyle = ComboBoxStyle.DropDownList;
            grdCentre.AllowUserToAddRows = false;
            this.grdCentre.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void btnCentreSearch_Click(object sender, EventArgs e)
        {
            getCentresList(cboCounty.SelectedItem.ToString().ToUpper().Trim());
        }

        
        public void getCentresList(String county)
        {

            //Connect to the DB
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //Define SQL Query
            String strSQL = "SELECT * FROM Centres WHERE County = '" + county + "' AND STATUS = 'A'";

            //Execute SQL Query 
            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            OracleDataAdapter oda = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();

            oda.Fill(ds);
            //if no centres was found
            if (ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("No active NCT Test Centres was found ! in Co." + county, "Confirmation",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //fill data grid
            grdCentre.DataSource = ds.Tables[0];

            // close DB
            myConn.Close();
            // make data grid visible
            grdCentre.Visible = true;
            //make clear form button visible
            btnClear.Visible = true;
        }
        private void grdCentre_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.grdCentre.Rows[e.RowIndex];

            int centre_id = Convert.ToInt32(row.Cells[0].Value);
            Centre aCentre = new Centre();
            aCentre.getCentreDetails(Convert.ToInt32(grdCentre.Rows[grdCentre.CurrentCell.RowIndex].Cells[0].Value));

            txtCentreId.Text = aCentre.getCentreID().ToString();
            txtName.Text = aCentre.getCentreName().ToString();
            txtAdd1.Text = aCentre.getAdd1().ToString();
            txtAdd2.Text = aCentre.getAdd2().ToString();
            txtTelNo.Text = aCentre.getTelNo().ToString();
            txtEmail.Text = aCentre.getEmail().ToString();
            txtCounty.Text = aCentre.getCounty().ToString();

            grbCentreDetails.Visible = true;
            btnDeRegCentre.Visible = true;
        }
        private void btnDeRegCentre_Click(object sender, EventArgs e)
        {
            Centre aCentre = new Centre();
            aCentre.deRegister(Convert.ToInt32(txtCentreId.Text));
            MessageBox.Show("The Test Centre is now De-Registered", "Confirmation",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            clearForm();
            loadCounties();
        }
        public void loadCounties()
        {
            cboCounty.Items.Add("Antrim");
            cboCounty.Items.Add("Armagh");
            cboCounty.Items.Add("Carlow");
            cboCounty.Items.Add("Cork");
            cboCounty.Items.Add("Derry");
            cboCounty.Items.Add("Galway");
            cboCounty.Items.Add("Kerry");
            cboCounty.Items.Add("Kilkenny");
            cboCounty.Items.Add("Mayo");
            cboCounty.Items.Add("Offaly");
            cboCounty.Items.Add("Roscommon");
            cboCounty.Items.Add("Sligo");
            cboCounty.Items.Add("Tipperary");
            cboCounty.Items.Add("Waterford");
            cboCounty.Items.Add("Westmeath");
            cboCounty.Items.Add("Wexford");
            cboCounty.Items.Add("Wicklow");
        }
        public void clearForm()
        {
            grdCentre.Visible = false;
            grbCentreDetails.Visible = false;
            btnClear.Visible = false;
            btnDeRegCentre.Visible = false;
            cboCounty.Items.Clear();
            loadCounties();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearForm();
        }
    }
}
