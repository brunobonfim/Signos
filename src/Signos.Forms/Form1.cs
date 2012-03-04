using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Signos.Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var pessoa = new Pessoa();
            var signoe = new Signo();

            pessoa.AtribuirNome(textBox1.Text);
            pessoa.AtribuirDataNascimento(Convert.ToDateTime(textBox2.Text));

            MessageBox.Show("Seu signo é: " 
                + signoe.ObterNomeSigno(pessoa.ObterDataNascimento()));

        }
    }
}
