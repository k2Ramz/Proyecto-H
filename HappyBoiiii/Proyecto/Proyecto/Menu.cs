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
    public partial class fMenu : Form
    {
        public fMenu()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            this.Close();
            fIngresar ff = new fIngresar();
            ff.Show();
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            this.Close();
            fHistorial ff = new fHistorial();
            ff.Show();
        }

        private void tmMenu_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("h:mm:ss");
            lblFecha.Text = DateTime.Now.ToShortDateString();
        }
    }
}
