using System;
using System.Collections.Generic;
using System.Data;
using System.Net.Sockets;
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
        public int GeraSenha(string usuario)
        {
            Random gerarSenha = new Random();
            int novaSenha = gerarSenha.Next(111111, 999999);

            string query = "UPDATE  usuarios SET senha=MD5(" + novaSenha + "), trocasenha='S' WHERE login='" + usuario + "'";
            _conexaoMysql.ExecutaComando(query);
            return novaSenha;
        }
        public string RetornaEmail(string usuario)
        {
            string queryEmail = "SELECT email FROM usuarios WHERE login='" + usuario + "'";
            var resultado = _conexaoMysql.ExecutaComandoComRetorno(queryEmail);
            return resultado[0]["email"];
        }
        public void AlteraSenha(string usuario, string senha)
        {
            string query = "UPDATE  usuarios SET senha=MD5(" + senha + "), trocasenha='N' WHERE login='" + usuario + "'";
            _conexaoMysql.ExecutaComando(query);
        }
        public bool ValidaLogin(string usuario, string senha)
        {
            string query = "SELECT count(id) as quantidade FROM usuarios WHERE login='" + usuario + "' and senha=MD5('" + senha + "')";
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

        public void CadastraEvento(string descricao, DateTime data, DateTime hora, string prioridade, string usuario)
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

        public DataTable RecuperaAgenda(int idUsuario, DateTime dataConsulta)
        {
            string query = $"SELECT id as ID,descricao as Descrição,importancia as Prioridade,data as Data,hora as Hora,if(concluido='N','Não','Sim') as Concluído FROM agendas WHERE idusuario={idUsuario} and data='{dataConsulta.ToString("yyyy/MM/dd")}'";
            var resultado = _conexaoMysql.ExecutaComandoComRetornoDataTable(query);
            return resultado;
        }

        public void AlteraEvento(int id, string descricao, DateTime data, DateTime hora, string prioridade, string concluido)
        {
            string concluidoBanco;
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

        public int InserirContato(string nomeCartorio, string nomeContato, string emailContato,
            string cep, string endereco, string numero, string complemento, string bairro, string cidade, string estado,
            string formaContato,int idUsuario)
        {
            string query =
                $"INSERT INTO contatos (nomecartorio,nomecontato,email,cep,endereco,numero,complemento,bairro,cidade,estado,formacontato,status,idusuario)" +
                $" VALUES('{nomeCartorio}','{nomeContato}','{emailContato}','{cep}','{endereco}',{numero},'{complemento}','{bairro}','{cidade}','{estado}','{formaContato}','SUSPECT',{idUsuario})";
            int id =_conexaoMysql.ExecutaComandoComRetornoId(query);

            string queryEvolucao = $"INSERT INTO evolucoes (data,idcontato,acao) VALUES(NOW(),{id},'SUSPECT')";
            _conexaoMysql.ExecutaComando(queryEvolucao);
            return id;

        }

        public void InserirTelefoneContato(int idContato,string numero,string tipo,string preferencia)
        {
            string query = $"INSERT INTO telefonescontatos (idcontato,numero,tipo,preferencial) VALUES({idContato},'{numero}','{tipo}','{preferencia}')";
            _conexaoMysql.ExecutaComando(query);
        }

        public DataTable PesquisaContatos(string termoPesquisado)
        {
            string query =
                $"SELECT id as ID, nomecontato as 'NOME CONTATO',nomecartorio 'NOME CARTÓRIO', email as EMAIL, status as STATUS FROM contatos WHERE (nomecontato LIKE'%{termoPesquisado}%' OR email LIKE'%{termoPesquisado}%') AND ativo='S'";
            DataTable resultado = _conexaoMysql.ExecutaComandoComRetornoDataTable(query);
            return resultado;
        }

        public List<Dictionary<string, string>> RetornaDadosContato(string idContato)
        {
            string query = $"SELECT * FROM contatos WHERE id={idContato}";
            var resultado = _conexaoMysql.ExecutaComandoComRetorno(query);
            return resultado;
        }
        public List<Dictionary<string, string>> RetornaTelefonesContatos(string idContato)
        {
            string query = $"SELECT id,numero,tipo,if(preferencial='S','Sim','Não') as preferencial FROM telefonescontatos WHERE idcontato={idContato}";
            var resultado = _conexaoMysql.ExecutaComandoComRetorno(query);
            return resultado;
        }

        public void AtualizaContato(string nomeCartorio, string nomeContato, string emailContato,
                string cep, string endereco, string numero, string complemento, string bairro, string cidade, string estado,
                string formaContato, int idUsuario,int idContato,string status)
        {
            string query =
                $"UPDATE contatos SET nomecartorio='{nomeCartorio}',nomecontato='{nomeContato}',email='{emailContato}',cep='{cep}',endereco='{endereco}',numero={numero},complemento='{complemento}',bairro='{bairro}',cidade='{cidade}',estado='{estado}',formacontato='{formaContato}',status='{status}',idusuario={idUsuario} WHERE id={idContato}";
            _conexaoMysql.ExecutaComando(query);
        }

        public void ValidaEvolucao(string idContato,string status)
        {
            string query = $"SELECT  status FROM contatos WHERE id={idContato}";
            var resultado = _conexaoMysql.ExecutaComandoComRetorno(query);
            if (!resultado[0]["status"].Equals(status))
            {
                string mudaStatus = $"INSERT INTO evolucoes (data,idcontato,acao) VALUES(NOW(),{idContato},'{status}')";
                _conexaoMysql.ExecutaComando(mudaStatus);
            }
        }

        public void AtualizaTelefoneContato(int idContato, string numero, string tipo, string preferencia,string idTelefone)
        {
            string query = $"UPDATE telefonescontatos SET idcontato={idContato},numero='{numero}',tipo='{tipo}',preferencial='{preferencia}' WHERE id={idTelefone}";
            _conexaoMysql.ExecutaComando(query);
        }

        public void ExcluirContato(int idContato)
        {
            var query = $"UPDATE contatos SET ativo='N' WHERE id={idContato}";
            _conexaoMysql.ExecutaComando(query);
        }

        public void CadastrarAtividade(string observacao,string atividade,DateTime data,string idContato,string idUsuario)
        {
            var query = $"INSERT INTO atividades (observacao,atividade,data,idcontato,idusuario) VALUES('{observacao}','{atividade}','{data.ToString("yyyy/MM/dd")}',{idContato},{idUsuario})";
            _conexaoMysql.ExecutaComando(query);
        }


        public DataTable PesquisaAtividades(string termo)
        {
            string query =
                $"SELECT a.id as ID,a.atividade as ATIVIDADE,b.nomecontato AS 'NOME CONTATO',a.data as DATA ,a.observacao as OBSERVAÇÃO FROM atividades a, contatos b WHERE a.idcontato = b.id AND observacao LIKE'%{termo}%' ";
            var resultado  = _conexaoMysql.ExecutaComandoComRetornoDataTable(query);
            return resultado;
        }

        public List<Dictionary<string, string>> RetornaDadosAtividades(string idAtividade)
        {
            string query =
                $"SELECT a.id,a.atividade, b.nomecontato, a.data, a.observacao,b.id as idcontato FROM atividades a, contatos b WHERE a.idcontato = b.id and a.id={idAtividade} ";
            var resultado = _conexaoMysql.ExecutaComandoComRetorno(query);
            return resultado;
        }

        public void AtualizaAtividade(string observacao, string atividade, DateTime data, string idContato, string idUsuario, string idAtividade)
        {
            var query = $"UPDATE atividades SET  observacao='{observacao}',atividade='{atividade}',data='{data.ToString("yyyy/MM/dd")}',idcontato={idContato},idusuario={idUsuario} WHERE id={idAtividade}";
            _conexaoMysql.ExecutaComando(query);
        }
        public void ExcluirAtividade(string idAtividade)
        {
            var query = $"DELETE FROM atividades WHERE id={idAtividade}";
            _conexaoMysql.ExecutaComando(query);
        }

        public string RetornaNomeUsuarioAtual(string idContato)
        {
            var query = $"SELECT b.nome FROM contatos a, usuarios b WHERE a.idusuario = b.id and a.id={idContato}";
            var resultado =_conexaoMysql.ExecutaComandoComRetorno(query);
            return resultado[0]["nome"];
        }

        public List<Dictionary<string,string>> RetornaDadosUsuarios(string idUsuario)
        {
            var query = $"SELECT * FROM usuarios  WHERE id={idUsuario}";
            var resultado = _conexaoMysql.ExecutaComandoComRetorno(query);
            return resultado;
        }

        public DataTable PesquisaUsuarios(string termo)
        {
            var query =
                $"SELECT id as ID, nome as NOME,login as LOGIN, permissao AS PERMISSÃO FROM usuarios WHERE (nome like'%{termo}%' OR login like '%{termo}%') AND ativo='S' ";
            var resultado = _conexaoMysql.ExecutaComandoComRetornoDataTable(query);
            return resultado;
        }

        public void AtribuiUsuario(string idContato,string idusuario)
        {
            var query = $"UPDATE contatos SET idusuario={idusuario} WHERE id={idContato} ";
            _conexaoMysql.ExecutaComando(query);
        }

        public void CadastraUsuario(string nome, string login, string email, string permisssao)
        {
            var query = $"INSERT INTO usuarios (nome,login,email,permissao,senha,trocasenha) VALUES('{nome}','{login}','{email}','{permisssao}',MD5('123'),'S') ";
            _conexaoMysql.ExecutaComando(query);
        }
        public void ExcluirUsuario(string idUsuario)
        {
            var query = $"UPDATE usuarios SET ativo='N'WHERE id={idUsuario}";
            _conexaoMysql.ExecutaComando(query);
        }

        public void AtualizaUsuario(string nome, string login, string email, string permissao, string idUsuario)
        {
            var query = $"UPDATE usuarios SET nome='{nome}',login='{login}',email='{email}',permissao='{permissao}' WHERE id='{idUsuario}' ";
            _conexaoMysql.ExecutaComando(query);
        }

        public DataTable RetornaClientesEfetuados(DateTime inicio,DateTime fim)
        {
            var query =
                $"SELECT a.nomecontato,date_format(b.data,'%d/%m/%y' ) FROM contatos a, evolucoes b WHERE a.id=b.idcontato and DATE(b.data) BETWEEN '{inicio.Date.ToString("yyyy /MM/dd")}' AND '{fim.Date.ToString("yyyy/MM/dd")}' and b.acao='CUSTOMER' ";
            var resultado = _conexaoMysql.ExecutaComandoComRetornoDataTable(query);
            return resultado;
        }
        public DataTable RetornaContatosNovos(DateTime inicio,DateTime fim)
        {
            var query =
                $"SELECT a.nomecontato,date_format(b.data,'%d/%m/%y' ) FROM contatos a, evolucoes b WHERE a.id=b.idcontato and DATE(b.data) BETWEEN '{inicio.Date.ToString("yyyy /MM/dd")}' AND '{fim.Date.ToString("yyyy/MM/dd")}' and b.acao='SUSPECT' ";
            var resultado = _conexaoMysql.ExecutaComandoComRetornoDataTable(query);
            return resultado;
        }
        public DataTable RetornaFunilVendas()
        {
            var query =
                $"SELECT status, TRUNCATE(count(id)*100/(SELECT count(id) as total FROM contatos WHERE ativo='S'),0) as quantidade FROM contatos WHERE ativo='S' group by status ";
            var resultado = _conexaoMysql.ExecutaComandoComRetornoDataTable(query);
            return resultado;
        }
        public string RetornaPermissao(string idUsuario)
        {
            var query =
                $"SELECT permissao FROM usuarios WHERE id={idUsuario} ";
            var resultado = _conexaoMysql.ExecutaComandoComRetornoDataTable(query);
            return resultado.Rows[0]["permissao"].ToString();
        }

    }
}
