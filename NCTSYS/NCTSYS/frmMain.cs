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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void registerACarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmReg nextForm = new frmReg(this);
            nextForm.Show();
        }

        private void deRegisterACarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmDeReg(this).Show();
        }

        private void carHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmHistory(this).Show();
        }

        private void newTestCentreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmNewCentre(this).Show();
        }

        private void closeCentreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmCloseCentre(this).Show();
        }

        private void issueNoticeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmNotice(this).Show();
        }

        private void makeAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmMakeApp(this).Show();
        }

        private void cancelAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmCancelApp(this).Show();
        }

        private void recordTestResultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmRecTestRes(this).Show();
        }

        private void listDailyAppointmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmDailyApp(this).Show();
        }
    }
}
