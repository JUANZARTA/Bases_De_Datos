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
    public partial class Consultar : Form
    {
        public Consultar()
        {
            InitializeComponent();
        }
        Empresa empresa = new Empresa();
        Portatil portatil = new Portatil();
        private void btnConsultarPortatil_Click_1(object sender, EventArgs e)
        {
            DataSet dsResultado = new DataSet();
            dsResultado = portatil.consultarPortatil();
            dgvConsultarEmpresa.DataSource = dsResultado;
            dgvConsultarEmpresa.DataMember = "ResultadoDatos";
        }

        private void btnBuscarPortatilNit_Click(object sender, EventArgs e)
        {
            DataSet miDS = new DataSet();
            int empresaNit;
            empresaNit = int.Parse(txtEmpresaNit.Text);
            miDS = portatil.consultarPortatil(empresaNit);
            
            if (miDS.Tables[0].Rows.Count > 0)
            {
                dgvConsultarEmpresa.DataSource = miDS;
                dgvConsultarEmpresa.DataMember = "ResultadoDatos";
            }
            else
            {
                MessageBox.Show("Empresa no encontrada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
