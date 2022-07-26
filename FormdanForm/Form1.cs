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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRenk_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2(this);
            frm.Show();
            this.Hide();

            //frm.ShowDialog(); form2 açılınca form1 e tıklayamıyoruz.
        }
        //İlk formda bir buton olsun. Tıkladığımda ikinci form açılsın.
        //ikinci formda combobox ile renk seçeyim(4-5 tane atsak yeter cbx içine)
        //2. formda tamam tuşuna bastığımda 1. formun arkaplan rengi 2. formdan seçtiğim renk olsun.
    }
}
