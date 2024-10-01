namespace EnqueteVeiculos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void txt_senha_TextChanged(object sender, EventArgs e)
        {
            txt_senha.TextAlign = HorizontalAlignment.Left;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            btn_login.FlatAppearance.BorderSize = 0;
            FichaTecnicaFRM fichaTecnica = new FichaTecnicaFRM();
            fichaTecnica.ShowDialog();

        }



        private void txt_email_TextChanged_1(object sender, EventArgs e)
        {
            txt_email.TextAlign = HorizontalAlignment.Left;

        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (true)
            {
                RegistroFrm registro = new RegistroFrm();
                registro.Show();
            }
        }

        private void txt_senha_TextChanged_1(object sender, EventArgs e)
        {
            txt_senha.TextAlign = HorizontalAlignment.Left;
        }
    }
}
