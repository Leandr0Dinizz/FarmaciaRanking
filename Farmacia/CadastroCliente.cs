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
    public partial class CadastroCliente : Form
    {
        DAO bd;
        public CadastroCliente()
        {
            InitializeComponent();
            bd = new DAO(); // conectar a tela com a classe DAO

        }//fim do construtor

        private void CadastroCliente_Load(object sender, EventArgs e)
        {

        }

        private void codigo_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//fim do código

        private void nome_TextChanged(object sender, EventArgs e)
        {

        }//fim do nome

        private void telefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//fim do telefone

        private void botaoCadastrar_Click(object sender, EventArgs e)
        {
            int cod = Convert.ToInt32(codigo.Text);
            string name     = nome.Text;
            string Rg       = (rg.Text);
            string tel      =(telefone.Text);
            string pSaude   = PlanoSaude.Text;
            string fPopular = FarmPopular.Text;
            string Prod     = Produtos.Text;

            bd.Inserir(cod, name, Rg, tel, pSaude, fPopular, Prod);// inserindo no BD


            codigo.Text = "";
            nome.Text = "";
            rg.Text = "";
            telefone.Text = "";
            PlanoSaude.Text = "";
            FarmPopular.Text = "";



        }//fim do botão cadastrar

        private void botaoVoltar_Click(object sender, EventArgs e)
        {

        }//fim do botão voltar

        private void PlanoSaude_TextChanged(object sender, EventArgs e)
        {

        }//fim plano saude

        private void FarmPopular_TextChanged(object sender, EventArgs e)
        {

        }//fim farmacia popular

        private void Produtos_TextChanged(object sender, EventArgs e)
        {

        }//fim produtos
    }//fim da classe
}//fim do projeto
