using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmGiris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void işlemlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTransactions frm = new frmTransactions();
            frm.MdiParent = this;
            frm.Show();
        }

        private void kullanıcıKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsers frm = new frmUsers();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
