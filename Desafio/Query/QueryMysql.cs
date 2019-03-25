using System;
using System.Collections.Generic;
using System.Data;
using Desafio.Classes;
using Desafio.Conexao;

namespace Desafio.Query
{
    class QueryMysql
    {
        private readonly ConexaoMysql _conexaoMysql;

        public QueryMysql()
        {
            _conexaoMysql = new ConexaoMysql();
        }

        public bool ValidaUsuario(string usuario)
        {
            string query = "SELECT count(id) as quantidade FROM usuarios WHERE login='" + usuario + "'";
           var resultado =  _conexaoMysql.ExecutaComandoComRetorno(query);
           if (resultado[0]["quantidade"].Equals("1"))
           {
               return true;
            }
           else
           {
               return false;
           }
        }
        public int GeraSenha(string usuario)
        {
            Random gerarSenha = new Random();
            int novaSenha = gerarSenha.Next(111111, 999999);

            string query = "UPDATE  usuarios SET senha=MD5("+novaSenha+"), trocasenha='S' WHERE login='" + usuario+"'";
            _conexaoMysql.ExecutaComando(query);
            return novaSenha;
        }
        public string RetornaEmail(string usuario)
        {
            string queryEmail = "SELECT email FROM usuarios WHERE login='" + usuario + "'";
            var resultado = _conexaoMysql.ExecutaComandoComRetorno(queryEmail);
            return resultado[0]["email"];
        }
        public void AlteraSenha(string usuario,string senha)
        {
            string query = "UPDATE  usuarios SET senha=MD5(" + senha + "), trocasenha='N' WHERE login='" + usuario + "'";
            _conexaoMysql.ExecutaComando(query);
        }
        public bool ValidaLogin(string usuario,string senha)
        {
            string query = "SELECT count(id) as quantidade FROM usuarios WHERE login='" + usuario + "' and senha=MD5('"+senha+"')";
            var resultado = _conexaoMysql.ExecutaComandoComRetorno(query);
            if (resultado[0]["quantidade"].Equals("1"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ValidaTrocaSenha(string usuario)
        {
            string query = "SELECT trocasenha FROM usuarios WHERE login='" + usuario + "'";
            var resultado = _conexaoMysql.ExecutaComandoComRetorno(query);
            if (resultado[0]["trocasenha"].Equals("S"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void CadastraEvento(string descricao, DateTime data,DateTime hora,string prioridade,string usuario)
        {
            string idUsuario = RetornaIdUsuario(usuario);
            string query = $"INSERT INTO agendas (descricao,data,hora,importancia,idusuario) VALUES('{descricao}','{data.ToString("yyyy-MM-dd")}','{hora.ToString("HH:mm:ss")}','{prioridade}',{idUsuario})";
            _conexaoMysql.ExecutaComando(query);
        }
        public string RetornaIdUsuario(string usuario)
        {
            string queryEmail = "SELECT id FROM usuarios WHERE login='" + usuario + "'";
            var resultado = _conexaoMysql.ExecutaComandoComRetorno(queryEmail);
            return resultado[0]["id"];
        }

        public DataTable RecuperaAgenda(int idUsuario)
        {
            string query = $"SELECT id as ID,descricao as Descrição,importancia as Prioridade,data as Data,hora as Hora,if(concluido='N','Não','Sim') as Concluído FROM agendas WHERE idusuario={idUsuario} and data=CURDATE()";
            var resultado = _conexaoMysql.ExecutaComandoComRetornoDataTable(query);
            return resultado;
        }

        public DataTable RecuperaAgenda(int idUsuario,DateTime dataConsulta)
        {
            string query = $"SELECT id as ID,descricao as Descrição,importancia as Prioridade,data as Data,hora as Hora,if(concluido='N','Não','Sim') as Concluído FROM agendas WHERE idusuario={idUsuario} and data='{dataConsulta.ToString("yyyy/MM/dd")}'";
            var resultado = _conexaoMysql.ExecutaComandoComRetornoDataTable(query);
            return resultado;
        }

        public void AlteraEvento(int id,string descricao,DateTime data,DateTime hora,string prioridade,string concluido)
        {
            var concluidoBanco="";
            if (concluido.Equals("Sim"))
            {
                concluidoBanco = "S";
                
            }
            else
            {
                concluidoBanco = "N";
            }
            string query = $"UPDATE agendas SET descricao='{descricao}',data='{data.ToString("yyyy/MM/dd")}',hora='{hora.ToString("HH:mm")}',importancia='{prioridade}', concluido='{concluidoBanco}' WHERE id={id} ";
            _conexaoMysql.ExecutaComando(query);
        }
        public void ExcluirEvento(int id)
        {
            string query = $"DELETE FROM agendas WHERE id={id} ";
            _conexaoMysql.ExecutaComando(query);
        }

    }
}
