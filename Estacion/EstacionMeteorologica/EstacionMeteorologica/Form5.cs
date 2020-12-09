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
    public partial class Baja : Form
    {
        private string[] separar(string texto)
        {
            string[] palabras = {"", "", "", "", "", "", ""};
            int i_pal = 0;
            for (int i = 0; i < texto.Length; i++)
            {
                if (texto[i] != ' ')
                {
                    if(i > 0)
                        if (texto[i - 1] == ' ')
                            i_pal++;
                    palabras[i_pal] += texto[i].ToString();
                }
            }

            return palabras;
        }
        public Baja()
        {
            InitializeComponent();
        }

        private void Baja_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button1.Enabled = false;
            label6.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();
            principal.Show();
            this.Close();
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "" && textBox2.Text != "")
            {
                StreamReader archivo = File.OpenText(@"C:\Users\Francisco Zamudio\Documents\Intro a Programacion\Estacion\EstacionMeteorologica\" + textBox1.Text + ".txt");
                if (archivo.ReadToEnd().Contains(textBox2.Text))
                {
                    button2.Enabled = true;
                    button1.Enabled = true;
                    label6.Text = "Registro Encontrado";
                    
                }
                else
                {
                    label6.Text = "Registro NO Encontrado";
                }               

                archivo.Close();
            }
            else
            {
                label6.Text = "Favor de llenar los campos de arriba";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader lectura = File.OpenText(@"C:\Users\Francisco Zamudio\Documents\Intro a Programacion\Estacion\EstacionMeteorologica\" + textBox1.Text + ".txt");
            string[] dias = lectura.ReadToEnd().Split('\n');
            lectura.Close();

            string resultado = "";
            for (int i = 0; i < dias.Length; i++)
            {
                if (dias[i].Contains(textBox2.Text))
                    i++;
                if(i < dias.Length)
                    resultado += dias[i];
                if (i < dias.Length - 1)
                    resultado += "\n";
            }

            StreamWriter archivo = File.CreateText(@"C:\Users\Francisco Zamudio\Documents\Intro a Programacion\Estacion\EstacionMeteorologica\" + textBox1.Text + ".txt");
            archivo.Write(resultado);
            archivo.Close();

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";

            button2.Enabled = false;
            button1.Enabled = false;
            label6.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamReader lectura = File.OpenText(@"C:\Users\Francisco Zamudio\Documents\Intro a Programacion\Estacion\EstacionMeteorologica\" + textBox1.Text + ".txt");
            string[] dias = lectura.ReadToEnd().Split('\n');
            lectura.Close();

            string resultado = "";
            for (int i = 0; i < dias.Length; i++)
            {
                if (dias[i].Contains(textBox2.Text))
                {
                    string[] dia = separar(dias[i]);
                    if (textBox3.Text != "")
                        dia[1] = textBox3.Text;
                    if (textBox4.Text != "")
                        dia[2] = textBox4.Text;
                    if (textBox5.Text != "")
                        dia[3] = textBox5.Text;
                    if (textBox6.Text != "")
                        dia[4] = textBox6.Text;
                    dias[i] = "";

                    for(int j = 0; j < dia.Length; j++)
                    {
                        dias[i] += dia[j];
                        if(j < dia.Length - 1)
                        {
                            dias[i] += " ";
                        }
                    }
                }
                resultado += dias[i];

                if (i < dias.Length - 1)
                    resultado += "\n";

            }

            StreamWriter archivo = File.CreateText(@"C:\Users\Francisco Zamudio\Documents\Intro a Programacion\Estacion\EstacionMeteorologica\" + textBox1.Text + ".txt");
            archivo.Write(resultado);
            archivo.Close();

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";

            button2.Enabled = false;
            button1.Enabled = false;
            label6.Text = "";
        }
    }
}
