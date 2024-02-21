using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Farmacia
{
    class DAO
    {
        MySqlConnection conexao;
        public string dados;

        public DAO()
        {
            conexao = new MySqlConnection("serverlocalhost;DataBase=Farmaciati18n;Uid=root;password=");
            try
            {

                conexao.Open();
                MessageBox.Show("Conectado com sucesso");//Temporario

            }catch(Exception erro)
            {

              MessageBox.Show (erro + "\n\nAlgo deu errado!");
                conexao.Close();

            }//fim do catch
        }//fim do construtor

        public void Inserir(int codigo, string nome, string rg, string telefone, bool planoSaude, bool farmPopular, string produtos)
        {

            dados = "('" + codigo + "','" + nome + "','" + rg + "','" + telefone + "','" + planoSaude + "','" + farmPopular + "','" + produtos + "')";
        }



    }//fim da classe



}//fim projeto
