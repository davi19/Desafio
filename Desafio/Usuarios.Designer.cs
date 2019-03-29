namespace Desafio
{
    partial class Usuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.labelpermissao = new MetroFramework.Controls.MetroLabel();
            this.comboPermissao = new MetroFramework.Controls.MetroComboBox();
            this.textEmail = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.textNome = new MetroFramework.Controls.MetroTextBox();
            this.textLogin = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btnExcluir = new MetroFramework.Controls.MetroButton();
            this.btnCadastrar = new MetroFramework.Controls.MetroButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pesquisarUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(23, 155);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(47, 19);
            this.metroLabel12.TabIndex = 41;
            this.metroLabel12.Text = "E-mail";
            // 
            // labelpermissao
            // 
            this.labelpermissao.AutoSize = true;
            this.labelpermissao.Location = new System.Drawing.Point(350, 155);
            this.labelpermissao.Name = "labelpermissao";
            this.labelpermissao.Size = new System.Drawing.Size(68, 19);
            this.labelpermissao.TabIndex = 40;
            this.labelpermissao.Text = "Permissão";
            // 
            // comboPermissao
            // 
            this.comboPermissao.FormattingEnabled = true;
            this.comboPermissao.ItemHeight = 23;
            this.comboPermissao.Items.AddRange(new object[] {
            "ADM",
            "COMUM"});
            this.comboPermissao.Location = new System.Drawing.Point(350, 177);
            this.comboPermissao.Name = "comboPermissao";
            this.comboPermissao.Size = new System.Drawing.Size(313, 29);
            this.comboPermissao.TabIndex = 38;
            this.comboPermissao.UseSelectable = true;
            // 
            // textEmail
            // 
            this.textEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            // 
            // 
            // 
            this.textEmail.CustomButton.Image = null;
            this.textEmail.CustomButton.Location = new System.Drawing.Point(285, 1);
            this.textEmail.CustomButton.Name = "";
            this.textEmail.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.textEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textEmail.CustomButton.TabIndex = 1;
            this.textEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textEmail.CustomButton.UseSelectable = true;
            this.textEmail.CustomButton.Visible = false;
            this.textEmail.Lines = new string[0];
            this.textEmail.Location = new System.Drawing.Point(23, 177);
            this.textEmail.MaxLength = 32767;
            this.textEmail.Name = "textEmail";
            this.textEmail.PasswordChar = '\0';
            this.textEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textEmail.SelectedText = "";
            this.textEmail.SelectionLength = 0;
            this.textEmail.SelectionStart = 0;
            this.textEmail.ShortcutsEnabled = true;
            this.textEmail.Size = new System.Drawing.Size(313, 29);
            this.textEmail.Style = MetroFramework.MetroColorStyle.Brown;
            this.textEmail.TabIndex = 37;
            this.textEmail.UseSelectable = true;
            this.textEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(24, 107);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(46, 19);
            this.metroLabel1.TabIndex = 39;
            this.metroLabel1.Text = "Nome";
            // 
            // textNome
            // 
            this.textNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.textNome.CustomButton.Image = null;
            this.textNome.CustomButton.Location = new System.Drawing.Point(291, 1);
            this.textNome.CustomButton.Name = "";
            this.textNome.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textNome.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textNome.CustomButton.TabIndex = 1;
            this.textNome.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textNome.CustomButton.UseSelectable = true;
            this.textNome.CustomButton.Visible = false;
            this.textNome.Lines = new string[0];
            this.textNome.Location = new System.Drawing.Point(23, 129);
            this.textNome.MaxLength = 32767;
            this.textNome.Name = "textNome";
            this.textNome.PasswordChar = '\0';
            this.textNome.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textNome.SelectedText = "";
            this.textNome.SelectionLength = 0;
            this.textNome.SelectionStart = 0;
            this.textNome.ShortcutsEnabled = true;
            this.textNome.Size = new System.Drawing.Size(313, 23);
            this.textNome.Style = MetroFramework.MetroColorStyle.Brown;
            this.textNome.TabIndex = 36;
            this.textNome.UseSelectable = true;
            this.textNome.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textNome.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // textLogin
            // 
            this.textLogin.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.textLogin.CustomButton.Image = null;
            this.textLogin.CustomButton.Location = new System.Drawing.Point(291, 1);
            this.textLogin.CustomButton.Name = "";
            this.textLogin.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textLogin.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textLogin.CustomButton.TabIndex = 1;
            this.textLogin.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textLogin.CustomButton.UseSelectable = true;
            this.textLogin.CustomButton.Visible = false;
            this.textLogin.Lines = new string[0];
            this.textLogin.Location = new System.Drawing.Point(350, 129);
            this.textLogin.MaxLength = 32767;
            this.textLogin.Name = "textLogin";
            this.textLogin.PasswordChar = '\0';
            this.textLogin.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textLogin.SelectedText = "";
            this.textLogin.SelectionLength = 0;
            this.textLogin.SelectionStart = 0;
            this.textLogin.ShortcutsEnabled = true;
            this.textLogin.Size = new System.Drawing.Size(313, 23);
            this.textLogin.Style = MetroFramework.MetroColorStyle.Brown;
            this.textLogin.TabIndex = 42;
            this.textLogin.UseSelectable = true;
            this.textLogin.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textLogin.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(350, 108);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(41, 19);
            this.metroLabel2.TabIndex = 43;
            this.metroLabel2.Text = "Login";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnExcluir.Location = new System.Drawing.Point(405, 217);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(126, 23);
            this.btnExcluir.Style = MetroFramework.MetroColorStyle.Brown;
            this.btnExcluir.TabIndex = 45;
            this.btnExcluir.Text = "Excluir Usuário";
            this.btnExcluir.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnExcluir.UseSelectable = true;
            this.btnExcluir.UseStyleColors = true;
            this.btnExcluir.Visible = false;
            this.btnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCadastrar.Location = new System.Drawing.Point(537, 217);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(126, 23);
            this.btnCadastrar.Style = MetroFramework.MetroColorStyle.Brown;
            this.btnCadastrar.TabIndex = 44;
            this.btnCadastrar.Text = "Cadastrar Usuário";
            this.btnCadastrar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnCadastrar.UseSelectable = true;
            this.btnCadastrar.UseStyleColors = true;
            this.btnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pesquisarUsuárioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(649, 24);
            this.menuStrip1.TabIndex = 46;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pesquisarUsuárioToolStripMenuItem
            // 
            this.pesquisarUsuárioToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.pesquisarUsuárioToolStripMenuItem.Name = "pesquisarUsuárioToolStripMenuItem";
            this.pesquisarUsuárioToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.pesquisarUsuárioToolStripMenuItem.Text = "Pesquisar Usuário";
            this.pesquisarUsuárioToolStripMenuItem.Click += new System.EventHandler(this.PesquisarUsuárioToolStripMenuItem_Click);
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 263);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.textLogin);
            this.Controls.Add(this.metroLabel12);
            this.Controls.Add(this.labelpermissao);
            this.Controls.Add(this.comboPermissao);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimizeBox = false;
            this.Name = "Usuarios";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Brown;
            this.Text = "Usuários";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel labelpermissao;
        private MetroFramework.Controls.MetroComboBox comboPermissao;
        private MetroFramework.Controls.MetroTextBox textEmail;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox textNome;
        private MetroFramework.Controls.MetroTextBox textLogin;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton btnExcluir;
        private MetroFramework.Controls.MetroButton btnCadastrar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pesquisarUsuárioToolStripMenuItem;
    }
}