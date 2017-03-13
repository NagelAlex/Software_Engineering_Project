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
    public partial class frmHistory : Form
    {
        private Form parent;
        public frmHistory()
        {
            InitializeComponent();
        }
        public frmHistory(Form parent)
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
    }
}
