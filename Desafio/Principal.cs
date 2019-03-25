using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Desafio.ClassesAuxiliares;
using Desafio.Query;
using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;

namespace Desafio
{
    public partial class Principal : MetroForm
    {
        private string _usuario;
        public Principal(string usuario)
        {
            _usuario = usuario;
            InitializeComponent();
            QueryMysql validaDados = new QueryMysql();
            var idUsuario = validaDados.RetornaIdUsuario(usuario);
            var dadosAgenda = validaDados.RecuperaAgenda(Convert.ToInt32(idUsuario));
            PreparaColunasGrid();
            GeraGridAgenda(dadosAgenda);
        }

        private void BtnAdicionarEvento_Click(object sender, EventArgs e)
        {
            AdicionarEvento evento = new AdicionarEvento(_usuario);
            evento.ShowDialog();
        }

        private void BtnBuscarEvento_Click(object sender, EventArgs e)
        {
            QueryMysql validaDados = new QueryMysql();
            var idUsuario = validaDados.RetornaIdUsuario(_usuario);
            var dadosAgenda = validaDados.RecuperaAgenda(Convert.ToInt32(idUsuario),dateEventos.Value);
            if (dadosAgenda.Rows.Count == 0)
            {
                MetroMessageBox.Show(this, "Nenhuma informação foi encontrada.", "Atenção", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                GeraGridAgenda(dadosAgenda);
            }
        }

        private void GridAgenda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            QueryMysql validaDados = new QueryMysql();
            if (e.ColumnIndex == 6)
            {
               DialogResult resultado =  MetroMessageBox.Show(this, "Deseja alterar as alterações ?.", "Atenção", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
               if (resultado == DialogResult.Yes)
               {
                   try
                   {
                       validaDados.AlteraEvento(Convert.ToInt32(gridAgenda.Rows[e.RowIndex].Cells[0].Value.ToString()),
                           gridAgenda.Rows[e.RowIndex].Cells[1].Value.ToString(),
                           Convert.ToDateTime(gridAgenda.Rows[e.RowIndex].Cells[2].Value.ToString()),
                           Convert.ToDateTime(gridAgenda.Rows[e.RowIndex].Cells[3].Value.ToString()),
                           gridAgenda.Rows[e.RowIndex].Cells[5].Value.ToString(),
                           gridAgenda.Rows[e.RowIndex].Cells[4].Value.ToString());
                   }
                   catch
                   {
                       MetroMessageBox.Show(this, "Ocorreu um erro ao salvar as alterações, Nenhuma alteração feita. ", "Erro", MessageBoxButtons.OK,
                           MessageBoxIcon.Hand);
                       var idUsuario = validaDados.RetornaIdUsuario(_usuario);
                       var dadosAgenda = validaDados.RecuperaAgenda(Convert.ToInt32(idUsuario), dateEventos.Value);
                        GeraGridAgenda(dadosAgenda);
                    }
               }
            }
           else if (e.ColumnIndex == 7)
            {
                DialogResult resultado = MetroMessageBox.Show(this, "Deseja excluir este evento ?.", "Atenção", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    validaDados.ExcluirEvento(Convert.ToInt32(gridAgenda.Rows[e.RowIndex].Cells[0].Value.ToString()));
                    var idUsuario = validaDados.RetornaIdUsuario(_usuario);
                    var dadosAgenda = validaDados.RecuperaAgenda(Convert.ToInt32(idUsuario), dateEventos.Value);
                    GeraGridAgenda(dadosAgenda);
                }

            }
        }

        private void GeraGridAgenda(DataTable dadosAgenda)
        {
            gridAgenda.Rows.Clear();
            

            for (int i = 0; i < dadosAgenda.Rows.Count; i++)
            {
                DataGridViewCell id = new DataGridViewTextBoxCell();
                id.Value = dadosAgenda.Rows[i]["ID"];
                DataGridViewCell descricao = new DataGridViewTextBoxCell();
                descricao.Value = dadosAgenda.Rows[i]["Descrição"];
                DataGridViewCell data = new DataGridViewTextBoxCell();
                data.Value = Convert.ToDateTime(dadosAgenda.Rows[i]["Data"]).ToString("dd/MM/yyyy");
                DataGridViewCell hora = new DataGridViewTextBoxCell();
                hora.Value = dadosAgenda.Rows[i]["Hora"];
                DataGridViewRow linhaGrid = new DataGridViewRow();
                linhaGrid.Cells.Add(id);
                linhaGrid.Cells.Add(descricao);
                linhaGrid.Cells.Add(data);
                linhaGrid.Cells.Add(hora);

                gridAgenda.Rows.Add(linhaGrid);
                gridAgenda.Rows[gridAgenda.RowCount - 1].Cells["concluido"].Value = dadosAgenda.Rows[i]["Concluído"];
                gridAgenda.Rows[gridAgenda.RowCount - 1].Cells["prioridade"].Value = dadosAgenda.Rows[i]["Prioridade"];

            }
        }

        private void PreparaColunasGrid()
        {
            gridAgenda.Columns.Add("id", "ID");
            gridAgenda.Columns.Add("descricao", "Descrição");
            gridAgenda.Columns.Add("data", "Data");
            gridAgenda.Columns.Add("hora", "Hora");

            DataGridViewComboBoxColumn concluido = new DataGridViewComboBoxColumn();
            List<String> itensConcluidos = new List<String>();
            itensConcluidos.Add("Sim");
            itensConcluidos.Add("Não");
            concluido.DataSource = itensConcluidos;
            concluido.HeaderText = "Concluído";
            concluido.Name = "concluido";
            concluido.Width = 270;
            concluido.FlatStyle = FlatStyle.Flat;
            gridAgenda.Columns.Add(concluido);

            DataGridViewComboBoxColumn prioridade = new DataGridViewComboBoxColumn();
            List<String> itensPrioridade = new List<String>();
            itensPrioridade.Add("Urgente");
            itensPrioridade.Add("Pouco Urgente");
            itensPrioridade.Add("Normal");
            itensPrioridade.Add("Sem Urgência");
            prioridade.DataSource = itensPrioridade;
            prioridade.HeaderText = "Prioridade";
            prioridade.Name = "prioridade";
            prioridade.Width = 270;
            prioridade.FlatStyle = FlatStyle.Flat;
            gridAgenda.Columns.Add(prioridade);

            DataGridViewButtonColumn salvar = new DataGridViewButtonColumn();
            salvar.Text = "Salvar";
            salvar.HeaderText = "Salvar";
            salvar.Name = "salvar";
            salvar.FlatStyle = FlatStyle.Flat;
            salvar.UseColumnTextForButtonValue = true;
            gridAgenda.Columns.Add(salvar);

            DataGridViewButtonColumn excluir = new DataGridViewButtonColumn();
            excluir.Text = "Excluir";
            excluir.FlatStyle = FlatStyle.Flat;
            excluir.HeaderText = "Excluir";
            excluir.Name = "excluir";
            excluir.UseColumnTextForButtonValue = true;
            gridAgenda.Columns.Add(excluir);
        }
    }
}
