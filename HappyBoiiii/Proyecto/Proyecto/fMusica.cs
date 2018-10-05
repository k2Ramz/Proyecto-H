using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class fMusica : Form
    {
        int lol;
        public fMusica()
        {
            InitializeComponent();
        }

        private void picCancion1_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\Oscar\Desktop\Proyecto\1.wav");
            player.Stop();
            if (lol == 0)
            {
                player.Play();
                lol = 1;
                
            }
            else
            {
                player.Stop();
                lol = 0;
             
            }
        }

        private void picRegresar_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\Oscar\Desktop\Padajalo\1.wav");
            player.Stop();
            this.Close();
            fMenuP ff = new fMenuP();
            ff.Show();
        }

        private void picCancion2_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\Oscar\Desktop\Proyecto\2.wav");
            player.Stop();
            if (lol == 0)
            {
                player.Play();
                lol = 1;

            }
            else
            {
                player.Stop();
                lol = 0;

            }
        }

        private void picCancion3_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\Oscar\Desktop\Proyecto\3.wav");
            player.Stop();
            if (lol == 0)
            {
                player.Play();
                lol = 1;

            }
            else
            {
                player.Stop();
                lol = 0;

            }
        }

        private void picCancion4_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\Oscar\Desktop\Proyecto\4.wav");
            player.Stop();
            if (lol == 0)
            {
                player.Play();
                lol = 1;

            }
            else
            {
                player.Stop();
                lol = 0;

            }
        }

        private void picCancion5_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\Oscar\Desktop\Proyecto\5.wav");
            player.Stop();
            if (lol == 0)
            {
                player.Play();
                lol = 1;

            }
            else
            {
                player.Stop();
                lol = 0;

            }
        }

        private void picCancion6_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\Oscar\Desktop\Proyecto\6.wav");
            player.Stop();
            if (lol == 0)
            {
                player.Play();
                lol = 1;

            }
            else
            {
                player.Stop();
                lol = 0;

            }
        }
    }
}
