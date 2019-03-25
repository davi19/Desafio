using System.Windows.Forms;
using Desafio.Query;
using MetroFramework;
using MetroFramework.Forms;

namespace Desafio
{
    public partial class TrocaSenha : MetroForm
    {
        private string _usuario;
        public TrocaSenha(string usuario)
        {
            InitializeComponent();
            _usuario = usuario;
            labelUsuario.Text = "Usuário: "+usuario;

        }

        private void BtnAlterar_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(textSenha.Text))
            {
                MetroMessageBox.Show(this, "Favor preencher a nova senha de acesso.", "Atenção", MessageBoxButtons.OK,
                    MessageBoxIcon.Hand);
            }
            else if (string.IsNullOrEmpty(textConfirmacaoSenha.Text))
            {
                MetroMessageBox.Show(this, "Favor preencher a confirmação da nova senha de acesso.", "Atenção", MessageBoxButtons.OK,
                    MessageBoxIcon.Hand);
            }
            else if(!textSenha.Text.Equals(textConfirmacaoSenha.Text))
            {
                MetroMessageBox.Show(this, "A nova senha e sua confirmação não são iguais.", "Atenção", MessageBoxButtons.OK,
                   MessageBoxIcon.Hand);
            }
            else
            {
                QueryMysql validaDados = new QueryMysql();
                validaDados.AlteraSenha(_usuario,textSenha.Text);
                Principal principal = new Principal(_usuario);
                this.Hide();
                principal.Show();
            }

        }
    }
}
