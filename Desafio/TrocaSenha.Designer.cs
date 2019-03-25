namespace Desafio
{
    partial class TrocaSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrocaSenha));
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.btnAlterar = new MetroFramework.Controls.MetroButton();
            this.textSenha = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.textConfirmacaoSenha = new MetroFramework.Controls.MetroTextBox();
            this.labelUsuario = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(10, 141);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(79, 19);
            this.metroLabel3.TabIndex = 10;
            this.metroLabel3.Text = "Nova Senha";
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(228, 245);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(95, 23);
            this.btnAlterar.Style = MetroFramework.MetroColorStyle.Brown;
            this.btnAlterar.TabIndex = 2;
            this.btnAlterar.Text = "Alterar Senha";
            this.btnAlterar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnAlterar.UseSelectable = true;
            this.btnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // textSenha
            // 
            // 
            // 
            // 
            this.textSenha.CustomButton.Image = null;
            this.textSenha.CustomButton.Location = new System.Drawing.Point(291, 1);
            this.textSenha.CustomButton.Name = "";
            this.textSenha.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textSenha.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textSenha.CustomButton.TabIndex = 1;
            this.textSenha.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textSenha.CustomButton.UseSelectable = true;
            this.textSenha.CustomButton.Visible = false;
            this.textSenha.Lines = new string[0];
            this.textSenha.Location = new System.Drawing.Point(10, 163);
            this.textSenha.MaxLength = 32767;
            this.textSenha.Name = "textSenha";
            this.textSenha.PasswordChar = '*';
            this.textSenha.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textSenha.SelectedText = "";
            this.textSenha.SelectionLength = 0;
            this.textSenha.SelectionStart = 0;
            this.textSenha.ShortcutsEnabled = true;
            this.textSenha.Size = new System.Drawing.Size(313, 23);
            this.textSenha.Style = MetroFramework.MetroColorStyle.Brown;
            this.textSenha.TabIndex = 0;
            this.textSenha.UseSelectable = true;
            this.textSenha.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textSenha.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(10, 189);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(159, 19);
            this.metroLabel1.TabIndex = 12;
            this.metroLabel1.Text = "Confirmação Nova Senha";
            // 
            // textConfirmacaoSenha
            // 
            // 
            // 
            // 
            this.textConfirmacaoSenha.CustomButton.Image = null;
            this.textConfirmacaoSenha.CustomButton.Location = new System.Drawing.Point(291, 1);
            this.textConfirmacaoSenha.CustomButton.Name = "";
            this.textConfirmacaoSenha.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textConfirmacaoSenha.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textConfirmacaoSenha.CustomButton.TabIndex = 1;
            this.textConfirmacaoSenha.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textConfirmacaoSenha.CustomButton.UseSelectable = true;
            this.textConfirmacaoSenha.CustomButton.Visible = false;
            this.textConfirmacaoSenha.Lines = new string[0];
            this.textConfirmacaoSenha.Location = new System.Drawing.Point(10, 216);
            this.textConfirmacaoSenha.MaxLength = 32767;
            this.textConfirmacaoSenha.Name = "textConfirmacaoSenha";
            this.textConfirmacaoSenha.PasswordChar = '*';
            this.textConfirmacaoSenha.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textConfirmacaoSenha.SelectedText = "";
            this.textConfirmacaoSenha.SelectionLength = 0;
            this.textConfirmacaoSenha.SelectionStart = 0;
            this.textConfirmacaoSenha.ShortcutsEnabled = true;
            this.textConfirmacaoSenha.Size = new System.Drawing.Size(313, 23);
            this.textConfirmacaoSenha.Style = MetroFramework.MetroColorStyle.Brown;
            this.textConfirmacaoSenha.TabIndex = 1;
            this.textConfirmacaoSenha.UseSelectable = true;
            this.textConfirmacaoSenha.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textConfirmacaoSenha.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.labelUsuario.Location = new System.Drawing.Point(10, 88);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(68, 25);
            this.labelUsuario.Style = MetroFramework.MetroColorStyle.Brown;
            this.labelUsuario.TabIndex = 13;
            this.labelUsuario.Text = "usuario";
            this.labelUsuario.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // TrocaSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 300);
            this.Controls.Add(this.labelUsuario);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.textConfirmacaoSenha);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.textSenha);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TrocaSenha";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Brown;
            this.Text = "Alteração de Senha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton btnAlterar;
        private MetroFramework.Controls.MetroTextBox textSenha;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox textConfirmacaoSenha;
        private MetroFramework.Controls.MetroLabel labelUsuario;
    }
}