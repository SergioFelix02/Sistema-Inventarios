using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Inventarios
{
    public partial class ventanaPrincipal : Form
    {
        public ventanaPrincipal()
        {
            InitializeComponent();
        } 
         
        private void datosDeLaEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            forms.datosEmpresa datos_Empresa = new forms.datosEmpresa();
            datos_Empresa.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void facturacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFacturas frmFacturas = new frmFacturas();
            frmFacturas.ShowDialog();
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            forms.frmClientes frmClientes = new forms.frmClientes();
            frmClientes.ShowDialog();
        }

        private void lineaDeProductosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmLineaProd frmLineaProd = new frmLineaProd();
            frmLineaProd.ShowDialog();
        }

        private void productosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmProductos frmProductos = new frmProductos();
            frmProductos.ShowDialog();
        }

        private void proveedoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmProveedores frmProveedores = new frmProveedores();
            frmProveedores.ShowDialog();
        }

        private void estadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEstados frmEstados = new frmEstados();
            frmEstados.ShowDialog();
        }

        private void ciudadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCiudades frmCiudades = new frmCiudades();
            frmCiudades.ShowDialog();
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
