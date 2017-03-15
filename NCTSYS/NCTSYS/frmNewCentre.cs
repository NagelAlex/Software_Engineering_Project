using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NCTSYS
{
    public partial class frmNewCentre : Form
    {
        private Form parent;
        public frmNewCentre()
        {
            InitializeComponent();
        }
        public frmNewCentre(Form parent)
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

        private void frmNewCentre_Load(object sender, EventArgs e)
        {
            loadCounties();
            cboCounty.DropDownStyle = ComboBoxStyle.DropDownList;
            txtCentreId.Text = Centre.nextCentreID().ToString("00");
        }
        //Register + Centre details validation
        private void btnRegCentre_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtAdd1.Text == "" || txtAdd2.Text == "" || txtTelNo.Text == "" || txtEmail.Text == "" || cboCounty.Text == "")
            {
                MessageBox.Show("All fields must be filled !!!", "Confirmation",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (NCTSYS.Owner.isValidEmail(txtEmail.Text) == false)
            {
                MessageBox.Show("Email address you entered is invalid !\nPlease Re-enter", "Confirmation",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //instantiate Centre Object
                char status = 'A';
                Centre aCentre = new Centre(Convert.ToInt32(txtCentreId.Text), txtName.Text, txtAdd1.Text, txtAdd2.Text, txtTelNo.Text, txtEmail.Text.ToLower(), cboCounty.Text, status);

                aCentre.regCentre();

                //Display confirmation message
                MessageBox.Show("Test Centre is now registered" + "\nThank you !", "Confirmation",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                // Clear registration form
                clearForm();
            }
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
        private void clearForm()
        {
            txtCentreId.Text = Centre.nextCentreID().ToString("00");
            txtName.Text = String.Empty;
            txtAdd1.Text = String.Empty;
            txtAdd2.Text = String.Empty;
            txtTelNo.Text = String.Empty;
            txtEmail.Text = String.Empty;
            cboCounty.Items.Clear();
            loadCounties();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearForm();
        }
    }
}
