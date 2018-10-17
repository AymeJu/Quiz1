using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace QUIZ
{
    class Jogador
    {
        // 1. Atributos da classe
        #region Atributos
        private MySqlConnection _nome;
        private MySqlDataAdapter _pontos;
        private DataSet _dados;
        private MySqlCommand _comandoDB;
        #endregion

        #region Getters e Setters 
        public string Host { get; set; } = "localhost";
        public string Nome { get; set; } = "";
        public string Id { get; set; } = "root";
        #endregion

        #region Construtor
        public Jogador() { }
        #endregion

        #region Métodos
        public void Conectar()
        {
            // dados da conexão

            // Server=<host>;Database=<banco>;Uid=<usuario>;Pwd=<senha>

            string strConexao = "Server=" + Host;
            strConexao += ";Database=" + Nome;
            strConexao += ";Uid=" + Id;
            strConexao += ";SSL Mode=None";
            // Server=localhost;Database=;Uid=root;Senha=

            try
            {// Bloco de comandos sujeito a erros       
                _nome = new MySqlConnection(strConexao);
                if (_nome.State.Equals(ConnectionState.Closed))
                {
                    _nome.Open();
                }

            }
            catch (MySqlException erro)
            {// Captura o erro, caso ocorra
                throw new Exception(erro.Message);
            }
            finally
            {// Libera o recurso, caso necessário, mesmo no erro
                _nome.Dispose();
            }



        }

        public void Inserir(string strSQL)
        {
            try
            {
                if (_nome.State.Equals(ConnectionState.Closed))
                {
                    _nome.Open();
                }

                // => EXCLUIR _comandoDB = new MySqlCommand();
                _comandoDB = _nome.CreateCommand(); // <= INCLUIR
                _comandoDB.CommandText = strSQL;

                if (_comandoDB.ExecuteNonQuery() != 1)
                {
                    throw new Exception("Falha ao inserir");
                }
            }
            catch (MySqlException erro)
            {
                throw new Exception("Erro ao inserir: " + erro.Message);
            }
        }


        // DAL.cs método Buscar()
        public DataSet Buscar(string strSQL)
        {

            if (_nome.State.Equals(ConnectionState.Closed))
            {
                _nome.Open();
            }
            // DAL.cs método Buscar()
            try
            {
                _dados = new DataSet();

                // Cria um "adapdator" para receber
                // o retorno da consulta
                _pontos = new MySqlDataAdapter(strSQL, _nome);
                _pontos.Fill(_dados, "tbl_resultado");

                return _dados;

            }
            catch (MySqlException erro)
            {
                throw new Exception(erro.Message);
            }
            finally { }

        }
        public void Atualizar() { }
        public void Excluir() { }
        #endregion
    }
}