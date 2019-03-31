using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Desafio.ClassesAuxiliares;
using Desafio.Model;
using Desafio.Query;
using MetroFramework;
using MetroFramework.Forms;

namespace Desafio
{
    public partial class Contato : MetroForm
    {
        private string _usuario;
        public Contato(string usuario)
        {
            _usuario = usuario;
            InitializeComponent();
        }

        private async void TextCep_Leave(object sender, EventArgs e)
        {
            BuscaCep localiza = new BuscaCep();
            var dadosEndereco = await localiza.Localizar(textCep.Text);
            textEndereco.Text = dadosEndereco.Rua;
            textBairro.Text = dadosEndereco.Bairro;
            textCidade.Text = dadosEndereco.Cidade;
            textEstado.Text = dadosEndereco.Estado;
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textNomeCartorio.Text))
            {
                MetroMessageBox.Show(this, "Favor preencher o nome do cartório.", "Atenção", MessageBoxButtons.OK,
                    MessageBoxIcon.Hand);
            }
            else if (string.IsNullOrEmpty(textNomeContato.Text))
            {
                MetroMessageBox.Show(this, "Favor preencher o nome do contato.", "Atenção", MessageBoxButtons.OK,
                    MessageBoxIcon.Hand);
            }
            else if (string.IsNullOrEmpty(textEmail.Text))
            {
                MetroMessageBox.Show(this, "Favor preencher o email do contato.", "Atenção", MessageBoxButtons.OK,
                    MessageBoxIcon.Hand);
            }
            else if (string.IsNullOrEmpty(textEndereco.Text))
            {
                MetroMessageBox.Show(this, "Favor preencher o endereço do contato.", "Atenção", MessageBoxButtons.OK,
                    MessageBoxIcon.Hand);
            }
            else if (string.IsNullOrEmpty(textNumero.Text))
            {
                MetroMessageBox.Show(this, "Favor preencher o numero endereço do contato.", "Atenção", MessageBoxButtons.OK,
                    MessageBoxIcon.Hand);
            }
            else if (string.IsNullOrEmpty(textBairro.Text))
            {
                MetroMessageBox.Show(this, "Favor preencher o bairro do contato.", "Atenção", MessageBoxButtons.OK,
                    MessageBoxIcon.Hand);
            }
            else if (string.IsNullOrEmpty(textCidade.Text))
            {
                MetroMessageBox.Show(this, "Favor preencher a cidade do contato.", "Atenção", MessageBoxButtons.OK,
                    MessageBoxIcon.Hand);
            }
            else if (string.IsNullOrEmpty(textEstado.Text))
            {
                MetroMessageBox.Show(this, "Favor preencher o estado do contato.", "Atenção", MessageBoxButtons.OK,
                    MessageBoxIcon.Hand);
            }else if (gridTelefones.RowCount ==0)
            {
                MetroMessageBox.Show(this, "Favor adicionar ao menos um número de contato.", "Atenção", MessageBoxButtons.OK,
                    MessageBoxIcon.Hand);
            }
            else if (comboForma.SelectedItem ==null)
            {
                MetroMessageBox.Show(this, "Favor selecionar a forma de entrada do contato.", "Atenção", MessageBoxButtons.OK,
                    MessageBoxIcon.Hand);
            }
            else
            {
                if (btnCadastrar.Text.Contains("Cadastrar"))
                {

                    QueryMysql validaDados = new QueryMysql();
                    string idUsuario = validaDados.RetornaIdUsuario(_usuario);
                   int idContato =  validaDados.InserirContato(textNomeCartorio.Text, textNomeContato.Text, textEmail.Text,
                       textCep.Text, textEndereco.Text, textNumero.Text,
                        textComplemento.Text, textBairro.Text, textCidade.Text, textEstado.Text,
                        comboForma.SelectedItem.ToString(),Convert.ToInt32(idUsuario));
                   for (int i = 0; i < gridTelefones.RowCount; i++)
                   {
                       if (gridTelefones.Rows[i].Cells[1].Value != null)
                       {
                           validaDados.InserirTelefoneContato(idContato,
                               gridTelefones.Rows[i].Cells[0].Value.ToString(),
                               gridTelefones.Rows[i].Cells[2].Value.ToString(),
                               gridTelefones.Rows[i].Cells[1].Value.ToString());
                       }
                   }
                   LimpaCampos();
                   
                   MetroMessageBox.Show(this, "Contato cadastrado com sucesso.", "Atenção", MessageBoxButtons.OK,
                       MessageBoxIcon.Information);
                }
                else
                {

                    QueryMysql validaDados = new QueryMysql();
                    string idUsuario = validaDados.RetornaIdUsuario(_usuario);

                    validaDados.ValidaEvolucao(AuxiliadoresEdicao._idContato, comboStatus.SelectedItem.ToString());

                    validaDados.AtualizaContato(textNomeCartorio.Text, textNomeContato.Text, textEmail.Text,
                        textCep.Text, textEndereco.Text, textNumero.Text,
                        textComplemento.Text, textBairro.Text, textCidade.Text, textEstado.Text,
                        comboForma.SelectedItem.ToString(), Convert.ToInt32(idUsuario),
                        Convert.ToInt32(AuxiliadoresEdicao._idContato), comboStatus.SelectedItem.ToString());

                    for (int i = 0; i < gridTelefones.RowCount; i++)
                    {
                        if (Convert.ToInt32(gridTelefones.Rows[i].Cells[0].Value) == 0)
                        {
                            if (gridTelefones.Rows[i].Cells[1].Value != null)
                            {
                                validaDados.InserirTelefoneContato(Convert.ToInt32(AuxiliadoresEdicao._idContato),
                                    gridTelefones.Rows[i].Cells[1].Value.ToString(),
                                    gridTelefones.Rows[i].Cells[3].Value.ToString(),
                                    gridTelefones.Rows[i].Cells[2].Value.ToString());
                            }
                        }
                        else
                        {
                            validaDados.AtualizaTelefoneContato(Convert.ToInt32(AuxiliadoresEdicao._idContato),
                                gridTelefones.Rows[i].Cells[1].Value.ToString(),
                                gridTelefones.Rows[i].Cells[3].Value.ToString(),
                                gridTelefones.Rows[i].Cells[2].Value.ToString(),gridTelefones.Rows[i].Cells[0].Value.ToString());
                        }
                    }

                    LimpaCampos();
                    MetroMessageBox.Show(this, "Contato alterado com sucesso.", "Atenção", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            
        }

        private void BuscarContatoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pesquisa pesquisa = new Pesquisa("contatos");
            pesquisa.ShowDialog();
            string idContato = AuxiliadoresEdicao._idContato;
            if (idContato != null)
            {
                QueryMysql validaDados = new QueryMysql();
                var dadosContatos = validaDados.RetornaDadosContato(idContato);

                textNomeCartorio.Text = dadosContatos[0]["nomecartorio"];
                textNomeContato.Text = dadosContatos[0]["nomecontato"];
                textEmail.Text = dadosContatos[0]["email"];

                comboStatus.Visible = true;
                labelStatus.Visible = true;
                comboStatus.SelectedItem = dadosContatos[0]["status"];

                textCep.Text = dadosContatos[0]["cep"];
                textEndereco.Text = dadosContatos[0]["endereco"];
                textNumero.Text = dadosContatos[0]["numero"];
                textComplemento.Text = dadosContatos[0]["complemento"];
                textBairro.Text = dadosContatos[0]["bairro"];
                textCidade.Text = dadosContatos[0]["cidade"];
                textEstado.Text = dadosContatos[0]["estado"];
                comboForma.SelectedItem = dadosContatos[0]["formacontato"].ToUpper();

                gridTelefones.Columns.Clear();
                gridTelefones.Rows.Clear();

                DataGridViewColumn idTelefone = new DataGridViewTextBoxColumn();
                idTelefone.ReadOnly = true;
                idTelefone.Name = "id";
                idTelefone.HeaderText = "ID";
                idTelefone.DefaultCellStyle.NullValue = "0";


                gridTelefones.Columns.Add(idTelefone);
                gridTelefones.Columns.Add("numero", "Número");

                DataGridViewComboBoxColumn preferencial = new DataGridViewComboBoxColumn();
                List<String> itensConcluidos = new List<String>();
                itensConcluidos.Add("Sim");
                itensConcluidos.Add("Não");
                preferencial.DataSource = itensConcluidos;
                preferencial.HeaderText = "Preferêncial para Contato";
                preferencial.Name = "preferencial";
                preferencial.Width = 200;
                preferencial.FlatStyle = FlatStyle.Flat;
                gridTelefones.Columns.Add(preferencial);




                DataGridViewComboBoxColumn tipo = new DataGridViewComboBoxColumn();
                List<String> itensPrioridade = new List<String>();
                itensPrioridade.Add("CELULAR");
                itensPrioridade.Add("FIXO RESIDENCIAL");
                itensPrioridade.Add("FIXO COMERCIAL");
                tipo.DataSource = itensPrioridade;
                tipo.HeaderText = "Tipo de Telefone";
                tipo.Name = "tipo";
                tipo.Width = 200;
                tipo.FlatStyle = FlatStyle.Flat;
                gridTelefones.Columns.Add(tipo);




                int count = 0;
                var telefones = validaDados.RetornaTelefonesContatos(idContato);
                foreach (var telefone in telefones)
                {


                    DataGridViewRow linha = new DataGridViewRow();
                    DataGridViewCell numero = new DataGridViewTextBoxCell();
                    DataGridViewCell id = new DataGridViewTextBoxCell();


                    id.Value = telefone["id"];
                    numero.Value = telefone["numero"];

                    linha.Cells.Add(id);
                    linha.Cells.Add(numero);

                    gridTelefones.Rows.Add(linha);

                    gridTelefones.Rows[count].Cells["tipo"].Value = telefone["tipo"];
                    gridTelefones.Rows[count].Cells["preferencial"].Value = telefone["preferencial"];
                    count++;


                }

                btnExcluir.Visible = true;
                btnCadastrar.Text = "Salvar Alterações";
            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            QueryMysql validaDados = new QueryMysql();
            DialogResult resultado = MetroMessageBox.Show(this, "Deseja excluir este contato ?.", "Atenção", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                validaDados.ExcluirContato(Convert.ToInt32(AuxiliadoresEdicao._idContato));




                LimpaCampos();



                MetroMessageBox.Show(this, "Contato excluido com sucesso.", "Atenção", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

            }
        }

        private void LimpaCampos()
        {
            textNomeCartorio.Clear();
            textNomeContato.Clear();
            textEmail.Clear();

            comboStatus.Visible = false;
            labelStatus.Visible = false;

            textCep.Clear();
            textEndereco.Clear();
            textNumero.Clear();
            textComplemento.Clear();
            textBairro.Clear();
            textCidade.Clear();
            textEstado.Clear(); 

            gridTelefones.Columns.Clear();
            gridTelefones.Rows.Clear();
            btnExcluir.Visible = false;
            AuxiliadoresEdicao._idContato = "";
            btnCadastrar.Text = "Cadastrar Contato";
        }
    }
}
