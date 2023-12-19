using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Inventarios
{
    public partial class frmProductos : Form
    {
         
        SQL sql = new SQL(); 
        public SqlDataAdapter bdProductos;
        public DataSet tbProductos;
        public DataRow regProductos;

        int pos = 0;
        string linea = "";
        string prov = "";
        public frmProductos()
        {
            InitializeComponent();
        }
        public void showData()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Productos", sql.connect());
            bdProductos = new SqlDataAdapter(cmd);
            tbProductos = new DataSet();
            bdProductos.Fill(tbProductos, "Productos");
            if (pos > BindingContext[tbProductos, "Productos"].Count - 1)
            {
                pos -= 1;
            }
            else if (pos <= 0)
            {
                pos = 0;
            }
            BindingContext[tbProductos, "Productos"].Position = pos;
            regProductos = tbProductos.Tables["Productos"].Rows[pos];
            txtId.Text = Convert.ToString(regProductos["Id"]);
            txtNombre.Text = Convert.ToString(regProductos["NombreCorto"]);
            txtDescripcion.Text = Convert.ToString(regProductos["Descripcion"]);
            txtCosto.Text = Convert.ToString(regProductos["Costo"]);
            txtPrecio1.Text = Convert.ToString(regProductos["Precio_1"]);
            txtPrecio2.Text = Convert.ToString(regProductos["Precio_2"]);
            txtPrecio3.Text = Convert.ToString(regProductos["Precio_3"]);
            txtDescuento.Text = Convert.ToString(regProductos["Descuento"]); 
            txtExistencia.Text = Convert.ToString(regProductos["Existencia"]);
            txtUbicacion.Text = Convert.ToString(regProductos["Ubicacion"]);
            txtCant1.Text = Convert.ToString(regProductos["CantMax"]);
            txtCant2.Text = Convert.ToString(regProductos["CantMin"]);
            txtCant3.Text = Convert.ToString(regProductos["CantReorden"]);
            dtpCaducidad.Value = Convert.ToDateTime(regProductos["Caducidad"]);
            //Llenar cboLinea
            SqlDataAdapter lineas = new SqlDataAdapter("SELECT Nombre, Id FROM Lineas", sql.connect());
            DataTable tbLineas = new DataTable();
            lineas.Fill(tbLineas);
            cboLinea.Items.Clear();
            for (int m = 0; m < tbLineas.Rows.Count; m++)
            {
                cboLinea.Items.Add(tbLineas.Rows[m]["Nombre"].ToString());
                if (Convert.ToString(tbLineas.Rows[m]["Id"]) == Convert.ToString(regProductos["Linea"]))
                {
                    linea = tbLineas.Rows[m]["Nombre"].ToString();
                }
            }
            cboLinea.Text = linea;
            //Llenar cboProveedor
            SqlDataAdapter proveedores = new SqlDataAdapter("SELECT Nombre, Id FROM Proveedores", sql.connect());
            DataTable tbProveedores = new DataTable();
            proveedores.Fill(tbProveedores);
            cboProveedor.Items.Clear();
            for (int m = 0; m < tbProveedores.Rows.Count; m++)
            {
                cboProveedor.Items.Add(tbProveedores.Rows[m]["Nombre"].ToString());
                if (Convert.ToString(tbProveedores.Rows[m]["Id"]) == Convert.ToString(regProductos["Proveedor"]))
                {
                    prov = tbProveedores.Rows[m]["Nombre"].ToString();
                }
            }
            cboProveedor.Text = prov;
            //Llenar cboVA
            cboVA.Items.Clear();
            cboVA.Items.Add("G");
            cboVA.Items.Add("E");
            cboVA.Text = Convert.ToString(regProductos["ValorAgregado"]);
            //Imagen
            if (regProductos["Foto"].ToString() != "")
            {
                byte[] byteLogotipo = ((byte[])regProductos["Foto"]);
                imgProducto.Image = ByteArrayToImage(byteLogotipo);
            }
            else
            {
                imgProducto.Image = null;
            }
        }

        //Image a Byte
        public byte[] ImageToByteArray(System.Drawing.Image img)
        {
            MemoryStream ms = new MemoryStream();
            img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }
        //Byte a Image 
        public System.Drawing.Image ByteArrayToImage(byte[] byteImg)
        {
            MemoryStream ms = new MemoryStream(byteImg);
            System.Drawing.Image img = System.Drawing.Image.FromStream(ms);
            return img;
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnRegistrar.Text == "Registrar")
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO Productos (NombreCorto, Descripcion, Linea, Costo, Precio_1, Precio_2, Precio_3, Descuento, Proveedor, Existencia, Ubicacion, CantMax, CantMin, CantReorden, Caducidad, ValorAgregado) " +
                        "VALUES ('','',1,0,0,0,0,0,1,0,'',0,0,0,getDate(),''); SELECT SCOPE_IDENTITY()", sql.connect());
                    int id = Convert.ToInt32(cmd.ExecuteScalar());
                    btnPrimero.Enabled = false;
                    btnUltimo.Enabled = false;
                    btnSiguiente.Enabled = false;
                    btnAnterior.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnActualizar.Enabled = false;
                    btnSalir.Enabled = false;
                    txtNombre.Text = "";
                    txtDescripcion.Text = "";
                    txtCosto.Text = "";
                    txtDescuento.Text = "";
                    txtPrecio1.Text = "";
                    txtPrecio2.Text = "";
                    txtPrecio3.Text = "";
                    txtDescuento.Text = "";
                    txtExistencia.Text = "";
                    txtUbicacion.Text = "";
                    txtCant1.Text = "";
                    txtCant2.Text = "";
                    txtCant3.Text = "";
                    dtpCaducidad.Value = DateTime.Now;
                    imgProducto.Image.Dispose();
                    imgProducto.Image = null;
                    txtId.Text = Convert.ToString(id);
                    btnRegistrar.Text = "Aceptar";
                }
                else
                {
                    if (txtNombre.Text == "" || txtDescripcion.Text == "" || txtCosto.Text == "" || txtPrecio1.Text == "" || txtPrecio2.Text == "" || txtPrecio3.Text == "" || imgProducto.Image == null || txtDescuento.Text == "" || txtExistencia.Text == "" || txtUbicacion.Text == "" || txtCant1.Text == "" || txtCant2.Text == "" || txtCant3.Text == "")
                    {
                        MessageBox.Show("LLena todos los campos.");
                    }
                    else
                    {
                        byte[] byteLogotipo = ImageToByteArray(imgProducto.Image); //Convertir Imagen a Byte
                        //Get idlinea
                        int idlinea = 0, idprov = 0;
                        SqlCommand cmd = new SqlCommand("SELECT * FROM Productos", sql.connect());
                        SqlDataAdapter lineas = new SqlDataAdapter("SELECT Nombre, Id FROM Lineas", sql.connect());
                        DataTable tbLineas = new DataTable();
                        lineas.Fill(tbLineas);
                        for (int m = 0; m < tbLineas.Rows.Count; m++)
                        {
                            if (Convert.ToString(tbLineas.Rows[m]["Nombre"]) == Convert.ToString(cboLinea.SelectedItem))
                            {
                                idlinea = Convert.ToInt32(tbLineas.Rows[m]["Id"]);
                            }
                        }
                        //Get idprov
                        SqlDataAdapter proveedores = new SqlDataAdapter("SELECT Id, Nombre FROM Proveedores", sql.connect());
                        DataTable tbProveedores = new DataTable();
                        proveedores.Fill(tbProveedores);
                        for (int m = 0; m < tbProveedores.Rows.Count; m++)
                        {
                            if (Convert.ToString(tbProveedores.Rows[m]["Nombre"]) == Convert.ToString(cboProveedor.SelectedItem))
                            {
                                idprov = Convert.ToInt32(tbProveedores.Rows[m]["Id"]);
                            }
                        }
                        //Consulta SQL 
                        string query = "UPDATE Productos SET " +
                        "NombreCorto = @Nombre," +
                        "Descripcion = @Descripcion," +
                        "Costo = @Costo," +
                        "Precio_1 = @Precio_1," +
                        "Precio_2 = @Precio_2," +
                        "Precio_3 = @Precio_3," +
                        "Foto = @Foto," +
                        "Linea = @Linea," +
                        "Descuento = @Descuento," +
                        "Proveedor = @Proveedor," +
                        "Existencia = @Existencia," +
                        "Ubicacion = @Ubicacion," +
                        "CantMax = @CantMax," +
                        "CantMin = @CantMin," +
                        "CantReorden = @CantReorden," +
                        "Caducidad = @Caducidad," +
                        "ValorAgregado = @ValorAgregado " +
                        "WHERE id = @Id ";
                        cmd = new SqlCommand(query, sql.connect());
                        //Parametros
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                        cmd.Parameters.AddWithValue("@Descripcion", txtDescripcion.Text);
                        cmd.Parameters.AddWithValue("@Costo", float.Parse(txtCosto.Text));
                        cmd.Parameters.AddWithValue("@Precio_1", float.Parse(txtPrecio1.Text));
                        cmd.Parameters.AddWithValue("@Precio_2", float.Parse(txtPrecio2.Text));
                        cmd.Parameters.AddWithValue("@Precio_3", float.Parse(txtPrecio3.Text));
                        cmd.Parameters.AddWithValue("@Foto", byteLogotipo);
                        cmd.Parameters.AddWithValue("@Linea", idlinea); 
                        cmd.Parameters.AddWithValue("@Descuento", float.Parse(txtDescuento.Text));
                        cmd.Parameters.AddWithValue("@Proveedor", idprov);
                        cmd.Parameters.AddWithValue("@Existencia", float.Parse(txtExistencia.Text));
                        cmd.Parameters.AddWithValue("@Ubicacion", txtUbicacion.Text);
                        cmd.Parameters.AddWithValue("@CantMax", float.Parse(txtCant1.Text));
                        cmd.Parameters.AddWithValue("@CantMin", float.Parse(txtCant2.Text));
                        cmd.Parameters.AddWithValue("@CantReorden", float.Parse(txtCant3.Text));
                        cmd.Parameters.AddWithValue("@Caducidad", dtpCaducidad.Value.Date.ToString());
                        cmd.Parameters.AddWithValue("@ValorAgregado", cboVA.SelectedItem.ToString());
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
                    if (MessageBox.Show("Quieres eliminar a este producto?", "Advertencia", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        string query = "SELECT * FROM Productos WHERE Id = " + int.Parse(txtId.Text);
                        SqlCommand cmd = new SqlCommand(query, sql.connect());
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            //Consulta SQL  
                            query = "DELETE FROM Productos WHERE Id = @Id";
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

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string imagen = openFileDialog1.FileName;
                    imgProducto.Image = Image.FromFile(imagen);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido" + ex.ToString());
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtId.Text == "" || txtNombre.Text == "" || txtDescripcion.Text == "" || txtCosto.Text == "" || txtPrecio1.Text == "" || txtPrecio2.Text == "" || txtPrecio3.Text == "" || imgProducto.Image == null || txtDescuento.Text == "" || txtExistencia.Text == "" || txtUbicacion.Text == "" || txtCant1.Text == "" || txtCant2.Text == "" || txtCant3.Text == "")
                {
                    MessageBox.Show("LLena todos los campos.");
                }
                else
                {
                    string query = "SELECT * FROM Productos WHERE Id = " + int.Parse(txtId.Text);
                    SqlCommand cmd = new SqlCommand(query, sql.connect());
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        byte[] byteLogotipo = ImageToByteArray(imgProducto.Image); //Convertir Imagen a Byte
                        //Get idlinea
                        int idlinea = 0, idprov = 0;
                        cmd = new SqlCommand("SELECT * FROM Productos", sql.connect());
                        SqlDataAdapter lineas = new SqlDataAdapter("SELECT Nombre, Id FROM Lineas", sql.connect());
                        DataTable tbLineas = new DataTable();
                        lineas.Fill(tbLineas);
                        for (int m = 0; m < tbLineas.Rows.Count; m++)
                        {
                            if (Convert.ToString(tbLineas.Rows[m]["Nombre"]) == Convert.ToString(cboLinea.SelectedItem))
                            {
                                idlinea = Convert.ToInt32(tbLineas.Rows[m]["Id"]);
                            }
                        }
                        //Get idprov
                        SqlDataAdapter proveedores = new SqlDataAdapter("SELECT Id, Nombre FROM Proveedores", sql.connect());
                        DataTable tbProveedores = new DataTable();
                        proveedores.Fill(tbProveedores);
                        for (int m = 0; m < tbProveedores.Rows.Count; m++)
                        {
                            if (Convert.ToString(tbProveedores.Rows[m]["Nombre"]) == Convert.ToString(cboProveedor.SelectedItem))
                            {
                                idprov = Convert.ToInt32(tbProveedores.Rows[m]["Id"]);
                            }
                        }
                        //Consulta SQL
                        query = "UPDATE Productos SET " +
                        "NombreCorto = @Nombre," +
                        "Descripcion = @Descripcion," +
                        "Costo = @Costo," +
                        "Precio_1 = @Precio_1," +
                        "Precio_2 = @Precio_2," +
                        "Precio_3 = @Precio_3," +
                        "Foto = @Foto," +
                        "Linea = @Linea," +
                        "Descuento = @Descuento," +
                        "Proveedor = @Proveedor," +
                        "Existencia = @Existencia," +
                        "Ubicacion = @Ubicacion," +
                        "CantMax = @CantMax," +
                        "CantMin = @CantMin," +
                        "CantReorden = @CantReorden," +
                        "Caducidad = @Caducidad," +
                        "ValorAgregado = @ValorAgregado " +
                        "WHERE id = @Id ";
                        cmd = new SqlCommand(query, sql.connect());
                        //Parametros
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                        cmd.Parameters.AddWithValue("@Descripcion", txtDescripcion.Text);
                        cmd.Parameters.AddWithValue("@Costo", float.Parse(txtCosto.Text));
                        cmd.Parameters.AddWithValue("@Precio_1", float.Parse(txtPrecio1.Text));
                        cmd.Parameters.AddWithValue("@Precio_2", float.Parse(txtPrecio2.Text));
                        cmd.Parameters.AddWithValue("@Precio_3", float.Parse(txtPrecio3.Text));
                        cmd.Parameters.AddWithValue("@Foto", byteLogotipo);
                        cmd.Parameters.AddWithValue("@Linea", idlinea);
                        cmd.Parameters.AddWithValue("@Descuento", float.Parse(txtDescuento.Text));
                        cmd.Parameters.AddWithValue("@Proveedor", idprov);
                        cmd.Parameters.AddWithValue("@Existencia", float.Parse(txtExistencia.Text));
                        cmd.Parameters.AddWithValue("@Ubicacion", txtUbicacion.Text);
                        cmd.Parameters.AddWithValue("@CantMax", float.Parse(txtCant1.Text));
                        cmd.Parameters.AddWithValue("@CantMin", float.Parse(txtCant2.Text));
                        cmd.Parameters.AddWithValue("@CantReorden", float.Parse(txtCant3.Text));
                        cmd.Parameters.AddWithValue("@Caducidad", dtpCaducidad.Value.Date.ToString());
                        cmd.Parameters.AddWithValue("@ValorAgregado", cboVA.SelectedItem.ToString());
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

        private void btnPrimero_Click_1(object sender, EventArgs e)
        {

        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            try
            {
                pos = BindingContext[tbProductos, "Productos"].Count - 1;
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

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            pos = 0;
            showData();
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            //sql.connect();
            showData();
        }
    }
}
