using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtYarisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBasla_Click(object sender, EventArgs e)
        {
            tmrYairs.Start();
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\Tarık\Desktop\atYarisi.wav");
            player.Play();
        }

            Random rnd = new Random();

        private void tmrYairs_Tick(object sender, EventArgs e)
        {
           

            int hiz= rnd.Next(10, 50);
            int hiz1= rnd.Next(10, 50);
            int hiz2= rnd.Next(10, 50);

            pictureBox1.Left+=hiz;
            pictureBox2.Left+=hiz1;
            pictureBox3.Left+=hiz2;

            if (pictureBox1.Left + 70 >= label1.Left)
            {
                tmrYairs.Stop();
                DialogResult dr = MessageBox.Show("1. at kazandı\r Tekrar oynamak ister misiniz ?", "Kazanan",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (dr == DialogResult.No)
                {
                    Application.Exit();
                }
                else
                {
                    pictureBox1.Left = 10;
                    pictureBox2.Left = 10;
                    pictureBox3.Left = 10;
                }
            }


            else if(pictureBox2.Left + 70 >= label1.Left)
            {
                tmrYairs.Stop();
                DialogResult dr = MessageBox.Show("2. at kazandı\r Tekrar oynamak ister misiniz ?", "Kazanan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.No)
                {
                    Application.Exit();
                }
                else
                {
                    pictureBox1.Left = 10;
                    pictureBox2.Left = 10;
                    pictureBox3.Left = 10;
                }
            }


            else if (pictureBox3.Left + 70 >= label1.Left)
            {
                tmrYairs.Stop();
                DialogResult dr = MessageBox.Show("3. at kazandı\r Tekrar oynamak ister misiniz ?", "Kazanan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.No)
                {
                    Application.Exit();
                }
                else
                {
                    pictureBox1.Left = 10;
                    pictureBox2.Left = 10;
                    pictureBox3.Left = 10;
                }
            }


        }

        //Timer Başladığı zaman atlar rastgele bir sayıya göre hareket edecek.
        //picturebox ın sağının  konumu label ın solunun konumuna değdiği anda oyun bitecek.
        //oyun bitişinde 1.,2.,3. at kazandı yazısını ekrana gösterecek.

    }
}
