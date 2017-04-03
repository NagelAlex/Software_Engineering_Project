namespace NCTSYS
{
    partial class frmCloseCentre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCloseCentre));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grbCentreSearch = new System.Windows.Forms.GroupBox();
            this.cboCounty = new System.Windows.Forms.ComboBox();
            this.btnCentreSearch = new System.Windows.Forms.Button();
            this.lblCentreCounty = new System.Windows.Forms.Label();
            this.grdCentre = new System.Windows.Forms.DataGridView();
            this.grbCentreDetails = new System.Windows.Forms.GroupBox();
            this.txtCounty = new System.Windows.Forms.TextBox();
            this.lblCID = new System.Windows.Forms.Label();
            this.txtCentreId = new System.Windows.Forms.TextBox();
            this.lblCname = new System.Windows.Forms.Label();
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
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDeRegCentre = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.grbCentreSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCentre)).BeginInit();
            this.grbCentreDetails.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(669, 24);
            this.menuStrip1.TabIndex = 4;
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
            // grbCentreSearch
            // 
            this.grbCentreSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grbCentreSearch.BackgroundImage")));
            this.grbCentreSearch.Controls.Add(this.cboCounty);
            this.grbCentreSearch.Controls.Add(this.btnCentreSearch);
            this.grbCentreSearch.Controls.Add(this.lblCentreCounty);
            this.grbCentreSearch.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbCentreSearch.Location = new System.Drawing.Point(26, 41);
            this.grbCentreSearch.Name = "grbCentreSearch";
            this.grbCentreSearch.Size = new System.Drawing.Size(614, 58);
            this.grbCentreSearch.TabIndex = 62;
            this.grbCentreSearch.TabStop = false;
            this.grbCentreSearch.Text = "Test Centre Search";
            // 
            // cboCounty
            // 
            this.cboCounty.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCounty.FormattingEnabled = true;
            this.cboCounty.Location = new System.Drawing.Point(280, 23);
            this.cboCounty.MaxDropDownItems = 5;
            this.cboCounty.Name = "cboCounty";
            this.cboCounty.Size = new System.Drawing.Size(131, 21);
            this.cboCounty.TabIndex = 60;
            // 
            // btnCentreSearch
            // 
            this.btnCentreSearch.BackColor = System.Drawing.SystemColors.Control;
            this.btnCentreSearch.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCentreSearch.Location = new System.Drawing.Point(529, 22);
            this.btnCentreSearch.Name = "btnCentreSearch";
            this.btnCentreSearch.Size = new System.Drawing.Size(75, 23);
            this.btnCentreSearch.TabIndex = 59;
            this.btnCentreSearch.Text = "Search";
            this.btnCentreSearch.UseVisualStyleBackColor = false;
            this.btnCentreSearch.Click += new System.EventHandler(this.btnCentreSearch_Click);
            // 
            // lblCentreCounty
            // 
            this.lblCentreCounty.AutoSize = true;
            this.lblCentreCounty.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCentreCounty.Location = new System.Drawing.Point(204, 27);
            this.lblCentreCounty.Name = "lblCentreCounty";
            this.lblCentreCounty.Size = new System.Drawing.Size(60, 13);
            this.lblCentreCounty.TabIndex = 57;
            this.lblCentreCounty.Text = "County:";
            // 
            // grdCentre
            // 
            this.grdCentre.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdCentre.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdCentre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdCentre.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdCentre.Location = new System.Drawing.Point(26, 115);
            this.grdCentre.Name = "grdCentre";
            this.grdCentre.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdCentre.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdCentre.Size = new System.Drawing.Size(614, 186);
            this.grdCentre.TabIndex = 63;
            this.grdCentre.Visible = false;
            this.grdCentre.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCentre_CellContentClick);
            // 
            // grbCentreDetails
            // 
            this.grbCentreDetails.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grbCentreDetails.BackgroundImage")));
            this.grbCentreDetails.Controls.Add(this.txtCounty);
            this.grbCentreDetails.Controls.Add(this.lblCID);
            this.grbCentreDetails.Controls.Add(this.txtCentreId);
            this.grbCentreDetails.Controls.Add(this.lblCname);
            this.grbCentreDetails.Controls.Add(this.txtAdd2);
            this.grbCentreDetails.Controls.Add(this.txtAdd1);
            this.grbCentreDetails.Controls.Add(this.lblCounty);
            this.grbCentreDetails.Controls.Add(this.lblTelNo);
            this.grbCentreDetails.Controls.Add(this.lblAdd2);
            this.grbCentreDetails.Controls.Add(this.txtEmail);
            this.grbCentreDetails.Controls.Add(this.lblAdd1);
            this.grbCentreDetails.Controls.Add(this.lblEcode);
            this.grbCentreDetails.Controls.Add(this.txtTelNo);
            this.grbCentreDetails.Controls.Add(this.txtName);
            this.grbCentreDetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grbCentreDetails.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbCentreDetails.Location = new System.Drawing.Point(26, 316);
            this.grbCentreDetails.Name = "grbCentreDetails";
            this.grbCentreDetails.Size = new System.Drawing.Size(615, 168);
            this.grbCentreDetails.TabIndex = 64;
            this.grbCentreDetails.TabStop = false;
            this.grbCentreDetails.Text = "Test Centre Details";
            this.grbCentreDetails.Visible = false;
            // 
            // txtCounty
            // 
            this.txtCounty.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCounty.Location = new System.Drawing.Point(409, 116);
            this.txtCounty.Name = "txtCounty";
            this.txtCounty.ReadOnly = true;
            this.txtCounty.Size = new System.Drawing.Size(131, 21);
            this.txtCounty.TabIndex = 60;
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
            // txtAdd2
            // 
            this.txtAdd2.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdd2.Location = new System.Drawing.Point(142, 116);
            this.txtAdd2.Name = "txtAdd2";
            this.txtAdd2.ReadOnly = true;
            this.txtAdd2.Size = new System.Drawing.Size(149, 21);
            this.txtAdd2.TabIndex = 26;
            // 
            // txtAdd1
            // 
            this.txtAdd1.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdd1.Location = new System.Drawing.Point(142, 88);
            this.txtAdd1.Name = "txtAdd1";
            this.txtAdd1.ReadOnly = true;
            this.txtAdd1.Size = new System.Drawing.Size(149, 21);
            this.txtAdd1.TabIndex = 25;
            // 
            // lblCounty
            // 
            this.lblCounty.AutoSize = true;
            this.lblCounty.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCounty.Location = new System.Drawing.Point(335, 119);
            this.lblCounty.Name = "lblCounty";
            this.lblCounty.Size = new System.Drawing.Size(60, 13);
            this.lblCounty.TabIndex = 17;
            this.lblCounty.Text = "county:";
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
            this.txtEmail.ReadOnly = true;
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
            this.txtTelNo.ReadOnly = true;
            this.txtTelNo.Size = new System.Drawing.Size(131, 21);
            this.txtTelNo.TabIndex = 23;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(143, 60);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(148, 21);
            this.txtName.TabIndex = 21;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Red;
            this.btnClear.Location = new System.Drawing.Point(26, 498);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(97, 27);
            this.btnClear.TabIndex = 65;
            this.btnClear.Text = "Clear Form";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Visible = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDeRegCentre
            // 
            this.btnDeRegCentre.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeRegCentre.ForeColor = System.Drawing.Color.Green;
            this.btnDeRegCentre.Location = new System.Drawing.Point(542, 498);
            this.btnDeRegCentre.Name = "btnDeRegCentre";
            this.btnDeRegCentre.Size = new System.Drawing.Size(99, 27);
            this.btnDeRegCentre.TabIndex = 66;
            this.btnDeRegCentre.Text = "de-Register";
            this.btnDeRegCentre.UseVisualStyleBackColor = true;
            this.btnDeRegCentre.Visible = false;
            this.btnDeRegCentre.Click += new System.EventHandler(this.btnDeRegCentre_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(188, 532);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 13);
            this.label1.TabIndex = 67;
            this.label1.Text = "Copyright © 2017 by NCT Systems Solutions LTD.";
            // 
            // frmCloseCentre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(669, 547);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeRegCentre);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.grbCentreDetails);
            this.Controls.Add(this.grdCentre);
            this.Controls.Add(this.grbCentreSearch);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCloseCentre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NCTSYS - Close Test Centre";
            this.Load += new System.EventHandler(this.frmCloseCentre_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grbCentreSearch.ResumeLayout(false);
            this.grbCentreSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCentre)).EndInit();
            this.grbCentreDetails.ResumeLayout(false);
            this.grbCentreDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox grbCentreSearch;
        private System.Windows.Forms.Button btnCentreSearch;
        private System.Windows.Forms.Label lblCentreCounty;
        private System.Windows.Forms.ComboBox cboCounty;
        private System.Windows.Forms.DataGridView grdCentre;
        private System.Windows.Forms.GroupBox grbCentreDetails;
        private System.Windows.Forms.Label lblCID;
        private System.Windows.Forms.TextBox txtCentreId;
        private System.Windows.Forms.Label lblCname;
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
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtCounty;
        private System.Windows.Forms.Button btnDeRegCentre;
        private System.Windows.Forms.Label label1;
    }
}