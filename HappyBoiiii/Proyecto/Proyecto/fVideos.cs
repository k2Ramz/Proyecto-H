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
    public partial class fVideos : Form
    {
        public fVideos()
        {
            InitializeComponent();
            WMP.URL = @"C:\Users\Oscar\Desktop\Padajalo\1.mp4 ";
            WMP.Ctlcontrols.play();
        }

        private void fVideos_Load(object sender, EventArgs e)
        {

        }

        private void picRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            fMenuP ff = new fMenuP();
            ff.Show();
        }
    }
}
