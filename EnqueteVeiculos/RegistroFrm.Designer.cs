namespace EnqueteVeiculos
{
    partial class RegistroFrm
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
            toolStrip1 = new ToolStrip();
            btn_novo = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btn_salvar = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            groupBox1 = new GroupBox();
            tb_confsenha = new TextBox();
            tb_senha = new TextBox();
            tb_login = new TextBox();
            toolStrip2 = new ToolStrip();
            btn_entrar = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            btn_sair = new ToolStripButton();
            pb_img = new PictureBox();
            lbl_cadastro = new Label();
            toolStripSeparator4 = new ToolStripSeparator();
            toolStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_img).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { btn_novo, toolStripSeparator1, btn_salvar, toolStripSeparator3 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 58);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // btn_novo
            // 
            btn_novo.AutoSize = false;
            btn_novo.Image = Properties.Resources.novo;
            btn_novo.ImageScaling = ToolStripItemImageScaling.None;
            btn_novo.ImageTransparentColor = Color.Magenta;
            btn_novo.Name = "btn_novo";
            btn_novo.Size = new Size(98, 55);
            btn_novo.Text = "Novo";
            btn_novo.TextImageRelation = TextImageRelation.ImageAboveText;
            btn_novo.ToolTipText = "Novo";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 58);
            // 
            // btn_salvar
            // 
            btn_salvar.AutoSize = false;
            btn_salvar.Image = Properties.Resources.salvar;
            btn_salvar.ImageScaling = ToolStripItemImageScaling.None;
            btn_salvar.ImageTransparentColor = Color.Magenta;
            btn_salvar.Name = "btn_salvar";
            btn_salvar.Size = new Size(98, 55);
            btn_salvar.Text = "Salvar";
            btn_salvar.TextImageRelation = TextImageRelation.ImageAboveText;
            btn_salvar.Click += toolStripButton1_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 58);
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Control;
            groupBox1.Controls.Add(lbl_cadastro);
            groupBox1.Controls.Add(tb_confsenha);
            groupBox1.Controls.Add(tb_senha);
            groupBox1.Controls.Add(tb_login);
            groupBox1.Location = new Point(466, 52);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(334, 370);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // tb_confsenha
            // 
            tb_confsenha.Location = new Point(29, 200);
            tb_confsenha.Name = "tb_confsenha";
            tb_confsenha.PlaceholderText = "Confirmar senha";
            tb_confsenha.Size = new Size(276, 23);
            tb_confsenha.TabIndex = 1;
            tb_confsenha.TextAlign = HorizontalAlignment.Center;
            // 
            // tb_senha
            // 
            tb_senha.Location = new Point(29, 161);
            tb_senha.Name = "tb_senha";
            tb_senha.PlaceholderText = "Senha";
            tb_senha.Size = new Size(276, 23);
            tb_senha.TabIndex = 1;
            tb_senha.TextAlign = HorizontalAlignment.Center;
            // 
            // tb_login
            // 
            tb_login.Location = new Point(29, 122);
            tb_login.Name = "tb_login";
            tb_login.PlaceholderText = "Login";
            tb_login.Size = new Size(276, 23);
            tb_login.TabIndex = 1;
            tb_login.TextAlign = HorizontalAlignment.Center;
            // 
            // toolStrip2
            // 
            toolStrip2.AutoSize = false;
            toolStrip2.Dock = DockStyle.Bottom;
            toolStrip2.Items.AddRange(new ToolStripItem[] { btn_entrar, toolStripSeparator2, btn_sair, toolStripSeparator4 });
            toolStrip2.Location = new Point(0, 425);
            toolStrip2.Name = "toolStrip2";
            toolStrip2.Size = new Size(800, 46);
            toolStrip2.TabIndex = 2;
            toolStrip2.Text = "toolStrip2";
            // 
            // btn_entrar
            // 
            btn_entrar.AutoSize = false;
            btn_entrar.Image = Properties.Resources.entrar;
            btn_entrar.ImageScaling = ToolStripItemImageScaling.None;
            btn_entrar.ImageTransparentColor = Color.Magenta;
            btn_entrar.Name = "btn_entrar";
            btn_entrar.Size = new Size(98, 55);
            btn_entrar.Text = "Entrar";
            btn_entrar.TextImageRelation = TextImageRelation.ImageAboveText;
            btn_entrar.Click += toolStripButton3_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 46);
            // 
            // btn_sair
            // 
            btn_sair.AutoSize = false;
            btn_sair.Image = Properties.Resources.excluir;
            btn_sair.ImageScaling = ToolStripItemImageScaling.None;
            btn_sair.ImageTransparentColor = Color.Magenta;
            btn_sair.Name = "btn_sair";
            btn_sair.Size = new Size(98, 55);
            btn_sair.Text = "Sair";
            btn_sair.TextImageRelation = TextImageRelation.ImageAboveText;
            btn_sair.Click += toolStripButton4_Click;
            // 
            // pb_img
            // 
            pb_img.Image = Properties.Resources.carros_motor_importado;
            pb_img.Location = new Point(0, 59);
            pb_img.Name = "pb_img";
            pb_img.Size = new Size(460, 363);
            pb_img.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_img.TabIndex = 3;
            pb_img.TabStop = false;
            // 
            // lbl_cadastro
            // 
            lbl_cadastro.AutoSize = true;
            lbl_cadastro.Font = new Font("Microsoft New Tai Lue", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_cadastro.ForeColor = Color.FromArgb(64, 64, 64);
            lbl_cadastro.Location = new Point(96, 49);
            lbl_cadastro.Name = "lbl_cadastro";
            lbl_cadastro.Size = new Size(137, 25);
            lbl_cadastro.TabIndex = 2;
            lbl_cadastro.Text = "CADASTRE-SE";
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 46);
            // 
            // RegistroFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 471);
            Controls.Add(pb_img);
            Controls.Add(toolStrip2);
            Controls.Add(groupBox1);
            Controls.Add(toolStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "RegistroFrm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegistroFrm";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            toolStrip2.ResumeLayout(false);
            toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_img).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton btn_novo;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btn_salvar;
        private ToolStripSeparator toolStripSeparator3;
        private GroupBox groupBox1;
        private TextBox tb_senha;
        private TextBox tb_login;
        private TextBox tb_confsenha;
        private ToolStrip toolStrip2;
        private ToolStripButton btn_entrar;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton btn_sair;
        private PictureBox pb_img;
        private Label lbl_cadastro;
        private ToolStripSeparator toolStripSeparator4;
    }
}