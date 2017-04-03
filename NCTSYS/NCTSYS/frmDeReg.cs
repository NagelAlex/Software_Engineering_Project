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
    public partial class frmDeReg : Form
    {
        private Form parent;

        
        public frmDeReg()
        {
            InitializeComponent();
        }
        public frmDeReg(Form parent)
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
            //if Reg NO text field is empty
            if (txtRegNo.Text == "")
            {
                MessageBox.Show("Please Enter Registration Number", "Confirmation",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtRegNo.Focus();
                return;
            }
            //if reg no not valid
            if (Util.isValidReg(txtRegNo.Text) == false)
            {
                MessageBox.Show("Registration Number you entered is invalid !\nPlease Re-enter", "Confirmation",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtRegNo.Focus();
                return;
            }
            //get and fill car details
            fillCarDetails();

        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            grbDeReg.Visible = true;
            btnContinue.Visible = false;
        }

        public void fillCarDetails()
        {
            //creating an instance of an Car object
            Car aCar = new Car();
            //geting Car Details
            aCar.getCarDetails(txtRegNo.Text.Trim().ToUpper());

            //if car not found
            if (aCar.getRegNo().Equals(""))
            {
                MessageBox.Show("Registration Number you entered not in database  !\nPlease Re-enter", "Confirmation",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearForm();
                txtRegNo.Focus();
                return;
            }
            //if car is allready De-Registered
            if (aCar.getCarStatus().ToString().Equals("I"))
            {
                MessageBox.Show("Registration Number you entered allready De-Registered  !", "Confirmation",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearForm();
                txtRegNo.Focus();
                return;
            }
            else
            {
                //make check button not visible
                btnCheckReg.Visible = false;
                //insert existing  car RegNo in to text box
                txtRegNo.Text = aCar.getRegNo();

                //insert existing  car Make in to text box
                txtMake.Text = aCar.getMake();

                //insert existing  car Model in to text box
                txtModel.Text = aCar.getModel();

                //insert existing  car Color in to text box
                txtColor.Text = aCar.getColor();

                //insert existing  car Engine Size in to text box
                txtEngine.Text = aCar.getEngine().ToString();

                //insert existing  car Fuel Type in to text box
                txtFuel.Text = aCar.getFuel();

                // insert existing  car First Reg date in to DateTime Picker
                dtpFregdate.Value = Convert.ToDateTime(aCar.getFirstRegDate().Substring(0, 10));

                //make all fields not editable
                txtRegNo.ReadOnly = true;
                txtMake.ReadOnly = true;
                txtModel.ReadOnly = true;
                txtColor.ReadOnly = true;
                txtEngine.ReadOnly = true;
                txtFuel.ReadOnly = true;
                dtpFregdate.Enabled = false;
                grbCarDetails.Visible = true;
                btnClear.Visible = true;
            }
        }

        private void btnDeReg_Click(object sender, EventArgs e)
        {
            //calling de-register method
            Car.deRegister(txtRegNo.Text.ToUpper());
            MessageBox.Show("The Car is now De-Registered", "Confirmation",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            clearForm();

        }

        private void clearForm()
        {
            txtRegNo.Text = String.Empty;
            txtRegNo.ReadOnly = false;
            txtMake.ReadOnly = false;
            txtModel.ReadOnly = false;
            txtColor.ReadOnly = false;
            txtEngine.ReadOnly = false;
            txtFuel.ReadOnly = false;
            dtpFregdate.Enabled = true;
            grbCarDetails.Visible = false;
            grbDeReg.Visible = false;
            btnClear.Visible = false;
            btnCheckReg.Visible = true;
            btnContinue.Visible = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearForm();
        }
    }
}
