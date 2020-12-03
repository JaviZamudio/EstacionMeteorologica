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
    public partial class Alta : Form
    {
        public Alta()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();
            principal.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //capturar datos en archivo
            string tb1 = textBox1.Text;
            string tb2 = textBox2.Text;
            string tb3 = textBox3.Text;
            string tb4 = textBox4.Text;
            string tb5 = textBox5.Text;
            string tb6 = textBox6.Text;

            if(tb1 != "" && tb2 != "" && tb3 != "" && tb4 != "" && tb5 != "" && tb6 != "")
            {
                string direccion = @"C:\Users\Francisco Zamudio\Documents\Intro a Programacion\Estacion\EstacionMeteorologica\" + tb1 + ".txt";

                label7.Text = direccion;
                StreamWriter archivo = File.AppendText(direccion);

                archivo.WriteLine("{0} {1} {2} {3} {4}", tb2, tb3, tb4, tb5, tb6);

                //mostrar estado
                label7.Text = "Se han guardado los datos!";
                //borrar datos
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";

                archivo.Close();
            }
            else
            {
                label7.Text = "Favor de Rellenar todos los campos";
            }


        }

        private void Form4_Load(object sender, EventArgs e)
        {
            label7.Text = "";
        }
    }
}
