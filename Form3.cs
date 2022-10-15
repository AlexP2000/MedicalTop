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
    public partial class Echo_forrm : Form
    {
        public Echo_forrm()
        {
            InitializeComponent();
        }

        private void Echo_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void Genereaza_pdf_Click(object sender, EventArgs e)
        {
            Document doc = new Document(iTextSharp.text.PageSize.A4, 10, 10, 30, 30);
            PdfWriter pdf = PdfWriter.GetInstance(doc, new FileStream("arhiva Echo Doppler/Redenumiti acest fisier astfel incat sa il puteti indentifica.pdf", FileMode.Create));
            doc.Open();
            iTextSharp.text.Image png = iTextSharp.text.Image.GetInstance("banner.jpg");
            png.ScalePercent(50f);
            doc.Add(png);
            Paragraph pw = new Paragraph("   " + label1.Text + "                                                     " + textBox1.Text);

            doc.Add(pw);
            Paragraph pw1 = new Paragraph("   " + label2.Text + "                                                          " + textBox2.Text);

            doc.Add(pw1);
            Paragraph pw2 = new Paragraph("   " + label3.Text + "                                                                            " + textBox3.Text);

            doc.Add(pw2);
            Paragraph pw3 = new Paragraph("   " + label4.Text);

            doc.Add(pw3);
            Paragraph p = new Paragraph("            " + "ECHO DOPPLER CAROTIDIAN, VERTEBRAL");
            p.Font.SetStyle(1);
            p.Font.Size = 20;
            doc.Add(p);
            Paragraph ps4 = new Paragraph("                                     " + label6.Text + " " + Nr.Text + " " + label5.Text + " " + Data.Text);
            ps4.Font.SetStyle(1);
            ps4.Font.Size = 16;
            doc.Add(ps4);
            Paragraph ps5 = new Paragraph("            ");

            doc.Add(ps5);
            Paragraph p1 = new Paragraph("   " + label8.Text + "" + label9.Text + " " + textBox4.Text + " " + label10.Text + " " + textBox5.Text + " " + label11.Text + "                " + label73.Text + " " + label72.Text + " " + textBox31.Text + " " + label71.Text + " " + textBox30.Text + " " + label70.Text);

            doc.Add(p1);
            Paragraph p2 = new Paragraph("                " + label12.Text + " " + textBox6.Text + " " + label17.Text + "                                         " + label69.Text + " " + textBox29.Text + " " + label64.Text);

            doc.Add(p2);
            Paragraph p3 = new Paragraph("                " + label13.Text + " " + textBox7.Text + " " + label16.Text + "                                       " + label68.Text + " " + textBox28.Text + " " + label65.Text);

            doc.Add(p3);
            Paragraph p4 = new Paragraph("                " + label14.Text + " " + textBox8.Text + " " + label15.Text + "                                                         " + label67.Text + " " + textBox27.Text + " " + label66.Text);

            doc.Add(p4);
            Paragraph p5 = new Paragraph("   " + label18.Text + " " + label24.Text + " " + textBox11.Text + " " + label19.Text + "                              " + label63.Text + " " + label62.Text + " " + textBox26.Text + " " + label57.Text); 

            doc.Add(p5);
            Paragraph p6 = new Paragraph("              " + label23.Text + " " + textBox10.Text + " " + label20.Text + "                                        " + label61.Text + " " + textBox25.Text + " " + label58.Text);

            doc.Add(p6);
            Paragraph p7 = new Paragraph("              " + label22.Text + " " + textBox9.Text + " " + label21.Text + "                                                          " + label60.Text + " " + textBox24.Text + " " + label59.Text);

            doc.Add(p7);
            Paragraph p8 = new Paragraph("   " + label25.Text + " " + label27.Text + " " + textBox12.Text + " " + label26.Text + "                            " + label56.Text + " " + label55.Text + " " + textBox23.Text + " " + label54.Text); ;

            doc.Add(p8);
            Paragraph p9 = new Paragraph("    " + label28.Text + " " + label37.Text + " " + textBox17.Text + " " + label36.Text + "           " + label53.Text + " " + label52.Text + " " + textBox22.Text + " " + label51.Text);

            doc.Add(p9);
            Paragraph p10 = new Paragraph("             " + label34.Text + " " + textBox15.Text + " " + label29.Text + "                                           " + label50.Text + " " + textBox21.Text + " " + label45.Text);

            doc.Add(p10);
            Paragraph p11 = new Paragraph("             " + label33.Text + " " + textBox14.Text + " " + label30.Text + "                                         " + label49.Text + " " + textBox20.Text + " " + label46.Text);

            doc.Add(p11);
            Paragraph p12 = new Paragraph("             " + label32.Text + " " + textBox13.Text + " " + label31.Text + "                                                           " + label48.Text + " " + textBox19.Text + " " + label47.Text);

            doc.Add(p12);
            Paragraph ps7 = new Paragraph("            ");

            doc.Add(ps7);
            Paragraph p13 = new Paragraph("   " + label35.Text + " " + label39.Text + " " + textBox16.Text + " " + label38.Text + " " + " aspect " + label40.Text); 

            doc.Add(p13);
            
            Paragraph p16 = new Paragraph("   " + label44.Text + " " + label43.Text + " " + textBox18.Text + " " + label42.Text + " " + " aspect " + label41.Text);

            doc.Add(p16);
            

            Paragraph p15 = new Paragraph("   " + label74.Text + " " + Concluzii.Text); 

            doc.Add(p15);
            Paragraph ps6 = new Paragraph("            ");

            doc.Add(ps6);

            Paragraph p21 = new Paragraph("                                                                                                                       " + "Semnatura si parafa");

            doc.Add(p21);


            MessageBox.Show("Pdf creat cu succes");
            doc.Close();
        }
    }
}
