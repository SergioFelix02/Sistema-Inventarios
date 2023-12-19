using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; 
 
namespace Sistema_Inventarios 
{
    public partial class frmEstados : Form 
    {
        public frmEstados() 
        {
            InitializeComponent(); 
        }

        public int idEdo;
        SQL sql = new SQL();
        public SqlDataAdapter bdEstados;
        public DataSet tbEstados;
        public DataRow regEstados;
        int pos = 0;
        public void showData()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Estados", sql.connect());
            bdEstados = new SqlDataAdapter(cmd);
            tbEstados = new DataSet();
            bdEstados.Fill(tbEstados, "Estados");
            if (pos > BindingContext[tbEstados, "Estados"].Count - 1)
            {
                pos -= 1;
            }
            else if (pos <= 0)
            {
                pos = 0;
            }
            BindingContext[tbEstados, "Estados"].Position = pos;
            regEstados = tbEstados.Tables["Estados"].Rows[pos];
            TxtId.Text = Convert.ToString(regEstados["Id"]);
            TxtNombre.Text = Convert.ToString(regEstados["Nombre"]);
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            if (TxtNombre.Text == "")
            {
                MessageBox.Show("Llena todos los campos.");
            }
            else
            {
                try
                {
                    if (BtnRegistrar.Text == "&Registrar")
                    {
                        SqlCommand cmd = new SqlCommand("INSERT INTO Estados VALUES ('') ; SELECT SCOPE_IDENTITY()", sql.connect());
                        int id = Convert.ToInt32(cmd.ExecuteScalar());
                        TxtNombre.Text = "";
                        BtnPrimero.Enabled = false;
                        BtnUltimo.Enabled = false;
                        BtnSiguiente.Enabled = false;
                        BtnAnterior.Enabled = false;
                        BtnEliminar.Enabled = false;
                        BtnActualizar.Enabled = false;
                        BtnSalir.Enabled = false;
                        TxtId.Text = Convert.ToString(id);
                        BtnRegistrar.Text = "Aceptar";
                    }
                    else
                    {
                        SqlCommand cmd = new SqlCommand("UPDATE Estados SET Nombre='" + TxtNombre.Text + "' WHERE Id=" + TxtId.Text, sql.connect());
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Datos Guardados Correctamente");
                        BtnPrimero.Enabled = true;
                        BtnUltimo.Enabled = true;
                        BtnSiguiente.Enabled = true;
                        BtnAnterior.Enabled = true;
                        BtnEliminar.Enabled = true;
                        BtnActualizar.Enabled = true;
                        BtnSalir.Enabled = true;
                        BtnRegistrar.Text = "&Registrar";
                        showData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Quieres eliminar a este estado?", "Advertencia", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    idEdo = int.Parse(TxtId.Text);
                    SqlCommand cmd = new SqlCommand("DELETE FROM Estados WHERE Id = " + idEdo + ";", sql.connect());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datos Eliminados Correctamente");
                    showData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void BtnUltimo_Click(object sender, EventArgs e)
        {
            try
            {
                pos = BindingContext[tbEstados, "Estados"].Count - 1;
                showData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BtnAnterior_Click(object sender, EventArgs e)
        {
            pos -= 1;
            showData();
        }

        private void BtnSiguiente_Click(object sender, EventArgs e)
        {
            pos += 1;
            showData();
        }

        private void BtnPrimero_Click(object sender, EventArgs e)
        {
            pos = 0;
            showData();
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            if (TxtNombre.Text == "")
            {
                MessageBox.Show("Llena todos los campos.");
            }
            else
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("UPDATE Estados SET Nombre='" + TxtNombre.Text + "' WHERE Id=" + TxtId.Text, sql.connect());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datos Actualizados Correctamente");
                    showData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void Frm_Estados_Load(object sender, EventArgs e)
        {
            showData();
        }
    }
}
