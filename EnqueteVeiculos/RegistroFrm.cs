using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnqueteVeiculos
{
    public partial class RegistroFrm : Form
    {
        public RegistroFrm()
        {
            InitializeComponent();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Salvo com successo","",MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
    }
}
