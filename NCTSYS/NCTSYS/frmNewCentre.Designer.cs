namespace NCTSYS
{
    partial class frmNewCentre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewCentre));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grbOdetails = new System.Windows.Forms.GroupBox();
            this.lblCID = new System.Windows.Forms.Label();
            this.txtCentreId = new System.Windows.Forms.TextBox();
            this.lblCname = new System.Windows.Forms.Label();
            this.cboCounty = new System.Windows.Forms.ComboBox();
            this.txtAdd2 = new System.Windows.Forms.TextBox();
            this.txtAdd1 = new System.Windows.Forms.TextBox();
            this.lblCounty = new System.Windows.Forms.Label();
            this.lblTelNo = new System.Windows.Forms.Label();
            this.lblAdd2 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblAdd1 = new System.Windows.Forms.Label();
            this.lblEcode = new System.Windows.Forms.Label();
            this.txtTelNo = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnRegCentre = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.grbOdetails.SuspendLayout();
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
            this.menuStrip1.TabIndex = 3;
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
            // grbOdetails
            // 
            this.grbOdetails.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grbOdetails.BackgroundImage")));
            this.grbOdetails.Controls.Add(this.lblCID);
            this.grbOdetails.Controls.Add(this.txtCentreId);
            this.grbOdetails.Controls.Add(this.lblCname);
            this.grbOdetails.Controls.Add(this.cboCounty);
            this.grbOdetails.Controls.Add(this.txtAdd2);
            this.grbOdetails.Controls.Add(this.txtAdd1);
            this.grbOdetails.Controls.Add(this.lblCounty);
            this.grbOdetails.Controls.Add(this.lblTelNo);
            this.grbOdetails.Controls.Add(this.lblAdd2);
            this.grbOdetails.Controls.Add(this.txtEmail);
            this.grbOdetails.Controls.Add(this.lblAdd1);
            this.grbOdetails.Controls.Add(this.lblEcode);
            this.grbOdetails.Controls.Add(this.txtTelNo);
            this.grbOdetails.Controls.Add(this.txtName);
            this.grbOdetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grbOdetails.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbOdetails.Location = new System.Drawing.Point(29, 42);
            this.grbOdetails.Name = "grbOdetails";
            this.grbOdetails.Size = new System.Drawing.Size(615, 168);
            this.grbOdetails.TabIndex = 57;
            this.grbOdetails.TabStop = false;
            this.grbOdetails.Text = "new Test Centre Details";
            // 
            // lblCID
            // 
            this.lblCID.AutoSize = true;
            this.lblCID.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCID.Location = new System.Drawing.Point(49, 25);
            this.lblCID.Name = "lblCID";
            this.lblCID.Size = new System.Drawing.Size(68, 13);
            this.lblCID.TabIndex = 59;
            this.lblCID.Text = "centre ID:";
            // 
            // txtCentreId
            // 
            this.txtCentreId.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCentreId.Location = new System.Drawing.Point(145, 21);
            this.txtCentreId.Name = "txtCentreId";
            this.txtCentreId.ReadOnly = true;
            this.txtCentreId.Size = new System.Drawing.Size(39, 22);
            this.txtCentreId.TabIndex = 58;
            // 
            // lblCname
            // 
            this.lblCname.AutoSize = true;
            this.lblCname.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCname.Location = new System.Drawing.Point(46, 64);
            this.lblCname.Name = "lblCname";
            this.lblCname.Size = new System.Drawing.Size(88, 13);
            this.lblCname.TabIndex = 10;
            this.lblCname.Text = "centre name:";
            // 
            // cboCounty
            // 
            this.cboCounty.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCounty.FormattingEnabled = true;
            this.cboCounty.Location = new System.Drawing.Point(409, 115);
            this.cboCounty.MaxDropDownItems = 5;
            this.cboCounty.Name = "cboCounty";
            this.cboCounty.Size = new System.Drawing.Size(131, 21);
            this.cboCounty.TabIndex = 31;
            // 
            // txtAdd2
            // 
            this.txtAdd2.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdd2.Location = new System.Drawing.Point(142, 116);
            this.txtAdd2.Name = "txtAdd2";
            this.txtAdd2.Size = new System.Drawing.Size(149, 21);
            this.txtAdd2.TabIndex = 26;
            // 
            // txtAdd1
            // 
            this.txtAdd1.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdd1.Location = new System.Drawing.Point(142, 88);
            this.txtAdd1.Name = "txtAdd1";
            this.txtAdd1.Size = new System.Drawing.Size(149, 21);
            this.txtAdd1.TabIndex = 25;
            // 
            // lblCounty
            // 
            this.lblCounty.AutoSize = true;
            this.lblCounty.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCounty.Location = new System.Drawing.Point(335, 119);
            this.lblCounty.Name = "lblCounty";
            this.lblCounty.Size = new System.Drawing.Size(58, 13);
            this.lblCounty.TabIndex = 17;
            this.lblCounty.Text = "county";
            // 
            // lblTelNo
            // 
            this.lblTelNo.AutoSize = true;
            this.lblTelNo.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelNo.Location = new System.Drawing.Point(332, 64);
            this.lblTelNo.Name = "lblTelNo";
            this.lblTelNo.Size = new System.Drawing.Size(51, 13);
            this.lblTelNo.TabIndex = 13;
            this.lblTelNo.Text = "Tel no:";
            // 
            // lblAdd2
            // 
            this.lblAdd2.AutoSize = true;
            this.lblAdd2.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdd2.Location = new System.Drawing.Point(48, 119);
            this.lblAdd2.Name = "lblAdd2";
            this.lblAdd2.Size = new System.Drawing.Size(66, 13);
            this.lblAdd2.TabIndex = 16;
            this.lblAdd2.Text = "Address 2";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(409, 88);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(131, 21);
            this.txtEmail.TabIndex = 24;
            // 
            // lblAdd1
            // 
            this.lblAdd1.AutoSize = true;
            this.lblAdd1.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdd1.Location = new System.Drawing.Point(48, 92);
            this.lblAdd1.Name = "lblAdd1";
            this.lblAdd1.Size = new System.Drawing.Size(63, 13);
            this.lblAdd1.TabIndex = 15;
            this.lblAdd1.Text = "Address 1";
            // 
            // lblEcode
            // 
            this.lblEcode.AutoSize = true;
            this.lblEcode.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEcode.Location = new System.Drawing.Point(334, 92);
            this.lblEcode.Name = "lblEcode";
            this.lblEcode.Size = new System.Drawing.Size(41, 13);
            this.lblEcode.TabIndex = 14;
            this.lblEcode.Text = "email:";
            // 
            // txtTelNo
            // 
            this.txtTelNo.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelNo.Location = new System.Drawing.Point(409, 60);
            this.txtTelNo.Name = "txtTelNo";
            this.txtTelNo.Size = new System.Drawing.Size(131, 21);
            this.txtTelNo.TabIndex = 23;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(143, 60);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(148, 21);
            this.txtName.TabIndex = 21;
            // 
            // btnRegCentre
            // 
            this.btnRegCentre.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegCentre.ForeColor = System.Drawing.Color.Green;
            this.btnRegCentre.Location = new System.Drawing.Point(545, 227);
            this.btnRegCentre.Name = "btnRegCentre";
            this.btnRegCentre.Size = new System.Drawing.Size(99, 27);
            this.btnRegCentre.TabIndex = 58;
            this.btnRegCentre.Text = "Register";
            this.btnRegCentre.UseVisualStyleBackColor = true;
            this.btnRegCentre.Click += new System.EventHandler(this.btnRegCentre_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Red;
            this.btnClear.Location = new System.Drawing.Point(29, 227);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(97, 27);
            this.btnClear.TabIndex = 59;
            this.btnClear.Text = "Clear Form";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(186, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 13);
            this.label1.TabIndex = 60;
            this.label1.Text = "Copyright © 2017 by NCT Systems Solutions LTD.";
            // 
            // frmNewCentre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(675, 280);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRegCentre);
            this.Controls.Add(this.grbOdetails);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNewCentre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NCTSYS - New Test Centre";
            this.Load += new System.EventHandler(this.frmNewCentre_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grbOdetails.ResumeLayout(false);
            this.grbOdetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox grbOdetails;
        private System.Windows.Forms.TextBox txtCentreId;
        private System.Windows.Forms.Label lblCname;
        private System.Windows.Forms.ComboBox cboCounty;
        private System.Windows.Forms.TextBox txtAdd2;
        private System.Windows.Forms.TextBox txtAdd1;
        private System.Windows.Forms.Label lblCounty;
        private System.Windows.Forms.Label lblTelNo;
        private System.Windows.Forms.Label lblAdd2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblAdd1;
        private System.Windows.Forms.Label lblEcode;
        private System.Windows.Forms.TextBox txtTelNo;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblCID;
        private System.Windows.Forms.Button btnRegCentre;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label1;
    }
}