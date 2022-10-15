using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalTop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ecografie_abdominala a = new Ecografie_abdominala();
            a.Show();
        }

        private void Echo_Click(object sender, EventArgs e)
        {
            this.Hide();
            Echo_forrm b=new Echo_forrm();
            b.Show();

        }

        private void Ecografie_Tiroida_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ecografie_Tiroida a = new Ecografie_Tiroida();
            a.Show();
        }
    }
}
