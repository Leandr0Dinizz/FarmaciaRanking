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
    public partial class Consultar: Form
    {
        DAO conectar;
        public Consultar()
        {
            InitializeComponent();
            conectar = new DAO();

            ConfigurarGrid();//prepara a tabela no meu Grid
            NomeColunas();//preencher os nomes das colunas
            conectar.PreencherVetor();//preencher os vetores com dados do BD
            AdicionarDados();//pegar os dados do vetor e colcoar no grid
        }//fim do construtor consultar

        public void NomeColunas()
        {

            dataGridView1.Columns[0].Name = "codigo";
            dataGridView1.Columns[1].Name = "nome";
            dataGridView1.Columns[2].Name = "rg";
            dataGridView1.Columns[3].Name = "telefone";
            dataGridView1.Columns[4].Name = "PlanoSaude";
            dataGridView1.Columns[5].Name = "farmPopular";
            dataGridView1.Columns[6].Name = "produtos";

        }//fim do método


        public void AdicionarDados()
        {
            for (int i = 0; i < conectar.RetornarContagem(); i++)
            {

                dataGridView1.Rows.Add(conectar.codigo[i], conectar.nome[i],
                conectar.rg[i], conectar.telefone[i],
                conectar.PlanoSaude[i], conectar.farmPopular[i], conectar.produtos[i]);
            }//fim do for

        }//fim do método

        public void ConfigurarGrid()
        {

            dataGridView1.AllowUserToAddRows = false;//incluir linhas
            dataGridView1.AllowUserToDeleteRows = false;//exzcluri linhas
            dataGridView1.AllowUserToResizeColumns = false;//redimensionar colunas
            dataGridView1.AllowUserToResizeRows = false;//redimensionasr linhas
            dataGridView1.ColumnCount = 5;//quantidade de colunas


        }//fim do configurar

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }//fim do dataGrid
    }//fim da classe
}//fim do projeto
