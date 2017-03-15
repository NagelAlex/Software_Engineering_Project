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
    public partial class frmReg : Form
    {
        private Form parent;
        public frmReg()
        {
            InitializeComponent();
        }
        public frmReg(Form parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }
        //================================================================================

        //Load form components
        private void frmReg_Load(object sender, EventArgs e)
        {
            loadMake();
            loadModels();
            loadCounties();
            loadEngine();
            loadColor();
            loadFuel();
   

            cboColour.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCounty.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEngine.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFuel.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMake.DropDownStyle = ComboBoxStyle.DropDownList;
            cboModel.DropDownStyle = ComboBoxStyle.DropDownList;

            dtpDob.MaxDate = DateTime.Today.AddYears(-17);
            dtpDob.MinDate = DateTime.Today.AddYears(-130);
            dtpFregdate.MaxDate = DateTime.Now;
            dtpRegDate.MaxDate = DateTime.Now;

            txtRegNo.CharacterCasing = CharacterCasing.Upper;
            txtPPSN.CharacterCasing = CharacterCasing.Upper;
            txtEmail.CharacterCasing = CharacterCasing.Lower;

            btnClearCarReg.Visible = false;    
        }

        // Registration No validation
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

                grbCarDetails.Visible = true;
                txtRegNo.ReadOnly = true;
                btnCheckReg.Visible = false;
                btnClearCarReg.Visible = true;
            
        }

        //Car details validation
        private void btnCarSubmit_Click(object sender, EventArgs e)
        {
            if (cboMake.Text == "" || cboModel.Text == "" || cboEngine.Text == "" || cboColour.Text == "" || cboFuel.Text == "")
            {
                MessageBox.Show("All fields must be filled !!!", "Confirmation",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                grbPPSN.Visible = true;
                btnCarSubmit.Visible = false;
            }
        }

        //PPSN check and validation
        private void btnCheckPPSN_Click(object sender, EventArgs e)
        {
            if (txtPPSN.Text == "")
            {
                MessageBox.Show("Please Enter your PPSN !", "Confirmation",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (NCTSYS.Owner.isValidPPSN(txtPPSN.Text) == false)
            {
                MessageBox.Show("PPS Number you entered is invalid !\nPlease Re-enter", "Confirmation",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //get Owner details
                Owner aOwner = new Owner();
                aOwner.getOwnerDetails(txtPPSN.Text);

                //if owner not found set checkbox = false
                if(aOwner.getPPSN().Equals(""))
                {
                    chkExists.Checked = false;
                    //set form controls enabled = true

                }
                else
                {
                    chkExists.Checked = true;
                    //load owner details onto the form and set enabled = false

                    txtSname.Text = aOwner.getSname();
                    txtSname.Enabled = false;
                    txtFname.Text = aOwner.getFname();
                    txtFname.Enabled = false;
                    dtpDob.Text = aOwner.getDOB();
                    dtpDob.Enabled = false;
                    txtTelNo.Text = aOwner.getTelNum();
                    txtTelNo.Enabled = false;
                    txtEmail.Text = aOwner.getEmail();
                    txtEmail.Enabled = false;
                    txtAdd1.Text = aOwner.getAdd1();
                    txtAdd1.Enabled = false;
                    txtAdd2.Text = aOwner.getAdd2();
                    txtAdd2.Enabled = false;
                    cboCounty.Text = aOwner.getCounty();
                    cboCounty.Enabled = false;
                }

                //if owner not found set check box = false
                
                grbOdetails.Visible = true;
                txtPPSN.ReadOnly = true;
                btnCheckPPSN.Visible = false;
            }
        }

        //Clear form
        private void btnClearCarReg_Click_1(object sender, EventArgs e)
        {
            clearReg();
        }

        //Register + Owner details validation
        private void btnRegCar_Click(object sender, EventArgs e)
        {
            if (txtSname.Text == "" || txtFname.Text == "" || txtEmail.Text == "" || txtAdd1.Text == "" || txtAdd2.Text == "" || cboCounty.Text == "" || txtTelNo.Text == "")
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
                //Insert data into cars, owners and registrations tables
                //instantiate Car Object
                if (chkCar.Checked == false)
                {
                    char carStatus = 'A';
                    Car newCar = new Car(txtRegNo.Text.ToUpper(), cboMake.Text, cboModel.Text, Convert.ToDouble(cboEngine.Text), cboColour.Text, cboFuel.Text, carStatus, dtpFregdate.Text);
                    newCar.regCar();
                }
                //instantiate Owner Object
                if (chkExists.Checked == false)
                {
                    Owner newOwner = new Owner(txtPPSN.Text.ToUpper(), txtSname.Text, txtFname.Text, dtpDob.Text, txtTelNo.Text, txtEmail.Text.ToLower(), txtAdd1.Text, txtAdd2.Text, cboCounty.Text);
                    newOwner.regOwner();
                }
                
                //instantiate Registration Object
                Registration newRegistration = new Registration(txtRegNo.Text.ToUpper(), dtpRegDate.Text, txtPPSN.Text.ToUpper());

                if(isProcessed(txtRegNo.Text, dtpRegDate.Text) == true)
                {
                    MessageBox.Show("Already processed !", "Confirmation",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearReg();
                    return; 
                }

                newRegistration.regOwnership();

                //Display confirmation message
                MessageBox.Show("Registration Number: " + txtRegNo.Text.Trim() + " is now registered" + "\nThank you !", "Confirmation",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Clear registration form
                clearReg();
            }
        }
        public void fillCarDetails()
        {
            Car car = new Car();
            car.getCarDetails(txtRegNo.Text);

            //if a new car
            if (car.getMake().Equals(""))
            {
                chkCar.Checked = false;
                   
            }

            //if car exists
            else
            {
                chkCar.Checked = true;
                txtRegNo.Text = car.getRegNo();

                //insert existing  car Make in to combo box
                String strMake = car.getMake().Trim();
                cboMake.SelectedIndex = 0;
                while (!cboMake.Text.Equals(strMake))
                {
                    cboMake.SelectedIndex++;  
                }

                //insert existing  car Model in to combo box
                String strModel = car.getModel().Trim();
                cboModel.SelectedIndex = 0;
                while (!cboModel.Text.Equals(strModel))
                {
                    cboModel.SelectedIndex++;
                }

                //insert existing  car Color in to combo box
                String strColor = car.getColor().Trim();
                cboColour.SelectedIndex = 0;
                while (!cboColour.Text.Equals(strColor))
                {
                    cboColour.SelectedIndex++;
                }

                //insert existing  car Engine Size in to combo box
                String strEngine = car.getEngine().ToString("0.#").Trim();
                cboEngine.SelectedIndex = 0;
                while (!cboEngine.Text.Equals(strEngine))
                {
                    cboEngine.SelectedIndex++;
                }

                //insert existing  car Fuel Type in to combo box
                String strFuelType = car.getFuel().Trim();
                cboFuel.SelectedIndex = 0;
                while (!cboFuel.Text.Equals(strFuelType))
                {
                    cboFuel.SelectedIndex++;
                }
                // insert existing  car First Reg date in to DateTime Picker
                dtpFregdate.Value = Convert.ToDateTime(car.getFirstRegDate().Substring(0, 10));

                //make all fields not editable
                txtRegNo.ReadOnly = true;
                cboMake.Enabled = false;
                cboModel.Enabled = false;
                cboColour.Enabled = false;
                cboEngine.Enabled = false;
                cboFuel.Enabled = false;
                dtpFregdate.Enabled = false;

            }
        }

        //load makes from DB
        public void loadMake()
        {
            //open database
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            String strSQL = "SELECT DISTINCT Make FROM MakeModels ORDER BY Make";
            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            OracleDataReader dr = cmd.ExecuteReader();

            //load data from datareader into combo box
            cboMake.Items.Clear();
            while (dr.Read())
            {
                cboMake.Items.Add(dr.GetString(0).Trim());
            }

            myConn.Close();
        }

        //load models from DB
        public void loadModels()
        {
            //open database
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            String strSQL = "SELECT Model FROM MakeModels WHERE Make = '" + cboMake.Text + "' ORDER BY Make, Model";
            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            OracleDataReader dr = cmd.ExecuteReader();

            //load data from datareader into combo box
            cboModel.Items.Clear();
            while (dr.Read())
            {
                cboModel.Items.Add(dr.GetString(0).Trim());
            }
            //Close DB
            myConn.Close();
        }

        //load models into como box
        private void cboMake_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadModels();
        }

        //clear form
        private void clearReg()
        {
            grbOdetails.Visible = false;
            grbPPSN.Visible = false;
            grbCarDetails.Visible = false;
            txtRegNo.Text = String.Empty;
            cboMake.Enabled = true;
            cboModel.Enabled = true;
            cboColour.Enabled = true;
            cboEngine.Enabled = true;
            cboFuel.Enabled = true;
            dtpFregdate.Enabled = true;
            cboColour.Items.Clear();
            cboEngine.Items.Clear();
            cboCounty.Items.Clear();
            cboFuel.Items.Clear();
            cboMake.Items.Clear();
            cboModel.Items.Clear();
            txtPPSN.Text = String.Empty;
            txtSname.Text = String.Empty;
            txtFname.Text = String.Empty;
            txtTelNo.Text = String.Empty;
            txtEmail.Text = String.Empty;
            txtAdd1.Text = String.Empty;
            txtAdd2.Text = String.Empty;
            dtpDob.Value = DateTime.Today.AddYears(-17);
            dtpFregdate.Value = DateTime.Today;
            txtRegNo.ReadOnly = false;
            txtPPSN.ReadOnly = false;
            btnCarSubmit.Visible = true;
            btnCheckReg.Visible = true;
            btnCheckPPSN.Visible = true;
            btnClearCarReg.Visible = false;
            loadCounties();
            loadEngine();
            loadColor();
            loadFuel();
            loadMake();
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
        public void loadEngine()
        {
            //open database
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            String strSQL = "SELECT * FROM EngineSizes";
            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            OracleDataReader dr = cmd.ExecuteReader();

            //load data from datareader into combo box
            cboEngine.Items.Clear();
            while (dr.Read())
            {
                cboEngine.Items.Add(dr.GetDouble(0).ToString("0.#").Trim());
            }
            //Close DB
            myConn.Close();
           
        }
        public void loadColor()
        {
            cboColour.Items.Add("White");
            cboColour.Items.Add("Black");
            cboColour.Items.Add("Green");
            cboColour.Items.Add("Gold");
            cboColour.Items.Add("Silver");
            cboColour.Items.Add("Pink");
            cboColour.Items.Add("Grey");
        }
        public void loadFuel()
        {
            cboFuel.Items.Add("PETROL");
            cboFuel.Items.Add("DIESEL");
        }
        public Boolean isProcessed(String RegNo, String RegDate)
        {
            Boolean answer = false;

            //Connect to the DB
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //Define SQL Query
            String strSQL = "SELECT * FROM Registrations WHERE Reg_No = '" + RegNo + "' AND Reg_Date = '" + RegDate + "'";

            //Execute SQL Query 
            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            OracleDataReader dr = cmd.ExecuteReader();
            //String date;
            if (dr.Read())
            {
                answer = true;
            }
            //Close DB
            myConn.Close();
            return answer;
        }
    }
}
