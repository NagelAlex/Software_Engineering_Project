namespace NCTSYS
{
    partial class frmReg
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReg));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblMake = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblColour = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblSname = new System.Windows.Forms.Label();
            this.lblFname = new System.Windows.Forms.Label();
            this.lblDob = new System.Windows.Forms.Label();
            this.lblTelNo = new System.Windows.Forms.Label();
            this.lblEcode = new System.Windows.Forms.Label();
            this.lblAdd1 = new System.Windows.Forms.Label();
            this.lblAdd2 = new System.Windows.Forms.Label();
            this.lblCounty = new System.Windows.Forms.Label();
            this.txtSname = new System.Windows.Forms.TextBox();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.txtTelNo = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAdd1 = new System.Windows.Forms.TextBox();
            this.txtAdd2 = new System.Windows.Forms.TextBox();
            this.cboMake = new System.Windows.Forms.ComboBox();
            this.cboModel = new System.Windows.Forms.ComboBox();
            this.cboColour = new System.Windows.Forms.ComboBox();
            this.cboEngine = new System.Windows.Forms.ComboBox();
            this.cboCounty = new System.Windows.Forms.ComboBox();
            this.dtpFregdate = new System.Windows.Forms.DateTimePicker();
            this.dtpDob = new System.Windows.Forms.DateTimePicker();
            this.grbCarDetails = new System.Windows.Forms.GroupBox();
            this.chkCar = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboFuel = new System.Windows.Forms.ComboBox();
            this.btnCarSubmit = new System.Windows.Forms.Button();
            this.btbNext = new System.Windows.Forms.Button();
            this.grbOdetails = new System.Windows.Forms.GroupBox();
            this.chkExists = new System.Windows.Forms.CheckBox();
            this.btnRegCar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grbPPSN = new System.Windows.Forms.GroupBox();
            this.btnCheckPPSN = new System.Windows.Forms.Button();
            this.lblDLNo = new System.Windows.Forms.Label();
            this.txtPPSN = new System.Windows.Forms.TextBox();
            this.grbRegCheck = new System.Windows.Forms.GroupBox();
            this.btnCheckReg = new System.Windows.Forms.Button();
            this.lblRegNo = new System.Windows.Forms.Label();
            this.txtRegNo = new System.Windows.Forms.TextBox();
            this.btnClearCarReg = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.grbCarDetails.SuspendLayout();
            this.grbOdetails.SuspendLayout();
            this.grbPPSN.SuspendLayout();
            this.grbRegCheck.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuStrip1.BackgroundImage")));
            this.menuStrip1.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(675, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.backToolStripMenuItem.Text = "back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // lblMake
            // 
            this.lblMake.AutoSize = true;
            this.lblMake.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMake.Location = new System.Drawing.Point(31, 51);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(39, 13);
            this.lblMake.TabIndex = 4;
            this.lblMake.Text = "Make:";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModel.Location = new System.Drawing.Point(30, 81);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(49, 13);
            this.lblModel.TabIndex = 5;
            this.lblModel.Text = "Model:";
            // 
            // lblColour
            // 
            this.lblColour.AutoSize = true;
            this.lblColour.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColour.Location = new System.Drawing.Point(30, 115);
            this.lblColour.Name = "lblColour";
            this.lblColour.Size = new System.Drawing.Size(50, 13);
            this.lblColour.TabIndex = 6;
            this.lblColour.Text = "Color:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(348, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Date of first Registration:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(30, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Engine Size:";
            // 
            // lblSname
            // 
            this.lblSname.AutoSize = true;
            this.lblSname.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSname.Location = new System.Drawing.Point(34, 54);
            this.lblSname.Name = "lblSname";
            this.lblSname.Size = new System.Drawing.Size(62, 13);
            this.lblSname.TabIndex = 10;
            this.lblSname.Text = "Surname:";
            // 
            // lblFname
            // 
            this.lblFname.AutoSize = true;
            this.lblFname.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFname.Location = new System.Drawing.Point(33, 83);
            this.lblFname.Name = "lblFname";
            this.lblFname.Size = new System.Drawing.Size(79, 13);
            this.lblFname.TabIndex = 11;
            this.lblFname.Text = "fornename:";
            // 
            // lblDob
            // 
            this.lblDob.AutoSize = true;
            this.lblDob.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDob.Location = new System.Drawing.Point(33, 109);
            this.lblDob.Name = "lblDob";
            this.lblDob.Size = new System.Drawing.Size(34, 13);
            this.lblDob.TabIndex = 12;
            this.lblDob.Text = "DOB:";
            // 
            // lblTelNo
            // 
            this.lblTelNo.AutoSize = true;
            this.lblTelNo.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelNo.Location = new System.Drawing.Point(33, 137);
            this.lblTelNo.Name = "lblTelNo";
            this.lblTelNo.Size = new System.Drawing.Size(51, 13);
            this.lblTelNo.TabIndex = 13;
            this.lblTelNo.Text = "Tel no:";
            // 
            // lblEcode
            // 
            this.lblEcode.AutoSize = true;
            this.lblEcode.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEcode.Location = new System.Drawing.Point(34, 167);
            this.lblEcode.Name = "lblEcode";
            this.lblEcode.Size = new System.Drawing.Size(41, 13);
            this.lblEcode.TabIndex = 14;
            this.lblEcode.Text = "email:";
            // 
            // lblAdd1
            // 
            this.lblAdd1.AutoSize = true;
            this.lblAdd1.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdd1.Location = new System.Drawing.Point(323, 63);
            this.lblAdd1.Name = "lblAdd1";
            this.lblAdd1.Size = new System.Drawing.Size(63, 13);
            this.lblAdd1.TabIndex = 15;
            this.lblAdd1.Text = "Address 1";
            // 
            // lblAdd2
            // 
            this.lblAdd2.AutoSize = true;
            this.lblAdd2.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdd2.Location = new System.Drawing.Point(323, 91);
            this.lblAdd2.Name = "lblAdd2";
            this.lblAdd2.Size = new System.Drawing.Size(66, 13);
            this.lblAdd2.TabIndex = 16;
            this.lblAdd2.Text = "Address 2";
            // 
            // lblCounty
            // 
            this.lblCounty.AutoSize = true;
            this.lblCounty.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCounty.Location = new System.Drawing.Point(323, 120);
            this.lblCounty.Name = "lblCounty";
            this.lblCounty.Size = new System.Drawing.Size(58, 13);
            this.lblCounty.TabIndex = 17;
            this.lblCounty.Text = "county";
            // 
            // txtSname
            // 
            this.txtSname.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSname.Location = new System.Drawing.Point(119, 48);
            this.txtSname.Name = "txtSname";
            this.txtSname.Size = new System.Drawing.Size(129, 21);
            this.txtSname.TabIndex = 21;
            // 
            // txtFname
            // 
            this.txtFname.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFname.Location = new System.Drawing.Point(119, 77);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(129, 21);
            this.txtFname.TabIndex = 22;
            // 
            // txtTelNo
            // 
            this.txtTelNo.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelNo.Location = new System.Drawing.Point(120, 132);
            this.txtTelNo.Name = "txtTelNo";
            this.txtTelNo.Size = new System.Drawing.Size(128, 21);
            this.txtTelNo.TabIndex = 23;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(118, 161);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(130, 21);
            this.txtEmail.TabIndex = 24;
            // 
            // txtAdd1
            // 
            this.txtAdd1.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdd1.Location = new System.Drawing.Point(397, 59);
            this.txtAdd1.Name = "txtAdd1";
            this.txtAdd1.Size = new System.Drawing.Size(191, 21);
            this.txtAdd1.TabIndex = 25;
            // 
            // txtAdd2
            // 
            this.txtAdd2.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdd2.Location = new System.Drawing.Point(397, 87);
            this.txtAdd2.Name = "txtAdd2";
            this.txtAdd2.Size = new System.Drawing.Size(191, 21);
            this.txtAdd2.TabIndex = 26;
            // 
            // cboMake
            // 
            this.cboMake.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMake.FormattingEnabled = true;
            this.cboMake.Location = new System.Drawing.Point(120, 48);
            this.cboMake.Name = "cboMake";
            this.cboMake.Size = new System.Drawing.Size(121, 21);
            this.cboMake.TabIndex = 27;
            this.cboMake.SelectedIndexChanged += new System.EventHandler(this.cboMake_SelectedIndexChanged);
            // 
            // cboModel
            // 
            this.cboModel.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboModel.FormattingEnabled = true;
            this.cboModel.Location = new System.Drawing.Point(119, 78);
            this.cboModel.Name = "cboModel";
            this.cboModel.Size = new System.Drawing.Size(121, 21);
            this.cboModel.TabIndex = 28;
            // 
            // cboColour
            // 
            this.cboColour.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboColour.FormattingEnabled = true;
            this.cboColour.Location = new System.Drawing.Point(119, 111);
            this.cboColour.Name = "cboColour";
            this.cboColour.Size = new System.Drawing.Size(121, 21);
            this.cboColour.TabIndex = 29;
            // 
            // cboEngine
            // 
            this.cboEngine.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEngine.FormattingEnabled = true;
            this.cboEngine.Location = new System.Drawing.Point(119, 144);
            this.cboEngine.Name = "cboEngine";
            this.cboEngine.Size = new System.Drawing.Size(121, 21);
            this.cboEngine.TabIndex = 30;
            // 
            // cboCounty
            // 
            this.cboCounty.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCounty.FormattingEnabled = true;
            this.cboCounty.Location = new System.Drawing.Point(397, 116);
            this.cboCounty.MaxDropDownItems = 5;
            this.cboCounty.Name = "cboCounty";
            this.cboCounty.Size = new System.Drawing.Size(121, 21);
            this.cboCounty.TabIndex = 31;
            // 
            // dtpFregdate
            // 
            this.dtpFregdate.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpFregdate.Location = new System.Drawing.Point(369, 76);
            this.dtpFregdate.Name = "dtpFregdate";
            this.dtpFregdate.Size = new System.Drawing.Size(138, 21);
            this.dtpFregdate.TabIndex = 32;
            // 
            // dtpDob
            // 
            this.dtpDob.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDob.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpDob.Location = new System.Drawing.Point(119, 106);
            this.dtpDob.MaxDate = new System.DateTime(4567, 12, 22, 0, 0, 0, 0);
            this.dtpDob.Name = "dtpDob";
            this.dtpDob.Size = new System.Drawing.Size(129, 21);
            this.dtpDob.TabIndex = 33;
            this.dtpDob.Value = new System.DateTime(2000, 12, 22, 0, 0, 0, 0);
            // 
            // grbCarDetails
            // 
            this.grbCarDetails.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grbCarDetails.BackgroundImage")));
            this.grbCarDetails.Controls.Add(this.chkCar);
            this.grbCarDetails.Controls.Add(this.label2);
            this.grbCarDetails.Controls.Add(this.cboFuel);
            this.grbCarDetails.Controls.Add(this.btnCarSubmit);
            this.grbCarDetails.Controls.Add(this.btbNext);
            this.grbCarDetails.Controls.Add(this.cboMake);
            this.grbCarDetails.Controls.Add(this.lblMake);
            this.grbCarDetails.Controls.Add(this.lblModel);
            this.grbCarDetails.Controls.Add(this.dtpFregdate);
            this.grbCarDetails.Controls.Add(this.lblColour);
            this.grbCarDetails.Controls.Add(this.cboModel);
            this.grbCarDetails.Controls.Add(this.cboEngine);
            this.grbCarDetails.Controls.Add(this.cboColour);
            this.grbCarDetails.Controls.Add(this.label8);
            this.grbCarDetails.Controls.Add(this.label7);
            this.grbCarDetails.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbCarDetails.Location = new System.Drawing.Point(32, 106);
            this.grbCarDetails.Name = "grbCarDetails";
            this.grbCarDetails.Size = new System.Drawing.Size(614, 178);
            this.grbCarDetails.TabIndex = 55;
            this.grbCarDetails.TabStop = false;
            this.grbCarDetails.Text = "Car Details";
            this.grbCarDetails.Visible = false;
            // 
            // chkCar
            // 
            this.chkCar.AutoSize = true;
            this.chkCar.Enabled = false;
            this.chkCar.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCar.Location = new System.Drawing.Point(33, 20);
            this.chkCar.Name = "chkCar";
            this.chkCar.Size = new System.Drawing.Size(112, 17);
            this.chkCar.TabIndex = 62;
            this.chkCar.Text = "Existing Car";
            this.chkCar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(259, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 61;
            this.label2.Text = "fuel type:";
            // 
            // cboFuel
            // 
            this.cboFuel.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFuel.FormattingEnabled = true;
            this.cboFuel.Location = new System.Drawing.Point(341, 145);
            this.cboFuel.Name = "cboFuel";
            this.cboFuel.Size = new System.Drawing.Size(121, 21);
            this.cboFuel.TabIndex = 60;
            // 
            // btnCarSubmit
            // 
            this.btnCarSubmit.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarSubmit.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnCarSubmit.Location = new System.Drawing.Point(510, 145);
            this.btnCarSubmit.Name = "btnCarSubmit";
            this.btnCarSubmit.Size = new System.Drawing.Size(94, 23);
            this.btnCarSubmit.TabIndex = 59;
            this.btnCarSubmit.Text = "Continue";
            this.btnCarSubmit.UseVisualStyleBackColor = true;
            this.btnCarSubmit.Click += new System.EventHandler(this.btnCarSubmit_Click);
            // 
            // btbNext
            // 
            this.btbNext.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbNext.ForeColor = System.Drawing.Color.Green;
            this.btbNext.Location = new System.Drawing.Point(529, 194);
            this.btbNext.Name = "btbNext";
            this.btbNext.Size = new System.Drawing.Size(80, 22);
            this.btbNext.TabIndex = 58;
            this.btbNext.Text = "NEXT";
            this.btbNext.UseVisualStyleBackColor = true;
            // 
            // grbOdetails
            // 
            this.grbOdetails.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grbOdetails.BackgroundImage")));
            this.grbOdetails.Controls.Add(this.chkExists);
            this.grbOdetails.Controls.Add(this.btnRegCar);
            this.grbOdetails.Controls.Add(this.lblFname);
            this.grbOdetails.Controls.Add(this.lblSname);
            this.grbOdetails.Controls.Add(this.cboCounty);
            this.grbOdetails.Controls.Add(this.txtAdd2);
            this.grbOdetails.Controls.Add(this.lblDob);
            this.grbOdetails.Controls.Add(this.txtAdd1);
            this.grbOdetails.Controls.Add(this.dtpDob);
            this.grbOdetails.Controls.Add(this.lblCounty);
            this.grbOdetails.Controls.Add(this.lblTelNo);
            this.grbOdetails.Controls.Add(this.lblAdd2);
            this.grbOdetails.Controls.Add(this.txtEmail);
            this.grbOdetails.Controls.Add(this.lblAdd1);
            this.grbOdetails.Controls.Add(this.lblEcode);
            this.grbOdetails.Controls.Add(this.txtTelNo);
            this.grbOdetails.Controls.Add(this.txtSname);
            this.grbOdetails.Controls.Add(this.txtFname);
            this.grbOdetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grbOdetails.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbOdetails.Location = new System.Drawing.Point(32, 362);
            this.grbOdetails.Name = "grbOdetails";
            this.grbOdetails.Size = new System.Drawing.Size(615, 222);
            this.grbOdetails.TabIndex = 56;
            this.grbOdetails.TabStop = false;
            this.grbOdetails.Text = "Owner Details";
            this.grbOdetails.Visible = false;
            // 
            // chkExists
            // 
            this.chkExists.AutoSize = true;
            this.chkExists.Enabled = false;
            this.chkExists.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkExists.Location = new System.Drawing.Point(33, 20);
            this.chkExists.Name = "chkExists";
            this.chkExists.Size = new System.Drawing.Size(132, 17);
            this.chkExists.TabIndex = 55;
            this.chkExists.Text = "Existing Owner";
            this.chkExists.UseVisualStyleBackColor = true;
            // 
            // btnRegCar
            // 
            this.btnRegCar.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegCar.ForeColor = System.Drawing.Color.Green;
            this.btnRegCar.Location = new System.Drawing.Point(510, 189);
            this.btnRegCar.Name = "btnRegCar";
            this.btnRegCar.Size = new System.Drawing.Size(99, 27);
            this.btnRegCar.TabIndex = 54;
            this.btnRegCar.Text = "Register";
            this.btnRegCar.UseVisualStyleBackColor = true;
            this.btnRegCar.Click += new System.EventHandler(this.btnRegCar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(193, 619);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 13);
            this.label1.TabIndex = 58;
            this.label1.Text = "Copyright © 2017 by NCT Systems Solutions LTD.";
            // 
            // grbPPSN
            // 
            this.grbPPSN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grbPPSN.BackgroundImage")));
            this.grbPPSN.Controls.Add(this.btnCheckPPSN);
            this.grbPPSN.Controls.Add(this.lblDLNo);
            this.grbPPSN.Controls.Add(this.txtPPSN);
            this.grbPPSN.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbPPSN.Location = new System.Drawing.Point(32, 294);
            this.grbPPSN.Name = "grbPPSN";
            this.grbPPSN.Size = new System.Drawing.Size(614, 59);
            this.grbPPSN.TabIndex = 59;
            this.grbPPSN.TabStop = false;
            this.grbPPSN.Text = "Owner PPSN Check";
            this.grbPPSN.Visible = false;
            // 
            // btnCheckPPSN
            // 
            this.btnCheckPPSN.BackColor = System.Drawing.SystemColors.Control;
            this.btnCheckPPSN.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckPPSN.Location = new System.Drawing.Point(529, 23);
            this.btnCheckPPSN.Name = "btnCheckPPSN";
            this.btnCheckPPSN.Size = new System.Drawing.Size(75, 23);
            this.btnCheckPPSN.TabIndex = 61;
            this.btnCheckPPSN.Text = "Check";
            this.btnCheckPPSN.UseVisualStyleBackColor = false;
            this.btnCheckPPSN.Click += new System.EventHandler(this.btnCheckPPSN_Click);
            // 
            // lblDLNo
            // 
            this.lblDLNo.AutoSize = true;
            this.lblDLNo.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDLNo.Location = new System.Drawing.Point(216, 30);
            this.lblDLNo.Name = "lblDLNo";
            this.lblDLNo.Size = new System.Drawing.Size(35, 13);
            this.lblDLNo.TabIndex = 59;
            this.lblDLNo.Text = "PPSN:";
            // 
            // txtPPSN
            // 
            this.txtPPSN.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPPSN.Location = new System.Drawing.Point(267, 26);
            this.txtPPSN.Name = "txtPPSN";
            this.txtPPSN.Size = new System.Drawing.Size(114, 21);
            this.txtPPSN.TabIndex = 60;
            // 
            // grbRegCheck
            // 
            this.grbRegCheck.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grbRegCheck.BackgroundImage")));
            this.grbRegCheck.Controls.Add(this.btnCheckReg);
            this.grbRegCheck.Controls.Add(this.lblRegNo);
            this.grbRegCheck.Controls.Add(this.txtRegNo);
            this.grbRegCheck.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbRegCheck.Location = new System.Drawing.Point(32, 42);
            this.grbRegCheck.Name = "grbRegCheck";
            this.grbRegCheck.Size = new System.Drawing.Size(614, 58);
            this.grbRegCheck.TabIndex = 60;
            this.grbRegCheck.TabStop = false;
            this.grbRegCheck.Text = "Registration Check";
            // 
            // btnCheckReg
            // 
            this.btnCheckReg.BackColor = System.Drawing.SystemColors.Control;
            this.btnCheckReg.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckReg.Location = new System.Drawing.Point(529, 22);
            this.btnCheckReg.Name = "btnCheckReg";
            this.btnCheckReg.Size = new System.Drawing.Size(75, 23);
            this.btnCheckReg.TabIndex = 59;
            this.btnCheckReg.Text = "Check";
            this.btnCheckReg.UseVisualStyleBackColor = false;
            this.btnCheckReg.Click += new System.EventHandler(this.btnCheckReg_Click);
            // 
            // lblRegNo
            // 
            this.lblRegNo.AutoSize = true;
            this.lblRegNo.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegNo.Location = new System.Drawing.Point(153, 29);
            this.lblRegNo.Name = "lblRegNo";
            this.lblRegNo.Size = new System.Drawing.Size(140, 13);
            this.lblRegNo.TabIndex = 57;
            this.lblRegNo.Text = "Registration Number:";
            // 
            // txtRegNo
            // 
            this.txtRegNo.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegNo.Location = new System.Drawing.Point(315, 25);
            this.txtRegNo.Name = "txtRegNo";
            this.txtRegNo.Size = new System.Drawing.Size(147, 21);
            this.txtRegNo.TabIndex = 58;
            // 
            // btnClearCarReg
            // 
            this.btnClearCarReg.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearCarReg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClearCarReg.Location = new System.Drawing.Point(542, 591);
            this.btnClearCarReg.Name = "btnClearCarReg";
            this.btnClearCarReg.Size = new System.Drawing.Size(99, 27);
            this.btnClearCarReg.TabIndex = 61;
            this.btnClearCarReg.Text = "Clear Form";
            this.btnClearCarReg.UseVisualStyleBackColor = true;
            this.btnClearCarReg.Click += new System.EventHandler(this.btnClearCarReg_Click_1);
            // 
            // frmReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(675, 640);
            this.Controls.Add(this.btnClearCarReg);
            this.Controls.Add(this.grbRegCheck);
            this.Controls.Add(this.grbPPSN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grbOdetails);
            this.Controls.Add(this.grbCarDetails);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmReg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NCTSYS - Car Registration";
            this.Load += new System.EventHandler(this.frmReg_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grbCarDetails.ResumeLayout(false);
            this.grbCarDetails.PerformLayout();
            this.grbOdetails.ResumeLayout(false);
            this.grbOdetails.PerformLayout();
            this.grbPPSN.ResumeLayout(false);
            this.grbPPSN.PerformLayout();
            this.grbRegCheck.ResumeLayout(false);
            this.grbRegCheck.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label lblMake;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblColour;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblSname;
        private System.Windows.Forms.Label lblFname;
        private System.Windows.Forms.Label lblDob;
        private System.Windows.Forms.Label lblTelNo;
        private System.Windows.Forms.Label lblEcode;
        private System.Windows.Forms.Label lblAdd1;
        private System.Windows.Forms.Label lblAdd2;
        private System.Windows.Forms.Label lblCounty;
        private System.Windows.Forms.TextBox txtSname;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.TextBox txtTelNo;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAdd1;
        private System.Windows.Forms.TextBox txtAdd2;
        private System.Windows.Forms.ComboBox cboMake;
        private System.Windows.Forms.ComboBox cboModel;
        private System.Windows.Forms.ComboBox cboColour;
        private System.Windows.Forms.ComboBox cboEngine;
        private System.Windows.Forms.ComboBox cboCounty;
        private System.Windows.Forms.DateTimePicker dtpFregdate;
        private System.Windows.Forms.DateTimePicker dtpDob;
        private System.Windows.Forms.GroupBox grbCarDetails;
        private System.Windows.Forms.GroupBox grbOdetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbPPSN;
        private System.Windows.Forms.Button btnCheckPPSN;
        private System.Windows.Forms.Label lblDLNo;
        private System.Windows.Forms.TextBox txtPPSN;
        private System.Windows.Forms.Button btnRegCar;
        private System.Windows.Forms.Button btbNext;
        private System.Windows.Forms.GroupBox grbRegCheck;
        private System.Windows.Forms.Button btnCheckReg;
        private System.Windows.Forms.Label lblRegNo;
        private System.Windows.Forms.TextBox txtRegNo;
        private System.Windows.Forms.Button btnCarSubmit;
        private System.Windows.Forms.Button btnClearCarReg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboFuel;
        private System.Windows.Forms.CheckBox chkExists;
        private System.Windows.Forms.CheckBox chkCar;
    }
}