using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aroma_no_atelie___Velas_aromaticas
{
    internal class VelaDAO
    {
        private Conexao Connect { get; set; }
        private SqlCommand Command { get; set; }
        public object Cmd { get; private set; }

        //Sempre o nome da classe
        public VelaDAO()
        {
            Connect = new Conexao();
            Command = new SqlCommand();
        }
        public void Insert(Vela vela)
        {
            Command.Connection = Connect.ReturnConnection();
            Command.CommandText = @"INSERT INTO vela VALUES 
            (@nome, @tamanho, @descricao, @preco)";

            Command.Parameters.AddWithValue("@nome", vela.NomeVela);
            Command.Parameters.AddWithValue("@tamanho", vela.TamanhoVela);
            Command.Parameters.AddWithValue("@descricao", vela.DescricaoVela);
            Command.Parameters.AddWithValue("@preco", vela.PrecoVela);


            try
            {
                //Executa query definida acima.
                Command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao inserir " +
                    "vela no banco.\n" + err.Message);
            }
            finally
            {
                Connect.CloseConnection();
            }
        }

        public void Atualizar(Vela velaAtualizado)
        {
            Command.Connection = Connect.ReturnConnection();
            Command.CommandText = @"UPDATE Vela SET NomeVela = @nomevela, TamanhoVela = @tamanhovela,
    DescricaoVela = @descricaovela, PrecoVela = @precovela
    WHERE CodVela = @codvela";
            Command.Parameters.AddWithValue("@codvela", velaAtualizado.CodVela);
            Command.Parameters.AddWithValue("@nomevela", velaAtualizado.NomeVela);
            Command.Parameters.AddWithValue("@tamanhovela", velaAtualizado.TamanhoVela);
            Command.Parameters.AddWithValue("@descricaovela", velaAtualizado.DescricaoVela);
            Command.Parameters.AddWithValue("@precovela", velaAtualizado.PrecoVela);
            try
            {
                Command.ExecuteNonQuery();
            }
        
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao realizar atualização de usuário no banco.\n" + err.Message);
            }
            finally
            {
                Connect.CloseConnection();
            }
        }
        public void Excluir(int codVela)
        {
            Command.Connection = Connect.ReturnConnection();
            Command.CommandText = @"DELETE FROM Vela WHERE CodVela = @codvela";
            Command.Parameters.AddWithValue("@codvela",codVela);
            try
            {
                Command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao excluir usuário no banco.\n" + err.Message);
            }
            finally
            {
                Connect.CloseConnection();
            }
        }
        public List<Vela> ListarTodasVelas()
        {

            Command.Connection = Connect.ReturnConnection();
            Command.CommandText = "SELECT * FROM vela";

            List<Vela> listaDeVelas = new List<Vela>(); //Instancio a list com o tamanho padrão.
            try
            {
                SqlDataReader rd = Command.ExecuteReader();

                //Enquanto for possível continuar a leitura das linhas que foram retornadas na consulta, execute.
                while (rd.Read())
                {
                    Vela vela = new Vela((int)rd["CodVela"],
                        (string)rd["NomeVela"], (string)rd["TamanhoVela"], (string)rd["DescricaoVela"],
                        (decimal)rd["PrecoVela"]);
                    listaDeVelas.Add(vela);
                }
                rd.Close();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao realizar leitura de usuários no banco.\n" + err.Message);
            }
            finally
            {
                Connect.CloseConnection();
            }

            return listaDeVelas;
        }
    }
}
