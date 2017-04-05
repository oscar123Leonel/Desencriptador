using SportSystem.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace palabras
{
    
    public partial class Form1 : Form
    {
     
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random nuevaLetra = new Random();
            string comillas = "\"";
            string diagonal = "\\";
            string posiblesletras = "!#$%&'()*+,-./:;<=>?_^][@¿¡|°abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXWZ0123456789"+comillas+diagonal;
            int longitud = posiblesletras.Length;
            char letra;
            int longitudnuevacadena = 15; // aqui se define la longitud de la nueva cadena ha crear 
            string nuevacadena = "";
            txtpalabra.Text = "";
            for (int i = 0; i < longitudnuevacadena; i++)
                {
                   letra = posiblesletras[nuevaLetra.Next(longitud)];
                   nuevacadena += letra.ToString();
                }
            txtpalabra.Text = nuevacadena;         
            
        }

        private void insert()
        { 
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
