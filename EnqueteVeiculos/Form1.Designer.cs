namespace EnqueteVeiculos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pb_img = new PictureBox();
            groupBox1 = new GroupBox();
            lbl_clique = new Label();
            lbl_cadastro = new Label();
            btn_login = new Button();
            txt_email = new TextBox();
            txt_senha = new TextBox();
            lbl_inicio = new Label();
            ((System.ComponentModel.ISupportInitialize)pb_img).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pb_img
            // 
            pb_img.Image = Properties.Resources.carros_motor_importado;
            pb_img.Location = new Point(12, 21);
            pb_img.Name = "pb_img";
            pb_img.Size = new Size(460, 417);
            pb_img.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_img.TabIndex = 1;
            pb_img.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lbl_clique);
            groupBox1.Controls.Add(lbl_cadastro);
            groupBox1.Controls.Add(btn_login);
            groupBox1.Controls.Add(txt_email);
            groupBox1.Controls.Add(txt_senha);
            groupBox1.Controls.Add(lbl_inicio);
            groupBox1.Location = new Point(478, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(320, 426);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // lbl_clique
            // 
            lbl_clique.Cursor = Cursors.Hand;
            lbl_clique.ForeColor = Color.FromArgb(64, 64, 64);
            lbl_clique.Location = new Point(207, 347);
            lbl_clique.Name = "lbl_clique";
            lbl_clique.Size = new Size(79, 15);
            lbl_clique.TabIndex = 8;
            lbl_clique.Text = "Clique Aqui!";
            lbl_clique.Click += label2_Click;
            // 
            // lbl_cadastro
            // 
            lbl_cadastro.AutoSize = true;
            lbl_cadastro.BackColor = SystemColors.Control;
            lbl_cadastro.ForeColor = SystemColors.ButtonShadow;
            lbl_cadastro.Location = new Point(74, 347);
            lbl_cadastro.Name = "lbl_cadastro";
            lbl_cadastro.Size = new Size(141, 15);
            lbl_cadastro.TabIndex = 7;
            lbl_cadastro.Text = "Ainda não tem cadastro? ";
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.FromArgb(64, 64, 64);
            btn_login.FlatAppearance.BorderSize = 0;
            btn_login.FlatStyle = FlatStyle.Flat;
            btn_login.ForeColor = SystemColors.Control;
            btn_login.Location = new Point(6, 386);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(308, 34);
            btn_login.TabIndex = 6;
            btn_login.Text = "LOGIN";
            btn_login.TextImageRelation = TextImageRelation.ImageAboveText;
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // txt_email
            // 
            txt_email.Location = new Point(27, 149);
            txt_email.Name = "txt_email";
            txt_email.PlaceholderText = "e-mail";
            txt_email.Size = new Size(253, 23);
            txt_email.TabIndex = 5;
            txt_email.TextAlign = HorizontalAlignment.Center;
            txt_email.TextChanged += txt_email_TextChanged_1;
            // 
            // txt_senha
            // 
            txt_senha.Location = new Point(27, 200);
            txt_senha.Name = "txt_senha";
            txt_senha.PlaceholderText = "senha";
            txt_senha.Size = new Size(253, 23);
            txt_senha.TabIndex = 5;
            txt_senha.TextAlign = HorizontalAlignment.Center;
            txt_senha.UseSystemPasswordChar = true;
            txt_senha.TextChanged += txt_senha_TextChanged_1;
            // 
            // lbl_inicio
            // 
            lbl_inicio.AutoSize = true;
            lbl_inicio.Font = new Font("Microsoft New Tai Lue", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_inicio.ForeColor = Color.FromArgb(64, 64, 64);
            lbl_inicio.Location = new Point(27, 46);
            lbl_inicio.Name = "lbl_inicio";
            lbl_inicio.Size = new Size(257, 38);
            lbl_inicio.TabIndex = 3;
            lbl_inicio.Text = "SEJA BEM-VINDO";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(pb_img);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pb_img).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pb_img;
        private GroupBox groupBox1;
        private Button btn_login;
        private TextBox txt_senha;
        private Label lbl_inicio;
        private Label lbl_cadastro;
        private Label lbl_clique;
        private TextBox txt_email;
    }
}
