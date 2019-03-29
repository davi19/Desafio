using System;
using System.Windows.Forms;
using Desafio.Model;
using Desafio.Query;
using MetroFramework;
using MetroFramework.Forms;

namespace Desafio
{
    public partial class Atividades : MetroForm
    {
        private string _idContato = "";
        private string _usuario = "";
        private string _idAtividade = "";
        public Atividades(string usuario)
        {
            _usuario = usuario;
            InitializeComponent();

        }


        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textObservacao.Text))
            {
                MetroMessageBox.Show(this, "Favor preencher a observação sobre atividade efetuada.", "Atenção", MessageBoxButtons.OK,
                    MessageBoxIcon.Hand);
            }
            else if (!textData.MaskFull)
            {
                MetroMessageBox.Show(this, "Favor preencher a data da atividade efetuada.", "Atenção", MessageBoxButtons.OK,
                    MessageBoxIcon.Hand);
            }
            else if (comboAtividade.SelectedItem == null)
            {
                MetroMessageBox.Show(this, "Favor preencher a atividade efetuada.", "Atenção", MessageBoxButtons.OK,
                    MessageBoxIcon.Hand);
            }
            else if (_idContato.Length == 0)
            {
                MetroMessageBox.Show(this, "Favor buscar um contato", "Atenção", MessageBoxButtons.OK,
                    MessageBoxIcon.Hand);
            }
            else
            {
                QueryMysql validaDados = new QueryMysql();
                var idUsuario = validaDados.RetornaIdUsuario(_usuario);
                if (btnCadastrar.Text.Contains("Cadastrar"))
                {
                    validaDados.CadastrarAtividade(textObservacao.Text, comboAtividade.SelectedItem.ToString(),
                        Convert.ToDateTime(textData.Text), _idContato, idUsuario);
                    LimpaCampos();
                    MetroMessageBox.Show(this, "Atividade cadastrada com sucesso.", "Atenção", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    validaDados.AtualizaAtividade(textObservacao.Text, comboAtividade.SelectedItem.ToString(),
                        Convert.ToDateTime(textData.Text), _idContato, idUsuario, _idAtividade);
                    LimpaCampos();

                    MetroMessageBox.Show(this, "Atividade atualizada com sucesso.", "Atenção", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
        }

        private void Btnbuscar_Click(object sender, EventArgs e)
        {
            Pesquisa pesquisa = new Pesquisa("contatos");
            pesquisa.ShowDialog();
            _idContato = AuxiliadoresEdicao._idContato;
            QueryMysql validaDados = new QueryMysql();
            var dadosContatos = validaDados.RetornaDadosContato(_idContato);

            labelContato.Text = "CONTATO:" + dadosContatos[0]["nomecontato"];


        }

        private void PesquisarAtividadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pesquisa pesquisa = new Pesquisa("atividades");
            pesquisa.ShowDialog();
            
            _idAtividade = AuxiliadoresEdicao._idAtividade;
            if (_idAtividade != null)
            {
                QueryMysql validaDados = new QueryMysql();
                var dadosAtividades = validaDados.RetornaDadosAtividades(_idAtividade);
                textObservacao.Text = dadosAtividades[0]["observacao"];
                textData.Text = dadosAtividades[0]["data"];
                comboAtividade.SelectedItem = dadosAtividades[0]["atividade"];
                labelContato.Text = "CONTATO:" + dadosAtividades[0]["nomecontato"];
                _idContato = dadosAtividades[0]["idcontato"];

                btnCadastrar.Text = "Salvar Alterações";
                btnExcluir.Visible = true;
            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            QueryMysql validaDados = new QueryMysql();
            DialogResult resultado = MetroMessageBox.Show(this, "Deseja excluir esta atividade ?.", "Atenção", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                validaDados.ExcluirAtividade(_idAtividade);
                LimpaCampos();



                MetroMessageBox.Show(this, "Atividade excluida com sucesso.", "Atenção", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

            }
        }

        private void LimpaCampos()
        {
            textObservacao.Clear();
            textData.Clear();
            comboAtividade.SelectedItem = null;
            _idContato = "";
            _idAtividade = "";
            btnCadastrar.Text = "Cadastrar Atividade";
            btnExcluir.Visible = false;
            labelContato.Text = "CONTATO:";
            AuxiliadoresEdicao._idAtividade = "";
        }

    }
}
