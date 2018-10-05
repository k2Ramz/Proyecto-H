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
    public partial class fGaleria : Form
    {
        int uwu;
        public fGaleria()
        {
            InitializeComponent();
        }

        private void btnAleatorio_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            uwu = random.Next(1, 13);

            switch (uwu)
            {
                case 1:
                    picGaleria.ImageLocation = @"C:\Users\Oscar\Desktop\Proyecto\1.jpg";
                    break;
                case 2:
                    picGaleria.ImageLocation = @"C:\Users\Oscar\Desktop\Proyecto\2.jpg";
                    break;
                case 3:
                    picGaleria.ImageLocation = @"C:\Users\Oscar\Desktop\Proyecto\3.png";
                    break;
                case 4:
                    picGaleria.ImageLocation = @"C:\Users\Oscar\Desktop\Proyecto\4.jpg";
                    break;
                case 5:
                    picGaleria.ImageLocation = @"C:\Users\Oscar\Desktop\Proyecto\5.jpg";
                    break;
                case 6:
                    picGaleria.ImageLocation = @"C:\Users\Oscar\Desktop\Proyecto\6.png";
                    break;
                case 7:
                    picGaleria.ImageLocation = @"C:\Users\Oscar\Desktop\Proyecto\7.jpg";
                    break;
                case 8:
                    picGaleria.ImageLocation = @"C:\Users\Oscar\Desktop\Proyecto\8.gif";
                    break;
                case 9:
                    picGaleria.ImageLocation = @"C:\Users\Oscar\Desktop\Proyecto\9.jpg";
                    break;
                case 10:
                    picGaleria.ImageLocation = @"C:\Users\Oscar\Desktop\Proyecto\10.jpg";
                    break;
                case 11:
                    picGaleria.ImageLocation = @"C:\Users\Oscar\Desktop\Proyecto\11.jpg";
                    break;
                case 12:
                    picGaleria.ImageLocation = @"C:\Users\Oscar\Desktop\Proyecto\12.jpg";
                    break;
            }
        }

        private void picRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            fMenuP ff = new fMenuP();
            ff.Show();
        }

        private void picGaleria_Click(object sender, EventArgs e)
        {

        }
    }
}
