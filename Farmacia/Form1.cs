using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmacia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }//método construtor

        private void Form1_Load(object sender, EventArgs e)
        {

        }//faz o carregamento de conteúdos da minha tela

        private void CadastroCliente_Click(object sender, EventArgs e)
        {
            CadastroCliente cad = new CadastroCliente();
            cad.ShowDialog();//Tela cadastrar
        }//fim cadastrar



    }//fim class
}// fim project
