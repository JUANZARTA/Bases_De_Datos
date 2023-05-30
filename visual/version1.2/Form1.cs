using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Bases_de_datos___Proyecto_final_v1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Movimiento de app
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        #endregion

        #region Iconos
        private void IconMenu_Click(object sender, EventArgs e)
        {
            if (panelLateral.Width == 200)
            {
                panelLateral.Width = 40;
            }
            else
                panelLateral.Width = 200;
        }
        private void IconoCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void IconoMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            IconoRestaurar.Visible = true;
            IconoMaximizar.Visible = false;
        }
        private void IconoRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            IconoMaximizar.Visible = true;
            IconoRestaurar.Visible = false;
        }
        private void IconoMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void IconoEmpresa_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new RegEmpresa());
        }
        private void IconoPortatil_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new RegPortatil());
        }
        private void IconoBuscar_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Consultar());
        }
        #endregion

        #region Botones de Menu
        private void PanelSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012,0);
        }
        private void AbrirFormInPanel(object FormHijo) 
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = FormHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }
        private void registrarEmp_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new RegEmpresa());
        }
        private void btnRegistrarPor_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new RegPortatil());
        }
        private void btnConsultarPor_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Consultar());
        }
        private void timerFecha_Tick(object sender, EventArgs e)
        {
           labelHora.Text = DateTime.Now.ToString("HH:mm:ss");
           labelFecha.Text = DateTime.Now.ToString("dddd : MMMM : yyyy");
        }

    
    }
        #endregion
}
