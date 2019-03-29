using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Desafio.Model;
using Desafio.Query;
using MetroFramework;
using MetroFramework.Forms;

namespace Desafio
{
    public partial class AtribuirContato : MetroForm
    {
        private string _idContato = "";
        private string _idUsuario = "";
        public AtribuirContato()
        {
            InitializeComponent();
        }

        private void BtnContato_Click(object sender, EventArgs e)
        {
            Pesquisa pesquisa = new Pesquisa("contatos");
            pesquisa.ShowDialog();
            _idContato = AuxiliadoresEdicao._idContato;
            QueryMysql validaDados = new QueryMysql();
            var dadosContatos = validaDados.RetornaDadosContato(_idContato);
            var nomeUsuarioAtual = validaDados.RetornaNomeUsuarioAtual(_idContato);

            labelContato.Text = "CONTATO:" + dadosContatos[0]["nomecontato"];
            labelAtual.Text = "USUÁRIO ATUAL:" + nomeUsuarioAtual;
        }

        private void BtnUsuario_Click(object sender, EventArgs e)
        {
            Pesquisa pesquisa = new Pesquisa("usuarios");
            pesquisa.ShowDialog();
            _idUsuario = AuxiliadoresEdicao._idUsuario;
            QueryMysql validaDados = new QueryMysql();
            var dadosUsuarios = validaDados.RetornaDadosUsuarios(_idUsuario);
            labelUsuario.Text = "USUÁRIO NOVO:"+ dadosUsuarios[0]["nome"];
        }

        private void BtnAtribuir_Click(object sender, EventArgs e)
        {
            if (_idUsuario.Length == 0)
            {
                MetroMessageBox.Show(this, "Favor buscar um usuário para atribuir o contato selecionado. ", "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Hand);
            }
            else if (_idContato.Length==0)
            {
                MetroMessageBox.Show(this, "Favor buscar um contato para ser atribuido. ", "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Hand);
            }
            else
            {
                QueryMysql validaDados = new QueryMysql();
                validaDados.AtribuiUsuario(_idContato,_idUsuario);
                labelUsuario.Text = "USUÁRIO NOVO:";
                labelContato.Text = "CONTATO:";
                labelAtual.Text = "USUÁRIO ATUAL:";
                _idContato = "";
                _idUsuario = "";
                AuxiliadoresEdicao._idContato = "";
                AuxiliadoresEdicao._idUsuario = "";
                MetroMessageBox.Show(this, "Contato atribuido com sucesso. ", "Sucesso", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

            }
        }
    }
}
