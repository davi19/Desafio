namespace Desafio
{
    partial class Prazo
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
            this.btnCadastrar = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.textDataInicial = new MetroFramework.Controls.MetroDateTime();
            this.textDataFinal = new MetroFramework.Controls.MetroDateTime();
            this.SuspendLayout();
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCadastrar.Location = new System.Drawing.Point(270, 113);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(126, 23);
            this.btnCadastrar.Style = MetroFramework.MetroColorStyle.Brown;
            this.btnCadastrar.TabIndex = 2;
            this.btnCadastrar.Text = "Gerar Relatório";
            this.btnCadastrar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnCadastrar.UseSelectable = true;
            this.btnCadastrar.UseStyleColors = true;
            this.btnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 53);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(72, 19);
            this.metroLabel3.TabIndex = 16;
            this.metroLabel3.Text = "Data Inicial";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(169, 53);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(67, 19);
            this.metroLabel1.TabIndex = 19;
            this.metroLabel1.Text = "Data Final";
            // 
            // textDataInicial
            // 
            this.textDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.textDataInicial.Location = new System.Drawing.Point(23, 75);
            this.textDataInicial.MinimumSize = new System.Drawing.Size(0, 29);
            this.textDataInicial.Name = "textDataInicial";
            this.textDataInicial.Size = new System.Drawing.Size(140, 29);
            this.textDataInicial.TabIndex = 20;
            // 
            // textDataFinal
            // 
            this.textDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.textDataFinal.Location = new System.Drawing.Point(169, 75);
            this.textDataFinal.MinimumSize = new System.Drawing.Size(0, 29);
            this.textDataFinal.Name = "textDataFinal";
            this.textDataFinal.Size = new System.Drawing.Size(138, 29);
            this.textDataFinal.TabIndex = 21;
            // 
            // Prazo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 159);
            this.Controls.Add(this.textDataFinal);
            this.Controls.Add(this.textDataInicial);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.metroLabel3);
            this.MaximizeBox = false;
            this.Name = "Prazo";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Brown;
            this.Text = "Prazo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton btnCadastrar;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroDateTime textDataInicial;
        private MetroFramework.Controls.MetroDateTime textDataFinal;
    }
}