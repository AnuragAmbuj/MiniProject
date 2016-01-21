using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;
using iTextSharp.text.pdf.parser;

namespace pan.pdfreader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            Document PdfDoc = new Document();
            PdfWriter pdfwriter=PdfWriter.GetInstance(PdfDoc,new FileStream("sample.pdf",FileMode.Create));
            PdfDoc.Open();
            PdfDoc.Add(new Paragraph("anurag ambush"));
            PdfDoc.NewPage();
            PdfDoc.Add(new Paragraph("hello world again"));
            PdfDoc.Close();
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            string filepath;
            dlg.Filter = "PDF Files(*.PDF)|*.PDF|All Files(*.*)|*.*";
            if(dlg.ShowDialog()==DialogResult.OK)
            {
                filepath = dlg.FileName.ToString();
            
            string strtext = string.Empty;
            try
            {
                PdfReader reader = new PdfReader(filepath);
                for(int page=1;page<=reader.NumberOfPages;page++)
                {
                    ITextExtractionStrategy its = new iTextSharp.text.pdf.parser.LocationTextExtractionStrategy();
                    String s = PdfTextExtractor.GetTextFromPage(reader, page, its);
                    s = Encoding.UTF8.GetString(ASCIIEncoding.Convert(Encoding.Default, Encoding.UTF8, Encoding.Default.GetBytes(s)));
                    strtext = strtext + s;
                    richTextBox1.Text = strtext;

                }
                reader.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
           }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }



        
    }
}
