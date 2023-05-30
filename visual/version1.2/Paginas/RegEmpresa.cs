using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bases_de_datos___Proyecto_final_v1.logica;

namespace Bases_de_datos___Proyecto_final_v1
{
    public partial class RegEmpresa : Form
    {
        public RegEmpresa()
        {
            InitializeComponent();
        }
        Empresa empresa = new Empresa();
        private void btnGuardar_1_Click(object sender, EventArgs e)
        {
            //GUARDAR VARUABLES
            int empresanit,r;
            string empresanombre, empresafechacreacion;
            empresanit = int.Parse(txtempresaNit.Text);
            empresanombre = txtempresaNombre.Text;
            empresafechacreacion = txtFechaCreacion.Text;
            r = empresa.ingresarEmpresa(empresanit, empresanombre, empresafechacreacion);
            if (r > 0)
            {
                MessageBox.Show("Empresa registrada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Empresa no registrada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

     
    }
}
