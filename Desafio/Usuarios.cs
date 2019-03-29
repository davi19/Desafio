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
    public partial class Usuarios : MetroForm
    {
        private string _idUsuario = "";
        public Usuarios()
        {
            InitializeComponent();
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textNome.Text))
            {
                MetroMessageBox.Show(this, "Favor preencher o nome do usuário. ", "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Hand);

            }
            else if (string.IsNullOrEmpty(textLogin.Text))
            {
                MetroMessageBox.Show(this, "Favor preencher o login do usuário. ", "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Hand);
            }
            else if (string.IsNullOrEmpty(textEmail.Text))
            {
                MetroMessageBox.Show(this, "Favor preencher o e-mail do usuário. ", "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Hand);
            }
            else if (comboPermissao.SelectedItem == null)
            {
                MetroMessageBox.Show(this, "Favor selecionar a permissão para o usuário. ", "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Hand);
            }
            else
            {
                QueryMysql validaDados = new QueryMysql();
                if (btnCadastrar.Text.Contains("Cadastrar"))
                {
                    
                    validaDados.CadastraUsuario(textNome.Text, textLogin.Text, textEmail.Text,
                        comboPermissao.SelectedItem.ToString());
                    LimpaDados();
                    MetroMessageBox.Show(this, "Usuário cadastrado com sucesso. Senha padrão 123, será solicitado a troca da mesma no primeiro acesso ", "Sucesso", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    validaDados.AtualizaUsuario(textNome.Text, textLogin.Text, textEmail.Text,
                        comboPermissao.SelectedItem.ToString(),_idUsuario);
                    LimpaDados();
                    MetroMessageBox.Show(this, "Usuário atualizado com sucesso. ", "Sucesso", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }

            }
        }


        public void LimpaDados()
        {
            textEmail.Clear();
            textLogin.Clear();
            textNome.Clear();
            _idUsuario = "";
            AuxiliadoresEdicao._idUsuario = "";
            comboPermissao.SelectedItem = null;
            btnExcluir.Visible = false;
            btnCadastrar.Text = "Cadastrar Usuário";
        }

        private void PesquisarUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pesquisa pesquisa = new Pesquisa("usuarios");
            pesquisa.ShowDialog();
            _idUsuario = AuxiliadoresEdicao._idUsuario;
            QueryMysql validaDados = new QueryMysql();
            var dadosUsuario = validaDados.RetornaDadosUsuarios(_idUsuario);

            textEmail.Text=dadosUsuario[0]["email"];
            textLogin.Text = dadosUsuario[0]["login"];
            textNome.Text = dadosUsuario[0]["nome"];
            comboPermissao.SelectedItem = dadosUsuario[0]["permissao"];
            btnExcluir.Visible = true;
            btnCadastrar.Text = "Salvar Alterações";
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            QueryMysql validaDados = new QueryMysql();
            DialogResult resultado = MetroMessageBox.Show(this, "Deseja excluir este usuário ?.", "Atenção", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                validaDados.ExcluirUsuario(_idUsuario);
                LimpaDados();
                MetroMessageBox.Show(this, "Usuário excluido com sucesso. ", "Sucesso", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

            }
        }
    }
}
