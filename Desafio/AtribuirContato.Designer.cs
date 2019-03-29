namespace Desafio
{
    partial class AtribuirContato
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
            this.btnContato = new MetroFramework.Controls.MetroButton();
            this.labelContato = new MetroFramework.Controls.MetroLabel();
            this.labelUsuario = new MetroFramework.Controls.MetroLabel();
            this.btnUsuario = new MetroFramework.Controls.MetroButton();
            this.labelAtual = new MetroFramework.Controls.MetroLabel();
            this.btnAtribuir = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // btnContato
            // 
            this.btnContato.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnContato.Location = new System.Drawing.Point(651, 78);
            this.btnContato.Name = "btnContato";
            this.btnContato.Size = new System.Drawing.Size(126, 23);
            this.btnContato.Style = MetroFramework.MetroColorStyle.Brown;
            this.btnContato.TabIndex = 24;
            this.btnContato.Text = "Buscar Contato";
            this.btnContato.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnContato.UseSelectable = true;
            this.btnContato.UseStyleColors = true;
            this.btnContato.Click += new System.EventHandler(this.BtnContato_Click);
            // 
            // labelContato
            // 
            this.labelContato.AutoSize = true;
            this.labelContato.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.labelContato.Location = new System.Drawing.Point(23, 76);
            this.labelContato.Name = "labelContato";
            this.labelContato.Size = new System.Drawing.Size(92, 25);
            this.labelContato.TabIndex = 23;
            this.labelContato.Text = "CONTATO:";
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.labelUsuario.Location = new System.Drawing.Point(23, 168);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(144, 25);
            this.labelUsuario.TabIndex = 25;
            this.labelUsuario.Text = "USUARIO NOVO:";
            // 
            // btnUsuario
            // 
            this.btnUsuario.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnUsuario.Location = new System.Drawing.Point(651, 128);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(126, 23);
            this.btnUsuario.Style = MetroFramework.MetroColorStyle.Brown;
            this.btnUsuario.TabIndex = 26;
            this.btnUsuario.Text = "Buscar Usuário";
            this.btnUsuario.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnUsuario.UseSelectable = true;
            this.btnUsuario.UseStyleColors = true;
            this.btnUsuario.Click += new System.EventHandler(this.BtnUsuario_Click);
            // 
            // labelAtual
            // 
            this.labelAtual.AutoSize = true;
            this.labelAtual.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.labelAtual.Location = new System.Drawing.Point(23, 126);
            this.labelAtual.Name = "labelAtual";
            this.labelAtual.Size = new System.Drawing.Size(140, 25);
            this.labelAtual.TabIndex = 27;
            this.labelAtual.Text = "USUARIO ATUAL:";
            // 
            // btnAtribuir
            // 
            this.btnAtribuir.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAtribuir.Location = new System.Drawing.Point(651, 170);
            this.btnAtribuir.Name = "btnAtribuir";
            this.btnAtribuir.Size = new System.Drawing.Size(126, 23);
            this.btnAtribuir.Style = MetroFramework.MetroColorStyle.Brown;
            this.btnAtribuir.TabIndex = 28;
            this.btnAtribuir.Text = "Atribuir Novo Usuário";
            this.btnAtribuir.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnAtribuir.UseSelectable = true;
            this.btnAtribuir.UseStyleColors = true;
            this.btnAtribuir.Click += new System.EventHandler(this.BtnAtribuir_Click);
            // 
            // AtribuirContato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 267);
            this.Controls.Add(this.btnAtribuir);
            this.Controls.Add(this.labelAtual);
            this.Controls.Add(this.btnUsuario);
            this.Controls.Add(this.labelUsuario);
            this.Controls.Add(this.btnContato);
            this.Controls.Add(this.labelContato);
            this.MaximizeBox = false;
            this.Name = "AtribuirContato";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Brown;
            this.Text = "Atribuir Contato";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnContato;
        private MetroFramework.Controls.MetroLabel labelContato;
        private MetroFramework.Controls.MetroLabel labelUsuario;
        private MetroFramework.Controls.MetroButton btnUsuario;
        private MetroFramework.Controls.MetroLabel labelAtual;
        private MetroFramework.Controls.MetroButton btnAtribuir;
    }
}