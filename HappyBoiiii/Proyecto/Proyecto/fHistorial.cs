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
    public partial class fHistorial : Form
    {
        public fHistorial()
        {
            InitializeComponent();
        }

        private void picRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            fMenu ff = new fMenu();
            ff.Show();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            this.Close();
            fHistorialD ff = new fHistorialD();
            ff.Show();
        }
    }
}
