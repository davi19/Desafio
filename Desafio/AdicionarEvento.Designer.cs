namespace Desafio
{
    partial class AdicionarEvento
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
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.textDescricao = new MetroFramework.Controls.MetroTextBox();
            this.comboPrioridade = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.btnCadastrar = new MetroFramework.Controls.MetroButton();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.textHora = new System.Windows.Forms.MaskedTextBox();
            this.textData = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 60);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(65, 19);
            this.metroLabel2.TabIndex = 8;
            this.metroLabel2.Text = "Descrição";
            // 
            // textDescricao
            // 
            this.textDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.textDescricao.CustomButton.Image = null;
            this.textDescricao.CustomButton.Location = new System.Drawing.Point(291, 1);
            this.textDescricao.CustomButton.Name = "";
            this.textDescricao.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textDescricao.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textDescricao.CustomButton.TabIndex = 1;
            this.textDescricao.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textDescricao.CustomButton.UseSelectable = true;
            this.textDescricao.CustomButton.Visible = false;
            this.textDescricao.Lines = new string[0];
            this.textDescricao.Location = new System.Drawing.Point(23, 82);
            this.textDescricao.MaxLength = 32767;
            this.textDescricao.Name = "textDescricao";
            this.textDescricao.PasswordChar = '\0';
            this.textDescricao.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textDescricao.SelectedText = "";
            this.textDescricao.SelectionLength = 0;
            this.textDescricao.SelectionStart = 0;
            this.textDescricao.ShortcutsEnabled = true;
            this.textDescricao.Size = new System.Drawing.Size(313, 23);
            this.textDescricao.Style = MetroFramework.MetroColorStyle.Brown;
            this.textDescricao.TabIndex = 0;
            this.textDescricao.UseSelectable = true;
            this.textDescricao.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textDescricao.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // comboPrioridade
            // 
            this.comboPrioridade.FormattingEnabled = true;
            this.comboPrioridade.ItemHeight = 23;
            this.comboPrioridade.Items.AddRange(new object[] {
            "Urgente",
            "Pouco Urgente",
            "Normal",
            "Sem Urgência"});
            this.comboPrioridade.Location = new System.Drawing.Point(23, 136);
            this.comboPrioridade.Name = "comboPrioridade";
            this.comboPrioridade.Size = new System.Drawing.Size(313, 29);
            this.comboPrioridade.Style = MetroFramework.MetroColorStyle.Brown;
            this.comboPrioridade.TabIndex = 3;
            this.comboPrioridade.UseSelectable = true;
            this.comboPrioridade.UseStyleColors = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 114);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(71, 19);
            this.metroLabel1.TabIndex = 10;
            this.metroLabel1.Text = "Prioridade";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(342, 60);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(36, 19);
            this.metroLabel3.TabIndex = 13;
            this.metroLabel3.Text = "Data";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCadastrar.Location = new System.Drawing.Point(444, 142);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(126, 23);
            this.btnCadastrar.Style = MetroFramework.MetroColorStyle.Brown;
            this.btnCadastrar.TabIndex = 4;
            this.btnCadastrar.Text = "Cadastrar Evento";
            this.btnCadastrar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnCadastrar.UseSelectable = true;
            this.btnCadastrar.UseStyleColors = true;
            this.btnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(459, 60);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(38, 19);
            this.metroLabel4.TabIndex = 16;
            this.metroLabel4.Text = "Hora";
            // 
            // textHora
            // 
            this.textHora.Location = new System.Drawing.Point(459, 82);
            this.textHora.Mask = "00:00";
            this.textHora.Name = "textHora";
            this.textHora.Size = new System.Drawing.Size(111, 20);
            this.textHora.TabIndex = 2;
            // 
            // textData
            // 
            this.textData.Location = new System.Drawing.Point(342, 82);
            this.textData.Mask = "00/00/0000";
            this.textData.Name = "textData";
            this.textData.Size = new System.Drawing.Size(111, 20);
            this.textData.TabIndex = 1;
            this.textData.ValidatingType = typeof(System.DateTime);
            // 
            // AdicionarEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 193);
            this.Controls.Add(this.textData);
            this.Controls.Add(this.textHora);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.comboPrioridade);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.textDescricao);
            this.MaximizeBox = false;
            this.Name = "AdicionarEvento";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Brown;
            this.Text = "Adicionar Evento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox textDescricao;
        private MetroFramework.Controls.MetroComboBox comboPrioridade;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton btnCadastrar;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.MaskedTextBox textHora;
        private System.Windows.Forms.MaskedTextBox textData;
    }
}