namespace Desafio
{
    partial class Atividades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Atividades));
            this.textData = new System.Windows.Forms.MaskedTextBox();
            this.btnCadastrar = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.comboAtividade = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.textObservacao = new MetroFramework.Controls.MetroTextBox();
            this.labelContato = new MetroFramework.Controls.MetroLabel();
            this.Btnbuscar = new MetroFramework.Controls.MetroButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pesquisarAtividadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExcluir = new MetroFramework.Controls.MetroButton();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textData
            // 
            this.textData.Location = new System.Drawing.Point(342, 139);
            this.textData.Mask = "00/00/0000";
            this.textData.Name = "textData";
            this.textData.Size = new System.Drawing.Size(88, 20);
            this.textData.TabIndex = 15;
            this.textData.ValidatingType = typeof(System.DateTime);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCadastrar.Location = new System.Drawing.Point(570, 193);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(126, 23);
            this.btnCadastrar.Style = MetroFramework.MetroColorStyle.Brown;
            this.btnCadastrar.TabIndex = 17;
            this.btnCadastrar.Text = "Cadastrar Evento";
            this.btnCadastrar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnCadastrar.UseSelectable = true;
            this.btnCadastrar.UseStyleColors = true;
            this.btnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(342, 117);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(36, 19);
            this.metroLabel3.TabIndex = 20;
            this.metroLabel3.Text = "Data";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 165);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(64, 19);
            this.metroLabel1.TabIndex = 19;
            this.metroLabel1.Text = "Atividade";
            // 
            // comboAtividade
            // 
            this.comboAtividade.FormattingEnabled = true;
            this.comboAtividade.ItemHeight = 23;
            this.comboAtividade.Items.AddRange(new object[] {
            "E-MAIL",
            "TELEFONEMA",
            "VISITA AO CLIENTE",
            "VISITA DO CLIENTE"});
            this.comboAtividade.Location = new System.Drawing.Point(23, 187);
            this.comboAtividade.Name = "comboAtividade";
            this.comboAtividade.Size = new System.Drawing.Size(407, 29);
            this.comboAtividade.Style = MetroFramework.MetroColorStyle.Brown;
            this.comboAtividade.TabIndex = 16;
            this.comboAtividade.UseSelectable = true;
            this.comboAtividade.UseStyleColors = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 117);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(80, 19);
            this.metroLabel2.TabIndex = 18;
            this.metroLabel2.Text = "Observação";
            // 
            // textObservacao
            // 
            this.textObservacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.textObservacao.CustomButton.Image = null;
            this.textObservacao.CustomButton.Location = new System.Drawing.Point(291, 1);
            this.textObservacao.CustomButton.Name = "";
            this.textObservacao.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textObservacao.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textObservacao.CustomButton.TabIndex = 1;
            this.textObservacao.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textObservacao.CustomButton.UseSelectable = true;
            this.textObservacao.CustomButton.Visible = false;
            this.textObservacao.Lines = new string[0];
            this.textObservacao.Location = new System.Drawing.Point(23, 139);
            this.textObservacao.MaxLength = 32767;
            this.textObservacao.Name = "textObservacao";
            this.textObservacao.PasswordChar = '\0';
            this.textObservacao.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textObservacao.SelectedText = "";
            this.textObservacao.SelectionLength = 0;
            this.textObservacao.SelectionStart = 0;
            this.textObservacao.ShortcutsEnabled = true;
            this.textObservacao.Size = new System.Drawing.Size(313, 23);
            this.textObservacao.Style = MetroFramework.MetroColorStyle.Brown;
            this.textObservacao.TabIndex = 14;
            this.textObservacao.UseSelectable = true;
            this.textObservacao.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textObservacao.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // labelContato
            // 
            this.labelContato.AutoSize = true;
            this.labelContato.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.labelContato.Location = new System.Drawing.Point(23, 84);
            this.labelContato.Name = "labelContato";
            this.labelContato.Size = new System.Drawing.Size(92, 25);
            this.labelContato.TabIndex = 21;
            this.labelContato.Text = "CONTATO:";
            // 
            // Btnbuscar
            // 
            this.Btnbuscar.Cursor = System.Windows.Forms.Cursors.Default;
            this.Btnbuscar.Location = new System.Drawing.Point(436, 136);
            this.Btnbuscar.Name = "Btnbuscar";
            this.Btnbuscar.Size = new System.Drawing.Size(126, 23);
            this.Btnbuscar.Style = MetroFramework.MetroColorStyle.Brown;
            this.Btnbuscar.TabIndex = 22;
            this.Btnbuscar.Text = "Buscar Contato";
            this.Btnbuscar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Btnbuscar.UseSelectable = true;
            this.Btnbuscar.UseStyleColors = true;
            this.Btnbuscar.Click += new System.EventHandler(this.Btnbuscar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pesquisarAtividadeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(676, 24);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pesquisarAtividadeToolStripMenuItem
            // 
            this.pesquisarAtividadeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.pesquisarAtividadeToolStripMenuItem.Name = "pesquisarAtividadeToolStripMenuItem";
            this.pesquisarAtividadeToolStripMenuItem.Size = new System.Drawing.Size(127, 20);
            this.pesquisarAtividadeToolStripMenuItem.Text = "Pesquisar Atividade";
            this.pesquisarAtividadeToolStripMenuItem.Click += new System.EventHandler(this.PesquisarAtividadeToolStripMenuItem_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnExcluir.Location = new System.Drawing.Point(436, 193);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(126, 23);
            this.btnExcluir.Style = MetroFramework.MetroColorStyle.Brown;
            this.btnExcluir.TabIndex = 24;
            this.btnExcluir.Text = "Excluir Atividade";
            this.btnExcluir.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnExcluir.UseSelectable = true;
            this.btnExcluir.UseStyleColors = true;
            this.btnExcluir.Visible = false;
            this.btnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // Atividades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 239);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.Btnbuscar);
            this.Controls.Add(this.labelContato);
            this.Controls.Add(this.textData);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.comboAtividade);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.textObservacao);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Atividades";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Brown;
            this.Text = "Atividades";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox textData;
        private MetroFramework.Controls.MetroButton btnCadastrar;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox comboAtividade;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox textObservacao;
        private MetroFramework.Controls.MetroLabel labelContato;
        private MetroFramework.Controls.MetroButton Btnbuscar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pesquisarAtividadeToolStripMenuItem;
        private MetroFramework.Controls.MetroButton btnExcluir;
    }
}