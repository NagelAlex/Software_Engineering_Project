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

        Car aCar = new Car();
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

            fillCarDetails();

        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            grbDeReg.Visible = true;
            btnContinue.Visible = false;
        }
        public void fillCarDetails()
        {
          
            aCar.getCarDetails(txtRegNo.Text.ToUpper());

            //if a new car
            if (aCar.getRegNo().Equals(""))
            {
                MessageBox.Show("Registration Number you entered not in database  !\nPlease Re-enter", "Confirmation",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtRegNo.Focus();
                return;
            }
            if (aCar.getCarStatus().ToString().Equals("I"))
            {
                MessageBox.Show("Registration Number you entered not allready De-Registered  !", "Confirmation",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtRegNo.Focus();
                return;
            }

            //if car exists
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
            
            aCar.deRegister(txtRegNo.Text);
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
