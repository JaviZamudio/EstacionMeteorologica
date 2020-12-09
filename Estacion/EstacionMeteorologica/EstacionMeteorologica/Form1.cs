using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace EstacionMeteorologica
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void b_registrarse_Click(object sender, EventArgs e)
        {
            Registro registro = new Registro();
            registro.Show();
            this.Hide();
        }

        private void b_iniciar_Click(object sender, EventArgs e)
        {
            bool valido = false;

            string usuario = tb_usuario.Text.Trim() + "," + tb_contraseña.Text.Trim();

            StreamReader archivo = File.OpenText(@"C:\Users\Francisco Zamudio\Documents\Intro a Programacion\Estacion\EstacionMeteorologica\Usuarios.txt");
            //comprobar usuario
            string texto = archivo.ReadToEnd();

            string[] usuarios = texto.Split('\n');

            for (int i = 0; i < usuarios.Length; i++)
            {               
                if (usuarios[i].Trim() == usuario.Trim())
                {
                    valido = true;
                }
            }

            archivo.Close();

            //mandar a la pantalla principal
            if (valido)
            {
                Principal principal = new Principal();
                principal.Show();
                this.Hide();
            }
            else
            {
                //mostrar que hay error
                label2.Text = "El Usuario o la Contraseña no coinciden\nFavor de comprobar los datos";
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            label2.Text = "";
        }
    }
}
