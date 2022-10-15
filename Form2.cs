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
    public partial class Ecografie_abdominala : Form
    {
        public Ecografie_abdominala()
        {
            InitializeComponent();
        }

        private void Ecografie_abdominala_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void Genereaza_pdf_Click(object sender, EventArgs e)
        {
            Document doc = new Document(iTextSharp.text.PageSize.A4, 10, 10, 30, 30);
            PdfWriter pdf = PdfWriter.GetInstance(doc, new FileStream("arhiva Ecografie Abdominala/Redenumiti acest fisier astfel incat sa il puteti indentifica.pdf", FileMode.Create));
            doc.Open();
            iTextSharp.text.Image png = iTextSharp.text.Image.GetInstance("banner.jpg");
            png.ScalePercent(50f);
            doc.Add(png);
            Paragraph p = new Paragraph("                                                                                                    " + "ECOGRAFIE ABDOMINALA");
            p.Font.SetStyle(1);
            p.Font.SetStyle(2);
            p.Font.Size = 25;
            doc.Add(p);
            
            Paragraph p1 = new Paragraph("                                   "+ label2.Text + "   " + Nr.Text +"   "+ label3.Text + "   " + Pacient.Text + "   " + label4.Text + "   " + Data.Text);
            p1.Font.SetStyle(1);
            p1.Font.Size = 14;
            doc.Add(p1);
            Paragraph p2 = new Paragraph("   " + label5.Text + " " + Ficat_cu_ecostructura.Text);

            doc.Add(p2);
            Paragraph p3 = new Paragraph("   " + label6.Text + " " + Dadls.Text);

            doc.Add(p3);
            Paragraph p4 = new Paragraph("   " + label7.Text + " " + Dapld.Text);

            doc.Add(p4);
            Paragraph pws1 = new Paragraph("                                 ");

            doc.Add(pws1);
            Paragraph p5 = new Paragraph("   " + label.Text + " " + Colecist.Text);

            doc.Add(p5);
            Paragraph ps = new Paragraph("   " + label9.Text + " " + VP.Text);

            doc.Add(ps);
            Paragraph ps1 = new Paragraph("   " + label26.Text + " " + CBP.Text);

            doc.Add(ps1);
            Paragraph pws2 = new Paragraph("                                 ");

            doc.Add(pws2);

            Paragraph p6 = new Paragraph("   " + label8.Text + " " + Pancreas_cu_ecostructura.Text);

            doc.Add(p6);
            Paragraph p7 = new Paragraph("   " + label24.Text + " " + Dimensiuni1.Text);

            doc.Add(p7);
            Paragraph p8 = new Paragraph("   " + label13.Text + " " + Observatii1.Text);

            doc.Add(p8);
            Paragraph pws3 = new Paragraph("                                 ");

            doc.Add(pws3);
            Paragraph p9 = new Paragraph("   " + label14.Text + " " + Pereti_antrali.Text);

            doc.Add(p9);
            Paragraph p10 = new Paragraph("   " + label17.Text + " " + Observatii2.Text);

            doc.Add(p10);
            Paragraph pws4 = new Paragraph("                                 ");

            doc.Add(pws4);
            Paragraph p11 = new Paragraph("   " + label16.Text + " " + Vena_splenica_dimensiuni.Text);

            doc.Add(p11);
            Paragraph p12 = new Paragraph("   " + label19.Text + " " + Splina_dimensiuni.Text + " " + label38.Text + " " + Splina_ecostructura.SelectedItem);

            doc.Add(p12);
            Paragraph p13 = new Paragraph("   " + label20.Text + " " + Observatii3.Text);

            doc.Add(p13);
            Paragraph pws5 = new Paragraph("                                 ");

            doc.Add(pws5);
            Paragraph p14 = new Paragraph("   " + label22.Text + " " + Rinichi_drep_diametru.Text + " " + label34.Text + " " + Rinichi_drept_ip.Text + " " + label36.Text);

            doc.Add(p14);
            Paragraph p15 = new Paragraph("   " + label23.Text + " " + Observatii4.Text);

            doc.Add(p15);
            Paragraph pws6 = new Paragraph("                                 ");

            doc.Add(pws6);
            Paragraph p16 = new Paragraph("   " + label42.Text + " " + Rinichi_stang_diametru.Text + " " + label44.Text + " " + Rinichi_stang_ip.Text + " " + label43.Text);

            doc.Add(p16);
            Paragraph p17 = new Paragraph("   " + label25.Text + " " + Observatii5.Text);

            doc.Add(p17);
            Paragraph pws7 = new Paragraph("                                 ");

            doc.Add(pws7);
            Paragraph p18 = new Paragraph("   " + label35.Text + " " + UtersauProstata.Text);

            doc.Add(p18);
            Paragraph p19 = new Paragraph("   " + label31.Text + " " + Vezica_urinara_dimensiuni.Text + " " + label37.Text);

            doc.Add(p19);
            Paragraph ps2 = new Paragraph("   " + label10.Text + " " + Observatii6.Text);

            doc.Add(ps2);
            Paragraph pws8 = new Paragraph("                                 ");

            doc.Add(pws8);

            Paragraph p20 = new Paragraph("   " + label32.Text + " " + Concluzii.Text);

            doc.Add(p20);
            Paragraph ps3 = new Paragraph("   " + textBox4.Text + " " + textBox5.Text);

            doc.Add(ps3);
            Paragraph p21 = new Paragraph("                                                                                                                                      " + "Semnatura");

            doc.Add(p21);

            MessageBox.Show("Pdf creat cu succes");
            doc.Close();
        }
    }
}
