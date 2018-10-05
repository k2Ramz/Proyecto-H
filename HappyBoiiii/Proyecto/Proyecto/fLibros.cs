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
    public partial class fLibros : Form
    {
        public fLibros()
        {
            InitializeComponent();
        }

        private void picRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            fMenuP ff = new fMenuP();
            ff.Show();
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void fLibros_Load(object sender, EventArgs e)
        {
            axAcroPDF1.src = "C:/Users/omar/Downloads/HappyBoiiii-master/Proyecto/Proyecto/Cuentos/elreyleon.pdf";
            axAcroPDF2.src = "C:/Users/omar/Downloads/HappyBoiiii-master/Proyecto/Proyecto/Cuentos/elzorroyeltigre.pdf";
            axAcroPDF3.src = "C:/Users/omar/Downloads/HappyBoiiii-master/Proyecto/Proyecto/Cuentos/lasirenita.pdf";

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            axAcroPDF4.src = openFileDialog1.FileName;
        }
    }
}
