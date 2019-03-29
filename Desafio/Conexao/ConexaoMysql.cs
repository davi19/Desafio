using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using Desafio.ClassesAuxiliares;

namespace Desafio.Conexao
{
    class ConexaoMysql
    {
        private MySqlConnection _conexao = new MySqlConnection();
        private Criptografia descriptador = new Criptografia();
        public void AbrirConexao()
        {
            string chave = descriptador.Descriptografa("wiJ736rOqnlKJNZFArgh6w==");
            string stringConexao = "Server=localhost;Port=3306;Database=desafio;Uid=root;Pwd=" + chave + ";SslMode=none;allowPublicKeyRetrieval=true";
            _conexao.ConnectionString = stringConexao;
            _conexao.Open();
        }

        public void FecharConexao()
        {
            _conexao.Close();
        }
        public void ExecutaComando(string query)
        {
            if (string.IsNullOrEmpty(query))
                throw new ArgumentException("O comandoSQL não pode ser nulo ou vazio");
            try
            {
                AbrirConexao();
                MySqlCommand comando = new MySqlCommand(query, _conexao);
                comando.ExecuteNonQuery();
            }
            finally
            {
                FecharConexao();
            }
        }

        public List<Dictionary<string, string>> ExecutaComandoComRetorno(string query)
        {
            List<Dictionary<string, string>> linhas;
            if (string.IsNullOrEmpty(query))
                throw new ArgumentException("O comandoSQL não pode ser nulo ou vazio");
            try
            {
                AbrirConexao();
                MySqlCommand comando = new MySqlCommand(query, _conexao);

                using (var reader = comando.ExecuteReader())
                {
                    linhas = new List<Dictionary<string, string>>();
                    while (reader.Read())
                    {
                        var linha = new Dictionary<string, string>();

                        for (var i = 0; i < reader.FieldCount; i++)
                        {
                            var nomeDaColuna = reader.GetName(i);
                            var valorDaColuna = reader.IsDBNull(i) ? null : reader.GetString(i);
                            linha.Add(nomeDaColuna, valorDaColuna);
                        }

                        linhas.Add(linha);
                    }
                }
            }
            finally
            {
                FecharConexao();
            }

            return linhas;

        }

        public DataTable ExecutaComandoComRetornoDataTable(string query)
        {
            DataTable tabela = new DataTable();
            try
            {
                AbrirConexao();
                MySqlCommand comando = new MySqlCommand(query,_conexao);
            MySqlDataAdapter leitor = new MySqlDataAdapter(comando);
            
            leitor.Fill(tabela);
            }
            finally
            {
                FecharConexao();
            }
            return tabela;
        }

        public int ExecutaComandoComRetornoId(string query)
        {
            long ultimoId;
            if (string.IsNullOrEmpty(query))
                throw new ArgumentException("O comandoSQL não pode ser nulo ou vazio");
            try
            {
                AbrirConexao();
                MySqlCommand comando = new MySqlCommand(query, _conexao);
                comando.ExecuteNonQuery();
               ultimoId = comando.LastInsertedId;
            }
            finally
            {
                FecharConexao();
            }

            return Convert.ToInt32(ultimoId);
        }
    }
}
