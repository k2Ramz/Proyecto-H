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
    public partial class fIngresar : Form
    {
        public fIngresar()
        {
            InitializeComponent();
        }

        private void tmIngresar_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("h:mm:ss");
            lblFecha.Text = DateTime.Now.ToShortDateString();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            this.Close();
            fMenuP ff = new fMenuP();
            ff.Show();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            fMenu ff = new fMenu();
            ff.Show();
        }
    }
}
