using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;

using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Desafio.Query;
using iTextSharp.text;
using iTextSharp.text.pdf;
using MetroFramework;
using MetroFramework.Forms;
using Image = iTextSharp.text.Image;

namespace Desafio
{
    public partial class FunilVendas : MetroForm
    {
        public FunilVendas()
        {
            InitializeComponent();
            QueryMysql validaDados = new QueryMysql();
            var funil = validaDados.RetornaFunilVendas();

            
            string[] x = (from p in funil.AsEnumerable()
                orderby p.Field<string>("status") ascending
                select p.Field<string>("status")).ToArray();

            int[] y = new int[funil.Rows.Count];
            for (int i = 0; i < funil.Rows.Count; i++)
            {
              y[i] =  Convert.ToInt32(funil.Rows[i]["quantidade"]);
            }

            grafico.Series[0].ChartType = SeriesChartType.Pie;
            grafico.Series[0].Points.DataBindXY(x, y);
            grafico.Legends[0].Enabled = true;
            grafico.ChartAreas[0].Area3DStyle.Enable3D = true;
            grafico.Series[0].IsValueShownAsLabel = true;

        }

        private void BtnGerar_Click(object sender, EventArgs e)
        {
            grafico.SaveImage(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)+ @"\temp.jpg",ChartImageFormat.Jpeg);
            Document documento = new Document(PageSize.A4, 10f, 10f, 10f, 0f);

            PdfWriter wri = PdfWriter.GetInstance(documento, new FileStream(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"\Funil de vendas.pdf", FileMode.Create));
            documento.Open();

            documento.Add(new Paragraph("\n"));
            documento.Add(new Paragraph("\n"));


            Paragraph Ph = new Paragraph("Funil de Vendas ");
            Ph.Alignment = Element.ALIGN_CENTER;
            Ph.Font.SetStyle(1);
            Ph.Font.Size = 20;
            documento.Add(Ph);
            Paragraph hora = new Paragraph(DateTime.Now.ToString());
            hora.Alignment = Element.ALIGN_RIGHT;
            documento.Add(hora);

            documento.Add(new Paragraph("\n"));
            Image logo = Image.GetInstance(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)+@"\temp.jpg");
            logo.Alignment = Element.ALIGN_CENTER;
            logo.ScalePercent(80);
            
           documento.Add(logo);
           documento.Close();

           File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"\temp.jpg");
           MetroMessageBox.Show(this, "Relatório gerado com sucesso. Ele foi salvo em sua Área de Trabalho", "Atenção", MessageBoxButtons.OK,
               MessageBoxIcon.Information);
           System.Diagnostics.Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory));
        }
    }
}
