using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //4 tane seçenek (küçük harf-büyük harf-sayı-özel karakter)
        //seçili olan seçenekler şifre uzunluğu ve şifre sayısına göre rastgele şifre oluşturup text box a yazdırın.


        //List<string> sifreler = new List<string>();
        bool kucukHarfVarMi, buyukHarfVarMi, rakamVarMi, ozelKarakterVarMi;
        int sifreUzunlugu = 0, sifreSayisi = 0;
        Random rnd = new Random();



        private void btnUret_Click_1(object sender, EventArgs e)
        {
            kucukHarfVarMi = chkKucukHarf.Checked;
            buyukHarfVarMi = chkBuyukHarf.Checked;
            rakamVarMi = chkSayi.Checked;
            ozelKarakterVarMi = chkOzelKarakter.Checked;
            sifreUzunlugu = (int)nudSifreUzunluğu.Value;
            sifreSayisi = (int)nudSifreSayisi.Value;
            txtSifreler.Text = "";

            if (!(kucukHarfVarMi || buyukHarfVarMi || rakamVarMi || ozelKarakterVarMi))
            {
                MessageBox.Show("Lütfen Bir Parametre Seçiniz");
                return;
            }

            string secilenKarakterler = "";
            if (ozelKarakterVarMi)
            {
                for (int i = 33; i < 48; i++)
                {
                    secilenKarakterler += Convert.ToChar(i);
                }
                for (int i = 58; i < 65; i++)
                {
                    secilenKarakterler += Convert.ToChar(i);
                }
                for (int i = 91; i < 97; i++)
                {
                    secilenKarakterler += Convert.ToChar(i);
                }
                for (int i = 123; i < 127; i++)
                {
                    secilenKarakterler += Convert.ToChar(i);
                }
            }
            if (rakamVarMi)
            {
                for (int i = 48; i < 58; i++)
                {
                    secilenKarakterler += Convert.ToChar(i);
                }
            }
            if (buyukHarfVarMi)
            {
                for (int i = 65; i < 90; i++)
                {
                    secilenKarakterler += Convert.ToChar(i);
                }
            }
            if (kucukHarfVarMi)
            {
                for (int i = 97; i < 123; i++)
                {
                    secilenKarakterler += Convert.ToChar(i);
                }
            }

            for (int i = 0; i < sifreSayisi; i++)
            {
                string sifre = "";

                while ((chkBuyukHarf.Checked  && !sifre.Any(char.IsUpper)) || (chkKucukHarf.Checked && !sifre.Any(char.IsLower)) || (chkSayi.Checked && !sifre.Any(char.IsDigit)) || (chkOzelKarakter.Checked && sifre.All(char.IsLetterOrDigit)))
                {
                    if (sifreUzunlugu < 4)
                    {
                        return;
                    }
                    sifre = "";
                    for (int j = 0; j < sifreUzunlugu; j++)
                    {
                        sifre += secilenKarakterler[rnd.Next(secilenKarakterler.Length)];
                    }
                }




                //string sifre;
                //do
                //{
                //    sifre = "";
                //    for (int j = 0; j < sifreUzunlugu; j++)
                //    {
                //        sifre += secilenKarakterler[rnd.Next(secilenKarakterler.Length)];
                //    }

                //} while ((chkBuyukHarf.Checked && !sifre.Any(char.IsUpper)) || (chkKucukHarf.Checked && !sifre.Any(char.IsLower)) || (chkSayi.Checked && !sifre.Any(char.IsDigit)) || (chkOzelKarakter.Checked && sifre.All(char.IsLetterOrDigit)));




                txtSifreler.Text += sifre;
                txtSifreler.Text += "\r\n\r\n";
            }
        }
    }
}
