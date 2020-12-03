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
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void b_volver_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void b_registrarse_Click(object sender, EventArgs e)
        {
            //comprobar datos
            string usuario = tb_usuario.Text;
            string password = tb_contraseña.Text;

            StreamWriter archivo = File.AppendText(@"C:\Users\Francisco Zamudio\Documents\Intro a Programacion\Estacion\EstacionMeteorologica\Usuarios.txt");

            if(usuario != "" && password != "" && textBox1.Text != "")
            {
                if(tb_contraseña.Text == textBox1.Text)
                {
                    archivo.WriteLine(usuario + "," + password);
                    label1.Text = "Usuario Registrado!";
                    b_registrarse.Enabled = false;
                }
                else
                {
                    label1.Text = "Las Contraseñas no son iguales. Intenta otra vez";
                    tb_contraseña.Text = "";
                    textBox1.Text = "";
                }
            }
            else
            {
            }
            archivo.Close();
        }

        private void Registro_Load(object sender, EventArgs e)
        {
            label1.Text = "";
        }
    }
}
