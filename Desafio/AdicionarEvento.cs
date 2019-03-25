using System;
using System.Windows.Forms;
using Desafio.Query;
using MetroFramework;
using MetroFramework.Forms;

namespace Desafio
{
    public partial class AdicionarEvento : MetroForm
    {
        private string _usuario;
        public AdicionarEvento(string usuario)
        {
            _usuario = usuario;
            InitializeComponent();
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textDescricao.Text))
            {
                MetroMessageBox.Show(this, "Favor preencher a descrição do evento.", "Atenção", MessageBoxButtons.OK,
                    MessageBoxIcon.Hand);
            }
            else if (comboPrioridade.SelectedItem ==null)
            {
                MetroMessageBox.Show(this, "Favor preencher a prioridade do evento.", "Atenção", MessageBoxButtons.OK,
                    MessageBoxIcon.Hand);
            }
            else if(!textHora.MaskCompleted)
            {
                MetroMessageBox.Show(this, "Favor preencher a hora do evento.", "Atenção", MessageBoxButtons.OK,
                    MessageBoxIcon.Hand);
            }
            else if (!textData.MaskCompleted)
            {
                MetroMessageBox.Show(this, "Favor preencher a data do evento.", "Atenção", MessageBoxButtons.OK,
                    MessageBoxIcon.Hand);
            }
            else
            {
                QueryMysql cadastra = new QueryMysql();
                cadastra.CadastraEvento(textDescricao.Text,Convert.ToDateTime(textData.Text), Convert.ToDateTime(textHora.Text),comboPrioridade.SelectedItem.ToString(),_usuario);
                textDescricao.Clear();
                comboPrioridade.SelectedItem = null;
                textData.Clear();
                textHora.Clear();
                MetroMessageBox.Show(this, "Evento cadastrado com sucesso.", "Atenção", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
    }
}
