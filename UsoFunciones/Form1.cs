using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsoFunciones
{
    public partial class Formulario1 : Form
    {
        public Formulario1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int contador = cuenta_letras(this.txtPalabra.Text, "a");
            this.txtResultado.Text = contador.ToString();
        }
        /// <summary>
        /// Cuenta la cantidad de "a" que existen en una frase
        /// </summary>
        /// <param name="frase"></param>
        /// <returns></returns>
        public int cuenta_letras(string frase, string letra)
        {
            int cont = 0;
            for(int i=0; i<frase.Length; i++)
            {
                if (frase[i].ToString().ToLower() == letra.ToLower())
                    cont++;
            }
            return cont;
        }
    }
}
