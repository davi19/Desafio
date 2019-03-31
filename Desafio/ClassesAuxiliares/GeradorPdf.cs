using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Desafio.ClassesAuxiliares
{
    class GeradorPdf
    {
        public static void GerarPdf(string titulo, int colunas, DataTable dados,List<string> cabecalho)
        {
            Document documento = new Document(PageSize.A4, 10f, 10f, 10f, 0f);

            PdfWriter wri = PdfWriter.GetInstance(documento, new FileStream(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"\Relatório "+titulo+".pdf", FileMode.Create));
            documento.Open();

            documento.Add(new Paragraph("\n"));
            documento.Add(new Paragraph("\n"));


            Paragraph Ph = new Paragraph("Relatório "+titulo);
            Ph.Alignment = Element.ALIGN_CENTER;
            Ph.Font.SetStyle(1);
            Ph.Font.Size = 20;
            documento.Add(Ph);
            Paragraph hora = new Paragraph(DateTime.Now.ToString());
            hora.Alignment = Element.ALIGN_RIGHT;
            documento.Add(hora);

            documento.Add(new Paragraph("\n"));

            PdfPTable tabela = new PdfPTable(colunas);

            BaseFont fonteheader = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1250, false);
            Font bold = new Font(fonteheader, 12, iTextSharp.text.Font.BOLD);
            foreach (var palavra in cabecalho)
            {
                PdfPCell celulaHeaderContato = new PdfPCell(new Phrase(palavra, bold));
                celulaHeaderContato.BackgroundColor = BaseColor.LIGHT_GRAY;

                tabela.AddCell(celulaHeaderContato);
            }

            for(int i =0;i < dados.Rows.Count;i++)
            {
                for (int j = 0; j < dados.Columns.Count; j++)
                {
                    tabela.AddCell(dados.Rows[i][j].ToString());
                }
            }
            
            documento.Add(tabela);
            documento.Close();

        }
    }
}
