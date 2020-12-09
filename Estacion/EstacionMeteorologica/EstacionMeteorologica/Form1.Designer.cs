namespace EstacionMeteorologica
{
    partial class Login
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
            this.l_usuario = new System.Windows.Forms.Label();
            this.l_contraseña = new System.Windows.Forms.Label();
            this.tb_usuario = new System.Windows.Forms.TextBox();
            this.tb_contraseña = new System.Windows.Forms.TextBox();
            this.b_iniciar = new System.Windows.Forms.Button();
            this.b_salir = new System.Windows.Forms.Button();
            this.b_registrarse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // l_usuario
            // 
            this.l_usuario.AutoSize = true;
            this.l_usuario.Location = new System.Drawing.Point(329, 176);
            this.l_usuario.Name = "l_usuario";
            this.l_usuario.Size = new System.Drawing.Size(46, 13);
            this.l_usuario.TabIndex = 0;
            this.l_usuario.Text = "Usuario:";
            // 
            // l_contraseña
            // 
            this.l_contraseña.AutoSize = true;
            this.l_contraseña.Location = new System.Drawing.Point(329, 208);
            this.l_contraseña.Name = "l_contraseña";
            this.l_contraseña.Size = new System.Drawing.Size(64, 13);
            this.l_contraseña.TabIndex = 1;
            this.l_contraseña.Text = "Contraseña:";
            // 
            // tb_usuario
            // 
            this.tb_usuario.Location = new System.Drawing.Point(381, 173);
            this.tb_usuario.Name = "tb_usuario";
            this.tb_usuario.Size = new System.Drawing.Size(100, 20);
            this.tb_usuario.TabIndex = 2;
            // 
            // tb_contraseña
            // 
            this.tb_contraseña.Location = new System.Drawing.Point(399, 205);
            this.tb_contraseña.Name = "tb_contraseña";
            this.tb_contraseña.PasswordChar = '*';
            this.tb_contraseña.Size = new System.Drawing.Size(100, 20);
            this.tb_contraseña.TabIndex = 3;
            // 
            // b_iniciar
            // 
            this.b_iniciar.Location = new System.Drawing.Point(372, 256);
            this.b_iniciar.Name = "b_iniciar";
            this.b_iniciar.Size = new System.Drawing.Size(83, 23);
            this.b_iniciar.TabIndex = 4;
            this.b_iniciar.Text = "Iniciar Sesion";
            this.b_iniciar.UseVisualStyleBackColor = true;
            this.b_iniciar.Click += new System.EventHandler(this.b_iniciar_Click);
            // 
            // b_salir
            // 
            this.b_salir.Location = new System.Drawing.Point(713, 415);
            this.b_salir.Name = "b_salir";
            this.b_salir.Size = new System.Drawing.Size(75, 23);
            this.b_salir.TabIndex = 5;
            this.b_salir.Text = "Salir";
            this.b_salir.UseVisualStyleBackColor = true;
            this.b_salir.Click += new System.EventHandler(this.button2_Click);
            // 
            // b_registrarse
            // 
            this.b_registrarse.Location = new System.Drawing.Point(372, 322);
            this.b_registrarse.Name = "b_registrarse";
            this.b_registrarse.Size = new System.Drawing.Size(83, 23);
            this.b_registrarse.TabIndex = 6;
            this.b_registrarse.Text = "Registrarse";
            this.b_registrarse.UseVisualStyleBackColor = true;
            this.b_registrarse.Click += new System.EventHandler(this.b_registrarse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(407, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "O";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(477, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 26);
            this.label2.TabIndex = 8;
            this.label2.Text = "El Usuario o la Contraseña no coinciden\r\nIntenta de nuevo";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.b_registrarse);
            this.Controls.Add(this.b_salir);
            this.Controls.Add(this.b_iniciar);
            this.Controls.Add(this.tb_contraseña);
            this.Controls.Add(this.tb_usuario);
            this.Controls.Add(this.l_contraseña);
            this.Controls.Add(this.l_usuario);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_usuario;
        private System.Windows.Forms.Label l_contraseña;
        private System.Windows.Forms.TextBox tb_usuario;
        private System.Windows.Forms.TextBox tb_contraseña;
        private System.Windows.Forms.Button b_iniciar;
        private System.Windows.Forms.Button b_salir;
        private System.Windows.Forms.Button b_registrarse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

