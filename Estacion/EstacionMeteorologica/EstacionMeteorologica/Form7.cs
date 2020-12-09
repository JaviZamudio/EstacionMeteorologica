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
    public partial class Consulta : Form
    {
        private string[] separar(string texto)
        {
            string[] palabras = { "", "", "", "", "", "", "" };
            int i_pal = 0;
            for (int i = 0; i < texto.Length; i++)
            {
                if (texto[i] != ' ')
                {
                    if (i > 0)
                        if (texto[i - 1] == ' ')
                            i_pal++;
                    palabras[i_pal] += texto[i].ToString();
                }
            }

            return palabras;
        }

        public Consulta()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StreamReader lectura = File.OpenText(@"C:\Users\Francisco Zamudio\Documents\Intro a Programacion\Estacion\EstacionMeteorologica\" + textBox1.Text + ".txt");
            string[] dias = lectura.ReadToEnd().Split('\n');
            lectura.Close();

            bool encontrado = false;
            label3.Text = "Precipitacion: ";
            label4.Text = "Evaporacion: ";
            label5.Text = "Temperatura maxima: ";
            label6.Text = "Temperatura minima: ";
            label7.Text = "Registro no encontrado";

            for (int i = 0; i < dias.Length; i++)
            {
                if (dias[i].Contains(textBox2.Text))
                {
                    string[] dia = separar(dias[i]);
                    label3.Text += dia[1];
                    label4.Text += dia[2];
                    label5.Text += dia[3];
                    label6.Text += dia[4];

                    encontrado = true;

                    break;
                }
            }

            if (encontrado)
                label7.Text = "Encontrado :)";
        }

        private void Consulta_Load(object sender, EventArgs e)
        {
            label7.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();
            principal.Show();
            this.Close();
        }
    }
}
