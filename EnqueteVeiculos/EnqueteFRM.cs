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
    public partial class FichaTecnicaFRM : Form
    {
        public FichaTecnicaFRM()
        {
            InitializeComponent();
        }
        string path = @"C:\Users\Usuário\Pictures\images (2).jpg";
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                pictureBox1.Image = Image.FromFile(path);
            }   
        }
    }
}
