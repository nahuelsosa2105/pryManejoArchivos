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

namespace pryManejoArchivos
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("datosproveedores.txt");

            //while (!sr.EndOfStream)
            while (sr.EndOfStream==false)
            {
                lblResultado.Text = sr.ReadLine();
            }
            
            sr.Close();
        }

        private void btnCargarLindo_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("datosproveedores.txt");

            //while (!sr.EndOfStream)
            while (sr.EndOfStream == false)
            {
                //concatenar
                //lblResultado2.Text = lblResultado2.Text + sr.ReadLine();
                //lblResultado2.Text += sr.ReadLine() + "\n";
                lblResultado2.Text += sr.ReadLine() + "\n\n";
            }

            sr.Close();
        }

        private void btnCargar3_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("baseproveedores.csv");

            grilla.Columns.Add("soyEjemplo", "soyEjemplo");

            //while (!sr.EndOfStream)
            while (sr.EndOfStream == false)
            {
                grilla.Rows.Add(sr.ReadLine());
            }

            sr.Close();
        }

        string leerLinea;
        string[] separarDatos;

        private void btnCargarLindo2_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("baseproveedores.csv");

            leerLinea= sr.ReadLine();
            separarDatos = leerLinea.Split(';');

            for (int indice = 0; indice < separarDatos.Length; indice++)
            {
                grilla.Columns.Add(separarDatos[indice], separarDatos[indice]);
            }

            while (sr.EndOfStream == false)
            {
                leerLinea = sr.ReadLine();
                separarDatos = leerLinea.Split(';');
                grilla.Rows.Add(separarDatos);
            }

            sr.Close();
        }
    }
}
