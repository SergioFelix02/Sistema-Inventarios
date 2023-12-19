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

namespace Sistema_Inventarios
{
    public partial class frmProveedores : Form
    {
        public SqlDataAdapter bdProveedores;
        public DataSet tbProveedores;
        public DataRow regProveedores;
        SQL sql = new SQL();  
         
        string edo;

        public frmProveedores()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //sql.connect();
            showData();
            //LlenarCboEstados();
        }
        public void LlenarCboEstados()
        {
            try
            {
                string query = "SELECT Nombre FROM Estados";
                SqlCommand cmd = new SqlCommand(query, sql.connect());
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    CboEstado.Items.Add(dr["Nombre"].ToString());
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        //LlenarCboCiudades
        public void LlenarCboCiudades()
        {
            CboCiudad.Items.Clear();
            try
            {
                //Obtener ID del Estado
                int id = 0;
                string query = "SELECT Id FROM Estados WHERE Nombre = '" + CboEstado.SelectedItem.ToString() + "'";
                SqlCommand cmd = new SqlCommand(query, sql.connect());
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    id = int.Parse(dr["Id"].ToString());
                }
                dr.Close();
                //Llenar CboCiudades 
                string query2 = "SELECT Nombre FROM Ciudades WHERE IdEdo = " + id;
                SqlCommand cmd2 = new SqlCommand(query2, sql.connect());
                SqlDataReader dr2 = cmd2.ExecuteReader();
                while (dr2.Read())
                {
                    CboCiudad.Items.Add(dr2["Nombre"].ToString());
                }
                dr2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            CboCiudad.SelectedIndex = 0;
        }

        private void CboEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                LlenarCboCiudades();
            } 
            catch
            {
                CboCiudad.Text = "";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {   
                if (btnRegistrar.Text == "Registrar")
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO Proveedores VALUES ('','',1,1,'',0,'','','',''); SELECT SCOPE_IDENTITY()", sql.getConn());
                    int id = Convert.ToInt32(cmd.ExecuteScalar());
                    btnPrimero.Enabled = false;
                    btnUltimo.Enabled = false;
                    btnSiguiente.Enabled = false;
                    btnAnterior.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnActualizar.Enabled = false;
                    btnSalir.Enabled = false;
                    txtNombre.Text = "";
                    txtDomicilio.Text = "";
                    txtCP.Text = "";
                    txtCorreo.Text = "";
                    txtContacto.Text = "";
                    txtNombreC.Text = "";
                    txtRFC.Text = "";
                    txtTelefono.Text = "";
                    txtId.Text = Convert.ToString(id);
                    btnRegistrar.Text = "Aceptar";
                }
                else
                {
                    if (txtNombre.Text == "" || txtDomicilio.Text == "" || CboEstado.Text == "" || CboCiudad.Text == "" || txtCP.Text == "" || txtTelefono.Text == "" || txtCorreo.Text == "" || txtRFC.Text == "" || txtNombreC.Text == "" || txtContacto.Text == "")
                    {
                        MessageBox.Show("LLena todos los campos.");
                    }
                    else
                    {
                        int idedo = 0, idcd = 0;
                        SqlCommand cmd = new SqlCommand("SELECT * FROM Proveedores", sql.getConn());
                        SqlDataAdapter estados = new SqlDataAdapter("SELECT Nombre, Id FROM Estados", sql.getConn());
                        DataTable tbEstados = new DataTable();
                        estados.Fill(tbEstados);
                        for (int m = 0; m < tbEstados.Rows.Count; m++)
                        {
                            if (Convert.ToString(tbEstados.Rows[m]["Nombre"]) == Convert.ToString(CboEstado.SelectedItem))
                            {
                                idedo = Convert.ToInt32(tbEstados.Rows[m]["Id"]);
                            }
                        }
                        ciudades = new SqlDataAdapter("SELECT Id, Nombre FROM Ciudades", sql.getConn());
                        tbCiudades = new DataTable();
                        ciudades.Fill(tbCiudades);
                        for (int m = 0; m < tbCiudades.Rows.Count; m++)
                        {
                            if (Convert.ToString(tbCiudades.Rows[m]["Nombre"]) == Convert.ToString(CboCiudad.SelectedItem))
                            {
                                idcd = Convert.ToInt32(tbCiudades.Rows[m]["Id"]);
                            }
                        }
                        //Consulta SQL 
                        string query = "UPDATE Proveedores SET " +
                        "Nombre = @Nombre," +
                        "Domicilio = @Domicilio," +
                        "Estado = @Estado," +
                        "Ciudad = @Ciudad," +
                        "CodigoPostal = @CodigoPostal," +
                        "Telefono = @Telefono," +
                        "Correo = @Correo," +
                        "RFC = @RFC," +
                        "NombreComercial = @NombreC," +
                        "Contacto = @Contacto " +
                        "WHERE id = @Id ";
                        cmd = new SqlCommand(query, sql.connect());
                        //Parametros
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                        cmd.Parameters.AddWithValue("@Domicilio", txtDomicilio.Text);
                        cmd.Parameters.AddWithValue("@Estado", idedo);
                        cmd.Parameters.AddWithValue("@Ciudad", idcd);
                        cmd.Parameters.AddWithValue("@CodigoPostal", int.Parse(txtCP.Text));
                        cmd.Parameters.AddWithValue("@Telefono", Int64.Parse(txtTelefono.Text));
                        cmd.Parameters.AddWithValue("@Correo", txtCorreo.Text);
                        cmd.Parameters.AddWithValue("@RFC", txtRFC.Text);
                        cmd.Parameters.AddWithValue("@NombreC", txtNombreC.Text);
                        cmd.Parameters.AddWithValue("@Contacto", txtContacto.Text);
                        cmd.Parameters.AddWithValue("@Id", int.Parse(txtId.Text));
                        //Ejecutar Consulta
                        cmd.ExecuteNonQuery();
                        btnPrimero.Enabled = true;
                        btnUltimo.Enabled = true;
                        btnSiguiente.Enabled = true;
                        btnAnterior.Enabled = true;
                        btnEliminar.Enabled = true;
                        btnActualizar.Enabled = true;
                        btnSalir.Enabled = true;
                        btnRegistrar.Text = "Registrar";
                        MessageBox.Show("Datos Guardados Correctamente");
                        showData();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error en el tipo de datos.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtId.Text == "")
                {
                    MessageBox.Show("LLena todos los campos.");
                }
                else
                {
                    if (MessageBox.Show("Quieres eliminar a este proveedor?", "Advertencia", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        string query = "SELECT * FROM Proveedores WHERE Id = " + int.Parse(txtId.Text);
                        SqlCommand cmd = new SqlCommand(query, sql.connect());
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            //Consulta SQL  
                            query = "DELETE FROM Proveedores WHERE Id = @Id";
                            cmd = new SqlCommand(query, sql.connect());
                            //Parametros
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@Id", int.Parse(txtId.Text));
                            //Ejecutar Consulta
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Datos Eliminados Correctamente");
                            showData();
                        }
                        else
                        {
                            MessageBox.Show("ID Invalido");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.Text == "" || txtDomicilio.Text == "" || CboEstado.Text == "" || CboCiudad.Text == "" || txtCP.Text == "" || txtTelefono.Text == "" || txtCorreo.Text == "" || txtRFC.Text == "" || txtNombreC.Text == "" || txtContacto.Text == "" || txtId.Text == "")
                {
                    MessageBox.Show("LLena todos los campos.");
                }
                else
                {
                    string query = "SELECT * FROM Proveedores WHERE Id = " + int.Parse(txtId.Text);
                    SqlCommand cmd = new SqlCommand(query, sql.connect());
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        dr.Close();
                        int idedo = 0, idcd = 0;
                        cmd = new SqlCommand("SELECT * FROM Proveedores", sql.getConn());
                        SqlDataAdapter estados = new SqlDataAdapter("SELECT Nombre, Id FROM Estados", sql.getConn());
                        DataTable tbEstados = new DataTable();
                        estados.Fill(tbEstados);
                        for (int m = 0; m < tbEstados.Rows.Count; m++)
                        {
                            if (Convert.ToString(tbEstados.Rows[m]["Nombre"]) == Convert.ToString(CboEstado.SelectedItem))
                            {
                                idedo = Convert.ToInt32(tbEstados.Rows[m]["Id"]);
                            }
                        }
                        ciudades = new SqlDataAdapter("SELECT Id, Nombre FROM Ciudades", sql.getConn());
                        tbCiudades = new DataTable();
                        ciudades.Fill(tbCiudades);
                        for (int m = 0; m < tbCiudades.Rows.Count; m++)
                        {
                            if (Convert.ToString(tbCiudades.Rows[m]["Nombre"]) == Convert.ToString(CboCiudad.SelectedItem))
                            {
                                idcd = Convert.ToInt32(tbCiudades.Rows[m]["Id"]);
                            }
                        }
                        //Consulta SQL
                        query = "UPDATE Proveedores SET " +
                        "Nombre = @Nombre," +
                        "Domicilio = @Domicilio," +
                        "Estado = @Estado," +
                        "Ciudad = @Ciudad," +
                        "CodigoPostal = @CodigoPostal," +
                        "Telefono = @Telefono," +
                        "Correo = @Correo," +
                        "RFC = @RFC," +
                        "NombreComercial = @NombreC," +
                        "Contacto = @Contacto " +
                        "WHERE id = @Id ";
                        cmd = new SqlCommand(query, sql.connect());
                        //Parametros
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                        cmd.Parameters.AddWithValue("@Domicilio", txtDomicilio.Text);
                        cmd.Parameters.AddWithValue("@Estado", idedo);
                        cmd.Parameters.AddWithValue("@Ciudad", idcd);
                        cmd.Parameters.AddWithValue("@CodigoPostal", int.Parse(txtCP.Text));
                        cmd.Parameters.AddWithValue("@Telefono", Int64.Parse(txtTelefono.Text));
                        cmd.Parameters.AddWithValue("@Correo", txtCorreo.Text);
                        cmd.Parameters.AddWithValue("@RFC", txtRFC.Text);
                        cmd.Parameters.AddWithValue("@NombreC", txtNombreC.Text);
                        cmd.Parameters.AddWithValue("@Contacto", txtContacto.Text);
                        cmd.Parameters.AddWithValue("@Id", int.Parse(txtId.Text));
                        //Ejecutar Consulta
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Datos Actualizados Correctamente");
                        showData();
                    }
                    else
                    {
                        MessageBox.Show("ID Invalido");
                    }
                } 
            }
            catch
            {
                MessageBox.Show("Error en el tipo de datos.");
            }
        }
        
        private void btnPrimero_Click(object sender, EventArgs e)
        {
            pos = 0;
            showData();
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            try
            {
                pos = BindingContext[tbProveedores, "Proveedores"].Count - 1;
                showData();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        private void btnAnterior_Click(object sender, EventArgs e)
        {
            pos -= 1;
            showData();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            pos += 1;
            showData();
        }
        int pos = 0;
        public void showData()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT dbo.Proveedores.Id, dbo.Proveedores.Nombre, dbo.Proveedores.Domicilio, " +
                "dbo.Proveedores.CodigoPostal, dbo.Proveedores.Telefono, dbo.Proveedores.Correo, dbo.Proveedores.RFC, " +
                "dbo.Proveedores.NombreComercial, dbo.Proveedores.Contacto, Ciudades.Nombre AS Ciudad, Estados.Nombre AS Estado " +
                "FROM dbo.Proveedores INNER JOIN " +
                "Ciudades ON Proveedores.Ciudad = Ciudades.Id INNER JOIN " +
                "Estados ON Proveedores.Estado = Estados.Id AND Ciudades.IdEdo = Estados.Id", sql.connect());
                bdProveedores = new SqlDataAdapter(cmd);
                tbProveedores = new DataSet();
                bdProveedores.Fill(tbProveedores, "Proveedores");
                if (pos >= BindingContext[tbProveedores, "Proveedores"].Count)
                {
                    pos -= 1;
                }
                else if (pos <= 0)
                {
                    pos = 0;
                }

                BindingContext[tbProveedores, "Proveedores"].Position = pos;
                regProveedores = tbProveedores.Tables["Proveedores"].Rows[pos];
                txtId.Text = Convert.ToString(regProveedores["Id"]);
                txtNombre.Text = Convert.ToString(regProveedores["Nombre"]);
                txtDomicilio.Text = Convert.ToString(regProveedores["Domicilio"]);
                txtCP.Text = Convert.ToString(regProveedores["CodigoPostal"]);
                txtTelefono.Text = Convert.ToString(regProveedores["Telefono"]);
                txtCorreo.Text = Convert.ToString(regProveedores["Correo"]);
                txtRFC.Text = Convert.ToString(regProveedores["RFC"]);
                txtNombreC.Text = Convert.ToString(regProveedores["NombreComercial"]);
                txtContacto.Text = Convert.ToString(regProveedores["Contacto"]);

                CboCiudad.SelectedItem = Convert.ToString(regProveedores["Ciudad"]);
                CboEstado.SelectedItem = Convert.ToString(regProveedores["Estado"]);
                SqlDataAdapter estados = new SqlDataAdapter("SELECT Nombre, Id FROM Estados", sql.getConn());
                DataTable tbEstados = new DataTable();
                estados.Fill(tbEstados);
                CboEstado.Items.Clear();
                for (int m = 0; m < tbEstados.Rows.Count; m++)
                {
                    CboEstado.Items.Add(tbEstados.Rows[m]["Nombre"].ToString());
                    if (Convert.ToString(tbEstados.Rows[m]["Nombre"]) == Convert.ToString(regProveedores["Estado"]))
                    {
                        edo = tbEstados.Rows[m]["Nombre"].ToString();
                    }
                }
                CboEstado.SelectedItem = edo;
                LlenarCboCiudades();
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
            ciudades = new SqlDataAdapter("SELECT C.Nombre, C.Id FROM Estados E INNER JOIN Ciudades C ON E.Id = C.IdEdo WHERE E.Nombre = '" + Convert.ToString(edo) + "';", sql.getConn());
            tbCiudades = new DataTable();
            ciudades.Fill(tbCiudades);
            string selected = "";
            Boolean flag = false;
            CboCiudad.Items.Clear();
            for (int m = 0; m < tbCiudades.Rows.Count; m++)
            {
                CboCiudad.Items.Add(tbCiudades.Rows[m]["Nombre"].ToString());
                if (Convert.ToString(tbCiudades.Rows[m]["Nombre"]) == Convert.ToString(regProveedores["Ciudad"]))
                {
                    selected = tbCiudades.Rows[m]["Nombre"].ToString();
                    flag = true;
                }
                if (flag)
                {
                    CboCiudad.SelectedIndex = 0;
                }
            }
            CboCiudad.SelectedItem = selected;
            tbCiudades.Clear();
            ciudades.Dispose();
        }
    }
}