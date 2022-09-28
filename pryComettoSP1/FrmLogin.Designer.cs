namespace pryComettoSP1_09_09_22_LP1_PAG_11
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.LblUsuario = new System.Windows.Forms.Label();
            this.LblPassword = new System.Windows.Forms.Label();
            this.LblModulo = new System.Windows.Forms.Label();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.LstModulo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Location = new System.Drawing.Point(30, 25);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(47, 15);
            this.LblUsuario.TabIndex = 0;
            this.LblUsuario.Text = "Usuario";
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.Location = new System.Drawing.Point(30, 64);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(67, 15);
            this.LblPassword.TabIndex = 1;
            this.LblPassword.Text = "Contraseña";
            // 
            // LblModulo
            // 
            this.LblModulo.AutoSize = true;
            this.LblModulo.Location = new System.Drawing.Point(30, 103);
            this.LblModulo.Name = "LblModulo";
            this.LblModulo.Size = new System.Drawing.Size(49, 15);
            this.LblModulo.TabIndex = 2;
            this.LblModulo.Text = "Módulo";
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.ForeColor = System.Drawing.Color.Blue;
            this.TxtUsuario.Location = new System.Drawing.Point(103, 22);
            this.TxtUsuario.MaxLength = 10;
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(121, 23);
            this.TxtUsuario.TabIndex = 3;
            this.TxtUsuario.TextChanged += new System.EventHandler(this.TxtUsuario_TextChanged);
            // 
            // TxtPassword
            // 
            this.TxtPassword.Enabled = false;
            this.TxtPassword.Location = new System.Drawing.Point(103, 61);
            this.TxtPassword.MaxLength = 10;
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '#';
            this.TxtPassword.Size = new System.Drawing.Size(121, 23);
            this.TxtPassword.TabIndex = 4;
            this.TxtPassword.TextChanged += new System.EventHandler(this.TxtContrseña_TextChanged);
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Enabled = false;
            this.BtnAceptar.Location = new System.Drawing.Point(295, 22);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(75, 23);
            this.BtnAceptar.TabIndex = 6;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(295, 64);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelar.TabIndex = 7;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // LstModulo
            // 
            this.LstModulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LstModulo.Enabled = false;
            this.LstModulo.FormattingEnabled = true;
            this.LstModulo.Items.AddRange(new object[] {
            "ADM",
            "SIST",
            "COM",
            "VTA"});
            this.LstModulo.Location = new System.Drawing.Point(103, 100);
            this.LstModulo.Name = "LstModulo";
            this.LstModulo.Size = new System.Drawing.Size(121, 23);
            this.LstModulo.TabIndex = 8;
            this.LstModulo.SelectedIndexChanged += new System.EventHandler(this.LstModulo_SelectedIndexChanged);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 147);
            this.Controls.Add(this.LstModulo);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtUsuario);
            this.Controls.Add(this.LblModulo);
            this.Controls.Add(this.LblPassword);
            this.Controls.Add(this.LblUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login - Sintepart";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LblUsuario;
        private Label LblPassword;
        private Label LblModulo;
        private TextBox TxtUsuario;
        private TextBox TxtPassword;
        private Button BtnAceptar;
        private Button BtnCancelar;
        private ComboBox LstModulo;
    }
}