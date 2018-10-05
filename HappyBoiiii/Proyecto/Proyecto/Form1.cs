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
    public partial class fCarga : Form
    {
        public fCarga()
        {
            InitializeComponent();
        }

        private void fCarga_Load(object sender, EventArgs e)
        {
            
        }
        public void fn_prba_()
        {
            pgCarga.Increment(1);
            lblCarga.Text = pgCarga.Value.ToString() + "%";
            if(pgCarga.Value == pgCarga.Maximum)
            {
                tmCarga.Stop();
                this.Hide();
                fMenu ff = new fMenu();
                ff.Show();
            }
        }

        private void tmCarga_Tick(object sender, EventArgs e)
        {
            fn_prba_();
        }
    }
}
