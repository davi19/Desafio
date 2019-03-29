using System.Windows.Forms;
using Desafio.ClassesAuxiliares;
using Desafio.Query;
using MetroFramework;
using MetroFramework.Forms;

namespace Desafio
{
    public partial class Login : MetroForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnEsqueceuSenha_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(textUsuario.Text))
            {
                MetroMessageBox.Show(this, "Favor preencher o usuário de acesso.", "Atenção", MessageBoxButtons.OK,
                    MessageBoxIcon.Hand);
            }
            else
            {
                QueryMysql validaDados = new QueryMysql();
                if (validaDados.ValidaUsuario(textUsuario.Text))
                {
                    int novaSenha = validaDados.GeraSenha(textUsuario.Text);
                    string email = validaDados.RetornaEmail(textUsuario.Text);

                    EnvioEmail emailNovaSenha = new EnvioEmail();
                    emailNovaSenha.Email(
                        "<p>Você solicitou uma nova senha de acesso.</p> <br/><p><b>Nova senha:</b>" + novaSenha + "</p> ",
                        email, "Alteração Acesso");

                    MetroMessageBox.Show(this, "Foi enviado um e-mail com sua senha temporária de acesso", "Atenção", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                }
                else
                {
                    MetroMessageBox.Show(this, "Usuário não encontrado em nossa base de dados.", "Atenção", MessageBoxButtons.OK,
                        MessageBoxIcon.Hand);
                }
                
            }
        }

        private void BtnEntrar_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(textUsuario.Text))
            {
                MetroMessageBox.Show(this, "Favor preencher o usuário de acesso.", "Atenção", MessageBoxButtons.OK,
                    MessageBoxIcon.Hand);
            }
            else if (string.IsNullOrEmpty(textSenha.Text))
            {
                MetroMessageBox.Show(this, "Favor preencher a senha de acesso.", "Atenção", MessageBoxButtons.OK,
                    MessageBoxIcon.Hand);
            }
            else
            {
                QueryMysql validaDados = new QueryMysql();
                if (validaDados.ValidaUsuario(textUsuario.Text))
                {
                    if (validaDados.ValidaLogin(textUsuario.Text, textSenha.Text))
                    {
                        if (validaDados.ValidaTrocaSenha(textUsuario.Text))
                        {
                            TrocaSenha troca = new TrocaSenha(textUsuario.Text);
                            Hide();
                            troca.Show();
                        }
                        else
                        {
                            Principal principal = new Principal(textUsuario.Text);
                            Hide();
                            principal.Show();
                        }
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "Senha inválida.", "Atenção", MessageBoxButtons.OK,
                            MessageBoxIcon.Hand);
                    }

                }
                else
                {
                    MetroMessageBox.Show(this, "Usuário não encontrado em nossa base de dados.", "Atenção", MessageBoxButtons.OK,
                        MessageBoxIcon.Hand);
                }
            }
        }

        private void TextSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                BtnEntrar_Click(sender,e);
            }
        }

        private void TextUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                BtnEntrar_Click(sender, e);
            }
        }
    }
}
