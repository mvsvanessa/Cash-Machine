using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaixaEletronico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            int valorSacado = 0;
            try
            {
                int[] notas = new int[6]    { 100, 50, 20, 10, 2, 5 };
                int[] qtdNotas = new int[6] { 0, 0, 0, 0, 0, 0 };
                
                valorSacado = int.Parse(textBox1.Text);
                if (valorSacado == 1 || valorSacado == 3)
                {
                    MessageBox.Show("Valor Saque incorreto");
                }
                else
                {
                    if (valorSacado % 2 != 0)
                    {
                        qtdNotas[5] = 1;
                        valorSacado -= 5;
                    }
                    for (int nota = 0; nota < 5; nota++)
                    {
                        qtdNotas[nota] = (valorSacado / notas[nota]);
                        valorSacado = valorSacado % notas[nota];

                    }
                    lbl100.Text = qtdNotas[0].ToString();
                    lbl50.Text = qtdNotas[1].ToString();
                    lbl20.Text = qtdNotas[2].ToString();
                    lbl10.Text = qtdNotas[3].ToString();
                    lbl5.Text = qtdNotas[5].ToString();
                    lbl2.Text = qtdNotas[4].ToString();
                }

               
                /*
                lbl100.Text = (valorSacado / 100).ToString();
                valorSacado = valorSacado % 100;
                lbl50.Text = (valorSacado / 50).ToString();
                valorSacado = valorSacado % 50;
                lbl20.Text = (valorSacado / 20).ToString();
                valorSacado = valorSacado % 20;
                lbl10.Text = (valorSacado / 10).ToString();
                valorSacado = valorSacado % 10;
                lbl5.Text = (valorSacado / 5).ToString();
                valorSacado = valorSacado % 5;
                lbl2.Text = (valorSacado / 2).ToString();
                valorSacado = valorSacado % 2;
                */
            }
            catch (Exception ex)
            {
                MessageBox.Show("OCORREU ERRO");
            }

        }
    }
}

