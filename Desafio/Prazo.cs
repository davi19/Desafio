using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Desafio.Model;
using MetroFramework;
using MetroFramework.Forms;

namespace Desafio
{
    public partial class Prazo : MetroForm
    {
        public Prazo()
        {
            InitializeComponent();
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            if (textDataFinal.Value < textDataInicial.Value)
            {
                MetroMessageBox.Show(this, "Favor selecionar uma data final maior que a data inicial ", "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Hand);
            }
            else
            {
                AuxiliadoresEdicao._DataInicial = textDataInicial.Value.ToString();
                AuxiliadoresEdicao._DataFinal = textDataFinal.Value.ToString();
                this.Hide();
            }

        }

    }
}
