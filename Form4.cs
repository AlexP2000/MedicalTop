using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
namespace MedicalTop
{
    public partial class Ecografie_Tiroida : Form
    {
        public Ecografie_Tiroida()
        {
            InitializeComponent();
        }

        private void Genereaza_pdf_Click(object sender, EventArgs e)
        {
            Document doc = new Document(iTextSharp.text.PageSize.A4, 10, 10, 30, 30);
            PdfWriter pdf = PdfWriter.GetInstance(doc, new FileStream("arhiva Ecografie Tiroida/Redenumiti acest fisier astfel incat sa il puteti indentifica.pdf", FileMode.Create));
            doc.Open();
            iTextSharp.text.Image png = iTextSharp.text.Image.GetInstance("banner.jpg");
            png.ScalePercent(50f);
            doc.Add(png);
            Paragraph a = new Paragraph("                    " + label1.Text);
            a.Font.SetStyle(1);
            a.Font.Size = 25;
            doc.Add(a);
            Paragraph b = new Paragraph("                                             "+ label2.Text + Nr.Text+ "   " + label3.Text + "   " + textBox2.Text + "   " + label4.Text + "   " + textBox3.Text);
            b.Font.SetStyle(1);
            doc.Add(b);
            Paragraph c = new Paragraph("                                             " + " Tiroida:");
            c.Font.SetStyle(1);
            doc.Add(c);
            Paragraph p20 = new Paragraph("                                              " + label6.Text + " " + textBox4.Text);

            doc.Add(p20);
            Paragraph p21 = new Paragraph("                                              " + label8.Text + "    " + label7.Text + " " + textBox5.Text + " " + label9.Text);

            doc.Add(p21);
            Paragraph p22 = new Paragraph("                                              " + label10.Text + " " + textBox1.Text);

            doc.Add(p22);
            Paragraph p23 = new Paragraph("                                              " + label14.Text + " " + label13.Text + " " + textBox6.Text + " " + label12.Text);

            doc.Add(p23);
            Paragraph p24 = new Paragraph("                                              " + label11.Text + " " + textBox8.Text);

            doc.Add(p24);
            Paragraph p25 = new Paragraph("                                              " + label18.Text + "    " + label17.Text + " " + textBox7.Text + " " + label16.Text);

            doc.Add(p25);
            Paragraph p26 = new Paragraph("                                              " + label15.Text + " " + textBox9.Text);

            doc.Add(p26);
            Paragraph ps1 = new Paragraph("                                                                                                                       ");

            doc.Add(ps1);
            Paragraph p27 = new Paragraph("                                                                                                                       " + "Semnatura si parafa");

            doc.Add(p27);
            Paragraph p28 = new Paragraph("                                                                                                                       ");

            doc.Add(p28);
            Paragraph p29 = new Paragraph("                                                                                                                       ");

            doc.Add(p29);
            Paragraph p30 = new Paragraph("                                                                                                                       ");

            doc.Add(p30);
            
            
            MessageBox.Show("Pdf creat cu succes");
            doc.Close();
        }
    }
}
