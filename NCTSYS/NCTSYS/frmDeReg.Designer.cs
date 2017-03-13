namespace NCTSYS
{
    partial class frmDeReg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDeReg));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grbRegCheck = new System.Windows.Forms.GroupBox();
            this.btnCheckReg = new System.Windows.Forms.Button();
            this.lblRegNo = new System.Windows.Forms.Label();
            this.txtRegNo = new System.Windows.Forms.TextBox();
            this.grbCarDetails = new System.Windows.Forms.GroupBox();
            this.btnContinue = new System.Windows.Forms.Button();
            this.txtFuel = new System.Windows.Forms.TextBox();
            this.txtEngine = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btbNext = new System.Windows.Forms.Button();
            this.lblMake = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.dtpFregdate = new System.Windows.Forms.DateTimePicker();
            this.lblColour = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grbDeReg = new System.Windows.Forms.GroupBox();
            this.btnDeReg = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.grbRegCheck.SuspendLayout();
            this.grbCarDetails.SuspendLayout();
            this.grbDeReg.SuspendLayout();
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
            this.menuStrip1.TabIndex = 1;
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
            // grbRegCheck
            // 
            this.grbRegCheck.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grbRegCheck.BackgroundImage")));
            this.grbRegCheck.Controls.Add(this.btnCheckReg);
            this.grbRegCheck.Controls.Add(this.lblRegNo);
            this.grbRegCheck.Controls.Add(this.txtRegNo);
            this.grbRegCheck.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbRegCheck.Location = new System.Drawing.Point(30, 45);
            this.grbRegCheck.Name = "grbRegCheck";
            this.grbRegCheck.Size = new System.Drawing.Size(614, 58);
            this.grbRegCheck.TabIndex = 61;
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
            // grbCarDetails
            // 
            this.grbCarDetails.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grbCarDetails.BackgroundImage")));
            this.grbCarDetails.Controls.Add(this.btnContinue);
            this.grbCarDetails.Controls.Add(this.txtFuel);
            this.grbCarDetails.Controls.Add(this.txtEngine);
            this.grbCarDetails.Controls.Add(this.txtColor);
            this.grbCarDetails.Controls.Add(this.txtModel);
            this.grbCarDetails.Controls.Add(this.txtMake);
            this.grbCarDetails.Controls.Add(this.label2);
            this.grbCarDetails.Controls.Add(this.btbNext);
            this.grbCarDetails.Controls.Add(this.lblMake);
            this.grbCarDetails.Controls.Add(this.lblModel);
            this.grbCarDetails.Controls.Add(this.dtpFregdate);
            this.grbCarDetails.Controls.Add(this.lblColour);
            this.grbCarDetails.Controls.Add(this.label8);
            this.grbCarDetails.Controls.Add(this.label7);
            this.grbCarDetails.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbCarDetails.Location = new System.Drawing.Point(30, 124);
            this.grbCarDetails.Name = "grbCarDetails";
            this.grbCarDetails.Size = new System.Drawing.Size(614, 178);
            this.grbCarDetails.TabIndex = 62;
            this.grbCarDetails.TabStop = false;
            this.grbCarDetails.Text = "Car Details";
            this.grbCarDetails.Visible = false;
            // 
            // btnContinue
            // 
            this.btnContinue.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinue.ForeColor = System.Drawing.Color.Green;
            this.btnContinue.Location = new System.Drawing.Point(518, 140);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(86, 23);
            this.btnContinue.TabIndex = 67;
            this.btnContinue.Text = "continue";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // txtFuel
            // 
            this.txtFuel.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFuel.Location = new System.Drawing.Point(360, 141);
            this.txtFuel.Name = "txtFuel";
            this.txtFuel.Size = new System.Drawing.Size(137, 21);
            this.txtFuel.TabIndex = 66;
            // 
            // txtEngine
            // 
            this.txtEngine.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEngine.Location = new System.Drawing.Point(118, 140);
            this.txtEngine.Name = "txtEngine";
            this.txtEngine.Size = new System.Drawing.Size(137, 21);
            this.txtEngine.TabIndex = 65;
            // 
            // txtColor
            // 
            this.txtColor.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColor.Location = new System.Drawing.Point(118, 107);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(137, 21);
            this.txtColor.TabIndex = 64;
            // 
            // txtModel
            // 
            this.txtModel.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModel.Location = new System.Drawing.Point(118, 73);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(137, 21);
            this.txtModel.TabIndex = 63;
            // 
            // txtMake
            // 
            this.txtMake.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMake.Location = new System.Drawing.Point(118, 43);
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(137, 21);
            this.txtMake.TabIndex = 62;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(275, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 61;
            this.label2.Text = "fuel type:";
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
            // dtpFregdate
            // 
            this.dtpFregdate.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpFregdate.Location = new System.Drawing.Point(369, 76);
            this.dtpFregdate.Name = "dtpFregdate";
            this.dtpFregdate.Size = new System.Drawing.Size(138, 21);
            this.dtpFregdate.TabIndex = 32;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(183, 435);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 13);
            this.label1.TabIndex = 63;
            this.label1.Text = "Copyright © 2017 by NCT Systems Solutions LTD.";
            // 
            // grbDeReg
            // 
            this.grbDeReg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grbDeReg.BackgroundImage")));
            this.grbDeReg.Controls.Add(this.btnDeReg);
            this.grbDeReg.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDeReg.Location = new System.Drawing.Point(30, 322);
            this.grbDeReg.Name = "grbDeReg";
            this.grbDeReg.Size = new System.Drawing.Size(614, 58);
            this.grbDeReg.TabIndex = 64;
            this.grbDeReg.TabStop = false;
            this.grbDeReg.Text = "De-Rigistration";
            this.grbDeReg.Visible = false;
            // 
            // btnDeReg
            // 
            this.btnDeReg.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeReg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDeReg.Location = new System.Drawing.Point(261, 21);
            this.btnDeReg.Name = "btnDeReg";
            this.btnDeReg.Size = new System.Drawing.Size(86, 23);
            this.btnDeReg.TabIndex = 30;
            this.btnDeReg.Text = "de-register";
            this.btnDeReg.UseVisualStyleBackColor = true;
            this.btnDeReg.Click += new System.EventHandler(this.btnDeReg_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClear.Location = new System.Drawing.Point(548, 395);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(96, 28);
            this.btnClear.TabIndex = 65;
            this.btnClear.Text = "clear form";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Visible = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmDeReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(675, 451);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.grbDeReg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grbCarDetails);
            this.Controls.Add(this.grbRegCheck);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDeReg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NCTSYS - De-Registration";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grbRegCheck.ResumeLayout(false);
            this.grbRegCheck.PerformLayout();
            this.grbCarDetails.ResumeLayout(false);
            this.grbCarDetails.PerformLayout();
            this.grbDeReg.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox grbRegCheck;
        private System.Windows.Forms.Button btnCheckReg;
        private System.Windows.Forms.Label lblRegNo;
        private System.Windows.Forms.TextBox txtRegNo;
        private System.Windows.Forms.GroupBox grbCarDetails;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btbNext;
        private System.Windows.Forms.Label lblMake;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.DateTimePicker dtpFregdate;
        private System.Windows.Forms.Label lblColour;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFuel;
        private System.Windows.Forms.TextBox txtEngine;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.GroupBox grbDeReg;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Button btnDeReg;
        private System.Windows.Forms.Button btnClear;
    }
}