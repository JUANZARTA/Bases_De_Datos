using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bases_de_datos___Proyecto_final_v1
{
    public partial class Advertencia : Form
    {
        public Advertencia()
        {
            InitializeComponent();
        }

        private void IconoCerrarAdv_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
