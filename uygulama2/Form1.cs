using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uygulama2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblTaksitTutari.Text = tbTaksitSayi.Text;
        }

        private void tbTaksitSayi_Scroll(object sender, EventArgs e)
        {
            lblTaksitTutari.Text = tbTaksitSayi.Value.ToString();

            double toplam = Convert.ToDouble(txtAdet.Text) * Convert.ToDouble(txtBirimFiyati);
            double taksit = toplam / tbTaksitSayi.Value;
            lblTaksitTutari.Text = taksit.ToString();
        }
    }
}
