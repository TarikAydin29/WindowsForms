using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormdanForm
{
    public partial class Form2 : Form
    {
        public Form2(Form1 f)
        {
            InitializeComponent();
            frm = f;
        }
        public Form1 frm;

   
        private void btnTamam_Click(object sender, EventArgs e)
        {
            if (cmbxRenkler.SelectedItem == "Mavi")
            {
                frm.BackColor = Color.Blue;
            }
            else if (cmbxRenkler.SelectedItem == "Yeşil")
            {
                frm.BackColor = Color.Green;
            }
            else if (cmbxRenkler.SelectedItem == "Siyah")
            {
                frm.BackColor = Color.Black;
            }
            else if (cmbxRenkler.SelectedItem == "Kırmızı")
            {
                frm.BackColor = Color.Red;
            }

            frm.Show();
            this.Hide();
        }
    }
}
