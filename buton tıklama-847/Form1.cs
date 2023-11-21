using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace buton_tıklama_847
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            bool durum = false;
            int sayac = 0;

            for (int  i= 0; i < lbAdlar.Items.Count; i++)
            {
                string aranan = lbAdlar.Items[i].ToString();
                if (aranan == txtAranan.Text)
                {
                    durum = true;
                    sayac++;
                }
            }
            if (durum)
            {
                lblSonuc.Text = "aradığınız kişiden" + sayac + " tane var.";
            }
            else
            {
                lblSonuc.Text = "aradığınız kişi yok.";
            }
        }   
    }
}
