using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Desafio.Model;
using Desafio.Query;
using MetroFramework.Forms;

namespace Desafio
{
    public partial class Pesquisa : MetroForm
    {
        private string _tabelaPesquisa;
        public Pesquisa(string tabela)
        {
            _tabelaPesquisa = tabela;
            InitializeComponent();

        }

        private void TextNomeContato_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                BtnPesquisar_Click(sender, e);
            }
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            QueryMysql validaDados = new QueryMysql();
            DataTable resultadoPesquisa;
            switch (_tabelaPesquisa)
            {
                case "contatos":
                    resultadoPesquisa = validaDados.PesquisaContatos(textTermo.Text);
                    gridResultado.DataSource = resultadoPesquisa;
                    break;
                case "atividades":
                    resultadoPesquisa = validaDados.PesquisaAtividades(textTermo.Text);
                    gridResultado.DataSource = resultadoPesquisa;
                    break;
                case "usuarios":
                    resultadoPesquisa = validaDados.PesquisaUsuarios(textTermo.Text);
                    gridResultado.DataSource = resultadoPesquisa;
                    break;

            }
        }

        private void GridResultado_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (_tabelaPesquisa)
            {
                case "contatos":
                    AuxiliadoresEdicao._idContato = gridResultado.Rows[e.RowIndex].Cells[0].Value.ToString();
                    Hide();
                    break;
                case "atividades":
                    AuxiliadoresEdicao._idAtividade = gridResultado.Rows[e.RowIndex].Cells[0].Value.ToString();
                    Hide();
                    break;
                case "usuarios":
                    AuxiliadoresEdicao._idUsuario = gridResultado.Rows[e.RowIndex].Cells[0].Value.ToString();
                    Hide();
                    break;

            }
            
        }
    }
}
