namespace EstacionMeteorologica
{
    partial class Registro
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
            this.b_registrarse = new System.Windows.Forms.Button();
            this.b_volver = new System.Windows.Forms.Button();
            this.tb_contraseña = new System.Windows.Forms.TextBox();
            this.tb_usuario = new System.Windows.Forms.TextBox();
            this.l_contraseña = new System.Windows.Forms.Label();
            this.l_usuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // b_registrarse
            // 
            this.b_registrarse.Location = new System.Drawing.Point(379, 291);
            this.b_registrarse.Name = "b_registrarse";
            this.b_registrarse.Size = new System.Drawing.Size(83, 23);
            this.b_registrarse.TabIndex = 14;
            this.b_registrarse.Text = "Registrarse";
            this.b_registrarse.UseVisualStyleBackColor = true;
            this.b_registrarse.Click += new System.EventHandler(this.b_registrarse_Click);
            // 
            // b_volver
            // 
            this.b_volver.Location = new System.Drawing.Point(711, 412);
            this.b_volver.Name = "b_volver";
            this.b_volver.Size = new System.Drawing.Size(75, 23);
            this.b_volver.TabIndex = 13;
            this.b_volver.Text = "Volver";
            this.b_volver.UseVisualStyleBackColor = true;
            this.b_volver.Click += new System.EventHandler(this.b_volver_Click);
            // 
            // tb_contraseña
            // 
            this.tb_contraseña.Location = new System.Drawing.Point(398, 210);
            this.tb_contraseña.Name = "tb_contraseña";
            this.tb_contraseña.PasswordChar = '*';
            this.tb_contraseña.Size = new System.Drawing.Size(100, 20);
            this.tb_contraseña.TabIndex = 11;
            // 
            // tb_usuario
            // 
            this.tb_usuario.Location = new System.Drawing.Point(379, 184);
            this.tb_usuario.Name = "tb_usuario";
            this.tb_usuario.Size = new System.Drawing.Size(100, 20);
            this.tb_usuario.TabIndex = 10;
            // 
            // l_contraseña
            // 
            this.l_contraseña.AutoSize = true;
            this.l_contraseña.Location = new System.Drawing.Point(328, 213);
            this.l_contraseña.Name = "l_contraseña";
            this.l_contraseña.Size = new System.Drawing.Size(64, 13);
            this.l_contraseña.TabIndex = 9;
            this.l_contraseña.Text = "Contraseña:";
            // 
            // l_usuario
            // 
            this.l_usuario.AutoSize = true;
            this.l_usuario.Location = new System.Drawing.Point(327, 187);
            this.l_usuario.Name = "l_usuario";
            this.l_usuario.Size = new System.Drawing.Size(46, 13);
            this.l_usuario.TabIndex = 8;
            this.l_usuario.Text = "Usuario:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(376, 339);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Usuario Registrado!";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(435, 236);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(328, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Repetir Contraseña:";
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.b_registrarse);
            this.Controls.Add(this.b_volver);
            this.Controls.Add(this.tb_contraseña);
            this.Controls.Add(this.tb_usuario);
            this.Controls.Add(this.l_contraseña);
            this.Controls.Add(this.l_usuario);
            this.Name = "Registro";
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.Registro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_registrarse;
        private System.Windows.Forms.Button b_volver;
        private System.Windows.Forms.TextBox tb_contraseña;
        private System.Windows.Forms.TextBox tb_usuario;
        private System.Windows.Forms.Label l_contraseña;
        private System.Windows.Forms.Label l_usuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
    }
}