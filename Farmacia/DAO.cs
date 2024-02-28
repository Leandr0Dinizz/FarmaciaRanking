using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
        public string sql;
        public int[] codigo;
        public string[] nome;
        public string[] rg;
        public string[] telefone;
        public string[] PlanoSaude;
        public string[] farmPopular;
        public string[] produtos;
        public int i;
        public int contador;

        public DAO()
        {
            conexao = new MySqlConnection("server=localhost;DataBase=Farmaciati18n;Uid=root;password=");
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

        public void Inserir(int codigo, string nome, string rg, string telefone, string planoSaude, string farmPopular, string produtos)
        {

            dados = "('" + codigo + "','" + nome + "','" + rg + "','" + telefone + "','" + planoSaude + "','" + farmPopular + "','" + produtos + "')";
            sql = "insert into pessoa(codigo, nome, rg, telefone,planoSaude, farmPopular, produtos) values " + dados;
            try
            {
                MySqlCommand conn = new MySqlCommand(sql, conexao);
                MessageBox.Show(conn.ExecuteNonQuery() + "1 Dado Inserido");
            }catch(Exception erro)
            {

                MessageBox.Show("Algo deu errado!\n\n" + erro);

            }//fim try catch

        }//fim do metodo

        public void PreencherVetor()
        {

            string query = "select * from pessoa";

            //instanciar vetores
            this.codigo      = new int[100];
            this.nome        = new string[100];
            this.rg          = new string[100];
            this.telefone    = new string[100];
            this.PlanoSaude  = new string[100];
            this.farmPopular = new string[100];
            this.produtos    = new string[100];

            //preencher com valores aleatórios
            for (i = 0; i<100; i++)
            {

                codigo[i] = 0;
                nome[i] = "";
                rg[i] = "";
                telefone[i] = "";
                PlanoSaude[i] = "";
                farmPopular[i] = "";
                produtos[i] = "";
            }//fim do for

            //criar o comando consultar no BD
            MySqlCommand coletar = new MySqlCommand(query, conexao);
            //listar todos os dados que estao no banco
            MySqlDataReader leitura = coletar.ExecuteReader();

            i = 0;//utilziar novamente contar i

            contador = 0; //contar quantos dados eu tenho no banco
            while(leitura.Read()) 
            {

                codigo[i] = Convert.ToInt32(leitura["codigo"]);
                nome[i] = "" + leitura["nome"];
                rg[i] = "" + leitura["rg"];
                telefone[i] = "" + leitura["telefone"];
                PlanoSaude[i] = "" + leitura["PlanoSaude"];
                farmPopular[i] = "" + leitura["farmPopular"];
                produtos[i] = "" + leitura["produtos"];
                i++;//mudando o contador
                contador++;//contar quantos dados tem no banco
            }//fim do while

            //encerrar o banco
            leitura.Close();
            //fim do método    
        }//fim do preencher

        public int RetornarContagem()
        {

            return contador;

        }//fim do método



    }//fim da classe
}//fim projeto
