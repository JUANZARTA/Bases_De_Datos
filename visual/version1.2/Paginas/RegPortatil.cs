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
    public partial class RegPortatil : Form
    {
        public RegPortatil()
        {
            InitializeComponent();
        }
         Portatil portatil = new Portatil();
        private void btnGuardar_2_Click(object sender, EventArgs e)
        {
            //GUARDAR VARUABLES
            int portatilcapacidaddiscoduro,portatilcapacidadmemoriaram, empresanit, r;
            string portatilmarca, portatilserial, portatilfechaensamblaje, portatiltipodiscoduro;
            portatilserial = txtSerial.Text;
            portatilmarca = comboBoxMarca.SelectedItem.ToString();
            portatilcapacidaddiscoduro =int.Parse( txtMemoria.Text);
            portatilcapacidadmemoriaram = int.Parse(txtRam.Text);
            portatilfechaensamblaje = txtFechaEnsamblaje.Text;
            portatiltipodiscoduro = txtTipoDisco.Text;
            empresanit = int.Parse(txtNitEmpresa.Text);
            r = portatil.ingresarPortatil(portatilserial, portatilmarca, portatilcapacidaddiscoduro, portatilcapacidadmemoriaram, portatilfechaensamblaje, portatiltipodiscoduro, empresanit);
            if (r > 0)
            {
                MessageBox.Show("Portatil registrada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Portatil no registrada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
