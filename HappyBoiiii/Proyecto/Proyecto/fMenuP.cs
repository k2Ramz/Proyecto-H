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
    public partial class fMenuP : Form
    {
        public fMenuP()
        {
            InitializeComponent();
            picMusica.Visible = true;
        }

        private void picMusica_Click(object sender, EventArgs e)
        {
            this.Close();
            fMusica ff = new fMusica();
            ff.Show();
        }

        private void fMenuP_Load(object sender, EventArgs e)
        {

        }

        private void picVideo_Click(object sender, EventArgs e)
        {
            this.Close();
            fVideos ff = new fVideos();
            ff.Show();
        }

        private void picLibros_Click(object sender, EventArgs e)
        {
            this.Close();
            fLibros ff = new fLibros();
            ff.Show();
        }

        private void picGaleria_Click(object sender, EventArgs e)
        {
            this.Close();
            fGaleria ff = new fGaleria();
            ff.Show();
        }

        private void tmMenuP_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("h:mm:ss");
            lblFecha.Text = DateTime.Now.ToShortDateString();
        }

        private void picRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            fIngresar ff = new fIngresar();
            ff.Show();
        }
    }
}
