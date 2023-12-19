using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Inventarios.forms
{
    public partial class frmClientes : Form
    { 
        SQL sql = new SQL(); 
        public SqlDataAdapter bdClientes;
        public DataSet tbClientes;
        public DataRow regClientes; 
        string edo;
        Boolean inn = false;
        SqlCommand cmd;
        public frmClientes()
        {
            InitializeComponent();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            sql.connect();
            showData();
        }
        int m = 0;
        void showData()
        {
            try
            {
                cmd = new SqlCommand("SELECT Clientes.Id, Clientes.RazonSocial, Clientes.NombreComercial, Clientes.Domicilio, Clientes.CodigoPostal, Clientes.RFC, Clientes.Correo, Clientes.Contacto, Clientes.Telefono, Clientes.Tipo, " +
                "Clientes.Status, Clientes.LimiteCredito, Clientes.Descuento, Clientes.NivelPrecio, Ciudades.Nombre AS Ciudad, Estados.Nombre AS Estado, Clientes.FechaNac " +
                "FROM Clientes INNER JOIN " +
                "Ciudades ON Clientes.Ciudad = Ciudades.Id INNER JOIN " +
                "Estados ON Clientes.Estado = Estados.Id AND Ciudades.IdEdo = Estados.Id", sql.getConn());
                bdClientes = new SqlDataAdapter(cmd);
                tbClientes = new DataSet();
                bdClientes.Fill(tbClientes, "Clientes");
                if (m >= BindingContext[tbClientes, "Clientes"].Count)
                {
                    m -= 1;
                }
                else if (m <= 0)
                {
                    m = 0;
                }
                BindingContext[tbClientes, "Clientes"].Position = m;
                regClientes = tbClientes.Tables["Clientes"].Rows[m];
                txtId.Text = Convert.ToString(regClientes["Id"]);
                txtRazonSocial.Text = Convert.ToString(regClientes["RazonSocial"]);
                txtNombreCom.Text = Convert.ToString(regClientes["NombreComercial"]);
                txtDomicilio.Text = Convert.ToString(regClientes["Domicilio"]);
                txtCp.Text = Convert.ToString(regClientes["CodigoPostal"]);
                txtRfc.Text = Convert.ToString(regClientes["RFC"]);
                txtCorreo.Text = Convert.ToString(regClientes["Correo"]);
                txtContacto.Text = Convert.ToString(regClientes["Contacto"]);
                txtTelefono.Text = Convert.ToString(regClientes["Telefono"]);

                dtpFechaNac.Value = Convert.ToDateTime(regClientes["FechaNac"]);

                if (Convert.ToString(regClientes["Tipo"]) == "1")
                {
                    rdbContado.Checked = true;
                }
                else
                {
                    rdbCredito.Checked = true;
                }
                if (Convert.ToString(regClientes["Status"]) == "1")
                {
                    rdbLibre.Checked = true;
                }
                else if (Convert.ToString(regClientes["Status"]) == "2")
                {
                    rdbControlado.Checked = true;
                }
                else if (Convert.ToString(regClientes["Status"]) == "3")
                {
                    rdbSuspendido.Checked = true;
                }
                else
                {
                    rdbCancelado.Checked = true;
                }
                txtLimCredito.Text = Convert.ToString(regClientes["LimiteCredito"]);
                txtDescuento.Text = Convert.ToString(regClientes["Descuento"]);
                if (Convert.ToString(regClientes["NivelPrecio"]) == "1")
                {
                    rdbPrecio1.Checked = true;
                }
                else if (Convert.ToString(regClientes["NivelPrecio"]) == "2")
                {
                    rdbPrecio2.Checked = true;
                }
                else
                {
                    rdbPrecio3.Checked = true;
                }
                cboCiudad.SelectedItem = Convert.ToString(regClientes["Ciudad"]);
                cboEstado.SelectedItem = Convert.ToString(regClientes["Estado"]);
                SqlDataAdapter estados = new SqlDataAdapter("SELECT Nombre, Id FROM Estados", sql.getConn());
                DataTable tbEstados = new DataTable();
                estados.Fill(tbEstados);
                cboEstado.Items.Clear();
                for (int m = 0; m < tbEstados.Rows.Count; m++)
                {
                    cboEstado.Items.Add(tbEstados.Rows[m]["Nombre"].ToString());
                    if (Convert.ToString(tbEstados.Rows[m]["Nombre"]) == Convert.ToString(regClientes["Estado"]))
                    {
                        edo = tbEstados.Rows[m]["Nombre"].ToString();
                    }
                }
                cboEstado.SelectedItem = edo;
                updateCiudad();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        SqlDataAdapter ciudades;
        DataTable tbCiudades;
        public void updateCiudad()
        {
            try
            {
                ciudades = new SqlDataAdapter("SELECT C.Nombre, C.Id FROM Estados E INNER JOIN Ciudades C ON E.Id = C.IdEdo WHERE E.Nombre = '" + Convert.ToString(edo) + "';", sql.getConn());
                tbCiudades = new DataTable();
                ciudades.Fill(tbCiudades);
                string selected = "";
                Boolean flag = false;
                for (int m = 0; m < tbCiudades.Rows.Count; m++)
                {
                    cboCiudad.Items.Add(tbCiudades.Rows[m]["Nombre"].ToString());
                    if (Convert.ToString(tbCiudades.Rows[m]["Nombre"]) == Convert.ToString(regClientes["Ciudad"]))
                    {
                        selected = tbCiudades.Rows[m]["Nombre"].ToString();
                        flag = true;
                    }
                    if (flag)
                    {
                        cboCiudad.SelectedIndex = 0;
                    }
                }
                cboCiudad.SelectedItem = selected;
                tbCiudades.Clear();
                ciudades.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cboEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (inn)
            {
                cboCiudad.Items.Clear();
                edo = Convert.ToString(cboEstado.SelectedItem);
                updateCiudad();
                try
                {
                    cboCiudad.SelectedIndex = 0;
                }
                catch
                {
                    cboCiudad.Text = "";
                }
            }
            else
            {
                inn = true;
            }
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            //BindingContext[tbClientes, "Clientes"].Position = 0;
            //regClientes = tbClientes.Tables["Clientes"].Rows[0];
            m = 0;
            showData();
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            //BindingContext[tbClientes, "Clientes"].Position = BindingContext[tbClientes, "Clientes"].Count - 1;
            //regClientes = tbClientes.Tables["Clientes"].Rows[BindingContext[tbClientes, "Clientes"].Count - 1];
            try
            {
                m = BindingContext[tbClientes, "Clientes"].Count - 1;
                showData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            /*int c = 0;
            if (BindingContext[tbClientes, "Clientes"].Position == BindingContext[tbClientes, "Clientes"].Count - 1)
            {
                c = BindingContext[tbClientes, "Clientes"].Position;
            }
            else
            {
                c = BindingContext[tbClientes, "Clientes"].Position + 1;
            }
            BindingContext[tbClientes, "Clientes"].Position = c;
            regClientes = tbClientes.Tables["Clientes"].Rows[c];
            */
            m += 1;
            showData();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            /*
            int c = 0;
            if (BindingContext[tbClientes, "Clientes"].Position == 0)
            {
                c = BindingContext[tbClientes, "Clientes"].Position;
            }
            else
            {
                c = BindingContext[tbClientes, "Clientes"].Position - 1;
            }
            BindingContext[tbClientes, "Clientes"].Position = c;
            regClientes = tbClientes.Tables["Clientes"].Rows[c];
            */
            m -= 1;
            showData();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Quieres eliminar a este cliente?", "Advertencia", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM Clientes WHERE Id = " + txtId.Text, sql.getConn());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datos Eliminados Correctamente");
                    if (BindingContext[tbClientes, "Clientes"].Position == 0)
                    {
                        m += 1;
                    }
                    else
                    {
                        m -= 1;
                    }
                    showData();
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtRazonSocial.Text == "" || txtNombreCom.Text == "" || txtDomicilio.Text == "" || cboEstado.Text == "" || cboCiudad.Text == "" || txtCp.Text == "" || txtRfc.Text == "" || txtCorreo.Text == "" || txtLimCredito.Text == "" || txtContacto.Text == "" || txtTelefono.Text == "" || txtDescuento.Text == "")
            {
                MessageBox.Show("Llena todos los campos.");
            }
            else
            {
                try
                {
                    if (btnRegistrar.Text == "&Registrar")
                    {
                        SqlCommand cmd = new SqlCommand("INSERT INTO Clientes VALUES ('','','',1,1,1,'','','',1,1,1,0,0,1,getDate()) ; SELECT SCOPE_IDENTITY()", sql.getConn());
                        int id = Convert.ToInt32(cmd.ExecuteScalar());
                        btnPrimero.Enabled = false;
                        btnUltimo.Enabled = false;
                        btnSiguiente.Enabled = false;
                        btnAnterior.Enabled = false;
                        btnEliminar.Enabled = false;
                        btnActualizar.Enabled = false;
                        btnSalir.Enabled = false;
                        rdbPrecio1.Checked = true;
                        rdbContado.Checked = true;
                        rdbLibre.Checked = true;
                        txtId.Text = Convert.ToString(id);
                        txtRazonSocial.Text = "";
                        txtNombreCom.Text = "";
                        txtDomicilio.Text = "";
                        txtCp.Text = "";
                        txtRfc.Text = "";
                        txtCorreo.Text = "";
                        txtLimCredito.Text = "";
                        txtContacto.Text = "";
                        txtTelefono.Text = "";
                        txtDescuento.Text = "";
                        cboEstado.SelectedIndex = 0;
                        dtpFechaNac.Value = DateTime.Now;
                        btnRegistrar.Text = "Aceptar";
                    }
                    else
                    {
                        int idedo = 0, idcd = 0;
                        SqlCommand cmd = new SqlCommand("SELECT * FROM Clientes", sql.getConn());
                        SqlDataAdapter estados = new SqlDataAdapter("SELECT Nombre, Id FROM Estados", sql.getConn());
                        DataTable tbEstados = new DataTable();
                        estados.Fill(tbEstados);
                        for (int m = 0; m < tbEstados.Rows.Count; m++)
                        {
                            if (Convert.ToString(tbEstados.Rows[m]["Nombre"]) == Convert.ToString(cboEstado.SelectedItem))
                            {
                                idedo = Convert.ToInt32(tbEstados.Rows[m]["Id"]);
                            }
                        }
                        ciudades = new SqlDataAdapter("SELECT Id, Nombre FROM Ciudades", sql.getConn());
                        tbCiudades = new DataTable();
                        ciudades.Fill(tbCiudades);
                        for (int m = 0; m < tbCiudades.Rows.Count; m++)
                        {
                            if (Convert.ToString(tbCiudades.Rows[m]["Nombre"]) == Convert.ToString(cboCiudad.SelectedItem))
                            {
                                idcd = Convert.ToInt32(tbCiudades.Rows[m]["Id"]);
                            }
                        }
                        int tipo = 0;
                        if (rdbContado.Checked)
                        {
                            tipo = 1;
                        }
                        else
                        {
                            tipo = 2;
                        }
                        int status = 0;
                        if (rdbLibre.Checked)
                        {
                            status = 1;
                        }
                        else if (rdbControlado.Checked)
                        {
                            status = 2;
                        }
                        else if (rdbSuspendido.Checked)
                        {
                            status = 3;
                        }
                        else
                        {
                            status = 4;
                        }
                        int nivelPrecio = 0;
                        if (rdbPrecio1.Checked)
                        {
                            nivelPrecio = 1;
                        }
                        else if (rdbPrecio2.Checked)
                        {
                            nivelPrecio = 2;
                        }
                        else
                        {
                            nivelPrecio = 3;
                        }
                        cmd.CommandText = "UPDATE Clientes SET " +
                                          "RazonSocial='" + txtRazonSocial.Text + "'," +
                                          "NombreComercial='" + txtNombreCom.Text + "'," +
                                          "Domicilio='" + txtDomicilio.Text + "'," +
                                          "Estado='" + idedo + "'," +
                                          "Ciudad='" + idcd + "'," +
                                          "CodigoPostal='" + int.Parse(txtCp.Text) + "'," +
                                          "RFC='" + txtRfc.Text + "'," +
                                          "Correo='" + txtCorreo.Text + "'," +
                                          "Contacto='" + txtContacto.Text + "'," +
                                          "Telefono='" + Int64.Parse(txtTelefono.Text) + "'," +
                                          "Tipo='" + tipo + "'," +
                                          "Status='" + status + "'," +
                                          "LimiteCredito='" + float.Parse(txtLimCredito.Text) + "'," +
                                          "Descuento='" + float.Parse(txtDescuento.Text) + "'," +
                                          "NivelPrecio='" + nivelPrecio + "'," +
                                          "FechaNac='" + dtpFechaNac.Value.Date.ToString() + "' " +
                                          "WHERE Id = " + txtId.Text;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Datos Guardados Correctamente");
                        btnPrimero.Enabled = true;
                        btnUltimo.Enabled = true;
                        btnSiguiente.Enabled = true;
                        btnAnterior.Enabled = true;
                        btnEliminar.Enabled = true;
                        btnActualizar.Enabled = true;
                        btnSalir.Enabled = true;
                        btnRegistrar.Text = "&Registrar";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    MessageBox.Show("Error en el tipo de datos.");
                }
            }
        }
          
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (txtRazonSocial.Text == "" || txtNombreCom.Text == "" || txtDomicilio.Text == "" || cboEstado.Text == "" || cboCiudad.Text == "" || txtCp.Text == "" || txtRfc.Text == "" || txtCorreo.Text == "" || txtLimCredito.Text == "" || txtContacto.Text == "" || txtTelefono.Text == "" || txtDescuento.Text == "")
            {
                MessageBox.Show("Llena todos los campos.");
            }
            else
            {
                try
                {
                    int idedo = 0, idcd = 0;
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Clientes", sql.getConn());
                    SqlDataAdapter estados = new SqlDataAdapter("SELECT Nombre, Id FROM Estados", sql.getConn());
                    DataTable tbEstados = new DataTable();
                    estados.Fill(tbEstados);
                    for (int m = 0; m < tbEstados.Rows.Count; m++)
                    {
                        if (Convert.ToString(tbEstados.Rows[m]["Nombre"]) == Convert.ToString(cboEstado.SelectedItem))
                        {
                            idedo = Convert.ToInt32(tbEstados.Rows[m]["Id"]);
                        }
                    }
                    ciudades = new SqlDataAdapter("SELECT Id, Nombre FROM Ciudades", sql.getConn());
                    tbCiudades = new DataTable();
                    ciudades.Fill(tbCiudades);
                    for (int m = 0; m < tbCiudades.Rows.Count; m++)
                    {
                        if (Convert.ToString(tbCiudades.Rows[m]["Nombre"]) == Convert.ToString(cboCiudad.SelectedItem))
                        {
                            idcd = Convert.ToInt32(tbCiudades.Rows[m]["Id"]);
                        }
                    }
                    int tipo = 0;
                    if (rdbContado.Checked)
                    {
                        tipo = 1;
                    }
                    else
                    {
                        tipo = 2;
                    }
                    int status = 0;
                    if (rdbLibre.Checked)
                    {
                        status = 1;
                    }
                    else if (rdbControlado.Checked)
                    {
                        status = 2;
                    }
                    else if (rdbSuspendido.Checked)
                    {
                        status = 3;
                    }
                    else
                    {
                        status = 4;
                    }
                    int nivelPrecio = 0;
                    if (rdbPrecio1.Checked)
                    {
                        nivelPrecio = 1;
                    }
                    else if (rdbPrecio2.Checked)
                    {
                        nivelPrecio = 2;
                    }
                    else
                    {
                        nivelPrecio = 3;
                    }
                    cmd.CommandText = "UPDATE Clientes SET " +
                                          "RazonSocial='" + txtRazonSocial.Text + "'," +
                                          "NombreComercial='" + txtNombreCom.Text + "'," +
                                          "Domicilio='" + txtDomicilio.Text + "'," +
                                          "Estado='" + idedo + "'," +
                                          "Ciudad='" + idcd + "'," +
                                          "CodigoPostal='" + int.Parse(txtCp.Text) + "'," +
                                          "RFC='" + txtRfc.Text + "'," +
                                          "Correo='" + txtCorreo.Text + "'," +
                                          "Contacto='" + txtContacto.Text + "'," +
                                          "Telefono='" + Int64.Parse(txtTelefono.Text) + "'," +
                                          "Tipo='" + tipo + "'," +
                                          "Status='" + status + "'," +
                                          "LimiteCredito='" + float.Parse(txtLimCredito.Text) + "'," +
                                          "Descuento='" + float.Parse(txtDescuento.Text) + "'," +
                                          "NivelPrecio='" + nivelPrecio + "'," +
                                          "FechaNac='" + dtpFechaNac.Value.Date.ToString() + "' " +
                                          "WHERE Id = " + txtId.Text;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datos Actualizados Correctamente");
                }
                catch
                {
                    MessageBox.Show("Error en el tipo de datos.");
                }
            }
        }
    }
} 
