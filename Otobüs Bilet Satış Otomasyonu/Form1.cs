using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otobüs_Bilet_Satış_Otomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kaydetbtn_Click(object sender, EventArgs e)
        {
            OtobusBiletSatis.Items.Add("Bilet Bilgileri" + " - "  + neredencb.Text + " - " + nereyecb.Text + " - " + tarih.Text + " - " + saat.Text + " - " +  " - " + adsoyad.Text + " - " + telno.Text + " - " + tc.Text);
        }

        private void neredencb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            rotalbl.Text = neredencb.Text;
            neredencb.Text = nereyecb.Text;
            nereyecb.Text = rotalbl.Text;
        }
    }
}