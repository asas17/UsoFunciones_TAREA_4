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
    public partial class FrmDecimal_a_Binario : Form
    {
        public FrmDecimal_a_Binario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*int numero = int.Parse(this.txtbox1.Text);
            int []res = binario(numero);
            Console.WriteLine("inicio");
            for(int i=res.Length-1;i>=0; i--)
            {
                Console.Write("{0}", res[i]);
            }
            Console.WriteLine("Fin");*/
            int numero = Int32.Parse(this.txtentero.Text);
            int[] res = binario(numero);

            for (int i = res.Length - 1; i > 0; i--)
            {
                if (res[0] == 1)
                {
                    this.Binario1.Checked = true;
                }
                else
                {
                    this.Binario1.Checked = false;
                }
                if (res[1] == 1)
                {
                    this.Binario2.Checked = true;
                }
                else
                {
                    this.Binario2.Checked = false;
                }
                if (res[2] == 1)
                {
                    this.Binario3.Checked = true;
                }
                else
                {
                    this.Binario3.Checked = false;
                }
                if (res[3] == 1)
                {
                    this.Binario4.Checked = true;
                }
                else
                {
                    this.Binario4.Checked = false;
                }
                if (res[4] == 1)
                {
                    this.Binario5.Checked = true;
                }
                else
                {
                    this.Binario5.Checked = false;
                }
                if (res[5] == 1)
                {
                    this.Binario6.Checked = true;
                }
                else
                {
                    this.Binario6.Checked = false;
                }
                if (res[6] == 1)
                {
                    this.Binario7.Checked = true;
                }
                else
                {
                    this.Binario7.Checked = false;
                }
                if (res[7] == 1)
                {
                    this.Binario8.Checked = true;
                }
                else
                {
                    this.Binario8.Checked = false;
                }
                Console.WriteLine("{0}", res[i]);
            }
        }

            private int[] binario(int num)
        {
            int[] bin = {0,0,0,0,0,0,0,0};
            //int[] bin = nex int[8];
            int i = 0;
            int resto = 0;
            while (num > 0)
            {
                resto = num % 2;
                bin[i++] = resto;
                num = num / 2;
                //Console.WriteLine("{0}", resto);
            }
            return bin;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num = 0;
            if (Binario1.Checked) num += 1;
            if (Binario2.Checked) num += 2;
            if (Binario3.Checked) num += 4;
            if (Binario4.Checked) num += 8;
            if (Binario5.Checked) num += 16;
            if (Binario6.Checked) num += 32;
            if (Binario7.Checked) num += 64;
            if (Binario8.Checked) num += 128;
            this.txtentero.Text = num.ToString();

        }

        private void Binario1_CheckedChanged(object sender, EventArgs e)
        {
            SumaBinarioaDecimal();
        }
        void SumaBinarioaDecimal()
        {
            int num = 0;
            if (Binario1.Checked) num += 1;
            if (Binario2.Checked) num += 2;
            if (Binario3.Checked) num += 4;
            if (Binario4.Checked) num += 8;
            if (Binario5.Checked) num += 16;
            if (Binario6.Checked) num += 32;
            if (Binario7.Checked) num += 64;
            if (Binario8.Checked) num += 128;
            this.txtentero.Text = num.ToString();
        }
    }
}
