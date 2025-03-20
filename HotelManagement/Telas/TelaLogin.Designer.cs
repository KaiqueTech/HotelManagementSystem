namespace HotelManagement
{
    partial class TelaLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaLogin));
            pictureBox1 = new PictureBox();
            lblLogin = new Label();
            txtLogin = new TextBox();
            txtSenha = new TextBox();
            lblSenha = new Label();
            btnEntrar = new Button();
            btnSair = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(112, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(229, 185);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Location = new Point(96, 211);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(40, 15);
            lblLogin.TabIndex = 1;
            lblLogin.Text = "Login:";
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(96, 229);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(299, 23);
            txtLogin.TabIndex = 2;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(96, 295);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(299, 23);
            txtSenha.TabIndex = 4;
            txtSenha.TextChanged += txtSenha_TextChanged;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(96, 277);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(42, 15);
            lblSenha.TabIndex = 3;
            lblSenha.Text = "Senha:";
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(138, 373);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(75, 23);
            btnEntrar.TabIndex = 5;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = false;
            // 
            // btnSair
            // 
            btnSair.BackColor = SystemColors.Control;
            btnSair.Location = new Point(266, 373);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(75, 23);
            btnSair.TabIndex = 6;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // TelaLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(465, 446);
            Controls.Add(btnSair);
            Controls.Add(btnEntrar);
            Controls.Add(txtSenha);
            Controls.Add(lblSenha);
            Controls.Add(txtLogin);
            Controls.Add(lblLogin);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "TelaLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Tag = "";
            Text = "Sandes Hotel Manager - Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblLogin;
        private TextBox txtLogin;
        private TextBox txtSenha;
        private Label lblSenha;
        private Button btnEntrar;
        private Button btnSair;
    }
}
