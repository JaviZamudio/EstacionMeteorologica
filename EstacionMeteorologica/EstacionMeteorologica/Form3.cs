using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstacionMeteorologica
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //cerrar sesion

            //devolver a Login
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //abrir creditos
            Creditos creditos = new Creditos();
            creditos.Show();
            this.Close();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            //nada
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //abrir alta de datos
            Alta alta = new Alta();
            alta.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //abrir Modificaciones
            Baja baja = new Baja();
            baja.Show();
            this.Close();
        }
    }
}
