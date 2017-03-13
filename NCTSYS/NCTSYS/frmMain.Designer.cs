namespace NCTSYS
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.rEGISTRATIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerACarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deRegisterACarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testCentreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newTestCentreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeCentreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appointmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issueNoticeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeAppointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelAppointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recordTestResultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listDailyAppointmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuStrip1.BackgroundImage")));
            this.menuStrip1.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rEGISTRATIONToolStripMenuItem,
            this.testCentreToolStripMenuItem,
            this.appointmentsToolStripMenuItem,
            this.eXITToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(11, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(621, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // rEGISTRATIONToolStripMenuItem
            // 
            this.rEGISTRATIONToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerACarToolStripMenuItem,
            this.deRegisterACarToolStripMenuItem,
            this.carHistoryToolStripMenuItem});
            this.rEGISTRATIONToolStripMenuItem.Name = "rEGISTRATIONToolStripMenuItem";
            this.rEGISTRATIONToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.rEGISTRATIONToolStripMenuItem.Text = "Registration";
            // 
            // registerACarToolStripMenuItem
            // 
            this.registerACarToolStripMenuItem.Name = "registerACarToolStripMenuItem";
            this.registerACarToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.registerACarToolStripMenuItem.Text = "Register";
            this.registerACarToolStripMenuItem.Click += new System.EventHandler(this.registerACarToolStripMenuItem_Click);
            // 
            // deRegisterACarToolStripMenuItem
            // 
            this.deRegisterACarToolStripMenuItem.Name = "deRegisterACarToolStripMenuItem";
            this.deRegisterACarToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.deRegisterACarToolStripMenuItem.Text = "De-Register";
            this.deRegisterACarToolStripMenuItem.Click += new System.EventHandler(this.deRegisterACarToolStripMenuItem_Click);
            // 
            // carHistoryToolStripMenuItem
            // 
            this.carHistoryToolStripMenuItem.Name = "carHistoryToolStripMenuItem";
            this.carHistoryToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.carHistoryToolStripMenuItem.Text = "Car History";
            this.carHistoryToolStripMenuItem.Click += new System.EventHandler(this.carHistoryToolStripMenuItem_Click);
            // 
            // testCentreToolStripMenuItem
            // 
            this.testCentreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTestCentreToolStripMenuItem,
            this.closeCentreToolStripMenuItem});
            this.testCentreToolStripMenuItem.Name = "testCentreToolStripMenuItem";
            this.testCentreToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.testCentreToolStripMenuItem.Text = "Test Centre";
            // 
            // newTestCentreToolStripMenuItem
            // 
            this.newTestCentreToolStripMenuItem.Name = "newTestCentreToolStripMenuItem";
            this.newTestCentreToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.newTestCentreToolStripMenuItem.Text = "New Test Centre";
            this.newTestCentreToolStripMenuItem.Click += new System.EventHandler(this.newTestCentreToolStripMenuItem_Click);
            // 
            // closeCentreToolStripMenuItem
            // 
            this.closeCentreToolStripMenuItem.Name = "closeCentreToolStripMenuItem";
            this.closeCentreToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.closeCentreToolStripMenuItem.Text = "Close Centre";
            this.closeCentreToolStripMenuItem.Click += new System.EventHandler(this.closeCentreToolStripMenuItem_Click);
            // 
            // appointmentsToolStripMenuItem
            // 
            this.appointmentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.issueNoticeToolStripMenuItem,
            this.makeAppointmentToolStripMenuItem,
            this.cancelAppointmentToolStripMenuItem,
            this.recordTestResultsToolStripMenuItem,
            this.listDailyAppointmentsToolStripMenuItem});
            this.appointmentsToolStripMenuItem.Name = "appointmentsToolStripMenuItem";
            this.appointmentsToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.appointmentsToolStripMenuItem.Text = "Appointments";
            // 
            // issueNoticeToolStripMenuItem
            // 
            this.issueNoticeToolStripMenuItem.Name = "issueNoticeToolStripMenuItem";
            this.issueNoticeToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.issueNoticeToolStripMenuItem.Text = "Issue Notice";
            this.issueNoticeToolStripMenuItem.Click += new System.EventHandler(this.issueNoticeToolStripMenuItem_Click);
            // 
            // makeAppointmentToolStripMenuItem
            // 
            this.makeAppointmentToolStripMenuItem.Name = "makeAppointmentToolStripMenuItem";
            this.makeAppointmentToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.makeAppointmentToolStripMenuItem.Text = "Make Appointment";
            this.makeAppointmentToolStripMenuItem.Click += new System.EventHandler(this.makeAppointmentToolStripMenuItem_Click);
            // 
            // cancelAppointmentToolStripMenuItem
            // 
            this.cancelAppointmentToolStripMenuItem.Name = "cancelAppointmentToolStripMenuItem";
            this.cancelAppointmentToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.cancelAppointmentToolStripMenuItem.Text = "Cancel Appointment";
            this.cancelAppointmentToolStripMenuItem.Click += new System.EventHandler(this.cancelAppointmentToolStripMenuItem_Click);
            // 
            // recordTestResultsToolStripMenuItem
            // 
            this.recordTestResultsToolStripMenuItem.Name = "recordTestResultsToolStripMenuItem";
            this.recordTestResultsToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.recordTestResultsToolStripMenuItem.Text = "Record Test Results";
            this.recordTestResultsToolStripMenuItem.Click += new System.EventHandler(this.recordTestResultsToolStripMenuItem_Click);
            // 
            // listDailyAppointmentsToolStripMenuItem
            // 
            this.listDailyAppointmentsToolStripMenuItem.Name = "listDailyAppointmentsToolStripMenuItem";
            this.listDailyAppointmentsToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.listDailyAppointmentsToolStripMenuItem.Text = "List Daily Appointments";
            this.listDailyAppointmentsToolStripMenuItem.Click += new System.EventHandler(this.listDailyAppointmentsToolStripMenuItem_Click);
            // 
            // eXITToolStripMenuItem
            // 
            this.eXITToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.eXITToolStripMenuItem.Name = "eXITToolStripMenuItem";
            this.eXITToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.eXITToolStripMenuItem.Text = "EXIT";
            this.eXITToolStripMenuItem.Click += new System.EventHandler(this.eXITToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(621, 435);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NCTSYS - MAIN MENU";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rEGISTRATIONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testCentreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem appointmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXITToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerACarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deRegisterACarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newTestCentreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeCentreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issueNoticeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeAppointmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelAppointmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recordTestResultsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listDailyAppointmentsToolStripMenuItem;
    }
}

